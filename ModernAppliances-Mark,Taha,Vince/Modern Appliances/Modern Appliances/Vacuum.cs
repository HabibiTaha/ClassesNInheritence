using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Appliances
{
    internal class Vacuum:Appliance
    {
        string grade;
        int batteryVoltage;
        public Vacuum() { }
        public Vacuum(long itemNumber, string brand, int quantity, double wattage, string color, double price, string grade,int batteryvoltage):base(itemNumber,brand,quantity,wattage,color,price)
        { 
            this.grade = grade;
            this.batteryVoltage = batteryvoltage;
        }

        public string Grade { get { return grade; } set { this.grade = value; } }
        public int BatteryVoltage { get { return batteryVoltage; } set { this.batteryVoltage = value; } }
        public override string ToString() 
        {
            return
                base.ToString() + " " +
                "\nGrade: " + Grade + " " +
                "\nBattery Voltage: " + BatteryVoltage + "V";
        }
    }
}
