using Fifa22;
using Fifa22.Library;
using System.Data;


DataTable tableGroups = DatabaseHelper.ExecuteQuery("select distinct Team_group from Team");
foreach (DataRow row in tableGroups.Rows)
{
    string group = row["Team_group"].ToString();
    Console.WriteLine(group);
    DataTable teams = DatabaseHelper.ExecuteQuery($"select Team_name from Team where Team_group='{group}'");
    foreach (DataRow teamRow in teams.Rows)
    {
        Console.WriteLine(teamRow["Team_name"].ToString());
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

