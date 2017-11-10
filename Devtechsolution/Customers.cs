using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devtechsolution
{
    class Customers
    {
        
        private string name { get; set; }
        private string address { get; set; }
        private string contact { get; set; }
        private double balance { get; set; }

        public Customers(string name,string address,string contact,double balance)
        {
            this.name = name;
            this.address = address;
            this.contact = contact;
            this.balance = balance;


        }

        public Customers(string name, string address, string contact)
        {
            this.name = name;
            this.address = address;
            this.contact = contact;
            this.balance = 0.0;


        }

        public Customers(string name,  string contact)
        {
            this.name = name;
            this.address = "";
            this.contact = contact;
            this.balance = 0.0;


        }


        public void Cupdate(int id, string name, string contact,string address,double balance)
        {
        }

        public void Cupdate(int id,  double balance)
        {
        }




    }
}
