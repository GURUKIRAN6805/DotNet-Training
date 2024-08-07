CREATE DATABASE RailwayReservationSystem;

USE RailwayReservationSystem;

-- Table for Trains
CREATE TABLE Trains (
   tno INT PRIMARY KEY,
   tname NVARCHAR(50),
   [from] NVARCHAR(50),
   dest NVARCHAR(50),
   price DECIMAL(10, 2),
   class_of_travel NVARCHAR(20),
   train_status NVARCHAR(10),
   seats_available INT
);

SELECT * FROM Trains

-- Table for Admins
CREATE TABLE Admins (
   admin_id INT IDENTITY(1,1) PRIMARY KEY,
   name NVARCHAR(50),
   username NVARCHAR(50) UNIQUE,
   password NVARCHAR(50)
);

INSERT INTO Admins (name,username, password) VALUES('Guru', 'Guru', 'Guru6805');

SELECT * FROM Admins

-- Table for Users
CREATE TABLE Users (
   user_id INT IDENTITY(1,1) PRIMARY KEY,
   name NVARCHAR(50),
   username NVARCHAR(50) UNIQUE,
   password NVARCHAR(50)
);

SELECT * FROM Users

-- Table for Bookings
CREATE TABLE Bookings (
   booking_id INT IDENTITY(1,1) PRIMARY KEY,
   user_id INT,
   tno INT,
   seats_booked INT,
   booking_date DATETIME DEFAULT GETDATE(),
   FOREIGN KEY (user_id) REFERENCES Users(user_id),
   FOREIGN KEY (tno) REFERENCES Trains(tno)
);

SELECT * FROM Bookings

-- Table for Cancellations
CREATE TABLE Cancellations (
   cancellation_id INT IDENTITY(1,1) PRIMARY KEY,
   booking_id INT,
   seats_cancelled INT,
   cancellation_date DATETIME DEFAULT GETDATE(),
   FOREIGN KEY (booking_id) REFERENCES Bookings(booking_id)
);

SELECT * FROM Cancellations






USE RailwayReservationSystem;
GO
-- Disable foreign key constraints
ALTER TABLE Cancellations NOCHECK CONSTRAINT ALL;
ALTER TABLE Bookings NOCHECK CONSTRAINT ALL;
-- Delete data from the tables
DELETE FROM Cancellations;
DELETE FROM Bookings;
DELETE FROM Users;
DELETE FROM Admins;
DELETE FROM Trains;
-- Enable foreign key constraints
ALTER TABLE Cancellations CHECK CONSTRAINT ALL;
ALTER TABLE Bookings CHECK CONSTRAINT ALL;