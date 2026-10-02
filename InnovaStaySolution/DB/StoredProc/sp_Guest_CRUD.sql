USE InnovaStayDB;
GO

CREATE OR ALTER PROCEDURE sp_Guest_CRUD
    @Action NVARCHAR(10),
    @guest_id INT = NULL,
    @first_name NVARCHAR(50) = NULL,
    @last_name NVARCHAR(50) = NULL,
    @email NVARCHAR(100) = NULL,
    @phone_number NVARCHAR(20) = NULL,
    @address NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;


    IF @Action = 'INSERT'
    BEGIN
        INSERT INTO tbl_Guests (first_name, last_name, email, phone_number, address)
        VALUES (@first_name, @last_name, @email, @phone_number, @address);

        SELECT SCOPE_IDENTITY() AS NewGuestId;
    END


    ELSE IF @Action = 'SELECT_ALL'
    BEGIN
        SELECT guest_id, first_name, last_name, email, phone_number, address, created_at, updated_at
        FROM tbl_Guests;
    END


    ELSE IF @Action = 'SELECT_BY_ID'
    BEGIN
        SELECT guest_id, first_name, last_name, email, phone_number, address, created_at, updated_at
        FROM tbl_Guests
        WHERE guest_id = @guest_id;
    END


    ELSE IF @Action = 'UPDATE'
    BEGIN
        UPDATE tbl_Guests
        SET first_name = ISNULL(@first_name, first_name),
            last_name = ISNULL(@last_name, last_name),
            email = ISNULL(@email, email),
            phone_number = ISNULL(@phone_number, phone_number),
            address = ISNULL(@address, address),
            updated_at = GETDATE()
        WHERE guest_id = @guest_id;
    END

    ELSE IF @Action = 'DELETE'
    BEGIN
        DELETE FROM tbl_Guests
        WHERE guest_id = @guest_id;
    END
END
GO