namespace solutions;
using std;

public sealed class Program1{
     public void Calculate(int radius, out float area, out float circumference )
    {
            area = 2*(3.14f)*radius;
            circumference = (3.14f)*radius;
    }

    public void swap(ref int num1, ref int num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }
  
}
