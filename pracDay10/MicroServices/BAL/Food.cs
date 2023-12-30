namespace BAL;

public class Food{
    public int id{set;get;}
    public string name{get;set;}
    public string unit{get;set;}
    public int cid{get;set;}

    public Food(int id,string name,string unit,int cid)
    {
        this.id=id;
        this.name=name;
        this.unit=unit;
        this.cid=cid;
    }
}