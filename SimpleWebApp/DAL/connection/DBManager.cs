namespace DAL.connection;

using System.Configuration;
using BAL;
using MySql.Data.MySqlClient;

public class BDManager{
    public static string cnString = "server=192.168.10.150;port=3306;user=dac27;password=welcome;database=dac27";
    public static List<Food> GetAllData(){
    List<Food> lst = new List<Food>();
    MySqlConnection con1 = new MySqlConnection();
    con1.ConnectionString = cnString;
    string query = "select * from food"; 
    MySqlCommand cmd = new MySqlCommand(query,con1);
    try{
        // cmd.Connection = con1;
        con1.Open();
        MySqlDataReader reader = cmd.ExecuteReader();
        while(reader.Read())
        {
            int id = int.Parse(reader["item_id"].ToString());
            string  name = reader["item_name"].ToString();
            string unit = reader["item_unit"].ToString();
            int cid = int.Parse(reader["company_id"].ToString());

            // Food f=new Food(id,name,unit,c_id);
            Food f = new Food(id,  name,  unit ,  cid);
            lst.Add(f);

        }reader.Close();
         
    }catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    finally{
        con1.Close();
    }
    return lst;
   
    }
}