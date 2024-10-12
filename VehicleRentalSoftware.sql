CREATE TABLE Reservations (
    ReservationID SERIAL PRIMARY KEY,
    DriverName VARCHAR(100) NOT NULL,     -- Name of the driver renting the vehicle
    VehicleID INT NOT NULL,               -- Foreign key linking to the Vehicles table
    ReservationDate TIMESTAMP NOT NULL,   -- Date and time of the reservation
    CheckOutDate TIMESTAMP NOT NULL,      -- The date and time when the vehicle is checked out
    ReturnDate TIMESTAMP,                 -- The planned return date/time (can be extended)
    TotalCost DECIMAL(10, 2),             -- The total rental cost, calculated based on the daily rate and duration
    Status VARCHAR(20) DEFAULT 'Active',  -- Reservation status (Active, Completed, Cancelled, Extended)
    FOREIGN KEY (VehicleID) REFERENCES Vehicles(VehicleID)
);