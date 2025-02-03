using System.Runtime.CompilerServices;

namespace Employee1;

public class Employee
{
    private int employeeNumber;
    private string firstName;
    private string lastName;
    private DateTime dateOfHire;
    private string jobDescription;
    private string department;
    private int monthlySalary;
    private bool isEmployed;

    public Employee(string firstName, string lastName, int monthlySalary, bool isEmployed)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.monthlySalary = monthlySalary;
        this.isEmployed = isEmployed;
    }

    public string Name
    {
        get { return firstName; }
        set { Name = firstName; }
    }

    public bool jobHave { get; set; }

    public string Name2
    {
        get { return lastName; }
        set { Name2 = lastName; }
    }

    public int MonthlySalary
    {
        get { return monthlySalary; }
        set { monthlySalary = value; }
    }

    public string EmploymentStatus
    {
        get
        {
            return isEmployed ? "Live anoher month" : "Fired";
        }
    }
}