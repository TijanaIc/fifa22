GO
-- EXEC [dbo].[RecreateDatabase]
CREATE OR ALTER PROCEDURE [dbo].[RecreateDatabase]
AS
DROP TABLE IF EXISTS Player;
DROP TABLE IF EXISTS Team;

create table Team(
Team_id int identity  PRIMARY KEY,
Team_name varchar(255),
Team_group varchar(255)
);


select * from Team;

create table Player(
PlayerId int identity primary key,
FirstName varchar(255),
LastName varchar(255),
GoalCount int,
TeamId int FOREIGN KEY REFERENCES Team(Team_id)
);

select * from Player;

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

INSERT into Player  
VALUES ('Kodi', 'Gaklo', 3, 4);
INSERT into Player  
VALUES ('Dejvi', 'Klasen', 1, 4);
INSERT into Player  
VALUES ('Boulaye', 'Dia', 1, 3);
INSERT into Player  
VALUES ('Bamba', 'Djeng', 1, 3);
INSERT into Player  
VALUES ('Mohamed', 'Muntari', 1, 1);
INSERT into Player  
VALUES ('Moizes', 'Kansedo', 1, 2);
INSERT into Player  
VALUES ('Ismala', 'Sar', 1, 3);
INSERT into Player  
VALUES ('Kalidu', 'Kulibali', 1, 3);
INSERT into Player  
VALUES ('Frenki', 'Jong', 1, 4);
INSERT into Player  
VALUES ('Bukajo', 'Saka', 2, 5);
INSERT into Player  
VALUES ('Markus', 'Rasford', 3, 5);
INSERT into Player  
VALUES ('Timoti', 'Vea', 1, 6);
INSERT into Player  
VALUES ('Garet', 'Bejl', 1, 8);
INSERT into Player    
VALUES ('Lionel', 'Mesi', 2, 10);
INSERT into Player    
VALUES ('Salem', 'El', 2, 11);
INSERT into Player    
VALUES ('Salih', 'Alsehiri', 1, 11);
INSERT into Player    
VALUES ('Olivije', 'Zirn', 2, 13);
INSERT into Player    
VALUES ('Adrijen', 'Rabio', 1, 13);
INSERT into Player    
VALUES ('Krejt', 'Gudvin', 1, 14);
INSERT into Player    
VALUES ('Ilkaj', 'Gundogan', 1, 20);
INSERT into Player    
VALUES ('Ricu', 'Doan', 2, 18);
INSERT into Player    
VALUES ('Alvaro', 'Morata', 3, 17);
INSERT into Player    
VALUES ('Misi', 'Bat', 1, 23);
INSERT into Player   
VALUES ('Bril', 'Embolo', 2, 26);
GO