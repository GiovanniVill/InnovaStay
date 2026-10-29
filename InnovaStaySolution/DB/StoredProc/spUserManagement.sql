CREATE PROCEDURE [dbo].[spGetAllUsersWithProfiles]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        u.UserID,
        u.Username,
        ISNULL(p.FullName, '') AS FullName,
        u.Role,
        u.FailedAttempts,
        u.IsLocked,
        u.CreatedAt
    FROM dbo.Users u
    LEFT JOIN dbo.UserProfiles p ON u.UserID = p.UserID
    ORDER BY u.UserID DESC;
END;
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

CREATE PROCEDURE [dbo].[spUpdateUserWithProfile]
    @UserID INT,
    @Username VARCHAR(50),
    @FullName VARCHAR(100),
    @Role VARCHAR(20),
    @IsLocked BIT
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        UPDATE dbo.Users
        SET Username = @Username,
            Role = @Role,
            IsLocked = @IsLocked
        WHERE UserID = @UserID;

        IF EXISTS (SELECT 1 FROM dbo.UserProfiles WHERE UserID = @UserID)
        BEGIN
            UPDATE dbo.UserProfiles
            SET FullName = @FullName
            WHERE UserID = @UserID;
        END
        ELSE
        BEGIN
            INSERT INTO dbo.UserProfiles (UserID, FullName, CreatedAt)
            VALUES (@UserID, @FullName, GETDATE());
        END

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE [dbo].[spDeleteUser]
    @UserID INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM dbo.Users WHERE UserID = @UserID;
END;
GO