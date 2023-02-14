using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Appliances
{
    internal class Microwave:Appliance
    {
        double capacity;
        string roomType;

        public Microwave()
        {

        }

        public Microwave(long intemNumber, string brand, int quantity, double wattage, string color, double price, double capacity, string roomtype) 
            : base(intemNumber, brand,quantity,wattage,color,price) 
        {
            this.capacity = capacity;
            this.roomType = roomtype;
        }

        public double Capacity { get { return capacity; } set { capacity = value; } }
        public string RoomType { get { return roomType; } set { roomType = value; } }

        public override string ToString()
        {
            return
                base.ToString() + " " +
                "\nCapacity: " + Capacity + " " +
                "\nRoom Type: " + RoomType;
        }
    }
}
