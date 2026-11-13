CREATE TABLE [dbo].[tbl_Payments] (
    [PaymentId]     INT             IDENTITY (1, 1) NOT NULL,
    [ReservationId] INT             NOT NULL,
    [PaymentMethod] NVARCHAR (50)   NOT NULL,
    [AmountPaid]    DECIMAL (18, 2) NOT NULL,
    [PaymentDate]   DATETIME        DEFAULT (getdate()) NULL,
    [PaymentStatus] NVARCHAR (50)   DEFAULT ('Paid') NULL,
    PRIMARY KEY CLUSTERED ([PaymentId] ASC),
    CONSTRAINT [FK_Payments_Reservation] FOREIGN KEY ([ReservationId]) REFERENCES [dbo].[Reservations] ([ReservationId]) ON DELETE CASCADE
);

