using solutions;
using std;
using op;



//caller & callee
//
// float area = 0;
// float circumference = 0;
// Program1 p = new Program1();
// p.Calculate(3,out area, out circumference);
// Console.WriteLine("area "+area+" circumference "+circumference);

// int num1 = 10;
// int num2 = 20;
// p.swap(ref num1,ref num2);
// Console.WriteLine("num1:-"+num1+" num2:-"+num2);



// partial

Student s = new Student();
s.Id = 20;
s.Name = "bhavesh";
s.Email = "bhavesh@20";
s.Phone = "151511";
int x = s.Division(100,2);
Console.WriteLine(x);
int y = s.Multiplication(30,5);
Console.WriteLine(y);
Console.WriteLine(s.Id);
Console.WriteLine(s.Name);
Console.WriteLine(s.Email);
Console.WriteLine(s.Phone);
