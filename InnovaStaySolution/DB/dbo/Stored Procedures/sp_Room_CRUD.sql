
CREATE PROCEDURE dbo.sp_Room_CRUD
    @Action NVARCHAR(20),
    @RoomId INT = NULL,
    @RoomNumber NVARCHAR(20) = NULL,
    @RoomType NVARCHAR(50) = NULL,
    @PricePerNight DECIMAL(18, 2) = NULL,
    @Status NVARCHAR(50) = 'Available',
    @Floor INT = 1,
    @BedCount INT = 1
AS
BEGIN
    -- DO NOT enable NOCOUNT globally so cmd.ExecuteNonQuery() returns > 0 on writes
    SET NOCOUNT OFF;

    -- CREATE / INSERT
    IF @Action = 'CREATE'
    BEGIN
        INSERT INTO dbo.tbl_Rooms (room_number, room_type, price_per_night, status, floor, BedCount, created_at, updated_at)
        VALUES (@RoomNumber, @RoomType, @PricePerNight, @Status, ISNULL(@Floor, 1), ISNULL(@BedCount, 1), GETDATE(), GETDATE());
    END

    -- READ ALL
    ELSE IF @Action = 'READ_ALL'
    BEGIN
        SET NOCOUNT ON;
        SELECT 
            room_id AS RoomId, 
            room_number AS RoomNumber, 
            room_type AS RoomType, 
            price_per_night AS PricePerNight, 
            status AS Status, 
            BedCount,
            created_at AS CreatedAt, 
            updated_at AS UpdatedAt
        FROM dbo.tbl_Rooms;
    END

    -- UPDATE
    ELSE IF @Action = 'UPDATE'
    BEGIN
        UPDATE dbo.tbl_Rooms
        SET room_number = ISNULL(@RoomNumber, room_number),
            room_type = ISNULL(@RoomType, room_type),
            price_per_night = ISNULL(@PricePerNight, price_per_night),
            status = ISNULL(@Status, status),
            floor = ISNULL(@Floor, floor),
            BedCount = ISNULL(@BedCount, BedCount),
            updated_at = GETDATE()
        WHERE room_id = @RoomId;
    END

    -- DELETE
    ELSE IF @Action = 'DELETE'
    BEGIN
        DELETE FROM dbo.tbl_Rooms
        WHERE room_id = @RoomId;
    END
END;