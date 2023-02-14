using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Appliances
{
    internal class Refrigerator:Appliance
    {
        int numberOfDoors;
        double height;
        double width;
        public Refrigerator()
        {

        }
        public Refrigerator(long itemNumber,string brand,int quantity,double wattage,string color,double price,int numberOfDoors, double height, double width)
        :base(itemNumber, brand, quantity,wattage,color,price)
        {
            this.numberOfDoors = numberOfDoors;
            this.height = height;
            this.width = width;
        }

        public int NumberOfDoors { get { return numberOfDoors; } set { numberOfDoors=value; } }

        public double Height { get { return height; } set { height = value; } }

        public double Width { get { return width; } set { width = value; } }

        public override string ToString()
        {
            return
                base.ToString() + " " +
                "\nNumber of doors: " + NumberOfDoors +
                "\nHeight: " + Height + 
                "\nWidth: " + Width ;
        }
    }
}
