using FrancisBulu_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrancisBulu_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction trans1 = new Transaction("0001", "01/01/2021", 200);
            trans1.ShowTransaction();
            Console.WriteLine("--------------------------");
            Transaction trans = new Transaction("000", "/01/2021",8);
            trans1.ShowTransaction();
        }
    }
}
