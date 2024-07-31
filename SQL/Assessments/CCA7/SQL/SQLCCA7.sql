Use Assessement

--BOOKS
CREATE TABLE Books (
    book_id INT PRIMARY KEY,
    title VARCHAR(100),
    author_name VARCHAR(100),
    isbn_code VARCHAR(20) UNIQUE,
    publication_date DATETIME
);

INSERT INTO Books (book_id, title, author_name, isbn_code, publication_date) 
VALUES
    (1, 'Introduction to SQL', 'Mary Parker', '981483029127', '2012-02-22 12:08:17'),
    (2, 'Advanced SQL Queries', 'John Mayer', '857300923713', '1972-07-03 09:22:45'),
    (3, 'SQL for Beginners', 'Cary Flint', '523120967812', '2015-10-18 14:05:44');

--REVIEWS
CREATE TABLE Reviews (
    review_id INT PRIMARY KEY,
    book_id INT,
    reviewer VARCHAR(100),
    review_content VARCHAR(500),
    rating INT,
    review_date DATETIME,
    FOREIGN KEY (book_id) REFERENCES Books(book_id)
);

INSERT INTO Reviews (review_id, book_id, reviewer, review_content, rating, review_date) 
VALUES
    (1, 1, 'John Smith', 'Excellent book for beginners', 4, '2017-12-10 05:50:11.1'),
    (2, 2, 'John Smith', 'Detailed coverage of SQL topics', 5, '2017-10-13 15:05:12.6'),
    (3, 2, 'Alice Walker', 'Not very useful for advanced users', 2, '2017-10-22 23:47:10');

--QUERY-1
SELECT * FROM Books
WHERE author_name LIKE '%er';

SELECT reviewer FROM Reviews
GROUP BY reviewer
HAVING COUNT(DISTINCT book_id) > 1;

--CUSTOMER
CREATE TABLE Customer (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(50),
    address VARCHAR(100),
    age INT,
    salary FLOAT
);

INSERT INTO Customer (name, address, age, salary)
VALUES 
    ('RAMESH', 'AHMEDABAD', 32, 2000.00),
    ('KHILAN', 'DELHI', 25, 1500.00),
    ('KAUSHIK', 'KOTA', 23, 2000.00),
    ('CHAITALI', 'MUMBAI', 25, 6500.00),
    ('HARDIK', 'BHOPAL', 27, 8500.00),
    ('KOMAL', 'MP', 22, 4500.00),
    ('MUFFY', 'INDORE', 24, 10000.00);

SELECT name FROM Customer
WHERE address LIKE '%o%';

--ORDERS
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    OrderDate DATETIME,
    CustomerID INT,
    Amount FLOAT
);

INSERT INTO Orders (OrderDate, CustomerID, Amount) 
VALUES 
    ('2009-10-08 00:00:00', 3, 3000.00),
    ('2009-10-08 00:00:00', 3, 1500.00),
    ('2008-05-20 00:00:00', 2, 1560.00),
    ('2008-05-20 00:00:00', 4, 2060.00);

--Query2
SELECT OrderDate, COUNT(DISTINCT CustomerID) AS TotalCustomers FROM Orders
GROUP BY OrderDate;

--EMPLOYEE
CREATE TABLE Employee (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(50),
    address VARCHAR(100),
    age INT,
    salary FLOAT
);

INSERT INTO Employee (name, address, age, salary)
VALUES 
    ('RAMESH', 'AHMEDABAD', 32, 2000.00),
    ('KHILAN', 'DELHI', 25, 1500.00),
    ('KAUSHIK', 'KOTA', 23, 2000.00),
    ('CHAITALI', 'MUMBAI', 25, 6500.00),
    ('HARDIK', 'BHOPAL', 27, 8500.00),
    ('KOMAL', 'MP', 22, NULL),
    ('MUFFY', 'INDORE', 24, NULL);

--EMPLOYEE
SELECT LOWER(name) AS LowercaseName
FROM Employee
WHERE salary IS NULL;

CREATE TABLE Students (
    Reg INT PRIMARY KEY,
    Name VARCHAR(100),
    Age INT,
    Qualification VARCHAR(100),
    Mobile_no VARCHAR(15),
    Mail_id VARCHAR(100),
    Location VARCHAR(255),
    Gender CHAR(1)
);

INSERT INTO Students (Reg, name, Age, Qualification, Mobile_no, Mail_id, Location, Gender)
VALUES 
    (2,'SAI', 22, 'BE', '9952836777', 'SAI@GMAIL.COM', 'CHENNAI', 'M'),
    (3,'KUMAR', 20, 'BSC', '7890125648', 'KUMAR@GMAIL.COM', 'MADURAI', 'M'),
    (4,'SELVI', 22, 'B TECH', '8904567342', 'SELVI@GMAIL.COM', 'SELAM', 'F'),
    (5,'NISHA', 25, 'ME', '7834672310', 'NISHA@GMAIL.COM', 'THENI', 'F'),
    (6,'SAISARAN', 21, 'BA', '7890345678', 'SARAN@GMAIL.COM', 'MADURAI', 'F'),
    (7,'TOM', 23, 'BCA', '8901234675', 'TOM@GMAIL.COM', 'PUNE', 'M');

--Query3
SELECT gender, COUNT(*) AS TotalStudents
FROM Students
GROUP BY gender;
