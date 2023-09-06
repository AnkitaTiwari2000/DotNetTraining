using SimpleRepo.Models;

namespace SimpleRepo.Repositry
{
    public class StudentRep : IStudent
    {
        public List<Stud> getAllStudents()
        {
            return DataSource();
        }

        public Stud getStudent(int id)
        {
            return DataSource().Where(x => x.Id ==id).FirstOrDefault();
        }
        private List<Stud> DataSource()
        {
            return new List<Stud>
            {
                new Stud {Id=1,Name="abc",Address="Delhi"},
                new Stud {Id=2,Name="ac",Address="Noida"},
                new Stud {Id=3,Name="ab",Address="Mumbai"},
                new Stud {Id=4,Name="bc",Address="Delhi"}

            };
        }
    }
}
