namespace BAL;
public class Food{
//    public int id;
//     public string name;
//     public string unit;
//     public int cid;
     public int id{set;get;}
    public string name{set;get;}
    public string unit{set;get;}
    public int cid{set;get;}

    public Food(int id,string name,string unit,int cid)
    {
        this.id = id;
        this.name = name;
        this.unit = unit;
        this.id = cid;
    }

}