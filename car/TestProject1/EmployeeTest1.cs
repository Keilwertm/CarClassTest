using CarBeep;

namespace EmployeeTests

{
    public class EmployeeTestCases

    {
        [Test]
        public void EmployeeConstructor_SetsPropertiesCorrectly()
        {
            Employee newEmployee = new Employee("John", "smith", 210, true);
            string expected = "John Doe";
            string actual = newEmployee.Name;
            Assert.AreEqual(expected, actual);
            // fix the errors with the first and last name not populating correclty. I also did work in CodeAcedemy today.
        }
    }

    //  <--------------------------------- Random Code Academy stuff ------------------------------>

    public class GalacticTravelAgency
    {
        public static void name(string[] args)
        {
            // Your code goes here
            string passengerName = "Zara";
            int passengerAge = 28;
            string ticketType = "First Class";
            string preferredPlanet = "Mars";
            string fullInformation =
                string.Concat(passengerName, " ", passengerAge, " ", ticketType, " ", preferredPlanet);

            Console.WriteLine(fullInformation);

            int correctAge = (passengerAge + 1);

            Console.WriteLine("The correct age is " + correctAge);

            double passengerAgeDouble = (double)passengerAge;

            Console.WriteLine(passengerAgeDouble);

            double implicintAge = passengerAge;

            Console.WriteLine(implicintAge);

            string passengerAgeString = Convert.ToString(passengerAge);

            Console.WriteLine(passengerAgeString);

            // just slapping in my Code Academy code showing string conversions and I can reference it 

        }

        public static void Main2(string[] args)
        {
            {

                {

                    {
                        static void Main3(string[] args)
                        {
                            string[] summerStrut =
                            {
                                "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel",
                                "Rebel Rebel", "Despacito", "Los Angeles"
                            };
                            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

                            Console.WriteLine($"You rated the song, {summerStrut[1]}, {ratings[1]} Stars.");

                            summerStrut[7] = "newSong";
                            ratings[7] = 2;

                            Console.WriteLine($"{summerStrut[7]}");
                        }
                    }
                }
            }
        }

        static void Main4(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[]
            {
                "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito",
                "Los Angeles"
            };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            int firstThree = Array.IndexOf(ratings, 3);
            Console.WriteLine($"Song number {firstThree + 1} is rated three stars");

            Array.Reverse(summerStrut);
            Console.WriteLine($"The new first song is {summerStrut[0]}. The new last song is {summerStrut[7]}.");

            Array.Sort(summerStrut);
            Console.WriteLine(
                $"After sorting the list again, the new first song is {summerStrut[0]} The new last song is {summerStrut[7]}");

            // yep we be flippin it and reversing it - doing stuff with arrays 
        }

        static void Main5(string[] args)
        {
            int emails = 20;
            while (emails > 0)
            {
                emails--;
                Console.WriteLine($"The remaining number of emails: {emails}");
            }

            Console.WriteLine("INBOX ZERO ACHIEVED!");

            // I made a loop yipee 
        }

        static void Main6(string[] args)
        {
            bool buttonClick = true;

            do
            {
                Console.WriteLine("Alarm Ringing");
            } while (!buttonClick);

            Console.WriteLine("Time for a five minute break.");

            // Uh half working loop "do" thing - for loop is next
        }
                
                    static void Main7(string[] args)
                    { 
                        for(int i = 1; i <= 16; i++) {
                            Console.WriteLine($"Week {i}");
                            Console.WriteLine("Announcements: \n \n \n ");
                            Console.WriteLine("Report Backs: \n \n \n");
                            Console.WriteLine("Discussion Items: \n \n \n");
                        }
                                        // A for loop that I don't exactly understand
                    }
                }
            }