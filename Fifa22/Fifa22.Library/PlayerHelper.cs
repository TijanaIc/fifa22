﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifa22.Library
{
    public class PlayerHelper
    {
        public static void InsertPlayers(int n, int teamId)
        {
            for (int i = 0; i < n; i++)
            {
                var player = new Player();
                player.FirstName = "PlayerName" + i;
                player.LastName = "PlayerSurname" + i;
                player.GoalCount = i;
                player.TeamId = teamId;
                HttpClientHelper.PostRequest("http://localhost:55667/player/insert", player);
                Console.WriteLine(player);

            }
        }
        public static void UpdatePlayer(int playerId)
        {
            var player = new Player();
            player.PlayerId = playerId;
            player.FirstName = "test";
            player.LastName = "test";
            player.GoalCount = 5;
            player.TeamId = 3;
            HttpClientHelper.PutRequest("http://localhost:55667/player/update-by-id", player);
            Console.WriteLine(player);
        }


    }
}
