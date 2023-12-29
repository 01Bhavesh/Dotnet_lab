namespace Transflower.Drawing;
public class Point{
    public Point()
    {
        this.X = 0;
        this.Y = 0;
    }
    public Point(int x , int y)
    {
        this.X = x;
        this.Y = y;
    }
    public int X{set;get;}
    public int Y{set;get;}
    public override string ToString(){
        return string.formate{"X = {0}, Y = {1}" , this.X , this.Y}
    }
}