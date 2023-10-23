using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        var person = new Person("id1", "Person1");
        var student = new Student("id2", "Student2", "Software Engineering");
        var employee = new Employee("id3", "Employee3", "CSEE");

        // The designation of a list
        List<Person> people = new List<Person>();

        people.Add(person);
        people.Add(student);
        people.Add(employee);
    }
}
// Parent class using variables and functions inherited classes would use in
// Pseudocode
public class Person {

    // The variables used
    private string _id;

    // Like private, but subclasses of the inheritor class can use protected
    // variables
    protected string _name;

    // A constructor
    public Person(string id, string name) {
        _id = id;
        _name = name;
    }

    // One of the functions used
    public void Display() {
        Console.WriteLine($"Name = {_name}");
    }
}

// An inherited class to Person
public class Student: Person {

    // A different variable
    private string _major;

    // " : base" will take the base constructor's variables
    public Student(string studentid, string studentname, string major) : base(studentid, studentname) {
        _major = major;
    }
    
    // The variable "_name" won't work here unless the variable where it is
    // designated isn't private
    public void DisplayStudentSummary() {
        Console.WriteLine($"{_name}: {_major}");
    }

}

public class Employee: Person {
    private string _department;

    public Employee(string id, string name, string department) : base(id, name) {
        _department = department;
    }

}