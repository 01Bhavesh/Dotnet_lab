using HR;
namespace Transflower.Drawing;


public class Line:Shapes,printer
{
    public Point StartPoint{set;get;}
    public Point EndPoint{set;get;}
    public Line():base()
    {
        this.StartPoint = new Point(0,0);
        this.EndPoint = new Point(0,0);
    }
    public Line(Point p1,Point p2,string s , int w):base(s,w)
    {
        this.StartPoint = p1;
        this.EndPoint = p2;
    }
    public override void Draw()
    {
        Console.WriteLine("drawing line");
        Console.WriteLine(this);
    }
    publis override string ToString()
    {
        return this.base + " "+ this.StartPoint+"  "+this.EndPoint;
    }
}