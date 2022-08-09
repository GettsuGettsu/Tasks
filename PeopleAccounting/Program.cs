using PeopleAccounting.Staff;
using PeopleAccounting.Staff.Post;

namespace PeopleAccounting;

internal class Program
{
    static void Main(string[] args)
    {
        University university1 = new();
        //university.Start();

        university1.AddStudent("Alex", "Morr", "21/07/1999", false, "Math,PE");
        university1.AddStudent("Mira", "Storm", "14/02/1999", false, "Language;;;physics");
        university1.AddStudent("Maxin", "Trooper", "02/04/1998", false, "physics"); // need add sex to human class

        Employee employee1 = new Employee();
        employee1.FillBaseInfo("Aran", "Logan", "30/01/1975");
        employee1.Salary = 850;
        employee1.IsOnVacation = true;

        university1.AddEmployee(employee1);

        Human employee2 = new Human();
        employee2.FillBaseInfo("Serena", "Waltz", "22/11/1985");
        employee2.IsOnVacation = false;

        university1.AddEmployee(employee2, 670, true);
        university1.AddEmployee("Eden", "Jackson", "01/01/1980", 780, false);

        Teacher teacher1 = new Teacher();
        teacher1.FillBaseInfo("Kristoffer", "Garland", "27/10/1981");
        teacher1.IsOnVacation = false;
        teacher1.Salary = 700;
        teacher1.OptionalClasses = EducationalHelper.ClassTypes.Physics;

        university1.AddTeacher(teacher1);

        Human teacher2 = new Human();
        teacher2.FillBaseInfo("Mariana", "Northwind", "15/09/1977");
        
        university1.AddTeacher(teacher2, 810, true, "math,physics");
        university1.AddTeacher("Alex", "Kirinn", "06/06/1976", 815, true, "no");

        var list = university1.GetListOfParticipants(EducationalHelper.ClassTypes.Math | EducationalHelper.ClassTypes.PhysicalEducation);

        foreach (Student human in university1.students)
            UniversityHelper.WriteAllProp(human);

        foreach (Human human in university1.staff)
            UniversityHelper.WriteAllProp(human);

        Console.ReadKey(false); // debugging
    }        
}