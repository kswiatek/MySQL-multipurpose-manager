using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_6_MySQL
{
    public class DatabaseChangedEventArgs : EventArgs
    {
        public string DatabaseName { get; set; }
    }
}
