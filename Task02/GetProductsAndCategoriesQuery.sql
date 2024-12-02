-- Подготовка для демонстрации запроса.
-- Существует связь многие ко многим, поэтому предполагаю сущесвование трех таблиц.
DROP TABLE IF EXISTS Products;
DROP TABLE IF EXISTS Categories;
DROP TABLE IF EXISTS ProductsCategoriesMap;

CREATE TABLE Products (
  Id int NOT NULL PRIMARY KEY,
  Name varchar(16) NOT NULL,
  Description varchar(128)
);
INSERT INTO Products(Id, Name, Description) 
VALUES 
	(1, 'A', '-'),
	(2, 'B', '-'),
	(3, 'C', '-');

CREATE TABLE Categories (
  Id int NOT NULL PRIMARY KEY,
  Name varchar(16) NOT NULL,
  Description varchar(128)
);
INSERT INTO Categories(Id, Name, Description) 
VALUES 
	(1, 'Excellent', '-'),
	(2, 'Good', '-'),
	(3, 'Fine', '-'),
	(4, 'Bad', '-');

CREATE TABLE ProductsCategoriesMap (
  Id int NOT NULL PRIMARY KEY,
  ProductId int NOT NULL,
  CategoryId int NOT NULL
);
INSERT INTO ProductsCategoriesMap(Id, ProductId, CategoryId) 
VALUES 
	(1, 1, 1),
    (2, 1, 2),
    (3, 2, 2),
    (4, 2, 3);

-- Запрос для задания Вопрос №2.
SELECT p.Name AS ProductName, c.Name AS CategoryName FROM Products p
LEFT JOIN ProductsCategoriesMap pc ON p.Id = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.Id;

-- Преполагаю, что необходимо вывести названия всех продуктов и названия категорий им соответствующих.
-- При этом категории, которые не соответствуют никакому продукту, выводить не требуется.
