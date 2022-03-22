use crud;
create table Actor(
id int primary key,
name varchar(20),
sex varchar(1),
birthdate int)

create table Movie(
id int primary key,
name varchar(20))

create table Roles(
id_actor int foreign key references Actor(id),
id_movie int foreign key references Movie(id),
name varchar(20)
)
drop table Actor
drop table Roles
insert into Actor values (1, '�����1', '�', 1971), (2, '�����2', '�', 1972),(3, '�����3', '�', 1973)
insert into Movie values (1, '�����1'), (2, '�����2'), (3, '�����3')
insert into Roles values (1, 1, '����11'),(1, 2, '����12'),(1, 3, '����13'),(2, 1, '����21'),(2, 2, '����22'),(3, 1, '����31'),(3, 3, '����33')
select * from Roles
select * from Movie
select * from Actor

select * from Movie where id = 1
select * from Actor where id = 1

select * from roles where id_movie = 1 and id_actor = 1

insert into Actor values (4, '�����4', '�', 1971)

update roles set id_movie = 4, id_actor = 1, name = 'new' where id_movie = 1 and id_actor = 2