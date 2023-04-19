CREATE TABLE Products (
	Id INT PRIMARY KEY,
	Name TEXT
);

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	Name TEXT
);

CREATE TABLE ProductsCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id)
);

INSERT INTO Products
VALUES
	(1, 'Iphone 14 Pro Max 128Gb'),
	(2, 'i9 11900k'),
	(3, 'SAMSUNG 980 SSD 1TB M.2'),
	(4, 'Epson Expression Home XP-4100'),
	(5, 'Xiaomi Curved 34-inch display'),
	(6, 'Galaxy A11'),
	(7, 'TP-Link AC17530');



INSERT INTO Categories
VALUES
	(1, 'Computer Components'),
	(2, 'Data Storage'),
	(3, 'Printers'),
	(4, 'Scanners'),
	(5, 'Monitors'),
	(6, 'Servers');


INSERT INTO ProductsCategories
VALUES
	(1, 6),
	(2, 1),
	(3, 1),
	(3, 2),
	(4, 3),
	(5, 5);

SELECT P.Name, C.Name
FROM Products P
LEFT JOIN ProductsCategories Pc
	ON P.Id = Pc.ProductId
LEFT JOIN Categories C
	ON Pc.CategoryId = C.Id;
