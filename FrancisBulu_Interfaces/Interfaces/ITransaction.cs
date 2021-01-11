using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrancisBulu_Interfaces.Interfaces
{
    interface ITransaction
    {
        //methodes
        void ShowTransaction();
        double GetAmount();
        string ShowBankName();


    }
}
