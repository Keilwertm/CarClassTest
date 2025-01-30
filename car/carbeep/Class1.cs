namespace CarBeep;

public class Car
{
    private string color;
    private int numberOfDoors;
    private bool isConvertible;

    public Car(string carColor, int doors, bool convertible)
    {
        color = carColor;
        NumberOfDoors = doors;  // Uses property to enforce validation
        IsConvertible = convertible;
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public bool IsConvertible
    {
        get { return isConvertible; }
        set { isConvertible = value; }
    }

    public int NumberOfDoors
    {
        get { return numberOfDoors; }
        set
        {
            if (value <= 4)
            {
                numberOfDoors = value;
            }
            else
            {
                throw new ArgumentException("A car cannot have more than 4 doors.");
            }
        }
    }

    public void Accelerate()
    {
        Console.WriteLine("I am accelerating.");
    }

    public bool IsFamilyCar()
    {
        return numberOfDoors >= 4;
    }
}