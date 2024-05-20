using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning1
{
    internal class PersonalRegister
    {
        private string name;
        private double salery;

        public string Name
        { 
            get { return name; } 
            set { name = value; }
        }

        public double Salery
        { 
            get { return salery; } 
            set {  salery = value; } 
        }
    }
}
