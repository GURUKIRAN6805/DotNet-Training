use Assignment

CREATE PROCEDURE GeneratePayslip
    @EmployeeID INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @EmployeeName VARCHAR(50);
    DECLARE @Salary DECIMAL(10, 2);
    DECLARE @HRA DECIMAL(10, 2);
    DECLARE @DA DECIMAL(10, 2);
    DECLARE @PF DECIMAL(10, 2);
    DECLARE @IT DECIMAL(10, 2);
    DECLARE @Deductions DECIMAL(10, 2);
    DECLARE @GrossSalary DECIMAL(10, 2);
    DECLARE @NetSalary DECIMAL(10, 2);

    SELECT @EmployeeName = ename,
           @Salary = sal
    FROM emp
    WHERE empno = @EmployeeID;

    SET @HRA = @Salary * 0.10;
    SET @DA = @Salary * 0.20;
    SET @PF = @Salary * 0.08;
    SET @IT = @Salary * 0.05;
    SET @Deductions = @PF + @IT;
    SET @GrossSalary = @Salary + @HRA + @DA;
    SET @NetSalary = @GrossSalary - @Deductions;

    PRINT '              PAYSLIP                          ';
    PRINT '----------------------------------------------';
    PRINT 'Employee ID: ' + CAST(@EmployeeID AS VARCHAR(10));
    PRINT 'Employee Name: ' + @EmployeeName;
    PRINT 'Basic Salary: ' + CAST(@Salary AS VARCHAR(20));
    PRINT 'HRA (10% of Salary): ' + CAST(@HRA AS VARCHAR(20));
    PRINT 'DA (20% of Salary): ' + CAST(@DA AS VARCHAR(20));
    PRINT 'Gross Salary: ' + CAST(@GrossSalary AS VARCHAR(20));
    PRINT 'PF (8% of Salary): ' + CAST(@PF AS VARCHAR(20));
    PRINT 'IT (5% of Salary): ' + CAST(@IT AS VARCHAR(20));
    PRINT 'Deductions (PF + IT): ' + CAST(@Deductions AS VARCHAR(20));
    PRINT '----------------------------------------------';
    PRINT 'Net Salary: ' + CAST(@NetSalary AS VARCHAR(20));
END;

EXEC GeneratePayslip @EmployeeID = 7902; 

SELECT * FROM EMP
