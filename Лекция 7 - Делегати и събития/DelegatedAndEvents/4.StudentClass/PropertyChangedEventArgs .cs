using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.StudentClass
{
    public class PropertyChangedEventArgs: EventArgs
    {
        public PropertyChangedEventArgs(string propertyChanged, dynamic oldValue, dynamic newValue)
        {
            this.PropertyChanged = propertyChanged;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string PropertyChanged { get; set; }
        public dynamic OldValue { get; set; }
        public dynamic NewValue { get; set; }
    }
}
