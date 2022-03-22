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
insert into Actor values (1, 'Актер1', 'М', 1971), (2, 'Актер2', 'Ж', 1972),(3, 'Актер3', 'М', 1973)
insert into Movie values (1, 'Фильм1'), (2, 'Фильм2'), (3, 'Фильм3')
insert into Roles values (1, 1, 'Роль11'),(1, 2, 'Роль12'),(1, 3, 'Роль13'),(2, 1, 'Роль21'),(2, 2, 'Роль22'),(3, 1, 'Роль31'),(3, 3, 'Роль33')
select * from Roles
select * from Movie
select * from Actor

select * from Movie where id = 1
select * from Actor where id = 1

select * from roles where id_movie = 1 and id_actor = 1

insert into Actor values (4, 'Актер4', 'М', 1971)

update roles set id_movie = 4, id_actor = 1, name = 'new' where id_movie = 1 and id_actor = 2