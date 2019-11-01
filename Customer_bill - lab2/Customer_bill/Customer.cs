//method and property of abstract class Customer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_bill
{
    //Define Class Customer with following property:
    //AccountNo – No of account 
    //CustomerName – name of customer
    //CustomerType – a single character string that can be “R”, “C”, or “I” (capital letters)
    //ChargeAmount the cost amount for customer 
    public abstract class Customer
    {

         const string RESIDENTIAL= "Residential";
         const string COMMERCIAL= "Commercial";
         const string INDUSTRIAL= "Industrial";
        //private data 
        private  int customer_no_value;//value of a customer no
        private string customer_name_value;//value of a customer name
        private char customer_type_value;//value of a customer type
        private decimal customer_amount_value;//value of a customer charge amount
        //constructor
        public Customer(int cust_id, string name, char c, decimal c_amount)
        {
            this.Customer_no = cust_id;
            this.Customer_name = name;
            this.Customer_type = c;
            this.Customer_amount = c_amount;
        }
        //property Customer_no
        public int Customer_no
        {
            get
            {
                return customer_no_value;
            }

            set
            {
                customer_no_value = value;
            }
        }
        //property Customer name
        public string Customer_name
        {
            get
            {
                return customer_name_value;
            }

            set
            {
                customer_name_value = value;
            }
        }
        //property Customer type
        public char Customer_type
        {
            get
            {
                return customer_type_value;
            }

            set
            {
                customer_type_value = value;
            }
        }
        //propety Customer amount
        public decimal Customer_amount
        {
            get
            {
                return customer_amount_value;
            }

            set
            {
                customer_amount_value = value;
            }
        }
        //method calculatecharge
        public abstract decimal CalculateCharge(decimal kwh1, decimal Kwh2);
        //Method toString :Dislay a customer
        public override string ToString()
        {
            string str = Get_str_from_type(this.Customer_type); 
            return (str +":No-> " + this.Customer_no.ToString() + " ,Name-> " + this.Customer_name +" ,Amount-> " + this.Customer_amount.ToString("c"));
        }
        // return class type in a string 
        private string Get_str_from_type(char c)
        {
            string str="";
            if ( c=='R'  ) { str = RESIDENTIAL; }
            else if (c =='C') { str= COMMERCIAL; }
            else  { str= INDUSTRIAL; }
            return str;
        }


    }
}