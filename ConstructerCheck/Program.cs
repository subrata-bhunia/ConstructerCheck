using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructerCheck
{
    class Program
    {
        static void Main(string[] args)
        {

            Trainer trainer1 = new Trainer();
            Trainer trainer2 = new Trainer(102, "Angie", "Java");
            Console.WriteLine("Obj1 => EmpId {0} EmpName {1} Technology {2}",trainer1.empId,trainer1.empName,trainer1.tech);
            Console.WriteLine("Obj2 => EmpId {0} EmpName {1} Technology {2}", trainer2.empId, trainer2.empName, trainer2.tech);

        }
    }
}
