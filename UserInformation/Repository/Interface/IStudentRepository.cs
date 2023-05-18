using UserInformation.Models;

namespace UserInformation.Repository.Interface
{

    public interface IStudentRepository
    {
        Student GetById(int id);
        IEnumerable<Student> GetAll();
        Student Add(Student student);
        Student Update(Student studentChanges);
        Student Delete(int id);


    }

}
