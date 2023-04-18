Create database MyNewDatabaseForLearning
use MyNewDatabaseForLearning
Create table Customers
(
	CustomerId int not null primary key,
	CustomerName nvarchar(20)
)
Create table Products
(
	ProductId int not null primary key,
	ProductName nvarchar(50)
)
Create table Orders
(
	OrderId int not null primary key,
	CustomerId int foreign key references Customers(CustomerId),
	ProductId int foreign key references Products(ProductId),
	OrderDate date
)

INSERT INTO Customers (CustomerId, CustomerName)
VALUES 
    (1, 'John'),
    (2, 'Mary'),
    (3, 'David'),
    (4, 'Sarah'),
    (5, 'Mike'),
    (6, 'Lisa'),
    (7, 'James'),
    (8, 'Emily'),
    (9, 'Tom'),
    (10, 'Jessica'),
    (11, 'Alex'),
    (12, 'Karen'),
    (13, 'Chris'),
    (14, 'Megan'),
    (15, 'Brian'),
    (16, 'Julia'),
    (17, 'Mark'),
    (18, 'Olivia'),
    (19, 'Lucas'),
    (20, 'Grace');

INSERT INTO Products (ProductId, ProductName)
VALUES 
    (1, 'iPhone 13'),
    (2, 'Samsung Galaxy S21'),
    (3, 'Google Pixel 6'),
    (4, 'MacBook Pro'),
    (5, 'Lenovo ThinkPad X1'),
    (6, 'Microsoft Surface Laptop 4'),
    (7, 'Sony PlayStation 5'),
    (8, 'Microsoft Xbox Series X'),
    (9, 'Nintendo Switch'),
    (10, 'Amazon Echo'),
    (11, 'Google Nest Hub'),
    (12, 'Sonos One'),
    (13, 'Bose QuietComfort 35'),
    (14, 'Sony WH-1000XM4'),
    (15, 'Apple AirPods Max'),
    (16, 'Samsung QLED QN90A'),
    (17, 'LG OLED C1'),
    (18, 'Sony BRAVIA XR'),
    (19, 'Bose Soundbar 700'),
    (20, 'Sonos Arc');

INSERT INTO Orders (OrderId, CustomerId, ProductId, OrderDate)
VALUES 
    (1, 1, 1, '2022-01-01'),
    (2, 2, 2, '2022-02-01'),
    (3, 3, 3, '2022-03-01'),
    (4, 4, 4, '2022-04-01'),
    (5, 5, 5, '2022-05-01'),
    (6, 6, 6, '2022-06-01'),
    (7, 7, 7, '2022-07-01'),
    (8, 8, 8, '2022-08-01'),
    (9, 9, 9, '2022-09-01'),
    (10, 10, 10, '2022-10-01'),
    (11, 11, 11, '2022-11-01'),
	(12, 12, 12,'2022-12-01'),
	(13, 13, 13, '2023-01-01'),
	(14, 14, 14, '2023-02-01'),
	(15, 15, 15, '2023-03-01'),
	(16, 16, 16, '2023-04-01'),
	(17, 17, 17, '2023-05-01'),
	(18, 18, 18, '2023-06-01'),
	(19, 19, 19, '2023-07-01'),
	(20, 20, 20, '2023-08-01');

SELECT Orders.OrderId, Customers.CustomerName, Products.ProductName, Orders.OrderDate
FROM Orders
JOIN Customers ON Orders.CustomerId = Customers.CustomerId
JOIN Products ON Orders.ProductId = Products.ProductId;
