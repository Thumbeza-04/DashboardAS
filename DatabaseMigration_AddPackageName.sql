-- Database Migration Script: Add PackageName to StudentMJ table
-- Run this script on existing databases to add the PackageName foreign key column

-- Check if PackageName column already exists
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS 
               WHERE TABLE_NAME = 'StudentMJ' AND COLUMN_NAME = 'PackageName')
BEGIN
    -- Add PackageName column to StudentMJ table
    ALTER TABLE StudentMJ
    ADD PackageName VARCHAR(50);
    
    -- Add foreign key constraint
    ALTER TABLE StudentMJ
    ADD CONSTRAINT FK_StudentMJ_PackageName 
    FOREIGN KEY (PackageName) REFERENCES PackageMJ(PackageName);
    
    PRINT 'PackageName column and foreign key constraint added successfully to StudentMJ table.';
END
ELSE
BEGIN
    PRINT 'PackageName column already exists in StudentMJ table.';
END

-- Optional: Update existing students with default package if needed
-- Uncomment the following lines if you want to assign a default package to existing students
/*
UPDATE StudentMJ 
SET PackageName = 'Basic Package' 
WHERE PackageName IS NULL;
*/

PRINT 'Migration completed successfully!';
