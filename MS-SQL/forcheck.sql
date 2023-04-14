Create database RepeatMSSQL
use RepeatMSSQL
create table emplyees
(
	id int not null Primary key,
	UserName nvarchar(50),
	age int,
	position nvarchar(50),
	salary decimal(10,2)
)
INSERT INTO emplyees (id, UserName, age, position, salary)
VALUES (1, 'John Smith', 30, 'Manager', 5000.00);

SELECT * FROM emplyees;

Select * from emplyees
where salary > 1000;

Select * from emplyees
where position = 'Manager'

SELECT * FROM emplyees 
WHERE UserName LIKE 'J%';

INSERT INTO emplyees (id, UserName, age, position, salary)
VALUES
(2, 'Mary Johnson', 25, 'Assistant', 3000.00),
(3, 'David Lee', 35, 'Manager', 6000.00),
(4, 'Sarah Brown', 28, 'Assistant', 3500.00),
(5, 'Michael Davis', 40, 'Director', 8000.00),
(6, 'Jennifer Wilson', 32, 'Manager', 5500.00),
(7, 'Robert Thompson', 45, 'Director', 9000.00),
(8, 'Emily Martinez', 27, 'Assistant', 3200.00),
(9, 'Daniel Hernandez', 38, 'Manager', 6500.00),
(10, 'Jessica Taylor', 30, 'Assistant', 3800.00),
(11, 'Christopher Garcia', 42, 'Director', 8500.00),
(12, 'Amanda Rodriguez', 29, 'Assistant', 3300.00),
(13, 'Matthew Martinez', 36, 'Manager', 6000.00),
(14, 'Ashley Hernandez', 31, 'Assistant', 3600.00),
(15, 'Joshua Davis', 43, 'Director', 9000.00),
(16, 'Samantha Wilson', 26, 'Assistant', 3100.00),
(17, 'Andrew Thompson', 39, 'Manager', 6700.00),
(18, 'Lauren Davis', 33, 'Assistant', 3900.00),
(19, 'Kevin Lee', 44, 'Director', 9500.00),
(20, 'Megan Brown', 28, 'Assistant', 3300.00),
(21, 'Brandon Wilson', 37, 'Manager', 6200.00),
(22, 'Stephanie Martinez', 30, 'Assistant', 3500.00),
(23, 'Nicholas Hernandez', 41, 'Director', 8800.00),
(24, 'Kayla Taylor', 27, 'Assistant', 3200.00),
(25, 'Jacob Garcia', 36, 'Manager', 5900.00),
(26, 'Madison Rodriguez', 31, 'Assistant', 3600.00),
(27, 'William Martinez', 42, 'Director', 9200.00),
(28, 'Olivia Hernandez', 29, 'Assistant', 3300.00),
(29, 'Ethan Davis', 38, 'Manager', 6400.00),
(30, 'Isabella Wilson', 32, 'Assistant', 3700.00),
(31, 'Alexander Thompson', 43, 'Director', 8900.00),
(32, 'Sophia Lee', 26, 'Assistant', 3100.00),
(33, 'Ryan Brown', 35, 'Manager', 5800.00),
(34, 'Emma Davis', 29, 'Assistant', 3400.00),
(35, 'Noah Wilson', 40, 'Director', 8700.00),
(36, 'Avery Martinez', 33, 'Assistant', 3900.00),
(37, 'Liam Hernandez', 42, 'Manager', 7100.00),
(38, 'Chloe Taylor', 27, 'Assistant', 3200.00),
(39, 'Logan Garcia', 39, 'Director', 9300.00),
(40, 'Aaliyah Rodriguez', 31, 'Assistant', 3600.00);

select * from emplyees

CREATE TABLE Orders
(
    Id INT PRIMARY KEY IDENTITY,
    CustomerId INT REFERENCES emplyees (id),
    CreatedAt Date
);

INSERT INTO Orders (CustomerId, CreatedAt) VALUES
(1, '2022-01-01'),
(2, '2022-01-02'),
(1, '2022-01-03'),
(3, '2022-01-04'),
(4, '2022-01-05'),
(2, '2022-01-06'),
(5, '2022-01-07'),
(1, '2022-01-08'),
(3, '2022-01-09'),
(2, '2022-01-10'),
(4, '2022-01-11'),
(1, '2022-01-12'),
(5, '2022-01-13'),
(2, '2022-01-14'),
(3, '2022-01-15'),
(1, '2022-01-16'),
(4, '2022-01-17'),
(5, '2022-01-18'),
(2, '2022-01-19'),
(3, '2022-01-20'),
(1, '2022-01-21'),
(4, '2022-01-22'),
(5, '2022-01-23'),
(2, '2022-01-24'),
(1, '2022-01-25'),
(3, '2022-01-26'),
(4, '2022-01-27'),
(5, '2022-01-28'),
(1, '2022-01-29'),
(2, '2022-01-30'),
(3, '2022-01-31'),
(4, '2022-02-01'),
(5, '2022-02-02'),
(1, '2022-02-03'),
(2, '2022-02-04'),
(3, '2022-02-05'),
(4, '2022-02-06'),
(5, '2022-02-07');

select * from Orders
select * from emplyees

SELECT UserName, age FROM emplyees;

SELECT o.Id, e.UserName, e.age, e.position, o.CreatedAt, o.CustomerId, e.salary
FROM Orders o
INNER JOIN emplyees e ON o.CustomerId = e.id;
-----------------------------------------------
Create table department
(
deptno int primary key, 
dname nvarchar(40),
location nvarchar(40)
)

create table employee
(
empid int,
ename nvarchar(40),
salary money,
deptno int foreign key references department(deptno)
)

insert department values
(10, 'DBA', 'HYD'),
(20, 'SAP', 'MUMBAI'),
(30, 'HR',  'PUNE');

select * from department
select * from employee

insert employee values
(101,'ADAMS', 56000, 10)
insert employee values
(102,'JAMES', 45000, 20)
insert employee values
(103,'SCOTT', 23000, 30)

SELECT e.empid, e.ename, e.salary, d.dname
FROM employee e
INNER JOIN department d ON e.deptno = d.deptno;
