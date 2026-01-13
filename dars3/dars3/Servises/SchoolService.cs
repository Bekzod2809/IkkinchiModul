using dars3.Models;

namespace dars3.Servises;

internal class SchoolService
{
    List<School> Schools;
    public SchoolService()
    {
        Schools = new List<School>();
    }

    public Guid AddSchool(School school)
    {
        school.SchoolId = Guid.NewGuid();
        Schools.Add(school);
        return school.SchoolId;
    }
    public List<School> GetAllSchools()
    {
        return Schools;
    }
    public bool DeleteSchool(Guid schoolId)
    {
        foreach (var school in Schools)
        {
            if (school.SchoolId == schoolId)
            {
                Schools.Remove(school);
                return true;
            }
        }
        return false;
    }

    public School? GetSchoolById(Guid schoolId)
    {
        foreach (var school in Schools)
        {
            if (school.SchoolId == schoolId)
            {
                return school;
            }
        }
        return null;
    }
    public bool UpdateSchool(Guid schoolId, School NewSchool)
    {
        for (int i = 0; i < Schools.Count; i++)
        {
            if (Schools[i].SchoolId == schoolId)
            {
                Schools[i].StudentNumber = NewSchool.StudentNumber;
                Schools[i].SchoolName = NewSchool.SchoolName;
                Schools[i].StudentNumber = NewSchool.SchoolNumber;
                Schools[i].Capacticy = NewSchool.Capacticy;
                return true;
            }
        }
        return false;
    }
}
