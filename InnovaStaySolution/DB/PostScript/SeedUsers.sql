IF NOT EXISTS (SELECT 1 FROM Users WHERE Username = 'admin')
BEGIN
    INSERT INTO Users (Username, PasswordHash, Role, FailedAttempts, IsLocked)
    VALUES 
    ('admin', 'admin123', 'Admin', 0, 0),
    ('frontdesk', 'fd123', 'Front Desk', 0, 0);
END