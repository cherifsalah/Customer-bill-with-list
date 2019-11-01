//this module conatin some functions that deal with in and out of customers from a file
using Customer_bill;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Customer_bill
{
    public static class CustomerFile
    {
        const string path = "Customers.txt"; // path of the file used to store all the customers
        //read all customers from a file and return a list of customers
        //because there is no charachter restriction on customername
        //I decide to put every field in a new line
        
        public static List<Customer> ReadCustomers()
        {
            List<Customer> customersList = new List<Customer>(); //contain all the customers in the file
            FileStream fs = null; //file stream used to access the file
            StreamReader sr = null;//buffer on the file

            string line_customer_no;//string that contain customer_no 
            string line_customer_name;//string that contain customer_name
            string line_customer_type;//string that contain customer_type
            string line_customer_amount;//string that contain customer_amount
            int customer_no;//customer_no
            string customer_name;//customer name
            char customer_type;//customer type
            decimal customer_amount;//customer amount
            Customer Cust; // customer
            
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);

                //loop if there is data
                while (!sr.EndOfStream)
                {
                    //read 4 lines of the file 
                    line_customer_no = sr.ReadLine();
                    line_customer_name = sr.ReadLine();
                    line_customer_type = sr.ReadLine();
                    line_customer_amount = sr.ReadLine();
                    
                    //convert data and create an object Customer
                    customer_type=Convert.ToChar( line_customer_type);
                    customer_name=line_customer_name;
                    customer_no=Convert.ToInt16(line_customer_no);
                    customer_amount=Convert.ToDecimal(line_customer_amount);
                    
                    //create a new customer
                    Cust = Create_customer_by_type(customer_no, customer_name, customer_type, customer_amount);
                    //add to list
                    customersList.Add(Cust);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally // executes always
            {
                if (fs != null) fs.Close(); // close the file
            }
            return customersList;
        }
        //return a new customer  
        public static Customer Create_customer_by_type(int cust_id, string name, char type, decimal c_amount)
        {
            if (type == 'R')
                return new ResidentialCustomer( cust_id,  name, type,  c_amount);
            else if (type == 'C')
                return new  CommercialCustomer(cust_id, name, type, c_amount);
            // type=='I'
            else return  new IndustrialCustomer(cust_id, name, type, c_amount);
  
        }
        // save list of Customer into a file  
        public static void SaveCustomers(List<Customer> listCustomer)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            string line_customer_no;
            string line_customer_name;
            string line_customer_type;
            string line_customer_amount;
            
            try
            {
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                //for each customer in the list, get every property of the customer object
                //in a separate line and write to the file 
                foreach (Customer cust in listCustomer)     // for each product in the list
                {
                    line_customer_no = cust.Customer_no.ToString();
                    sw.WriteLine(line_customer_no);
                    line_customer_name = cust.Customer_name;
                    sw.WriteLine(line_customer_name);
                    line_customer_type = cust.Customer_type.ToString();
                    sw.WriteLine(line_customer_type);
                    line_customer_amount = cust.Customer_amount.ToString();
                    sw.WriteLine(line_customer_amount);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sw != null) sw.Close(); // close streams
                if (fs != null) fs.Close();
            }
        }
        //return Nomber of customers in the list
        public static int NombreOfCustomer(List<Customer> listCust)
        {
            return listCust.Count();
        }
        //the sum of charges for list of customer
        public static decimal SumOfChargeForList(List<Customer> listCust)
        {
            decimal result=0;
            foreach (Customer cust in listCust)
            {
                result += cust.Customer_amount;
            }
            return result;
        }
        //Return list of custmers by type
        public static List<Customer> GetListByType(List<Customer> listCust,char type )
        {
            List<Customer> result = new List<Customer>();
            foreach (Customer cust in listCust)
            {
                if (cust.Customer_type == type)
                    result.Add(cust);
            }
            return result;
        }
        
    }
}
