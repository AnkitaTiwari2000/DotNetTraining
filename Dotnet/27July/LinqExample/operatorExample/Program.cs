namespace operatorExample
{
    public  class Program
    {
       public  static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
    new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
};
            var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

            var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);
            Console.WriteLine("ThenBy:");

            foreach (var std in thenByResult)
                Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);

            Console.WriteLine("ThenByDescending:");

            foreach (var std in thenByDescResult)
                Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}