namespace DAL.connected;
using MySql.Data.MySqlClient;
using BOL;

public class DBManager
{
    public static string con1 = @"server=localhost;port=3306;user=root;password=Bhavesh.20@;database=dotnet";
    public static List<Food> GetAllData()
    {
        List<Food> lst = new List<Food>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = con1;
        string query = "select * from food";
        MySqlCommand cmd = new MySqlCommand(query,con);
        
        try{
            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id = int.Parse(reader["item_id"].ToString());       //select * from table
                string name = reader["item_name"].ToString();
                string unit = reader["item_unit"].ToString();
                int cid = int.Parse(reader["company_id"].ToString());
                Food f = new Food(id,name,unit,cid);
                lst.Add(f);
            }reader.Close(); 

        }catch(Exception e){Console.WriteLine(e.Message);}
        finally
        {
            con.Close();
        }
        return lst;
    }
    public static void InsertData()
    {
        List<Food> lst = new List<Food>();
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = con1;
        Rocky r = new Rocky();
        List<Food> lst1 = r.rockybhai();
        try{
            con.Open();
        foreach(Food f in lst1)
            {
                string query = "insert into food values(@id,@name,@unit,@cid)";
                 MySqlCommand cmd = new MySqlCommand(query,con);
                int id = f.id;
                string name = f.name;
                string unit = f.unit;
                int cid = f.cid;
                cmd.ExecuteNonQuery();
            }
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }finally{
            con.Close();
        }
        // (item_id,item_name,item_unit,company_id)
    }
}