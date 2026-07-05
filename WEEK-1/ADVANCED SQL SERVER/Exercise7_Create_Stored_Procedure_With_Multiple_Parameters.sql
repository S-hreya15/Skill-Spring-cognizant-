-- ============================================
-- Exercise 7 : Create a Stored Procedure with Multiple Parameters
-- ============================================

-- Drop table if it already exists
IF OBJECT_ID('Employees', 'U') IS NOT NULL
DROP TABLE Employees;
GO

-- Create Employees Table
CREATE TABLE Employees
(
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE
);
GO

-- Insert Sample Data
INSERT INTO Employees
VALUES
(1,'John','Smith',1,5000.00,'2023-01-15'),
(2,'Alice','Brown',2,6000.00,'2022-05-10'),
(3,'David','Wilson',1,7000.00,'2021-03-20');
GO

--------------------------------------------------------
-- Create Stored Procedure
--------------------------------------------------------

IF OBJECT_ID('sp_UpdateEmployeeSalary', 'P') IS NOT NULL
DROP PROCEDURE sp_UpdateEmployeeSalary;
GO

CREATE PROCEDURE sp_UpdateEmployeeSalary
    @EmployeeID INT,
    @Salary DECIMAL(10,2)
AS
BEGIN
    UPDATE Employees
    SET Salary = @Salary
    WHERE EmployeeID = @EmployeeID;
END;
GO

--------------------------------------------------------
-- Execute Stored Procedure
--------------------------------------------------------

EXEC sp_UpdateEmployeeSalary 1, 5500.00;
GO

--------------------------------------------------------
-- Verify Updated Data
--------------------------------------------------------

SELECT * FROM Employees;
GO