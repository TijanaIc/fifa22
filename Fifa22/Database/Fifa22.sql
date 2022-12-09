create table Team(
Team_id int identity  PRIMARY KEY,
Team_name varchar(255),
Team_group varchar(255)
);

create table Player(
PlayerId int identity primary key,
FirstName varchar(255),
LastName varchar(255),
TeamId int FOREIGN KEY REFERENCES Team(Team_id)
);

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
values ('France', 'D');
insert into Team
values ('Australia', 'D');
insert into Team
values ('Denmark', 'D');
insert into Team
values ('Tunisia', 'D');

insert into Team
values ('Spain', 'E');
insert into Team
values ('Japan', 'E');
insert into Team
values ('Costa Rica', 'E');
insert into Team
values ('Germany', 'E');

insert into Team
values ('Croatia', 'F');
insert into Team
values ('Morocco', 'F');
insert into Team
values ('Belgium', 'F');
insert into Team
values ('Canada', 'F');

insert into Team
values ('Serbia', 'G');
insert into Team
values ('Switzerland', 'G');
insert into Team
values ('Cameroon', 'G');
insert into Team
values ('Brazil', 'G');

insert into Team
values ('Portugal', 'H');
insert into Team
values ('Ghana', 'H');
insert into Team
values ('South Korea', 'H');
insert into Team
values ('Uruguay', 'H');


INSERT [dbo].[Player]  VALUES (N'Kodi', N'Gaklo', 3, 4);
INSERT [dbo].[Player]  VALUES ( N'Dejvi', N'Klasen', 1, 4)
INSERT [dbo].[Player]  VALUES (N'Boulaye', N'Dia', 1, 3)
INSERT [dbo].[Player]  VALUES (N'Bamba', N'Djeng', 1, 3)
INSERT [dbo].[Player]  VALUES (N'Mohamed', N'Muntari', 1, 1)
INSERT [dbo].[Player]  VALUES (N'Moizes', N'Kansedo', 1, 2)
INSERT [dbo].[Player]  VALUES (N'Ismala', N'Sar', 1, 3)
INSERT [dbo].[Player]  VALUES (N'Kalidu', N'Kulibali', 1, 3)
INSERT [dbo].[Player]  VALUES (N'Frenki', N'Jong', 1, 4)
INSERT [dbo].[Player]  VALUES (N'Bukajo', N'Saka', 2, 5)
INSERT [dbo].[Player]  VALUES (N'Markus', N'Rasford', 3, 5)
INSERT [dbo].[Player]  VALUES (N'Timoti', N'Vea', 1, 6)
INSERT [dbo].[Player]  VALUES (N'Garet', N'Bejl', 1, 8)
INSERT [dbo].[Player]  VALUES (N'Lionel', N'Mesi', 2, 10)
INSERT [dbo].[Player]  VALUES (N'Salem', N'El', 2, 11)
INSERT [dbo].[Player]  VALUES (N'Salih', N'Alsehiri', 1, 11)
INSERT [dbo].[Player]  VALUES (N'Olivije', N'Zirn', 2, 13)
INSERT [dbo].[Player]  VALUES (N'Adrijen', N'Rabio', 1, 13)
INSERT [dbo].[Player]  VALUES (N'Krejt', N'Gudvin', 1, 14)
INSERT [dbo].[Player]  VALUES (N'Ilkaj', N'Gundogan', 1, 20)
INSERT [dbo].[Player]  VALUES (N'Ricu', N'Doan', 2, 18)
INSERT [dbo].[Player]  VALUES (N'Alvaro', N'Morata', 3, 17)
INSERT [dbo].[Player]  VALUES (N'Misi', N'Bat', 1, 23)
INSERT [dbo].[Player]  VALUES (N'Bril', N'Embolo', 2, 26)

select * from Team;