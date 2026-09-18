CREATE TABLE [dbo].[Users] (
    [UserID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Username] VARCHAR(50) NOT NULL UNIQUE,
    [PasswordHash] VARCHAR(255) NOT NULL,
    [Role] VARCHAR(20) NOT NULL CHECK ([Role] IN ('Admin', 'Front Desk')),
    [FailedAttempts] INT NOT NULL DEFAULT 0,
    [IsLocked] BIT NOT NULL DEFAULT 0,
    [CreatedAt] DATETIME NOT NULL DEFAULT GETDATE()
);