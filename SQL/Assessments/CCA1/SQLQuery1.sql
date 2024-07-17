use Assessement

--1. Declare and initialize the @YourBirthday with date
DECLARE @YourBirthday DATE = '2001-11-19';
SELECT DATENAME(dw, @YourBirthday) AS BirthdayDayOfWeek;

--2.
DECLARE @YourBirthday DATE = '2001-11-19';
SELECT DATEDIFF(day, @YourBirthday, GETDATE()) AS AgeInDays;

-- Create EMP table
CREATE TABLE EMP (
    EMPNO INT PRIMARY KEY,
    ENAME VARCHAR(50),
    JOB VARCHAR(50),
    MGR_ID INT,
    HIREDATE DATE,
    SAL DECIMAL(10, 2),
    COMM DECIMAL(10, 2),
    DEPTNO INT,
    FOREIGN KEY (DEPTNO) REFERENCES DEPT(DEPTNO)
);

-- Create DEPT table
CREATE TABLE DEPT (
    DEPTNO INT PRIMARY KEY,
    DNAME VARCHAR(50),
    LOC VARCHAR(50)
);

-- Insert data into DEPT table
INSERT INTO DEPT (DEPTNO, DNAME, LOC) VALUES
(10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON');

-- Insert data into EMP table
INSERT INTO EMP (EMPNO, ENAME, JOB, MGR_ID, HIREDATE, SAL, COMM, DEPTNO) VALUES
(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10);
INSERT INTO EMP Values(8984, 'SANTU','CLERK',8843,'2020-11-08',4000,NULL,30),
(7999, 'KHAN','ANALYST',8834,'2019-06-11',3000,NULL,10),
(8994, 'SALMAN','SALESMAN',8856,'2015-07-10',4200,NULL,20);

--3.Employees who joined 5 years ago or earlier
SELECT * FROM EMP
WHERE HIREDATE < DATEADD(YEAR, -5, GETDATE())

--4.
IF OBJECT_ID('dbo.Employee', 'U') IS NOT NULL
    DROP TABLE dbo.Employee;

CREATE TABLE dbo.Employee (
    empno INT PRIMARY KEY,
    ename VARCHAR(50),
    sal DECIMAL(10, 2),
    doj DATE,
    SysStartTime DATETIME2 GENERATED ALWAYS AS ROW START HIDDEN NOT NULL,
    SysEndTime DATETIME2 GENERATED ALWAYS AS ROW END HIDDEN NOT NULL,
    PERIOD FOR SYSTEM_TIME (SysStartTime, SysEndTime)
)
BEGIN TRANSACTION;

--a. Insert three rows into the Employee table
INSERT INTO dbo.Employee (empno, ename, sal, doj)
VALUES
    (1818, 'Sky', 45000, '2021-05-14'),
    (1819, 'Santu', 48000, '2021-02-17'),
    (1820, 'Guru', 49000, '2021-01-19');

--b. Update the salary of the second row with a 15% increment
UPDATE dbo.Employee
SET sal = sal * 1.15
WHERE empno = 1819;

SELECT * FROM dbo.Employee

--c. Delete the first row
BEGIN TRANSACTION;

DELETE FROM dbo.Employee
WHERE empno = 1818;

ROLLBACK;

--5.
CREATE FUNCTION dbo.CalculateBonus (
@deptno INT,
@sal DECIMAL(10, 2)
)
RETURNS DECIMAL(10, 2)
AS
BEGIN 
DECLARE @bonus DECIMAL(10, 2);
SET @bonus = 
	CASE 
	WHEN @deptno = 10 THEN @sal * 0.15  
	WHEN @deptno = 20 THEN @sal * 0.20  
	ELSE @sal * 0.05                    
END;
RETURN @bonus;
END;

DECLARE @bonus DECIMAL(10, 2);

--a. bonus for employee in Deptno 10
SET @bonus = dbo.CalculateBonus(10, 4800);  
SELECT @bonus AS BonusForDept10;

--b. bonus for employee in Deptno 20
SET @bonus = dbo.CalculateBonus(20, 7400);  
SELECT @bonus AS BonusForDept20;

--c. bonus for employee in a different department 
SET @bonus = dbo.CalculateBonus(30, 9200);  
SELECT @bonus AS BonusForOtherDepts;