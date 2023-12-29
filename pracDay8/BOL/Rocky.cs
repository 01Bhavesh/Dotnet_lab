namespace BOL;

public class Rocky
{
    public List<Food> rockybhai(){
    List<Food> lst = new List<Food>();

    Food f1 = new Food(10,  "rasgulla", "packet" ,50);
    Food f2 = new Food(20,  "gullabjamun", "packet" ,100);
    Food f3= new Food(30,  "lassi", "jar" ,20);
     lst.Add(f1);
     lst.Add(f2);
     lst.Add(f3);
     return lst;
    }
}