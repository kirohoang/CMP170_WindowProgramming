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

create table customers(
	customer_id int identity(1,1) primary key not null,
	customer_name nvarchar(50),
	username varchar(20),
	password varchar(10),
	email varchar(30),
	address nvarchar(100),
	numberphone int,
	dob smalldatetime
)

create table order_details(
	order_id int not null,
	book_id int,
	quantity int,
	price decimal(10,2),

	foreign key (order_id) references orders (order_id)
)

create table orders(
	order_id int identity(1,1) primary key not null,
	ispayment bit,
	isship bit,
	order_date date,
	delivery_date date,
	customer_id int,

	foreign key (customer_id) references customers(customer_id)
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

delete from books where book_id = 10