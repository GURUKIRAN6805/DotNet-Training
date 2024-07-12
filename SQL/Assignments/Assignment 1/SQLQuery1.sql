use Assignment

-- Clients Table
CREATE TABLE Clients (
    Client_ID INT PRIMARY KEY,
    Cname VARCHAR(40) NOT NULL,
    Address VARCHAR(30),
    Email VARCHAR(30) UNIQUE,
    Phone VARCHAR(10),
    Business VARCHAR(20) NOT NULL
);

-- Insert into Clients
INSERT INTO Clients (Client_ID, Cname, Address, Email, Phone, Business)
VALUES
(1001, 'ACME Utilities', 'Noida', 'contact@acmeutil.com', '9567880032', 'Manufacturing'),
(1002, 'Trackon Consultants', 'Mumbai', 'consult@trackon.com', '8734210090', 'Consultant'),
(1003, 'MoneySaver Distributors', 'Kolkata', 'save@moneysaver.com', '7799886655', 'Reseller'),
(1004, 'Lawful Corp', 'Chennai', 'justice@lawful.com', '9210342219', 'Professional');


select * from Clients

-- Employees Table
CREATE TABLE Employees (
    Empno INT PRIMARY KEY,
    Ename VARCHAR(20) NOT NULL,
    Job VARCHAR(15),
    Salary INT CHECK (Salary > 0),
    Deptno INT,
    FOREIGN KEY (Deptno) REFERENCES Departments(Deptno)
);

-- Insert into Employees
INSERT INTO Employees (Empno, Ename, Job, Salary, Deptno)
VALUES
(7001, 'Sandeep', 'Analyst', 25000, 10),
(7002, 'Rajesh', 'Designer', 30000, 10),
(7003, 'Madhav', 'Developer', 40000, 20),
(7004, 'Manoj', 'Developer', 40000, 20),
(7005, 'Abhay', 'Designer', 35000, 10),
(7006, 'Uma', 'Tester', 30000, 30),
(7007, 'Gita', 'Tech. Writer', 30000, 40),
(7008, 'Priya', 'Tester', 35000, 30),
(7009, 'Nutan', 'Developer', 45000, 20),
(7010, 'Smita', 'Analyst', 20000, 10),
(7011, 'Anand', 'Project Mgr', 65000, 10);

select * from Employees;

-- Departments Table
CREATE TABLE Departments (
    Deptno INT PRIMARY KEY,
    Dname VARCHAR(15) NOT NULL,
    Loc VARCHAR(20)
);

-- Insert into Departments
INSERT INTO Departments (Deptno, Dname, Loc)
VALUES
(10, 'Design', 'Pune'),
(20, 'Development', 'Pune'),
(30, 'Testing', 'Mumbai'),
(40, 'Document', 'Mumbai');

select * from Departments

-- Projects Table
CREATE TABLE Projects (
    Project_ID INT PRIMARY KEY,
    Descr VARCHAR(30) NOT NULL,
    Start_Date DATE,
    Planned_End_Date DATE,
    Actual_End_date DATE,
    Budget INT CHECK (Budget > 0),
    Client_ID INT,
    CONSTRAINT FK_Client_Project FOREIGN KEY (Client_ID) REFERENCES Clients(Client_ID)
);

-- Insert into Projects
INSERT INTO Projects (Project_ID, Descr, Start_Date, Planned_End_Date, Actual_End_date, Budget, Client_ID)
VALUES
(401, 'Inventory', '2011-04-01', '2011-10-01', '2011-10-31', 150000, 1001),
(402, 'Accounting', '2011-08-01', '2012-01-01', NULL, 500000, 1002),
(403, 'Payroll', '2011-10-01', '2011-12-31', NULL, 75000, 1003),
(404, 'Contact Mgmt', '2011-11-01', '2011-12-31', NULL, 50000, 1004);

select * from Projects;

-- EmpProjectTasks Table
CREATE TABLE EmpProjectTasks (
    Project_ID INT,
    Empno INT,
    Start_Date DATE,
    End_Date DATE,
    Task VARCHAR(25) NOT NULL,
    Status VARCHAR(15) NOT NULL,
    PRIMARY KEY (Project_ID, Empno),
    FOREIGN KEY (Project_ID) REFERENCES Projects(Project_ID),
    FOREIGN KEY (Empno) REFERENCES Employees(Empno)
);

-- Insert into EmpProjectTasks
INSERT INTO EmpProjectTasks (Project_ID, Empno, Start_Date, End_Date, Task, Status)
VALUES
(401, 7001, '2011-04-01', '2011-04-20', 'System Analysis', 'Completed'),
(401, 7002, '2011-04-21', '2011-05-30', 'System Design', 'Completed'),
(401, 7003, '2011-06-01', '2011-07-15', 'Coding', 'Completed'),
(401, 7004, '2011-07-18', '2011-09-01', 'Coding', 'Completed'),
(401, 7006, '2011-09-03', '2011-09-15', 'Testing', 'Completed'),
(401, 7009, '2011-09-18', '2011-10-05', 'Code Change', 'Completed'),
(401, 7008, '2011-10-06', '2011-10-16', 'Testing', 'Completed'),
(401, 7007, '2011-10-06', '2011-10-22', 'Documentation', 'Completed'),
(401, 7011, '2011-10-22', '2011-10-31', 'Sign off', 'Completed'),
(402, 7010, '2011-08-01', '2011-08-20', 'System Analysis', 'Completed'),
(402, 7002, '2011-08-22', '2011-09-30', 'System Design', 'Completed');

select * from EmpProjectTasks;
