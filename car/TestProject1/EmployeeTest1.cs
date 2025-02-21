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
            for (int i = 1; i <= 16; i++)
            {
                Console.WriteLine($"Week {i}");
                Console.WriteLine("Announcements: \n \n \n ");
                Console.WriteLine("Report Backs: \n \n \n");
                Console.WriteLine("Discussion Items: \n \n \n");
            }
            // A for loop that I don't exactly understand
        }

        static void Main8(string[] args)
        {
            string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };

            foreach (string task in todo)
            {
                Console.WriteLine($"[] {task}");

                // anotha one
            }

            static void Main9(string[] args)
            {
                string[] websites = { "twitter", "facebook", "gmail" };

                foreach (string website in websites)
                {
                    Console.WriteLine(website);
                }
            }
        }

        static void Main10(string[] args)
        {
            bool buttonClick = false;
            int clockTime = 0;

            do
            {
                Console.WriteLine("Alarm Ringing");
                clockTime++;

                if (clockTime == 3)
                {
                    break;
                }
            } while (!buttonClick);
        }

        static void Main11()
        {
            List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg" };

            citiesList.Add("New York City");

            citiesList.Remove("Delhi");

            citiesList.AddRange(new string[] { "Cairo", "Johannesburg" });

            bool hasNewDelhi = citiesList.Contains("New Delhi");

            foreach (string city in citiesList)
            {
                Console.WriteLine(city);

                // an example of a list
            }
        }

        static void Main12()
        {
            List<double> marathons = new List<double>();
            marathons.Add(144.07);
            marathons.Add(143.12);
            Console.WriteLine(marathons[1]);
        }

        static void Main13()
        {
            List<double> marathons = new List<double> { 144.07, 143.12, 146.73, 146.33 };

            double time = marathons[1];

            Console.WriteLine($"The 2012 marathon was ran in {time} minutes!");

        }

        static void Main14()
        {
            List<double> marathons = new List<double>
            {
                144.07,
                143.12,
                146.73,
                146.33
            };

            marathons.Add(143.23);


            Console.WriteLine(marathons.Count);
            Console.WriteLine(marathons.Contains(143.23));

        }

        static void Main15()
        {
            List<double> marathons = new List<double>
            {
                144.07,
                143.12,
                146.73,
                146.33
            };

            Console.WriteLine(marathons[1]);
            bool removed = marathons.Remove(143.12);
            Console.WriteLine(marathons[1]);
            Console.WriteLine(removed);

        }

        static void Main16()
        {
            List<double> marathons = new List<double>
            {
                148.22,
                156.10,
                153.88,
                155.34,
                160.89
            };

            Console.WriteLine($"Count: {marathons.Count}");
            marathons.Clear();
            Console.WriteLine($"Count: {marathons.Count}");
        }

        static void Main17()
        {
            List<double> marathons = new List<double>
            {
                144.07,
                143.12,
                146.73,
                146.33
            };

            double futureWinner = marathons[2];
            marathons[2] = 143.23;

            Console.WriteLine("If you reached this point, there are no errors!");
        }

        static void Main18()
        {
            List<double> marathons = new List<double>
            {
                144.07,
                143.12,
                146.73,
                146.33
            };

            List<double> topMarathons = marathons.GetRange(0, 3);

            foreach (double d in topMarathons)
            {
                Console.WriteLine(d);
            }

            static void Main19()
            {
                List<bool> boolList = new List<bool>();
                List<Random> randomList = new List<Random>();
                List<IServiceProvider> serviceList = new List<IServiceProvider>();
            }
        }

        static void Main20()
        {
            List<string> citiesList = new List<string> { "Delhi", "Los Angeles", "Saint Petersburg", "Provo" };
            citiesList.Add("Saratoga");

            foreach (string cityName in citiesList)
            {
                Console.WriteLine(cityName);
            }
        }
        
        static void Main21(string[] args)
        {
            string designer = "Anders Hejlsberg";
      
            Console.WriteLine(designer);

            int indexOfSpace = designer.IndexOf(" ");
            int indexOfSecondName = indexOfSpace + 1;

            string secondName = designer.Substring(indexOfSecondName);
            Console.WriteLine(secondName);
            
            // um kind of learning methods. Making a method here to store and call the second name of the string

        }
        static void Main22(string[] args)
        {
            VisitPlanets();
        }
    
        static void VisitPlanets()
        {
            Console.WriteLine("You visited many new planets...");
        }
        
        // uh calling a made method inside the main after making it outside. Probably going to expand stuff
        
        static void Main23(string[] args)
        {
            Console.WriteLine(DecoratePlanet("Jupiter"));    
        }
    
        static string DecoratePlanet(string planet)
        {
            return $"*..*..* Welcome to {planet} *..*..*";
            
            // look at this one some more later on, using a method outside of the string first and then adding it later
        }
        
        static void Main24(string[] args)
        {
            IntroduceFriends("Laika", "Albert");
            IntroduceFriends("Naomi", "Jasmine", "Cyrus");
            IntroduceFriends();
        }
    
        static void IntroduceFriends(string friend1, string friend2)
        {
            Console.WriteLine($"These are my friends, {friend1} and {friend2}!");
        }  
    
        static void IntroduceFriends(string friend1, string friend2, string friend3)
        {
            Console.WriteLine($"These are my friends, {friend1}, {friend2}, and {friend3}!");
        }  
    
        static void IntroduceFriends()
        {
            Console.WriteLine("There is no one who needs to be introduced.");
            
            //overloading methods, need to return to this. 
        }
        
        static void CalculateRectangle(int length, int width, out int area, out int perimeter)
        {
            area = length * width;
            perimeter = 2 * (length + width);
        }

        static void Main25()
        {
            int length = 5;
            int width = 3;
        
            CalculateRectangle(length, width, out int area, out int perimeter);

            Console.WriteLine($"Area: {area}"); // Prints "Area: 15"
            Console.WriteLine($"Perimeter: {perimeter}"); // Prints "Perimeter: 16"
        }
            // out parameters 
            
static void Main26(string[] args)
    {
      string scoreAsString = "85.6";
      string statement = "Hello World";
      
      double scoreAsDouble;
      bool outcome;

      outcome = Double.TryParse(scoreAsString, out scoreAsDouble);

      Console.WriteLine($"{outcome}, {scoreAsDouble}");

      string whispered = Whisper(statement, out bool marker);
      Console.WriteLine(whispered);
    }  

    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
      wasWhisperCalled = true;
      return phrase.ToLower();
    }
    //Out Parameters are a way to intereact and parse things without touching the main code. This is better than just 
    // a console.WriteLine() because you can change the values of data types without interacting with the code
    
    static void Main27(string[] args)
    {
        VisitPlanets(3);
        VisitPlanets(4);
        VisitPlanets(5);
        VisitPlanets();
    }
    
    static void VisitPlanets(int numberOfPlanets = 0)
    {
        Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }
        // We can call VisitPlanets(); with not int input, because the out parameter of "= 0" gives it a defualt value
        //...I think
    }          
}