//Module contain CommercialCustomer class  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_bill
{
    public class CommercialCustomer : Customer
    {
        // constructor 
        public CommercialCustomer(int cust_id, string name, char c, decimal c_amount) : base(cust_id, name, c, c_amount)
        {
            this.Customer_no = cust_id;
            this.Customer_name = name;
            this.Customer_type = c;
            this.Customer_amount = c_amount;
        }
        //method that return charge amount for a Commercial customer
        public override decimal CalculateCharge(decimal kwh1, decimal Kwh2 = 0)
        {
            decimal amount= Calcul_functions.GetAmount_Commercial(kwh1); ;
            Customer_amount = amount; 
            return amount; 
        }
        //display a customer 
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
