create database gatepass;

create table appUser(
appuser_pk int identity(1,1) primary key,
username varchar(250) not null,
upass varchar(250) not null,
urole varchar(50) not null,
uenabled tinyint default 1 not null
);

select * from appUser;

delete from employee from appUser where appuser_fk=appuser_pk and username ='srv'

insert into appUser(username,upass,urole) values ('admin','pass','ADMIN');
INSERT INTO appUser(username, upass, urole) VALUES 
('admin', 'pass', 'ADMIN'),
('user1', 'pass1', 'USER'),
('user2', 'pass2', 'USER'),
('user3', 'pass3', 'USER'),
('user4', 'pass4', 'USER');

create table employee(
employee_pk int identity(1,1) primary key,
ename varchar(250),
hiredate datetime,
contact bigint,
gender varchar(50),
eaddress varchar(350),
city varchar(50),
estate varchar(50),
appuser_fk int not null,
FOREIGN KEY(appuser_fk) REFERENCES appUser(appuser_pk)
);

create table visitors(
visitors_pk int identity(1,1) primary key,
vname varchar(250),
contact bigint,
gender varchar(50),
vaddress varchar(350),
uniqueId varchar(50),
visitorId varchar(50)
);

create table pass(
pass_pk int identity(1,1) primary key,
passId varchar(50),
validFrom Date,
validTo Date,
visitors_fk int not null,
FOREIGN KEY(visitors_fk) REFERENCES visitors(visitors_pk)
);

select * from visitors;

INSERT INTO employee (ename, hiredate, contact, gender, eaddress, city, estate, appuser_fk)
VALUES 
('Alok', '2023-06-27', 9876543210, 'Male', 'Address 1', 'City 1', 'State 1', 1),
('Amrit', '2023-06-27', 9876543211, 'Male', 'Address 2', 'City 2', 'State 2', 2),
('Rahul', '2023-06-27', 9876543212, 'Male', 'Address 3', 'City 3', 'State 3', 3),
('Saurabh', '2023-06-27', 9876543213, 'Male', 'Address 4', 'City 4', 'State 4', 4),
('Ram', '2023-06-27', 9876543214, 'Male', 'Address 5', 'City 5', 'State 5', 5);


INSERT INTO employee (ename, hiredate, contact, gender, eaddress, city, estate, appuser_fk)
VALUES 
('ALOK RAJ', '2024-01-15', 1234567890, 'Male', 'palm Street', 'Indore', 'MP', 1),
('AMRITA', '2024-02-20', 2345678901, 'Female', 'Oak Avenue', 'Begusarai', 'BR', 2),
('RAHUL', '2024-03-25', 3456789012, 'Male', 'Pine Lane', 'Mandi', 'HP', 3),
('SHYAM', '2024-04-30', 4567890123, 'Male', 'chd', 'Begusarai', 'BR', 4),
('RAM', '2024-05-05', 5678901234, 'Male', 'Planet plaza', 'Begusarai', 'BR', 5);
