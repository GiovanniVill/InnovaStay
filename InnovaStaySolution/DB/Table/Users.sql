CREATE TABLE [dbo].[Users] (
    [UserID]         INT           IDENTITY (1, 1) NOT NULL,
    [Username]       VARCHAR (50)  NOT NULL,
    [PasswordHash]   VARCHAR (255) NOT NULL,
    [Role]           VARCHAR (20)  NOT NULL,
    [FailedAttempts] INT           DEFAULT ((0)) NOT NULL,
    [IsLocked]       BIT           DEFAULT ((0)) NOT NULL,
    [CreatedAt]      DATETIME      DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC),
    CHECK ([Role]='Front Desk' OR [Role]='Admin'),
    UNIQUE NONCLUSTERED ([Username] ASC)
);

