using UserInformation.Models;
using UserInformation.Repository;
using UserInformation.Repository.Interface;

namespace UserInformation.Services
{
    public class StudentServices:IStudentServices
    {
        private readonly IStudentRepository _sqlStudentRepository;
        private readonly ISave _save1;
        public StudentServices(IStudentRepository sqlStudentRepository,ISave save1)
        {
            _sqlStudentRepository = sqlStudentRepository;
            _save1=save1;
        }

        public IEnumerable<Student> GetAll()
        {
            return _sqlStudentRepository.GetAll();
        }

        public Student GetById(int id) { 
            return _sqlStudentRepository.GetById(id);
        }
        
        public Student Add(Student student)
        {

            Student student1 = _sqlStudentRepository.Add(student);
            _save1.Save();
            return student1;
            
        }
        public Student Update(Student student)
        {
            Student student1=_sqlStudentRepository.Update(student);
            _save1.Save();
            return student1;
        }

        public Student Delete(int id) { 
           Student std1= _sqlStudentRepository.Delete(id);
           _save1.Save();
           return std1;
            
        }

        


    }
}
