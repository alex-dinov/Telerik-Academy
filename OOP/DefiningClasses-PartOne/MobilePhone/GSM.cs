using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;

        private List<Call> callHistory = new List<Call>();

        private static Battery iBattery = new Battery(BatteryType.NiMH, 300, 24);
        private static Display iDisplay = new Display(10, 256000);
        private static GSM iPhone4S = new GSM("IPhone4S", "Apple", 500, "Apple", iBattery, iDisplay);

        //Constructors
        public GSM(string model,string manufacturer):this(model,manufacturer,null,null,new Battery(),new Display())
        {
        }

        public GSM(string model, string manufacturer, decimal? price)
            : this(model, manufacturer, price, null,new Battery(),new Display())
        {
        }

        public GSM(string model, string manufacturer, decimal? price, string owner,Battery battery,Display display)
        {
            if (price < 0)
            {
                throw new ArgumentException("Invalid price!Price must be positive number");
            }
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        //Propertys
        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid price!Price must be positive number");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                this.owner = value;
            }
        }
        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        //Methods
        public void AddCall(Call call)
        {   
            this.CallHistory.Add(call);
        }

        public void RemoveCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public void PriceOfCalls(decimal pricePerMinute)
        {
            int? totalTime = 0;
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalTime += this.callHistory[i].Duration;
            }
            Console.WriteLine(pricePerMinute * (totalTime / 60)+"лв",new CultureInfo("BG-bg"));
        }

        //Override
        public override string ToString()
        {
          StringBuilder output = new StringBuilder();
            output.AppendFormat("Model: {0}\n", this.Model ?? "");
            output.AppendFormat("Manufacturer: {0}\n", this.Manufacturer ?? "");
            output.AppendFormat("Price: {0:C}\n", this.Price ?? null);
            output.AppendFormat("Owner: {0}\n", this.Owner ?? "");
            output.AppendFormat("Battery type: {0}\n", this.Battery.Model ?? BatteryType.Default);
            output.AppendFormat("Battery hours idle: {0}\n", this.Battery.HoursIdle ?? null);
            output.AppendFormat("Battery hours talk: {0}\n", this.Battery.HoursTalk ?? null);
            output.AppendFormat("Display size: {0}\n", this.Display.Size ?? null);
            output.AppendFormat("Display number of colors: {0}\n", this.Display.NumOfColors ?? null);

            return output.ToString();
        }
    }
}
