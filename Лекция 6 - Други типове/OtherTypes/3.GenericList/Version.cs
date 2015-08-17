using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GenericList
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | 
        AttributeTargets.Method, AllowMultiple = true)]
    class Version : System.Attribute
    {
        private int major;
        private int minor;

        public Version(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major
        {
            get { return this.major; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("value", "Value must be e positive integer or zero");
                }
                this.major = value;
            }
        }

        public int Minor
        {
            get { return this.minor; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("value", "Value must be a positive integer or zero.");
                }
                this.minor = value;
            }
        }
    }
}
