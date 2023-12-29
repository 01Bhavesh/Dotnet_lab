namespace call;
using MySql.Data.MySqlClient;

public class food{
    public int item_id{set;get;}
    public string item_name{set;get;}
    public string item_unit{set;get;}
    public int company_id{set;get;}
    public food()
    {
        item_id = 10;
        item_name = "ladoo";
        item_unit = "container";
        company_id = 50;
    }
    public food(int item_id,string item_name,string item_unit,int company_id)
    {
        this.item_id = item_id;
        this.item_name = item_name;
        this.item_unit = item_unit;
        this.company_id = company_id;
    }
}