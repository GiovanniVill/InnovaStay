USE InnovaStayDB;
GO

CREATE OR ALTER PROCEDURE sp_Room_CRUD
    @Action NVARCHAR(10),
    @room_id INT = NULL,
    @room_number NVARCHAR(10) = NULL,
    @room_type NVARCHAR(20) = NULL,
    @price_per_night DECIMAL(10,2) = NULL,
    @status NVARCHAR(20) = NULL,
    @floor INT = NULL
AS
BEGIN
    SET NOCOUNT ON;


    IF @Action = 'INSERT'
    BEGIN
        INSERT INTO tbl_Rooms (room_number, room_type, price_per_night, status, floor)
        VALUES (@room_number, @room_type, @price_per_night, @status, @floor);

        SELECT SCOPE_IDENTITY() AS NewRoomId;
    END


    ELSE IF @Action = 'SELECT_ALL'
    BEGIN
        SELECT room_id, room_number, room_type, price_per_night, status, floor, created_at, updated_at
        FROM tbl_Rooms;
    END


    ELSE IF @Action = 'SELECT_BY_ID'
    BEGIN
        SELECT room_id, room_number, room_type, price_per_night, status, floor, created_at, updated_at
        FROM tbl_Rooms
        WHERE room_id = @room_id;
    END


    ELSE IF @Action = 'UPDATE'
    BEGIN
        UPDATE tbl_Rooms
        SET room_number = ISNULL(@room_number, room_number),
            room_type = ISNULL(@room_type, room_type),
            price_per_night = ISNULL(@price_per_night, price_per_night),
            status = ISNULL(@status, status),
            floor = ISNULL(@floor, floor),
            updated_at = GETDATE()
        WHERE room_id = @room_id;
    END


    ELSE IF @Action = 'DELETE'
    BEGIN
        DELETE FROM tbl_Rooms
        WHERE room_id = @room_id;
    END
END
GO