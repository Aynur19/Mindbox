-- Работа в контексте БД "test"
use test;
go

-- Удаление таблиц если они существуют
DROP TABLE IF EXISTS dbo.ProductsCategories, dbo.Categories, dbo.Products;
go

-- Создание таблицы "Категории"
create table Categories 
(
	Id uniqueidentifier primary key default newid(),
	Name varchar(255) not null
);
go

-- Создание таблицы "Продукты"
create table Products 
(
	Id uniqueidentifier primary key default newid(),
	Name varchar(255) not null
);
go

-- Создание таблицы "Продукты-Категории" для обеспечения связи многие-ко-многим
create table ProductsCategories 
(
	Id uniqueidentifier primary key default newid(),
	CategoryId uniqueidentifier foreign key references Categories(Id),
	ProductId uniqueidentifier foreign key references Products(Id)
);
go

-- Объявление временных таблиц, для заполнения идентификаторами продуктов и категорий
declare @insertedCategories table(OriginalId int identity(1,1), CategoryId uniqueidentifier);
declare @insertedProducts table(OriginalId int identity(1,1), ProductId uniqueidentifier);

-- Далее необходимо заполнить таблицы данными в следующем виде:
-- 
-- __________________________
-- | Category | Product     |
-- |----------|-------------|
-- | software | drivers     |
-- | software | BIOS        |
-- | software | games       |
-- | software | browsers    |
-- | ...      | ...         |
-- | hardware | drivers     |
-- | hardware | BIOS        |
-- | hardware | CPU         |
-- | hardware | GPU         |
-- | ...      | ...         |
-- |          | Chair       |
-- |          | Table       |
-- |          | Accessories |
-- |__________|_____________|

insert into dbo.Categories(Name)
output inserted.Id into @insertedCategories(CategoryId)
values 
	('software'), ('software'), ('software'), ('software'),
	('hardware'), ('hardware'), ('hardware'), ('hardware');

insert into dbo.Products(Name)
output inserted.Id into @insertedProducts(ProductId)
values 
	('drivers'), ('BIOS'), ('games'), ('browsers'),
	('drivers'), ('BIOS'), ('CPU'), ('GPU'),
	('Chair'), ('Table'), ('Accessories');

insert into dbo.ProductsCategories(CategoryId, ProductId)
select insCat.CategoryId, insProd.ProductId
from @insertedProducts insProd inner join @insertedCategories insCat on insCat.OriginalId=insProd.OriginalId
go

-- Получение данных (пара значение "Продукт-Категория")
select p.Name, c.Name from Products p
left join ProductsCategories pc on pc.ProductId = p.Id
left join Categories c on c.Id = pc.CategoryId
group by p.Name, c.Name
order by p.Name, c.Name;