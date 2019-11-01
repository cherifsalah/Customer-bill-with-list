//Class IndustrialCustomer property and Method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_bill
{
    public class IndustrialCustomer : Customer
    {
        //Constructor
        public IndustrialCustomer(int cust_id, string name, char c, decimal c_amount): base(cust_id,  name,  c,  c_amount)
        {
            this.Customer_no = cust_id;
            this.Customer_name = name;
            this.Customer_type = c;
            this.Customer_amount = c_amount;
        }
        //Method ClaculateCharge: return total amount of charge for an indudtrial Customer
        public override decimal CalculateCharge(decimal kwh1, decimal Kwh2)
        {
            decimal amount= Calcul_functions.GettotalAmount_Industrial(kwh1, Kwh2);
            Customer_amount = amount;
            return amount;
        }
        //return Off Peak hours charge amount 
        public   decimal Calculate_OFFPH_Amount(decimal kwh)
        {
            return  Calcul_functions.GetAmount_Industrial_OffPeakHours(kwh);
        }

        //return Peak Hours amount of charge
        public   decimal Calculate_PH_Amount(decimal kwh)
        {
        return Calcul_functions.GetAmount_Industrial_PeakHours(kwh);
        }
        //return a string for an industrial customer
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
