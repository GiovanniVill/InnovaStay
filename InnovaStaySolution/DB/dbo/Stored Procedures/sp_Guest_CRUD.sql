
CREATE PROCEDURE dbo.sp_Guest_CRUD
    @Action NVARCHAR(10),
    @guest_id INT = NULL,
    @first_name NVARCHAR(50) = NULL,
    @middle_name NVARCHAR(50) = NULL,
    @last_name NVARCHAR(50) = NULL,
    @email NVARCHAR(100) = NULL,
    @phone_number NVARCHAR(20) = NULL,
    @address NVARCHAR(255) = NULL,
    @age INT = NULL,
    @date_of_birth DATE = NULL
AS
BEGIN
    SET NOCOUNT ON;

    IF @Action = 'INSERT'
    BEGIN
        INSERT INTO dbo.tbl_Guests (first_name, middle_name, last_name, email, phone_number, address, age, date_of_birth)
        VALUES (@first_name, @middle_name, @last_name, @email, @phone_number, @address, @age, @date_of_birth);

        SELECT SCOPE_IDENTITY() AS NewGuestId;
    END

    ELSE IF @Action = 'SELECT_ALL'
    BEGIN
        SELECT guest_id, first_name, middle_name, last_name, email, phone_number, address, age, date_of_birth, created_at, updated_at
        FROM dbo.tbl_Guests;
    END

    ELSE IF @Action = 'SELECT_BY_ID'
    BEGIN
        SELECT guest_id, first_name, middle_name, last_name, email, phone_number, address, age, date_of_birth, created_at, updated_at
        FROM dbo.tbl_Guests
        WHERE guest_id = @guest_id;
    END

    ELSE IF @Action = 'UPDATE'
    BEGIN
        UPDATE dbo.tbl_Guests
        SET first_name = ISNULL(@first_name, first_name),
            middle_name = @middle_name,
            last_name = ISNULL(@last_name, last_name),
            email = ISNULL(@email, email),
            phone_number = ISNULL(@phone_number, phone_number),
            address = ISNULL(@address, address),
            age = ISNULL(@age, age),
            date_of_birth = ISNULL(@date_of_birth, date_of_birth),
            updated_at = GETDATE()
        WHERE guest_id = @guest_id;
    END

    ELSE IF @Action = 'DELETE'
    BEGIN
        DELETE FROM dbo.tbl_Guests
        WHERE guest_id = @guest_id;
    END
END;