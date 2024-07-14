create schema hub

create table hub.duplicate
(
user_id int identity(101,1) primary key,
Name varchar(50) not null,
age int not null,
)

select * from hub.duplicate

insert into hub.duplicate
(Name,age)
values
('Uday', 20 ),
('shreya', 18),
('Ram', 24 ),
('Ajay', 30 ),
('Uday', 20 )

select Name,age,
count(*) from hub.duplicate
group by Name,age

delete from hub.duplicate
where user_id not in 
(
select min(user_id)
from hub.duplicate
group by Name,age
);

select * from hub.duplicate
