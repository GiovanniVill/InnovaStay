IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'InnovaStayDB')
BEGIN
    CREATE DATABASE InnovaStayDB;
END
GO

USE InnovaStayDB;
GO


IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbl_Guests')
BEGIN
    CREATE TABLE tbl_Guests (
        guest_id INT IDENTITY(1,1) PRIMARY KEY,
        first_name NVARCHAR(50) NOT NULL,
        last_name NVARCHAR(50) NOT NULL,
        email NVARCHAR(100) NOT NULL UNIQUE,
        phone_number NVARCHAR(20) NOT NULL,
        address NVARCHAR(255) NULL,
        created_at DATETIME2 DEFAULT GETDATE(),
        updated_at DATETIME2 DEFAULT GETDATE()
    );
END
GO


IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tbl_Rooms')
BEGIN
    CREATE TABLE tbl_Rooms (
        room_id INT IDENTITY(1,1) PRIMARY KEY,
        room_number NVARCHAR(10) NOT NULL UNIQUE,
        room_type NVARCHAR(20) NOT NULL DEFAULT 'Single'
            CONSTRAINT CK_tbl_Rooms_RoomType CHECK (room_type IN ('Single', 'Double', 'Suite', 'Deluxe')),
        price_per_night DECIMAL(10, 2) NOT NULL,
        status NVARCHAR(20) NOT NULL DEFAULT 'Available'
            CONSTRAINT CK_tbl_Rooms_Status CHECK (status IN ('Available', 'Occupied', 'Maintenance', 'Reserved')),
        floor INT NOT NULL DEFAULT 1,
        created_at DATETIME2 DEFAULT GETDATE(),
        updated_at DATETIME2 DEFAULT GETDATE()
    );
END
GO