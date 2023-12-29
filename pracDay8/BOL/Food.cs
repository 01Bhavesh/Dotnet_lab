namespace BOL;
public class Food{
    public int id;
    public string name;
    public string unit;
    public int cid;

    public int Id{set;get;}
    public string Name{set;get;}
    public string Unit{set;get;}
    public int Cid{set;get;}
    public Food(int id ,string name, string unit, int cid)
    {
        this.id = id ; 
        this.name = name;
        this.unit = unit;
        this.cid = cid;
    }
}