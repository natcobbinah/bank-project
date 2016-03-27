using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK
{
    class employee
    {
        private string username;
        private string password;
        private string address;
        private string areacode;
        private string phonenumber;
        private string firstname;
        private string middle_initial;
        private string lastname;
        private string gender;
        private int day;
        private string month;
        private int year;
        private string type;
   


        employee()
        {

            string username = "";
            string password = "";
            string address = "";
            string areacode = "";
            string phonenumber = "";
            string firstname = "";
            string middle_initial ="";
            string lastname = "";
            string gender = "";
            int day = 1;
            string month = "";
            int year = 2012;
            string type = "";
      }

  
        string personaldetails(string fname, string mdin, string lname, string gndr, int dy,string mnth,int yr,string tpe,string area,string number,string addr)
        {
            firstname = fname;
            middle_initial = mdin;
            lastname = lname;
            gender = gndr;
            day = dy;
            month = mnth;
            year = yr;
            type = tpe;
            areacode = area;
            address = addr;
            phonenumber = number;

            return personaldetails(fname, mdin, lname, gndr, dy, mnth, yr, tpe,area,number,addr);
        }

        string Getaccess(string uname, string pword)
        {
            username = uname;
            password = pword;

        return Getaccess(uname, pword);
        }
         
    }
}
