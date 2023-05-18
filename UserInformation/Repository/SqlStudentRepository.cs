using Microsoft.EntityFrameworkCore;
using UserInformation.Models;
using UserInformation.Repository.Interface;

namespace UserInformation.Repository
{
    public class SqlStudentRepository:IStudentRepository
    {
        private readonly AppDbContext dBContext;

        public SqlStudentRepository(AppDbContext dBContext) {
            this.dBContext = dBContext;
        }

        public Student Add(Student student)
        {
            dBContext.Students.Add(student);
            return student;
        }

      

        public Student Delete(int id)
        {
            Student std = dBContext.Students.Find(id);
            dBContext.Students.Remove(std);
            return std;
        }

        public IEnumerable<Student> GetAll()
        {
            //throw new NotImplementedException();
            return dBContext.Students;
        }


        public Student GetById(int id)
        {
            return dBContext.Students.Find(id);
        }

        public Student Update(Student studentChanges)
        {
            var student=dBContext.Students.Attach(studentChanges);
            student.State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            return studentChanges;
            

            
        }
    }
}
