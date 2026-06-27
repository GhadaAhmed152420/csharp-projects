using System.Reflection.Metadata.Ecma335;

public class StudentService
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    public List<Student> GetAllStudents()
    {
        return students;
    }

    public Student GetStudentById(int id)
    {
        var student = students.Find(s => s.Id == id);
        return student;
    }

    public void DeleteStudent(int id)
    {
        var student = students.Find(s => s.Id == id);
        if (student != null)
        {
            students.Remove(student);
        }
    }

    public void UpdateStudent(int id, string name, int age, string dept)
    {
        var student = students.Find(s => s.Id == id);
        if (student != null)
        {
            student.Name = name;
            student.Age = age;
            student.Department = dept;
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    public List<Student> SearchByName(string name) { 

        var result = students.Where(s => s.Name.Contains(name));
        return result.ToList();

    }
}