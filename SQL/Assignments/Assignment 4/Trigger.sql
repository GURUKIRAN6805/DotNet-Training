use Assignment

CREATE TABLE Holidays (
    HolidayDate DATE,
    HolidayName VARCHAR(30)
);

INSERT INTO Holidays (HolidayDate, HolidayName)
VALUES
    ('2023-01-01', 'New Year''s Day'),
    ('2024-01-14', 'Makar Sankranti'),
	('2022-12-25', 'Christmas'),
    ('2022-10-24', 'Diwali');

CREATE OR ALTER TRIGGER trg_RestrictEMPManipulation
ON emp
INSTEAD OF INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @HolidayDate DATE = GETDATE();
    DECLARE @HolidayName VARCHAR(30);

    SELECT @HolidayName = HolidayName
    FROM Holidays
    WHERE HolidayDate = @HolidayDate;

    IF @HolidayName IS NOT NULL
    BEGIN
        RAISERROR ('Due to %s, you cannot manipulate data', 16, 1, @HolidayName);
        ROLLBACK TRANSACTION;
        RETURN;
    END
    RAISERROR ('Data manipulation allowed on normal days', 0, 1);
END;

INSERT INTO emp (EMPNO, ENAME, JOB, MGR_ID, HIREDATE, SAL, COMM, DEPTNO)
VALUES (6805, 'GURUKIRAN', 'Associate software engineer', 7329, '2024-02-26', 9000.00, NULL, 20);
