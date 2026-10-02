CREATE PROCEDURE [dbo].[spAuthenticateUser]
    @Username VARCHAR(50),
    @PasswordHash VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @UserID INT, 
            @StoredHash VARCHAR(255), 
            @Role VARCHAR(20), 
            @FailedAttempts INT, 
            @IsLocked BIT;

    SELECT @UserID = UserID, 
           @StoredHash = PasswordHash, 
           @Role = Role, 
           @FailedAttempts = FailedAttempts, 
           @IsLocked = IsLocked
    FROM Users 
    WHERE Username = @Username;

    -- Case 1: Account does not exist
    IF @UserID IS NULL
    BEGIN
        SELECT 'INVALID' AS AuthStatus, '' AS Role, 0 AS AttemptsLeft;
        RETURN;
    END

    -- Case 2: Account is already locked
    IF @IsLocked = 1
    BEGIN
        SELECT 'LOCKED' AS AuthStatus, @Role AS Role, 0 AS AttemptsLeft;
        RETURN;
    END

    -- Case 3: Valid Credentials
    IF @StoredHash = @PasswordHash
    BEGIN
        UPDATE Users 
        SET FailedAttempts = 0 
        WHERE UserID = @UserID;

        SELECT 'SUCCESS' AS AuthStatus, @Role AS Role, 3 AS AttemptsLeft;
        RETURN;
    END
    ELSE
    -- Case 4: Invalid Password (tracks failure count, locks at 3)
    BEGIN
        DECLARE @NewAttempts INT = @FailedAttempts + 1;
        DECLARE @ShouldLock BIT = CASE WHEN @NewAttempts >= 3 THEN 1 ELSE 0 END;

        UPDATE Users 
        SET FailedAttempts = @NewAttempts,
            IsLocked = @ShouldLock
        WHERE UserID = @UserID;

        IF @ShouldLock = 1
            SELECT 'LOCKED' AS AuthStatus, @Role AS Role, 0 AS AttemptsLeft;
        ELSE
            SELECT 'INVALID' AS AuthStatus, @Role AS Role, (3 - @NewAttempts) AS AttemptsLeft;
    END
END;