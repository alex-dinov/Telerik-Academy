using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Attribute
{
    [AttributeUsage(AttributeTargets.Struct | 
        AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum |
        AttributeTargets.Method)]
    public class Version : System.Attribute
    {
        private int minor;
        private int major;

        public int Major 
        {
            get { return this.major; }
            set { this.major = value; }
        }
        public int Minor
        {
            get { return this.minor; }
            set { this.minor = value; }
        }

        public Version(int major,int minor)
        {
            this.major = major;
            this.minor=minor;
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}", Major, Minor);
        }
    }
}
