

create table Customers(
id int Identity(1,1)  primary key,
customername varchar(200) not null,
createdDate Datetime2 default getdate(),
dob DateTime
)



create table Products(
id int identity(1,1) primary key,
name varchar(200),
created DateTime2 default getdate(),
customerid int foreign key references customers(id),
description varchar(200)
);


insert into customers (customername, dob)
values('prakhar', '2000-05-17'
),
('ram', '2001-07-15'
)
,('shivam', '1999-03-10'
)


insert into products (name, customerid, description)
values('laptop',1, 'dell laptop'),
('mobile', 2, 'oppo mobile')



select * from 

