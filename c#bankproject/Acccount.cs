using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK
{
    
    
    class Acccount
    {
         string Accountname;
         string Accounttype;
         string Accountnumber;
         double custbalance;
         string custtype;

        //Account()
        //{
            
        //  string Accountname = "";
        //  string     Accounttype = "";
        //  string   Accountnumber = "";
        //  double  custbalance = 0.00;
        //  string custtype = "";
        //}

        string AccountDetails(string aName, string actype, string accnum, double custbal)
        {
            Accountname = aName;
            Accounttype = actype;
            Accountnumber = accnum;
            custbalance = custbal;
            return AccountDetails(aName, actype, accnum, custbalance);
            
        }

        string deposit(string accnum, double balance)
        {
            if(Accountnumber == accnum)
            {
                balance = balance + custbalance;
            }
            return deposit(accnum,balance);
        }


        string withdrawal(string accnum, string acctype, string custtpe , double takingoff)
        {
            if((Accountnumber.EndsWith("14"))&& (Accounttype == acctype) && ((custtype == "STUDENT")||(custtype== "NON-STUDENT")))//SAVINGS ACCOUNT DEDUCTIONS
                {
                double balance = custbalance - takingoff;
                }

             else if((Accountnumber.EndsWith("15"))&&(Accounttype==acctype) && (custtype == "STUDENT")) //CURRENT ACCOUNT DEDUCTIONS FOR STUDENT
              {
                double balance = custbalance - takingoff;
              }

            else
            {
               double balance = custbalance - ((1/100.0)* takingoff);
            }
            return withdrawal(accnum, acctype, custtpe, takingoff);
        }


        }
    }

