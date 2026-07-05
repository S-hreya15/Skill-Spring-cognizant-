-- ============================================
-- Exercise 5 : Return Data from a Stored Procedure
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
('Priya','Sharma',2,58000,'2023-07-12'),
('Amit','Verma',1,52000,'2022-11-08');
GO

---------------------------------------------------------
-- Stored Procedure to Return Employee Count
---------------------------------------------------------

IF OBJECT_ID('sp_GetEmployeeCount', 'P') IS NOT NULL
DROP PROCEDURE sp_GetEmployeeCount;
GO

CREATE PROCEDURE sp_GetEmployeeCount
    @DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

---------------------------------------------------------
-- Execute Stored Procedure
---------------------------------------------------------

EXEC sp_GetEmployeeCount @DepartmentID = 1;
GO

EXEC sp_GetEmployeeCount @DepartmentID = 2;
GO

EXEC sp_GetEmployeeCount @DepartmentID = 3;
GO

---------------------------------------------------------
-- Display Employees Table
---------------------------------------------------------

SELECT * FROM Employees;
GO