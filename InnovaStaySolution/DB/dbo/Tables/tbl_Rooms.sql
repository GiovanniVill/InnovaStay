CREATE TABLE [dbo].[tbl_Rooms] (
    [room_id]         INT             IDENTITY (1, 1) NOT NULL,
    [room_number]     NVARCHAR (10)   NOT NULL,
    [room_type]       NVARCHAR (20)   DEFAULT ('Single') NOT NULL,
    [price_per_night] DECIMAL (10, 2) NOT NULL,
    [status]          NVARCHAR (20)   DEFAULT ('Available') NOT NULL,
    [floor]           INT             DEFAULT ((1)) NOT NULL,
    [created_at]      DATETIME2 (7)   DEFAULT (getdate()) NULL,
    [updated_at]      DATETIME2 (7)   DEFAULT (getdate()) NULL,
    [BedCount]        INT             CONSTRAINT [DF_tbl_Rooms_BedCount] DEFAULT ((1)) NOT NULL,
    PRIMARY KEY CLUSTERED ([room_id] ASC),
    CONSTRAINT [CK_tbl_Rooms_RoomType] CHECK ([room_type]='Deluxe' OR [room_type]='Suite' OR [room_type]='Double' OR [room_type]='Single'),
    CONSTRAINT [CK_tbl_Rooms_Status] CHECK ([status]='Reserved' OR [status]='Maintenance' OR [status]='Occupied' OR [status]='Available'),
    UNIQUE NONCLUSTERED ([room_number] ASC)
);

