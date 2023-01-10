using Fifa22;
using Fifa22.Library;

IDataReader datareader = new ServiceReader();
Console.WriteLine("Press any key to start application");
Console.ReadLine();

List<Group> groups = datareader.GetGroups();
foreach (var group in groups)
{
    Console.WriteLine(group.Name);
    List<Team> teams = datareader.GetTeamByName(group.Name);
    foreach(var team in teams)
    {
        Console.WriteLine(team.Team_name);
        List<Player> players = datareader.GetPlayersFromTeam(team.Team_id);
        foreach (var player in players)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName);
        }
    }
}

List<TeamEx> teamsg = datareader.GetTeamByGoal(5);
foreach(var team in teamsg)
{
    Console.WriteLine(team.Team_name);
}

Console.ReadLine();






