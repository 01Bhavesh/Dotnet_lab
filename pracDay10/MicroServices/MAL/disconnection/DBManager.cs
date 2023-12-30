namespace MAL.disconnected;

using System.Data;
using System.Reflection.Metadata;
using BAL;
using MySql.Data.MySqlClient;

public class DBManager{
    public static string cn = @"server=localhost;port=3306;user=root;password=Bhavesh20@;database=dotnet";
    List<Food> lst = new List<Food>();
    public List<Food> GetAllData()
    {
        
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = cn;
        try{
                DataSet d = new DataSet();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                string query = "select * from food";
                cmd.CommandText = query;
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(d);
                DataTable dt=d.Tables[0];
            DataRowCollection rows=dt.Rows;
            foreach( DataRow row in rows)
            {
                 int id = int.Parse(row["item_id"].ToString());
                string name = row["item_name"].ToString();
                string unit = row["item_unit"].ToString();
                int cid = int.Parse(row["company_id"].ToString());
                Food f = new Food(id,name,unit,cid);
                lst.Add(f);
            }
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return lst;
    }
}