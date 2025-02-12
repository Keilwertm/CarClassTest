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
    }
}