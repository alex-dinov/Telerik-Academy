using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public enum BatteryType
    {
        Lilon, NiMH, NiCd,Default
    }

    class Battery
    {
        private BatteryType? model;
        private int? hoursIdle;
        private int? hoursTalk;

        public Battery() : this(null,null,null)
        {
        }

        public Battery(BatteryType? model): this(model,null,null)
        {
        }

        public Battery(BatteryType? model, int? hoursIdle, int? hoursTalk)
        {
            if (hoursIdle < 0 || hoursTalk < 0)
            {
                throw new ArgumentException("Battery hours idle or hours talk cannot be negative");
            }
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
        }

        public BatteryType? Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int? HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid HoursIdle!HoursIdle must be positive number");
                }
                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid HoursTalk!HoursTalk must be positive number");
                }
                this.hoursTalk = value;
            }
        }
    }
}
