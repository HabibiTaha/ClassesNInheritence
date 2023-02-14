using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modern_Appliances
{
    internal class Dishwasher:Appliance
    {
        string featureAndFinish;
        string soundRating;
        public Dishwasher()
        {

        }

        public Dishwasher(long itemNumber, string brand, int quantity, double wattage, string color, double price, string featureandfinish, string soundrating)
            :base(itemNumber,brand,quantity,wattage,color,price)
        {
            this.featureAndFinish = featureandfinish;
            this.soundRating = soundrating;
        }

        public string FeatureAndFinish { get { return featureAndFinish; } set { this.featureAndFinish = value; } }
        public string SoundRating { get { return soundRating; } set { soundRating = value; } }

        public override string ToString()
        {
            return
                base.ToString() + " " +
                "\nFeature and Finish: " + FeatureAndFinish + " " +
                "\nSound Rating: " + SoundRating;
        }
    }
}
