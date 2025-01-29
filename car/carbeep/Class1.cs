namespace carbeep;

class car
{
    // private variables help us define properties 
    private string color;
    private int numberOfDoors;
    private bool isConvertable;

    // Constructor - Factory for creating objects of the class
    
    // get and set define attributes noun-like 
    
    public string Color
    {
        get
        { return color;}
        set
        {color = value;}
    }

    public bool IsConvertable
    {
        get; set;
    }

    public int NumberOfDoors
    {
        get {return numberOfDoors;}
        set
        {
            if (value <= 4)
            {
                numberOfDoors = value;
            }
            else
            {
                Console.WriteLine("Car cannot be more than 4 doors.");
            }
        }
    }
    
    // methods tell the class what to do 
}