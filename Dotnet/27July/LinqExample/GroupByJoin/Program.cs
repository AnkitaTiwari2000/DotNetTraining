using System;
class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public int EmpDeptNo { get; set; }

}
class Department
{
    public int EmpDeptNo { get; set; }
    public string DeptName { get; set; }

}


    internal class Program
    {
        static void Main(string[] args)
        {
        IList<Employee> EmpList = new List<Employee>() {
    new Employee() { EmpId = 1, EmpName = "Ron",EmpDeptNo=101 },
     new Employee() { EmpId = 2, EmpName = "Roon",EmpDeptNo=102 },
      new Employee() { EmpId = 3, EmpName = "Rony",EmpDeptNo=103 },
       new Employee() { EmpId = 4, EmpName = "pRon",EmpDeptNo=104 }
};
        List<Department> deptlist = new List<Department>()
        {
         new Department(){EmpDeptNo=101 ,DeptName="cs"},
         new Department(){EmpDeptNo=101 ,DeptName="cs"},
         new Department(){EmpDeptNo=102 ,DeptName="Ms"},
        };
        var result = deptlist.GroupJoin(EmpList,

            emp => emp.EmpDeptNo,
            e => e.EmpDeptNo,
            (emp, empGroup) => new
            {
                Employee = empGroup,
                Department=emp.DeptName
                

            }

            ) ;
        foreach (var item in result)
        {
            Console.WriteLine(item.Department);

            foreach (var stud in item.Employee)
                Console.WriteLine(stud.EmpName);
        }


    }
    }
