using StudentManagementSystem.UI;

class Program
{
    public static void Main(string[] args)
    {
        StudentService service = new StudentService();

        while (true)
        {
            Menu.Show();
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    // Code to add student

                    Student s = new Student();

                    Console.Write("Id: ");
                    s.Id = int.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    s.Name = Console.ReadLine();

                    Console.Write("Age: ");
                    s.Age = int.Parse(Console.ReadLine());

                    Console.Write("Department: ");
                    s.Department = Console.ReadLine();

                    service.AddStudent(s);

                    Console.WriteLine("Student added successfully.");

                    break;



                case "2":
                    // Code to view all students

                    var list = service.GetAllStudents();

                    foreach (var student in list)
                    {
                        Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Department: {student.Department}");
                    }
                    break;



                case "3":
                    // Code to view student by ID

                    Console.Write("Enter student ID: ");
                    var id = int.Parse(Console.ReadLine());

                    var studentById = service.GetStudentById(id);

                    if (studentById != null)
                    {
                        Console.WriteLine($"Id: {studentById.Id}, Name: {studentById.Name}, Age: {studentById.Age}, Department: {studentById.Department}");
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                    }
                    break;



                case "4":
                    // Code to update student

                    Console.Write("Enter student ID to update: ");
                    int Id = int.Parse(Console.ReadLine());

                    Console.Write("Enter new name: ");
                    string newName = Console.ReadLine();

                    Console.Write("Enter new age: ");
                    int newAge = int.Parse(Console.ReadLine());

                    Console.Write("Enter new department: ");
                    string newDepartment = Console.ReadLine();


                    service.UpdateStudent(Id, newName, newAge, newDepartment);

                    Console.WriteLine("Student updated successfully.");
                    break;



                case "5":
                    // Code to delete student

                    Console.Write("Enter student ID to delete: ");
                    int idToDelete = int.Parse(Console.ReadLine());

                    service.DeleteStudent(idToDelete);

                    Console.WriteLine("Student deleted successfully.");
                    break;



                case "6":
                    // Code to search student by name
                    Console.Write("Enter name to search: ");
                    string nameToSearch = Console.ReadLine();
                    var searchResults = service.SearchByName(nameToSearch);
                    if (searchResults.Count > 0)
                    {
                        foreach (var student in searchResults)
                        {
                            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}, Department: {student.Department}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No students found with that name.");
                    }
                    break;



                case "7":
                    // Exit the program
                    Console.WriteLine("Exiting program...");
                    Environment.Exit(0);
                    break;



                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

    }
}