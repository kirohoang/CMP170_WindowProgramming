create database BookStore
go
use BookStore
go

create table publishers(
	publisher_id int identity(1, 1) primary key not null,
	publisher_name varchar(50) not null
)
go

create table books(
	book_id int identity(1,1) primary key not null,
	book_name nvarchar(100),
	price decimal,
	quantity_stock int,
	image varchar(100),
	publisher_id int references publishers (publisher_id),
	update_date smalldatetime
)


insert into publishers values ('Publisher 1')
insert into publishers values ('Publisher 2')
insert into publishers values ('Publisher 3')
insert into publishers values ('Publisher 4')
select * from publishers

insert into books values (N'Book Title 1', 4.5, 20, 'images/book1.png', 1, '12/5/2024')
insert into books values (N'Book Title 2', 4.5, 20, 'images/book2.png', 2, '12/5/2024')
insert into books values (N'Book Title 3', 4.5, 20, 'images/book3.png', 3, '12/5/2024')
insert into books values (N'Book Title 4', 4.5, 20, 'images/book4.png', 4, '12/5/2024')
select * from books