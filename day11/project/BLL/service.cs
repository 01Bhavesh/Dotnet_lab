namespace BLL;
using BAL;
using MAL.connected;

public class service{
    List<Food> lst = new List<Food>();
    DBManager db = new DBManager();
    public List<Food> ShowData(){
        lst = db.GetAllData();
        return lst;
    }
    public void Insert(int id, string name,string unit,int cid)
    {
        DBManager bd = new DBManager();
        bd.Insert(id,name,unit,cid);
    }
}
