CREATE TABLE [dbo].[tbl_Guests] (
    [guest_id]      INT            IDENTITY (1, 1) NOT NULL,
    [first_name]    NVARCHAR (50)  NOT NULL,
    [last_name]     NVARCHAR (50)  NOT NULL,
    [email]         NVARCHAR (100) NOT NULL,
    [phone_number]  NVARCHAR (20)  NOT NULL,
    [address]       NVARCHAR (255) NULL,
    [created_at]    DATETIME2 (7)  DEFAULT (getdate()) NULL,
    [updated_at]    DATETIME2 (7)  DEFAULT (getdate()) NULL,
    [age]           INT            NULL,
    [date_of_birth] DATE           NULL,
    [middle_name]   NVARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([guest_id] ASC),
    UNIQUE NONCLUSTERED ([email] ASC)
);

