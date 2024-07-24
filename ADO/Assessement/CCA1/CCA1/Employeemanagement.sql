CREATE DATABASE Employeemanagement;

Use Employeemanagement

Create Table Employee_Details (
    Empno int PRIMARY KEY,
    EmpName varchar(50) NOT NULL,
    Empsal float CHECK (Empsal >= 25000),
    Emptype char(1) CHECK (Emptype IN ('F', 'P'))
);

CREATE or Alter PROCEDURE InsertEmployee
    @EmpName varchar(50),
    @Empsal float,
    @Emptype char(1)
AS
BEGIN
    DECLARE @Empno int;
    SELECT @Empno = COALESCE(MAX(Empno), 0) + 1 FROM Employee_Details;
    INSERT INTO Employee_Details (Empno, EmpName, Empsal, Emptype)
    VALUES (@Empno, @EmpName, @Empsal, @Emptype);
END;

Exec InsertEmployee 'GURUKIRAN', 30000.00, 'F';
Exec InsertEmployee 'JOYDEEP', 42000.00, 'P';
Exec InsertEmployee 'JAYKUMAR', 48000.00, 'F';
Exec InsertEmployee 'BANUREKHA', 52000.00, 'P';

Select * from Employee_Details

