
using Student.API.Domain.Services;

namespace Student.API.Services
{
    public class StudentService : IStudentService{

        public string hello()
        {
            return "Hello World";
        }
    }
}