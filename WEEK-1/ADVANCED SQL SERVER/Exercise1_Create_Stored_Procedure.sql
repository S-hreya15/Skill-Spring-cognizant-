-- ============================================
-- Exercise 1 : Create a Stored Procedure
-- ============================================

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

--------------------------------------------------------
-- Insert Sample Data
--------------------------------------------------------

INSERT INTO Employees
(FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES
('John','Smith',1,50000,'2023-01-15'),
('Alice','Brown',2,60000,'2022-05-10'),
('David','Wilson',1,55000,'2021-03-20');

--------------------------------------------------------
-- Stored Procedure to Retrieve Employees by Department
--------------------------------------------------------

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

--------------------------------------------------------
-- Execute Stored Procedure
--------------------------------------------------------

EXEC sp_GetEmployeesByDepartment 1;
GO

--------------------------------------------------------
-- Stored Procedure to Insert Employee
--------------------------------------------------------

CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees
    (
        FirstName,
        LastName,
        DepartmentID,
        Salary,
        JoinDate
    )
    VALUES
    (
        @FirstName,
        @LastName,
        @DepartmentID,
        @Salary,
        @JoinDate
    );
END;
GO

--------------------------------------------------------
-- Execute Insert Procedure
--------------------------------------------------------

EXEC sp_InsertEmployee
'Rahul',
'Kumar',
3,
65000,
'2024-06-15';
GO

--------------------------------------------------------
-- View Data
--------------------------------------------------------

SELECT * FROM Employees;