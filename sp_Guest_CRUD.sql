USE InnovaStayDB;
GO


-- 1. CREATE: Mag-insert ng Bagong Guest

CREATE OR ALTER PROCEDURE sp_CreateGuest
    @first_name NVARCHAR(50),
    @last_name NVARCHAR(50),
    @email NVARCHAR(100),
    @phone_number NVARCHAR(20),
    @address NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Suriin kung existing na ang email
    IF EXISTS (SELECT 1 FROM tbl_Guests WHERE email = @email)
    BEGIN
        RAISERROR('May kaparehong email address na nakarehistro.', 16, 1);
        RETURN;
    END

    INSERT INTO tbl_Guests (first_name, last_name, email, phone_number, address)
    VALUES (@first_name, @last_name, @email, @phone_number, @address);

    -- Ibalik ang bagong guest_id
    SELECT SCOPE_IDENTITY() AS new_guest_id;
END;
GO

-- 2. READ: Kunin Lahat o Isang Guest Lang

CREATE OR ALTER PROCEDURE sp_GetAllGuests
AS
BEGIN
    SET NOCOUNT ON;
    SELECT guest_id, first_name, last_name, email, phone_number, address, created_at, updated_at
    FROM tbl_Guests
    ORDER BY guest_id DESC;
END;
GO

CREATE OR ALTER PROCEDURE sp_GetGuestById
    @guest_id INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT guest_id, first_name, last_name, email, phone_number, address, created_at, updated_at
    FROM tbl_Guests
    WHERE guest_id = @guest_id;
END;
GO


-- 3. UPDATE: I-update ang Impormasyon ng Guest

CREATE OR ALTER PROCEDURE sp_UpdateGuest
    @guest_id INT,
    @first_name NVARCHAR(50),
    @last_name NVARCHAR(50),
    @email NVARCHAR(100),
    @phone_number NVARCHAR(20),
    @address NVARCHAR(255) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Suriin kung nag-e-exist ang guest_id
    IF NOT EXISTS (SELECT 1 FROM tbl_Guests WHERE guest_id = @guest_id)
    BEGIN
        RAISERROR('Hindi natagpuan ang guest record.', 16, 1);
        RETURN;
    END

    -- Siguraduhing hindi maagaw ang email ng ibang guest
    IF EXISTS (SELECT 1 FROM tbl_Guests WHERE email = @email AND guest_id <> @guest_id)
    BEGIN
        RAISERROR('Ginagamit na ng ibang guest ang email na ito.', 16, 1);
        RETURN;
    END

    UPDATE tbl_Guests
    SET first_name = @first_name,
        last_name = @last_name,
        email = @email,
        phone_number = @phone_number,
        address = @address,
        updated_at = GETDATE()
    WHERE guest_id = @guest_id;
END;
GO


-- 4. DELETE: Tanggalin ang Guest Record

CREATE OR ALTER PROCEDURE sp_DeleteGuest
    @guest_id INT
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM tbl_Guests WHERE guest_id = @guest_id)
    BEGIN
        RAISERROR('Hindi natagpuan ang guest na buburahin.', 16, 1);
        RETURN;
    END

    DELETE FROM tbl_Guests
    WHERE guest_id = @guest_id;
END;
GO