using dars3.Models;

namespace dars3.Servises;

public class StudentService
{
    List<Student> Students;
    public StudentService()
    {
        Students = new List<Student>();
    }
    public Guid AddStudent(Student student)
    {
        student.StudentId = Guid.NewGuid();
        Students.Add(student);
        return student.StudentId;
    }
    public Student? GetStudentById(Guid studentId)
    {
        foreach (var student in Students)
        {
            if (student.StudentId == studentId)
            {
                return student;
            }
        }
        return null;
    }
    public bool DeleteStudent(Guid studentId)
    {
        foreach (var student in Students)
        {
            if (student.StudentId == studentId)
            {
                Students.Remove(student);
                return true;
            }
        }
        return false;
    }
    public List<Student> GetAllStudents()
    {
        return Students;
    }
    public bool UpdateStudent(Guid studentId, Student NewStudent)
    {
        for (int i = 0; i < Students.Count; i++)
        {
            if (Students[i].StudentId == studentId)
            {
                Students[i].StudentAge = NewStudent.StudentAge;
                Students[i].StudentEmail = NewStudent.StudentEmail;
                Students[i].StudentLastName = NewStudent.StudentLastName;
                Students[i].StudentFirstName = NewStudent.StudentFirstName;
                return true;
            }
        }
        return false;
    }
}
