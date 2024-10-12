INSERT INTO Reservations (DriverName, VehicleModel, VehicleType, ReservationDate, CheckOutDate, ReturnDate, TotalCost, Status)
VALUES 
    ('Alice Johnson', 'Toyota Camry', 'Sedan', '2024-10-10 09:00:00', '2024-10-10 12:00:00', '2024-10-12 12:00:00', 150.00, 'Active'),
    ('John Smith', 'Ford F-150', 'Pickup', '2024-10-11 10:00:00', '2024-10-11 13:00:00', NULL, 200.00, 'Active'),
    ('Emma Brown', 'Honda Accord', 'Sedan', '2024-10-12 11:00:00', '2024-10-12 14:00:00', '2024-10-15 14:00:00', 175.00, 'Extended'),
    ('Michael Davis', 'Chevrolet Tahoe', 'SUV', '2024-10-10 08:00:00', '2024-10-10 11:00:00', '2024-10-13 11:00:00', 300.00, 'Active'),
    ('Sophia Wilson', 'Chrysler Pacifica', 'Van', '2024-10-09 15:00:00', '2024-10-09 18:00:00', '2024-10-11 18:00:00', 250.00, 'Completed');
