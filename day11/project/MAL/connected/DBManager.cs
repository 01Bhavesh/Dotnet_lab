namespace MAL.connected;
using MySql.Data.MySqlClient;
using BAL;
using Microsoft.AspNetCore.Mvc.ModelBinding;

public class DBManager{
    List<Food> lst = new List<Food>();
     public List<Food> GetAllData(){
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = "server=localhost;port=3306;user=root;password=Bhavesh.20@;database=dotnet";
        string query = "select * from food";
        MySqlCommand cmd = new MySqlCommand(query,con);
        try{
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            // Console.WriteLine(reader.Read());
            while(reader.Read())
            {
                int id = int.Parse(reader["item_id"].ToString());
                string name = reader["item_name"].ToString();
                string unit = reader["item_unit"].ToString();
                int cid = int.Parse(reader["company_Id"].ToString());
                Food f = new Food(id,name,unit,cid);
                lst.Add(f);
            }
        }catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    finally{
        con.Close();
    }
        return lst;
     }
       public void Insert(int id1, string name1,string unit1,int cid1)
    {
        
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = "server=localhost;port=3306;user=root;password=Bhavesh.20@;database=dotnet";
        string query = "insert into food values(@id,@name,@unit,@cid)";
        MySqlCommand cmd = new MySqlCommand(query,con);
        // Console.WriteLine(id1);
        try{
            con.Open();
            cmd.Parameters.AddWithValue("@id",id1);
            cmd.Parameters.AddWithValue("@name",name1);
            cmd.Parameters.AddWithValue("@unit",unit1);
            cmd.Parameters.AddWithValue("@cid",cid1);
            cmd.ExecuteNonQuery();
        }catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    finally{
        con.Close();
    }
     }
     public bool Update(int id1, string name1,string unit1,int cid1)
     {
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = "server=localhost;port=3306;user=root;password=Bhavesh.20@;database=dotnet";
        string query = "update food set item_name=@name,item_unit = @unit where item_id = @id";
        MySqlCommand cmd = new MySqlCommand(query,con);
        Console.WriteLine(name1 +" "+unit1);
        try{
            con.Open();
             cmd.Parameters.AddWithValue("@id",id1);
            cmd.Parameters.AddWithValue("@name",name1);
            cmd.Parameters.AddWithValue("@unit",unit1);
            cmd.Parameters.AddWithValue("@cid",cid1);
            cmd.ExecuteNonQuery();
            return true;
        }catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    finally{
        con.Close();
    }
    return false;
 }
 public bool DeleteById(int id1)
 {
    bool status = false;
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString = "server=localhost;port=3306;user=root;password=Bhavesh.20@;database=dotnet";
    string query = "delete from food where item_id=@id";
    MySqlCommand cmd = new MySqlCommand(query,con);
    try{
        con.Open();
        cmd.Parameters.AddWithValue("@id",id1);
        cmd.ExecuteNonQuery();
        status = true;
    }catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    finally{
        con.Close();
    }
    return false;
}
}
