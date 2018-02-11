using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class CreditAccount : Account
    {
        double creditLine;
        public CreditAccount(string id, string pwd, double money, double creditLine) : base(id, pwd, money)
        {
            this.creditLine = creditLine;
        }
        public double GetCreditLine()
        {
            return creditLine;
        }

        public void SetCreditLine(double val)
        {
            this.creditLine = val;
        }
        public bool AddCreditLine(double creditLine)
        {
            if (creditLine < 0) return false;  //卫语句

            this.creditLine += creditLine;
            return true;
        }

        public bool ReduceCreditLine(double creditLine)
        {
            if (this.creditLine >= creditLine)
            {
                this.creditLine -= creditLine;
                return true;
            }

            return false;

        }
    }
