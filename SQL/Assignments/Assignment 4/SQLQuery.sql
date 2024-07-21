use Assignment

--1. T-SQL Program to find the factorial of a given number.
DECLARE @number INT = 9; 
DECLARE @factorial INT = 1;
DECLARE @counter INT = 1;

IF @number < 0
BEGIN
    PRINT 'Factorial is not defined for negative numbers.';
    RETURN;
END

WHILE @counter <= @number
BEGIN
    SET @factorial = @factorial * @counter; 
    SET @counter = @counter + 1; 
END

PRINT 'Factorial of ' + CAST(@number AS VARCHAR(10)) + ' is ' + CAST(@factorial AS VARCHAR(50));

--2. stored procedure to generate multiplication tables up to a given number.
CREATE or Alter Procedure GenerateMultiplicationTable
    @X INT,  
    @Y INT  --  multiplicand
AS
BEGIN
    DECLARE @Multiplicand INT = 1; 

    IF @X < 1 OR @Y < 1
    BEGIN
        PRINT 'Invalid input. Please provide positive integers for X and Y.';
        RETURN; 
    END

    PRINT 'Multiplication Table for ' + CAST(@X AS VARCHAR(10)) + ' up to ' + CAST(@Y AS VARCHAR(10)) + ' rows:';

    WHILE @Multiplicand <= @Y
    BEGIN
        DECLARE @Result VARCHAR(50) = CAST(@X AS VARCHAR(10)) + ' x ' + CAST(@Multiplicand AS VARCHAR(10)) + ' = ' + CAST(@X * @Multiplicand AS VARCHAR(10));
        PRINT @Result;
        SET @Multiplicand = @Multiplicand + 1;
    END
END

EXEC GenerateMultiplicationTable @X = 7, @Y = 5;

select * from EMP