using Fifa22;
using System.Data;

DataTable table = DatabaseHelper.ExecuteQuery("Server=localhost;Database=Fifa22;Trusted_Connection=True;", "select * from Team");

foreach (DataRow row in table.Rows)
{
    Team t = new Team();
    t.Team_id = Convert.ToInt32(row["Team_id"]);
    Console.WriteLine(t.Team_id);
    t.Team_name = row["Team_name"].ToString();
    Console.WriteLine(t.Team_name);
    t.Team_group = row["Team_group"].ToString();
    Console.WriteLine(t.Team_group); 
}
