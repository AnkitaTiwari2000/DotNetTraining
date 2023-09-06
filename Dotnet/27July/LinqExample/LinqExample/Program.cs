using System;
public class Student
{
    public int Sid { get; set; }
   public  string Sname { get; set; }
   public   int Sage { get; set; }
}


class Program
{
    public static void Main()
    {
        Student[] studentDetails = {
            new Student(){Sid=1,Sname="anu",Sage=12},
             new Student() { Sid = 2, Sname = "john", Sage = 18 },
               new Student(){Sid=3,Sname="niya",Sage=22},
             new Student() { Sid = 5, Sname = "ram", Sage = 28 },
        }; 
        Student[] students=new Student[10];
        int i = 0;
        foreach (Student std in studentDetails)
        {
            if(std.Sage>13 && std.Sage < 25)
            {
                students[i] = std;
                Console.WriteLine(std.Sname+" "+std.Sid+" "+std.Sage);
                i++;
            }
            
        }
    }
}
