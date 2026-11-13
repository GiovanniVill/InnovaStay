
-- Create Stored Procedure
CREATE   PROCEDURE dbo.spAuthenticateUser
    @Username VARCHAR(50),
    @PasswordHash VARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @UserID INT, @StoredHash VARCHAR(255), @Role VARCHAR(20), @FailedAttempts INT, @IsLocked BIT;

    SELECT @UserID = UserID, @StoredHash = PasswordHash, @Role = Role,
           @FailedAttempts = FailedAttempts, @IsLocked = IsLocked
    FROM Users WHERE Username = @Username;

    IF @UserID IS NULL
    BEGIN
        SELECT 'INVALID' AS AuthStatus, '' AS Role, 0 AS AttemptsLeft;
        RETURN;
    END

    IF @IsLocked = 1
    BEGIN
        SELECT 'LOCKED' AS AuthStatus, @Role AS Role, 0 AS AttemptsLeft;
        RETURN;
    END

    IF @StoredHash = @PasswordHash
    BEGIN
        UPDATE Users SET FailedAttempts = 0 WHERE UserID = @UserID;
        SELECT 'SUCCESS' AS AuthStatus, @Role AS Role, 3 AS AttemptsLeft;
    END
    ELSE
    BEGIN
        DECLARE @NewAttempts INT = @FailedAttempts + 1;
        DECLARE @ShouldLock BIT = CASE WHEN @NewAttempts >= 3 THEN 1 ELSE 0 END;

        UPDATE Users 
        SET FailedAttempts = @NewAttempts, IsLocked = @ShouldLock 
        WHERE UserID = @UserID;

        IF @ShouldLock = 1
            SELECT 'LOCKED' AS AuthStatus, @Role AS Role, 0 AS AttemptsLeft;
        ELSE
            SELECT 'INVALID' AS AuthStatus, @Role AS Role, (3 - @NewAttempts) AS AttemptsLeft;
    END
END