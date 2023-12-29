namespace Transflower.Drawing;
public abstract class Shapes{
    public Shapes()
    {
        this.Color = "yellow";
        this.Width = 2;
    }
    public Shapes(string c , int w)
    {
        this.Color = c;
        this.Width = w;
    }
    public string Color{set;get;}
    public int Width{set;get;}
    public abstract void Draw();
    public override string ToString()
    {
        return this.Color+" "+this.Width;
    }

}