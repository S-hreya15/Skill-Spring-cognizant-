-- ============================================
-- Exercise 4 : Execute a Stored Procedure
-- ============================================

-- Drop table if it already exists
IF OBJECT_ID('Employees', 'U') IS NOT NULL
DROP TABLE Employees;
GO

-- Create Employees Table
CREATE TABLE Employees
(
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE
);
GO

-- Insert Sample Data
INSERT INTO Employees
(FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES
('John','Smith',1,50000,'2023-01-15'),
('Alice','Brown',2,60000,'2022-05-10'),
('David','Wilson',1,55000,'2021-03-20'),
('Rahul','Kumar',3,65000,'2024-06-15'),
('Priya','Sharma',2,58000,'2023-07-12');
GO

-- Drop Procedure if it already exists
IF OBJECT_ID('sp_GetEmployeesByDepartment', 'P') IS NOT NULL
DROP PROCEDURE sp_GetEmployeesByDepartment;
GO

-- Create Stored Procedure
CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT EmployeeID,
           FirstName,
           LastName,
           DepartmentID,
           Salary,
           JoinDate
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

-- ============================================
-- Execute Stored Procedure
-- ============================================

PRINT 'Employees in Department 1';
EXEC sp_GetEmployeesByDepartment @DepartmentID = 1;
GO

PRINT 'Employees in Department 2';
EXEC sp_GetEmployeesByDepartment @DepartmentID = 2;
GO

PRINT 'Employees in Department 3';
EXEC sp_GetEmployeesByDepartment @DepartmentID = 3;
GO

-- View Complete Table
SELECT * FROM Employees;
GO