namespace CarBeep;

public class Employee
{
    private int employeeNumber;
    private  readonly string _firstName;
    private readonly string _lastName;
    private DateTime dateOfHire;
    private string jobDescription;
    private string department;
    private int _monthlySalary;
    private readonly bool _isEmployed;

    public Employee(string firstName, string lastName, int monthlySalary, bool isEmployed)
    {
        this._firstName = firstName;
        this._lastName = lastName;
        this._monthlySalary = monthlySalary;
        this._isEmployed = isEmployed;
    }

    public string Name
    {
        get { return _firstName; }
        set { Name = _firstName; }
    }

    public bool JobHave { get; set; }

    public string Name2
    {
        get { return _lastName; }
        set { Name2 = _lastName; }
    }

    public int MonthlySalary
    {
        get { return _monthlySalary; }
        set { _monthlySalary = value; }
    }

    public string EmploymentStatus
    {
        get
        {
            return _isEmployed ? "Live anoher month" : "Fired";
        }
    }
}