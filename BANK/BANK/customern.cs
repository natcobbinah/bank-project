using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK
{
   public class customern
    {
        public string firstname;
        public string middle_initial;
        public string lastname;
        public string gender;
        public string phonenumber;
        public int day;
        public string month;
        public int year;
        public int pin;
        /// <summary>
        /// tring something here
        /// </summary>
        string Accountname;
        string Accounttype;
        string Accountnumber;
        double custbalance;
        string custtype;



        //customern()
        //{
        //    string firstname = "";
        //    string middle_initial = "";
        //    string lastname = "";
        //    string gender = "";
        //    string phonenumber = "";
        //    int day = 1;
        //    string month = "";
        //    int year = 2012;
        //    int pin = 00;
        //    ///<summary>
        //    ///trying something here 
        //    /// </summary>
            
        //    string Accountname = "";
        //    string Accounttype = "";
        //    string Accountnumber = "";
        //    double custbalance = 0.00;
        //    string custtype = "";
        //}

     public   string personalInfo(string fname, string mdin, string lname, string gndr, string phone, int dy, string mnth, int yr, int p,string aName,string actype,string accnum,double custbal)
        {
            firstname = fname;
            middle_initial = mdin;
            lastname = lname;
            gender = gndr;
            phonenumber = phone;
            day = dy;
            month = mnth;
            year = yr;
            pin = p;

            Accountname = aName;
            Accounttype = actype;
            Accountnumber = accnum;
            custbalance = custbal;

            return personalInfo(fname, mdin, lname, gndr,phone, dy, mnth, yr, p,aName,actype,accnum,custbal);
        }


    public    string getAccessOnline(string phone,int p)
        {
            phonenumber = phone;
            pin = p;

            return getAccessOnline(phone, p);
        }


        
    }
}
