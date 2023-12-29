using System.Runtime.InteropServices;
using op;
namespace std;

public partial class Student:ICloneable{
    private int size;
    private string[] arr;
    public Student()
    {
        this.size = 2;
        this.arr = new string[size];
        arr[0] = "bhavesh";
        arr[1] = "sakharamtx";
        arr[2] = "gharat";
    }
    public string Email{get;set;}
    public string Phone{get;set;}
    public object Clone()
    {
        Student s = new Student();
        // String[] arr2 = new string[2];
        // arr = (string[])s.arr.Clone();
        this.arr.CopyTo(s.arr,0);
        // arr2[0] = "vishakha";
        return s;
    }

}