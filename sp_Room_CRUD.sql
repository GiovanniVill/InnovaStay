USE InnovaStayDB;
GO

-- =============================================
-- 1. CREATE: Magdagdag ng Bagong Room
-- =============================================
CREATE OR ALTER PROCEDURE sp_CreateRoom
    @room_number NVARCHAR(10),
    @room_type NVARCHAR(20),
    @price_per_night DECIMAL(10, 2),
    @status NVARCHAR(20) = 'Available',
    @floor INT = 1
AS
BEGIN
    SET NOCOUNT ON;

    -- Suriin kung may kaparehong room_number na
    IF EXISTS (SELECT 1 FROM tbl_Rooms WHERE room_number = @room_number)
    BEGIN
        RAISERROR('May kaparehong Room Number na nakarehistro.', 16, 1);
        RETURN;
    END

    INSERT INTO tbl_Rooms (room_number, room_type, price_per_night, status, floor)
    VALUES (@room_number, @room_type, @price_per_night, @status, @floor);

    -- Ibalik ang bagong room_id
    SELECT SCOPE_IDENTITY() AS new_room_id;
END;
GO

-- =============================================
-- 2. READ: Kunin Lahat ng Rooms o Isa Lang
-- =============================================
CREATE OR ALTER PROCEDURE sp_GetAllRooms
AS
BEGIN
    SET NOCOUNT ON;
    SELECT room_id, room_number, room_type, price_per_night, status, floor, created_at, updated_at
    FROM tbl_Rooms
    ORDER BY room_number ASC;
END;
GO

CREATE OR ALTER PROCEDURE sp_GetRoomById
    @room_id INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT room_id, room_number, room_type, price_per_night, status, floor, created_at, updated_at
    FROM tbl_Rooms
    WHERE room_id = @room_id;
END;
GO

-- Karagdagang Helper: Kuhanin lang ang Available Rooms
CREATE OR ALTER PROCEDURE sp_GetAvailableRooms
AS
BEGIN
    SET NOCOUNT ON;
    SELECT room_id, room_number, room_type, price_per_night, status, floor
    FROM tbl_Rooms
    WHERE status = 'Available'
    ORDER BY room_number ASC;
END;
GO

-- =============================================
-- 3. UPDATE: I-update ang Room Details / Status
-- =============================================
CREATE OR ALTER PROCEDURE sp_UpdateRoom
    @room_id INT,
    @room_number NVARCHAR(10),
    @room_type NVARCHAR(20),
    @price_per_night DECIMAL(10, 2),
    @status NVARCHAR(20),
    @floor INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Siguraduhing nag-e-exist ang room
    IF NOT EXISTS (SELECT 1 FROM tbl_Rooms WHERE room_id = @room_id)
    BEGIN
        RAISERROR('Hindi natagpuan ang Room record.', 16, 1);
        RETURN;
    END

    -- Siguraduhing walang kaparehong room number sa ibang kwarto
    IF EXISTS (SELECT 1 FROM tbl_Rooms WHERE room_number = @room_number AND room_id <> @room_id)
    BEGIN
        RAISERROR('Ginagamit na ng ibang room ang Room Number na ito.', 16, 1);
        RETURN;
    END

    UPDATE tbl_Rooms
    SET room_number = @room_number,
        room_type = @room_type,
        price_per_night = @price_per_night,
        status = @status,
        floor = @floor,
        updated_at = GETDATE()
    WHERE room_id = @room_id;
END;
GO

-- =============================================
-- 4. DELETE: Tanggalin ang Room
-- =============================================
CREATE OR ALTER PROCEDURE sp_DeleteRoom
    @room_id INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM tbl_Rooms WHERE room_id = @room_id)
    BEGIN
        RAISERROR('Hindi natagpuan ang Room na buburahin.', 16, 1);
        RETURN;
    END

    DELETE FROM tbl_Rooms
    WHERE room_id = @room_id;
END;
GO