CREATE TABLE [dbo].[Reservations] (
    [ReservationId] INT             IDENTITY (1, 1) NOT NULL,
    [GuestId]       INT             NOT NULL,
    [RoomId]        INT             NOT NULL,
    [CheckInDate]   DATETIME        NOT NULL,
    [CheckOutDate]  DATETIME        NOT NULL,
    [TotalAmount]   DECIMAL (18, 2) NOT NULL,
    [Status]        NVARCHAR (50)   DEFAULT ('Confirmed') NOT NULL,
    [CreatedAt]     DATETIME        DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ReservationId] ASC)
);

