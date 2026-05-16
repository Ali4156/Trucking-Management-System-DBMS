USE TruckingSystem;
GO

-- ===============================
-- DELETE OLD TABLES
-- ===============================

DROP TABLE IF EXISTS Shipment;
DROP TABLE IF EXISTS Driver;
DROP TABLE IF EXISTS Truck;
DROP TABLE IF EXISTS Users;
DROP TABLE IF EXISTS Member
GO

-- ===============================
-- USERS TABLE
-- ===============================

CREATE TABLE Users (
    user_id INT PRIMARY KEY IDENTITY(1,1),
    full_name VARCHAR(100) NOT NULL,
    username VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(50) NOT NULL,
    role VARCHAR(20) NOT NULL,
    phone VARCHAR(20),
    email VARCHAR(100)
);

-- SAMPLE USERS
INSERT INTO Users 
(full_name, username, password, role, phone, email)
VALUES
('Admin User', 'admin', '123', 'Admin', '03001234567', 'admin@gmail.com'),

('Ali Khan', 'ali', '111', 'User', '03111222333', 'ali@gmail.com');

-- ===============================
-- TRUCK TABLE
-- ===============================

CREATE TABLE Truck (
    truck_number VARCHAR(50) PRIMARY KEY,
    model VARCHAR(50) NOT NULL,
    capacity INT NOT NULL,
    status VARCHAR(20) NOT NULL
);

-- SAMPLE TRUCKS
INSERT INTO Truck
(truck_number, model, capacity, status)
VALUES
('4156', '2010', 15, 'Active'),

('7821', '2018', 20, 'Maintenance'),

('9001', '2022', 25, 'Active');

-- ===============================
-- DRIVER TABLE
-- ===============================

CREATE TABLE Driver (
    driver_id INT PRIMARY KEY IDENTITY(1,1),
    driver_name VARCHAR(100) NOT NULL,
    phone VARCHAR(20),
    license_number VARCHAR(50),
    status VARCHAR(20)
);

-- SAMPLE DRIVERS
INSERT INTO Driver
(driver_name, phone, license_number, status)
VALUES
('Ali', '03001234567', 'LIC123', 'Available'),

('Ahmed', '03111234567', 'LIC456', 'Busy'),

('Usman', '03221234567', 'LIC789', 'Available');

-- ===============================
-- SHIPMENT TABLE
-- ===============================

CREATE TABLE Shipment (
    shipment_id VARCHAR(20) PRIMARY KEY,
    truck_id VARCHAR(50),
    driver_id VARCHAR(100),
    shipment_from VARCHAR(100),
    destination VARCHAR(100),
    shipment_date DATE,
    shipment_status VARCHAR(20)
);

-- SAMPLE SHIPMENTS
INSERT INTO Shipment
(shipment_id, truck_id, driver_id, shipment_from, destination, shipment_date, shipment_status)
VALUES
('104', '4156', 'Ali', 'Muzaffarabad', 'Pindi', '2026-05-09', 'In Transit'),

('105', '7821', 'Ahmed', 'Muzaffarabad', 'Haripur', '2026-05-10', 'Pending'),

('106', '9001', 'Usman', 'Muzaffarabad', 'Neelum Sharda', '2026-05-11', 'Delivered');


CREATE TABLE Member (
    member_id INT PRIMARY KEY IDENTITY(1,1),

    full_name VARCHAR(100) NOT NULL,

    username VARCHAR(50) UNIQUE NOT NULL,

    password VARCHAR(50) NOT NULL,

    role VARCHAR(20) NOT NULL,

    phone_number VARCHAR(20),

    email VARCHAR(100)
);

INSERT INTO Member
(full_name, username, password, role, phone_number, email)
VALUES
('Ali Khan', 'ali', '123', 'Admin', '03001234567', 'ali@gmail.com'),

('Ahmed Raza', 'ahmed', '111', 'User', '03111222333', 'ahmed@gmail.com'),

('Usman Tariq', 'usman', '222', 'Admin', '03221234567', 'usman@gmail.com');

-- ===============================
-- VIEW ALL TABLES
-- ===============================

SELECT * FROM Users;

SELECT * FROM Truck;

SELECT * FROM Driver;

SELECT * FROM Shipment;

SELECT * FROM Member;
SELECT username,password,role
FROM Member;

