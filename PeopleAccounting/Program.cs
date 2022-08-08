using PeopleAccounting.Staff;
using PeopleAccounting.Staff.Post;

namespace PeopleAccounting;

internal class Program
{
    static void Main(string[] args)
    {
        University university1 = new();
        //university.Start();

        university1.AddStudent("Alex", "Morr", "21/07/1999", "Math,PE", false);
        university1.AddStudent("Mira", "Storm", "14/02/1999", "Language;;;physics", false);
        university1.AddStudent("Maxin", "Trooper", "02/04/1998", "physics", false); // need add sex to human class

        Employee employee1 = new Employee();
        employee1.FillBaseInfo("Aran", "Logan", "30/01/1975");
        employee1.Salary = 850;
        employee1.IsOnVacation = true;

        university1.AddEmployee(employee1);

        Human employee2 = new Human();
        employee2.FillBaseInfo("Serena", "Waltz", "22/11/1985");
        employee2.IsOnVacation = false;

        var a1 = new Human();
        a1.FillBaseInfo("a", "b", "c");
        var a2 = new Employee();


        university1.AddEmployee(employee2, 670, true);
        university1.AddEmployee("Eden", "Jackson", "01/01/1980", 780, false);

        university1.AddingEducationalHuman(true);

        Human teacher1 = new Human();
        teacher1.FillBaseInfo("Mariana", "Northwind", "15/09/1977");
        
        university1.AddEmployee(teacher1, 810, true, "math,physics");
        university1.AddEmployee("Alex", "Kirinn", "06/06/1976", 815, true, false, "no");

        Console.ReadKey(false); // debugging
    }        
}