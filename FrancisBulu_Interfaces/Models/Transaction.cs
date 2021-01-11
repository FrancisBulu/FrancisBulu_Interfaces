using FrancisBulu_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrancisBulu_Interfaces.Models
{
    public class Transaction : Bank, ITransaction
    {
        //properties
        private readonly string _code;
        private readonly string _date;
        private readonly double _amount;
        private readonly double _commission;
        private readonly object accountCharged;

        //constructor
        public Transaction(string code, string date, double amount)
        {
            this._code = code;
            this._date = date;
            this._amount = amount;
        }
        //methodes
        public double GetAmount()
        {
            double charge = 0;
            string accountCharged = "";
            if (this._amount>100)
            {
                charge = _commission + _commission*0.05;
                accountCharged = "You will BE charged with extra comission" + charge;
            }
            else if (this._amount<100)
            {
                charge = _commission;
                Console.WriteLine($"Your account will NOT Be charged {charge}");
            }
            return _amount;
        }

        public string ShowBankName()
        {
            return BankName;
        }

        public void ShowTransaction()
        {
            Console.WriteLine($"{BankName} \n{Address} \nTransaction: {_code} \nDate: {_date} \nAmount: {_amount} \n{accountCharged}");
        }
    }
}
