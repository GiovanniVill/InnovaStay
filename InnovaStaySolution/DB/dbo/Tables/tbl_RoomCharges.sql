CREATE TABLE [dbo].[tbl_RoomCharges] (
    [ChargeId]      INT             IDENTITY (1, 1) NOT NULL,
    [ReservationId] INT             NOT NULL,
    [Description]   NVARCHAR (150)  NOT NULL,
    [Amount]        DECIMAL (18, 2) NOT NULL,
    [ChargedAt]     DATETIME        DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([ChargeId] ASC),
    CONSTRAINT [FK_RoomCharges_Reservation] FOREIGN KEY ([ReservationId]) REFERENCES [dbo].[Reservations] ([ReservationId]) ON DELETE CASCADE
);

