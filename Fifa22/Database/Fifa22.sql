create table Team(
Team_id int identity  PRIMARY KEY,
Team_name varchar(255),
Team_group varchar(255)
);

select * from Team order by Team_group;

insert into Team
values ('Serbia', 'G');
insert into Team
values ('Switzerland', 'G');
insert into Team
values ('Cameroon', 'G');
insert into Team
values ('Brazil', 'G');

insert into Team
values ('Qatar', 'A');
insert into Team
values ('Ecuador', 'A');
insert into Team
values ('Senegal', 'A');
insert into Team
values ('Netherlands', 'A');

insert into Team
values ('England', 'B');
insert into Team
values ('United States', 'B');
insert into Team
values ('Iran', 'B');
insert into Team
values ('Wales', 'B');

insert into Team
values ('Poland', 'C');
insert into Team
values ('Argentina', 'C');
insert into Team
values ('Saudi Arabia', 'C');
insert into Team
values ('Mexico', 'C');

insert into Team
values (' France', 'D');
insert into Team
values ('Australia', 'D');
insert into Team
values ('Denmark', 'D');
insert into Team
values ('Tunisia', 'D');
