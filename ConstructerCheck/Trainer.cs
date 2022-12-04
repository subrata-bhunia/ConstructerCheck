using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructerCheck
{
    class Trainer
    {
       public int empId;
       public string empName;
       public string tech;
        public Trainer()
        {
            empId = 101;
            empName = "Peter";
            tech = "Dotnet";
        }
        public Trainer(int id,string name,string technology)
        {
            empId = id;
            empName = name;
            tech = technology;
        }
        
    }
}
