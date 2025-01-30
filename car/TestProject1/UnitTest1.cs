using CarBeep;
namespace TestProject1;
public class CarTest
{
    [SetUp]
    public void Setup()
    {
        
    }
    [Test]
    public void Class_Car_Color_Set()
    {
            //arrange act assert
            Car myCar = new Car("Red", 2, true);
            StringAssert.AreEqualIgnoringCase(myCar.Color, "Red");
    }
}