using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Appliances
{
    public class Appliance
    {
        private long itemnumber;
        private string brand;
        private int quantity;
        private double wattage;
        private string color;
        private double price;

        public Appliance()
        {

        }
        public Appliance(long itemNumber, string brand, int quantity, double wattage, string color, double price)
        {
            this.itemnumber = itemNumber;
            this.brand = brand; 
            this.quantity = quantity;   
            this.wattage = wattage; 
            this.color = color;
            this.price = price;
        }

        public long ItemNumber { get { return itemnumber; } set { this.itemnumber = value; } }
        public string Brand { get { return brand; } set { this.brand = value; } }
        public int Quantity { get { return quantity; } set { this.quantity = value; } }
        public double Wattage { get { return wattage; } set { this.wattage = value; } }
        public string Color { get { return color; } set { this.color = value; } }
        public double Price { get { return price; } set { this.price = value; } }

        //check if item is in stock
        public bool IsAvailable()
        {
            if (Quantity > 0)
            {
                return true;
            }
            else { return false; }
        }

        
        public void Checkout(int checkoutQuantity) 
        {
            Quantity = checkoutQuantity--;
        }

        //public string FormatForFile() { }

        public override string ToString() 
        {
            return
                "Item Number: " + ItemNumber + " " +
                "\nBrand: " + Brand + " " +
                "\nQuantity: " + Quantity + " " +
                "\nWattage: " + Wattage + " " +
                "\nColor: " + Color + " " +
                "\nPrice: " + Price;       
        }

    }
}
