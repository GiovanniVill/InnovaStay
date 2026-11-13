CREATE PROCEDURE spGetAllUsersWithProfiles
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        u.UserID,
        u.Username,
        u.PasswordHash,
        u.Role,
        'Active' AS Status,
        0 AS FailedAttempts,
        CAST(0 AS BIT) AS IsLocked,
        u.CreatedAt,
        u.CreatedAt AS UpdatedAt,
        u.Username AS FullName,
        '' AS Email,
        '' AS PhoneNumber
    FROM dbo.Users u;
END
GO

CREATE PROCEDURE [dbo].[spAddUserWithProfile]
    @Username VARCHAR(50),
    @PasswordHash VARCHAR(255),
    @FullName VARCHAR(100),
    @Role VARCHAR(20),
    @IsLocked BIT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        INSERT INTO dbo.Users (Username, PasswordHash, Role, FailedAttempts, IsLocked, CreatedAt)
        VALUES (@Username, @PasswordHash, @Role, 0, @IsLocked, GETDATE());

        DECLARE @NewUserID INT = SCOPE_IDENTITY();

        INSERT INTO dbo.UserProfiles (UserID, FullName, CreatedAt)
        VALUES (@NewUserID, @FullName, GETDATE());

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE dbo.spUpdateUserWithProfile
    @UserID INT,
    @Username NVARCHAR(50),
    @FullName NVARCHAR(100) = NULL,
    @Role NVARCHAR(50),
    @IsLocked BIT = 0,
    @PasswordHash NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @NormalizedRole NVARCHAR(50) = 
        CASE 
            WHEN REPLACE(@Role, ' ', '') = 'FrontDesk' THEN 'Front Desk'
            ELSE @Role
        END;

    IF EXISTS (SELECT 1 FROM dbo.Users WHERE Username = @Username AND UserID <> @UserID)
    BEGIN
        RAISERROR('Username already exists.', 16, 1);
        RETURN;
    END

    UPDATE dbo.Users
    SET Username = @Username,
        Role = @NormalizedRole,
        IsLocked = @IsLocked,
        FailedAttempts = CASE WHEN @IsLocked = 0 THEN 0 ELSE FailedAttempts END,
        PasswordHash = CASE 
                           WHEN @PasswordHash IS NOT NULL AND LTRIM(RTRIM(@PasswordHash)) <> '' 
                           THEN @PasswordHash 
                           ELSE PasswordHash 
                       END
    WHERE UserID = @UserID;
END
GO

CREATE PROCEDURE [dbo].[spDeleteUser]
    @UserID INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Users WHERE UserID = @UserID;
END;
GO