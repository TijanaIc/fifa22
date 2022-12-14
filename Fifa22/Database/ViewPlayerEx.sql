USE [Fifa22]
GO

/****** Object:  View [dbo].[PlayerEx]    Script Date: 13.12.2022. 11:25:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[PlayerEx]
as
select Player.*, Team.Team_name, Team.Team_group from Player inner join Team on Player.Teamid = Team.Team_id
GO


