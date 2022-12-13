using Fifa22;
using Fifa22.Library;

Console.WriteLine("Press any key to start application");
Console.ReadLine();
List<Group> groups = HttpClientHelper.ExecuteRequest<List<Group>>("http://localhost:55667/group/list");
foreach (var group in groups)
{
    Console.WriteLine(group.Name);
    List<Team> teams = HttpClientHelper.ExecuteRequest<List<Team>>($"http://localhost:55667/team/search-by-group/{group.Name}");
    foreach (var team in teams)
    {
        Console.WriteLine(team.Team_name);
        List<PlayerEx> players = HttpClientHelper.ExecuteRequest<List<PlayerEx>>($"http://localhost:55667/player/search-by-team/{team.Team_id}");
        foreach (var player in players)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName);
        }
    }
}

//string[] groups = { "A", "B", "C" };
//foreach (string group in groups)
//{
//    Console.WriteLine(group);
//    DataTable table = DatabaseHelper.ExecuteQuery($"select Team_name from Team where Team_group='{group}'");
//    foreach (DataRow row in table.Rows)
//    {
//        //Team t = new Team();
//        //t.Team_id = Convert.ToInt32(row["Team_id"]);
//        //Console.WriteLine(t.Team_id);
//        //t.Team_name = row["Team_name"].ToString();
//        Console.WriteLine(row["Team_name"].ToString());
//        //t.Team_group = row["Team_group"].ToString();
//        //Console.WriteLine(t.Team_group);
//    }
//}


//List<int> list = new List<int>();
//list.Add(1);
//list.Add(2);
//list.Add(3);

//foreach(var item in list)
//{
//    Console.WriteLine(item);
//}
//string[] groups1 = { "A", "B", "C", "Z" };
//string[] groups2 = { "X", "Y", "Z", "A", "B", "K", "A" };
//int[] k = { 1, 2, 3 };
//int[] p = { 3, 4, 5 };
//int br1 = Helper.Presek(groups1, groups2);
//Console.WriteLine(br1);
//br1 = Helper.Presek(groups2, groups1);
//Console.WriteLine(br1);
//br1 = Helper.Presek(k, p);
//Console.WriteLine(br1);

