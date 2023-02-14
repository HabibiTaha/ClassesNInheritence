using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Linq.Expressions;
using System.Threading;

namespace Modern_Appliances
{
    internal class Program
    {
        public static List<string> lines;

        public static List<Refrigerator> refrigeratorList = new List<Refrigerator>();

        public static List<Vacuum> vacuumList = new List<Vacuum>();

        public static List<Microwave> microwaveList = new List<Microwave>();

        public static List<Dishwasher> dishwasherList = new List<Dishwasher>();
        static void Main(string[] args)
        {
            //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE
            string filepath = "appliances.txt";



            //call the method to read and parse the text file
            ParseFile(filepath);
            //ask user what they want to do
            MainMenu();

        }
        /// <summary>
        /// Asks user what to do
        /// </summary>
        /// 

        public static void MainMenu()
        {
            int loop = 0;
            while (loop <= 1)   //initiates the loop
            {
                Console.WriteLine("Welcome to Modern Appliances!\n");
                Console.WriteLine("How May We Assist You?");
                Console.WriteLine("1 - Checkout appliance " +
                    "\n2 - Find appliances by brand " +
                    "\n3 - Display appliances by type " +
                    "\n4 - Produce random appliance list " +
                    "\n5 - Save & Exit\n");
                Console.Write("Enter option: ");
                string input = Console.ReadLine();

                switch (int.Parse(input))
                {
                    case 1: //Case: Checks out appliance
                        int number = 0;
                        Console.Write("Enter item number of an Appliance: ");
                        string inputAppliance = Console.ReadLine();
                        List<Appliance> applianceList = new List<Appliance>();
                        applianceList = ApplianceList();
                        Appliance appliance = new Appliance();
                        for (int count = 0; count < applianceList.Count; count++)
                        {
                            if ((applianceList[count].ItemNumber.ToString() == inputAppliance) && (applianceList[count].Quantity > 0))
                            {
                                //quantity = applianceList[count].Quantity;
                                //appliance.Checkout(quantity);
                                //counter to meet the condition below for if/else
                                number++;
                            }
                            if ((applianceList[count].ItemNumber.ToString() == inputAppliance) && (applianceList[count].Quantity == 0))
                            {
                                number = -1;
                            }

                        }
                        //itemnumber found so execute this
                        if (number > 0)
                        {
                            Console.WriteLine("Appliance " + inputAppliance + " has been checked out.\n");

                        }
                        if (number < 0)
                        {
                            Console.WriteLine("The appliance is not available to be checked out.\n");
                        }
                        if (number == 0)
                        {
                            Console.WriteLine("No appliances found with that item number.\n");
                        }
                        break;
                    case 2: 
                        bool isThere = false;
                        Console.Write("Enter brand to search for: ");
                        string applianceBrand = Console.ReadLine();
                        applianceList = ApplianceList();
                        for (int count = 0; count < applianceList.Count; count++)
                        {
                            if (applianceList[count].Brand.ToString() == applianceBrand)
                            {
                                //quantity = applianceList[count].Quantity;
                                //appliance.Checkout(quantity);
                                //counter to meet the condition below for if/else
                                isThere = true;
                            }

                        }
                        //itemnumber found so execute this
                        if (isThere == true)
                        {
                            //list of refrigerators from the text file
                            refrigeratorList = RefrigeratorList();
                            foreach (Refrigerator item in refrigeratorList)    //to display the info by brand
                            {
                                if (item.Brand.ToLower() == applianceBrand.ToLower())
                                {
                                    Console.WriteLine(item + "\n");
                                }
                            }
                            vacuumList = VacuumList();
                            foreach (Vacuum item in vacuumList)
                            {
                                if (item.Brand.ToLower() == applianceBrand.ToLower())
                                {
                                    Console.WriteLine(item + "\n");
                                }
                            }
                            microwaveList = MicrowaveList();
                            foreach (Microwave item in microwaveList)
                            {
                                if (item.Brand.ToLower() == applianceBrand.ToLower())
                                {
                                    Console.WriteLine(item + "\n");
                                }
                            }
                            dishwasherList = DishwasherList();
                            foreach (Dishwasher item in dishwasherList)
                            {
                                if (item.Brand.ToLower() == applianceBrand.ToLower())
                                {
                                    Console.WriteLine(item + "\n");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Brand not found.");
                        }
                        break;
                    case 3:
                        bool isHere = false;
                        Console.Write("Appliace Types: \n1 - Refrigerators \n2 - Vacuums \n3 - Microwaves \n4 - Dishwashers \n");
                        Console.WriteLine("Enter type of appliance: ");
                        string applianceType = Console.ReadLine();
                        applianceList = ApplianceList();

                        //itemnumber found so execute this
                        switch (int.Parse(applianceType))
                        {
                            case 1:
                                refrigeratorList = RefrigeratorList();
                                Console.WriteLine("Enter number of doors: 2(double door), 3(three doors), 4(four doors):");
                                string numberofdoors = Console.ReadLine();
                                foreach (Refrigerator item in refrigeratorList)
                                {
                                    if (item.NumberOfDoors.ToString() == numberofdoors)
                                    {
                                        Console.WriteLine("Matching refrigerators:");
                                        Console.WriteLine(item + "\n");
                                    }
                                }
                                break;
                            case 2:
                                vacuumList = VacuumList();
                                Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high)");
                                string batteryVoltage = Console.ReadLine();
                                foreach (Vacuum item in vacuumList)
                                {
                                    if (item.BatteryVoltage.ToString() == batteryVoltage)
                                    {
                                        Console.WriteLine("Matching vacuums:");
                                        Console.WriteLine(item + "\n");
                                    }
                                }
                                break;
                            case 3:
                                microwaveList = MicrowaveList();
                                Console.WriteLine("Room where the microwave will be installed: K (kitchen) or W (work site):");
                                string roomtype = Console.ReadLine();
                                foreach (Microwave item in microwaveList)
                                {
                                    if (item.RoomType.ToString() == roomtype)
                                    {
                                        Console.WriteLine("Matching microwave:");
                                        Console.WriteLine(item + "\n");
                                    }
                                }
                                break;
                            case 4:
                                dishwasherList = DishwasherList();
                                Console.WriteLine("Enter the sound rating of the dishwasher: Qt(Quietest), Qr(Quieter), Qu(Quiet) or M (Moderate):");
                                string soundrating = Console.ReadLine();
                                foreach (Dishwasher item in dishwasherList)
                                {
                                    if (item.SoundRating.ToString() == soundrating)
                                    {
                                        Console.WriteLine("Matching dishwashers:");
                                        Console.WriteLine(item + "\n");
                                    }
                                }
                                break;
                        }
                        break;


                    case 4:

                        applianceList = ApplianceList();
                        Console.WriteLine("Enter number of appliances:");
                        string numberofappliances = Console.ReadLine();
                        Console.WriteLine("Random appliances:");

                        Random random = new Random();
                        for (int i = 0; i < int.Parse(numberofappliances); i++)
                        {

                            int randomNumber = random.Next(applianceList.Count);
                            Console.WriteLine(applianceList[randomNumber]);
                        }


                        break;
                    case 5:
                        Console.WriteLine("Goodbye");
                        loop++; //ends the loop
                        break;
                }
 
            }
            Console.ReadLine();
        }


        /// <summary>
        /// reads each line parse the strings from the text file provided
        /// </summary>
        /// <param name="filepath"></param>
        public static void ParseFile(string filepath)
        {
            lines = new List<string>();

            //read file using streamreader
            StreamReader streamReader = new StreamReader(filepath);
            //loop as long as there is text that can be read
            while (!streamReader.EndOfStream)
            {
                lines.Add(streamReader.ReadLine());
            }

            //always close this 
            streamReader.Close();
        }


        //create list of object based on the item number
        public static List<Appliance> ApplianceList()
        {
           // lines = new List<string>();
            List<Appliance> list = new List<Appliance>();
            foreach (string line in lines)
            {
                string[] strings = line.Split(';');
                list.Add(new Appliance(long.Parse(strings[0]),strings[1], int.Parse(strings[2]), 
                    double.Parse(strings[3]), strings[4], double.Parse(strings[5])));
            }
            return list;
        }
        public static List<Refrigerator> RefrigeratorList()
        {
            List<Refrigerator> list = new List<Refrigerator>();
            foreach (string line in lines)
            {
                if (line.StartsWith("1"))
                {
                    string[] strings = line.Split(';');
                    list.Add(new Refrigerator
                        (long.Parse(strings[0]), strings[1], int.Parse(strings[2]), double.Parse(strings[3]), strings[4],
                        double.Parse(strings[5]), int.Parse(strings[6]), double.Parse(strings[7]), double.Parse(strings[8])));
                }
            }
            return list;
        }
        public static List<Vacuum> VacuumList()
        {
            List<Vacuum> list = new List<Vacuum>();
            foreach (string line in lines)
            {
                if (line.StartsWith("2"))
                {
                    //separate strings with delimiter ;
                    string[] strings = line.Split(';');
                    list.Add(new Vacuum(long.Parse(strings[0]), strings[1], int.Parse(strings[2]), double.Parse(strings[3]), strings[4],
                        double.Parse(strings[5]), strings[6], int.Parse(strings[7])));
                }
            }
            return list;
        }
        public static List<Microwave> MicrowaveList()
        {
            List<Microwave> list = new List<Microwave>();
            foreach (string line in lines)
            {
                if (line.StartsWith("3"))
                {
                    //separate strings with delimiter ;
                    string[] strings = line.Split(';');
                    list.Add(new Microwave(long.Parse(strings[0]), strings[1], int.Parse(strings[2]), double.Parse(strings[3]), strings[4],
                        double.Parse(strings[5]), double.Parse(strings[6]), strings[7]));
                }
            }
            return list;
        }

        public static List<Dishwasher> DishwasherList()
        {
            List<Dishwasher> list = new List<Dishwasher>();
            foreach (string line in lines)
            {
                if (line.StartsWith("4") || line.StartsWith("5"))
                {
                    //separate strings with delimiter ;
                    string[] strings = line.Split(';');
                    list.Add(new Dishwasher(long.Parse(strings[0]), strings[1], int.Parse(strings[2]), double.Parse(strings[3]), strings[4],
                        double.Parse(strings[5]), strings[6], strings[7]));
                }
            }
            return list;
        }
    }
}
