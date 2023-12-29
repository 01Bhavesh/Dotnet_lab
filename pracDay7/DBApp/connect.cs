namespace DBconnect;
using call;
using MySql.Data.MySqlClient;

public  class connect{
 public  void connection()
 {
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString = "server=localhost;port=3306;user=root;password=Bhavesh.20@;database=dotnet";
    // string query = "select * from food";
    string query = "insert into food (item_id,item_name,item_unit,company_id) values(@item_id,@item_name,@item_unit,@company_id)";

    MySqlCommand command = new MySqlCommand(query,con);

    try{
        con.Open();
        // MySqlDataReader reader = command.ExecuteReader(); 
        /* while(reader.Read())
        {
            int id = int.Parse(reader["item_id"].ToString());
            string name = reader["item_name"].ToString();
            string unit = reader["item_unit"].ToString();
            Console.WriteLine(id+" "+name+" "+unit); 
        } */

        
        // food f = new food();
        int item_id = 10;
        string item_name = "ladoo";
        string item_unit = "container";
        int company_id = 50;
        command.Parameters.AddWithValue("@item_id",item_id);
        command.Parameters.AddWithValue("@item_name",item_name);
        command.Parameters.AddWithValue("@item_unit",item_unit);
        command.Parameters.AddWithValue("@company_id",company_id);
        command.ExecuteNonQuery();


    }catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    finally{
        con.Close();
    }
 }
}