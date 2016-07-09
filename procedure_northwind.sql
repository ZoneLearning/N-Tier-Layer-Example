use NORTHWND
go
create procedure ListProduct
as
select *from Products

go
create procedure AddProduct
@n nvarchar(40),
@p money,
@s  smallint
as
insert into Products(ProductName,UnitPrice,UnitsInStock) values(@n,@p,@s)

go
create procedure DeleteProduct
@id int
as
delete Products where ProductID=@id

go
create procedure UpdateProduct
@n nvarchar(40),
@p money,
@s  smallint,
@id int
as
update Products set ProductName=@n, UnitPrice=@p, UnitsInStock=@s where ProductID=@id

--------------------------------------------------------------------------------------
go
create procedure ListCategories
as
select *from Categories

go
create procedure AddCategory
@n nvarchar(15),
@d ntext
as
insert into Categories(CategoryName,Description) values(@n,@d)

go
create procedure DeleteCategory
@id int
as
delete Categories where CategoryID=@id

go
create procedure UpdateCategory
@n nvarchar(15),
@d ntext,
@id int
as
update Categories set CategoryName=@n where CategoryID=@id
