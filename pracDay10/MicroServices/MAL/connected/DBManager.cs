namespace MAL.connected;

using System.Reflection.Metadata;
using BAL;
using MySql.Data.MySqlClient;
public class DBManager{
    public static string cn = @"server=localhost;port=3306;user=root;password=Bhavesh.20@;database=dotnet";
    List<Food> lst = new List<Food>();
    public List<Food> GetAllData(){
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = cn;
        string qurey = "select * from food";
        MySqlCommand cmd = new MySqlCommand(qurey,con);
        try{
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id = int.Parse(reader["item_id"].ToString());
                string name = reader["item_name"].ToString();
                string unit = reader["item_unit"].ToString();
                int cid = int.Parse(reader["company_id"].ToString());
                Food f = new Food(id,name,unit,cid);
                lst.Add(f);
            }
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
        finally{
            con.Close();
        }

        return lst;
    }
    
    }