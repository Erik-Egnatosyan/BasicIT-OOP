Create database VegaVestaNew
use VegaVestaNew
create table VegaCategory
(
ID int not null identity primary key,
VegaObject nvarchar(50) not null,
VegaKitchen bit,
VegaDevice bit,
VegaFurniture bit
)
create table VegaBrand
(
ID int not null identity primary key,
VegaBrandName nvarchar(50) not null,
)
create table VegaDiscount
(
ID int not null identity,
VegaPrice money not null,
VegaObjectID int foreign key references VegaCategory(ID),
VegaBrand int foreign key references VegaBrand(ID),
VegaDiscountSize int
)

INSERT INTO VegaCategory (VegaObject, VegaKitchen, VegaDevice, VegaFurniture)
VALUES 
    ('Chair', 0, 1, 1),
    ('Sofa', 0, 1, 1),
    ('Table', 1, 0, 1),
    ('Fridge', 1, 1, 0),
    ('Oven', 1, 1, 0),
    ('Bed', 0, 0, 1),
    ('Dresser', 0, 0, 1),
    ('Lamp', 1, 0, 0),
    ('TV', 0, 1, 0),
    ('Microwave', 1, 0, 0);

INSERT INTO VegaBrand (VegaBrandName)
VALUES 
    ('Ikea'),
    ('Ashley Furniture'),
    ('Samsung'),
    ('LG'),
    ('Whirlpool'),
    ('Sony'),
    ('Panasonic'),
    ('Philips'),
    ('LG'),
    ('Bosch');

INSERT INTO VegaDiscount (VegaPrice, VegaObjectID, VegaBrand, VegaDiscountSize)
VALUES 
    (1499.99, 2, 1, 10),
    (799.99, 3, 1, 15),
    (399.99, 1, 2, 5),
    (599.99, 4, 4, 20),
    (2499.99, 5, 5, 10),
    (999.99, 1, 6, 15),
    (799.99, 6, 2, 5),
    (499.99, 7, 2, 10),
    (249.99, 8, 3, 10),
    (349.99, 9, 4, 5);

SELECT vd.ID, vd.VegaPrice, vc.VegaObject, vb.VegaBrandName, vd.VegaDiscountSize, 
vd.VegaPrice * (100 - vd.VegaDiscountSize) / 100.0 AS PriceWithDiscount
FROM VegaDiscount vd
JOIN VegaCategory vc ON vd.VegaObjectID = vc.ID
JOIN VegaBrand vb ON vd.VegaBrand = vb.ID;

select VegaObject from VegaCategory
where VegaDevice = 1
