namespace BLL;
using BOL;
using DAL.connected;

public class Service{
    public List<Food> GetAllData()
    {
        List<Food> lst = DBManager.GetAllData();
        return lst;

    }
    public void InsertData()
    {
        DBManager.InsertData();
    }
}