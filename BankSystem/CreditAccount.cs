using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public class CreditAccount : Account
    {
        double Creditline;
        public CreditAccount(string id, string pwd, double money, double Creditline) : base(id, pwd, money)
        {
            this.Creditline = Creditline;
        }
        public double getCreditline()
        {
            return Creditline;
        }

        public void setCreditline(double val)
        {
            this.Creditline = val;
        }
        public bool addCreditline(double Creditline)
        {
            if (Creditline < 0) return false;  //卫语句

            this.Creditline += Creditline;
            return true;
        }

        public bool reduceCreditline(double Creditline)
        {
            if (this.Creditline >= Creditline)
            {
                this.Creditline -= Creditline;
                return true;
            }

            return false;

        }
    }
