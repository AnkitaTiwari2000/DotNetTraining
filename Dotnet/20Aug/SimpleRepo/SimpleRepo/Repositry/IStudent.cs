using SimpleRepo.Models;

namespace SimpleRepo.Repositry
{
    public interface IStudent
    {
        List<Stud> getAllStudents();
        Stud getStudent(int id);

    }
}
