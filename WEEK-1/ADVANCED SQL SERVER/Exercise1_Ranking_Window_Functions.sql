-- =========================================
-- Exercise 1 : Ranking and Window Functions
-- =========================================

-- Create Product table

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Category VARCHAR(30),
    Price DECIMAL(10,2)
);

-- Insert Sample Data

INSERT INTO Products VALUES
(1,'Laptop','Electronics',80000),
(2,'Mobile','Electronics',60000),
(3,'Headphones','Electronics',5000),
(4,'TV','Electronics',70000),
(5,'Shirt','Clothing',1500),
(6,'Jeans','Clothing',2500),
(7,'Jacket','Clothing',4000),
(8,'Shoes','Clothing',3500),
(9,'Rice','Grocery',900),
(10,'Oil','Grocery',1800),
(11,'Sugar','Grocery',1200),
(12,'Milk','Grocery',700);

--------------------------------------------------
-- ROW_NUMBER()
--------------------------------------------------

SELECT *
FROM
(
    SELECT *,
           ROW_NUMBER() OVER
           (
               PARTITION BY Category
               ORDER BY Price DESC
           ) AS RowNum
    FROM Products
) AS T
WHERE RowNum <= 3;

--------------------------------------------------
-- RANK()
--------------------------------------------------

SELECT *,
       RANK() OVER
       (
           PARTITION BY Category
           ORDER BY Price DESC
       ) AS RankNo
FROM Products;

--------------------------------------------------
-- DENSE_RANK()
--------------------------------------------------

SELECT *,
       DENSE_RANK() OVER
       (
           PARTITION BY Category
           ORDER BY Price DESC
       ) AS DenseRankNo
FROM Products;