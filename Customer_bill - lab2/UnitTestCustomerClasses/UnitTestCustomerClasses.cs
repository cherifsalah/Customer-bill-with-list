using Microsoft.VisualStudio.TestTools.UnitTesting;
using Customer_bill;


namespace Customer_bill.Test
{
    [TestClass]
    //Contain unit test for all customer class: Residential,commercial, Industrial
    public class TestAllCustomerClasses
    {
        [TestMethod]
        
        //test calculate charge with Kwh = 0 
        //Customer is Residential
        public void calculatecharge_ResidentialCust_Kwh_is_zero()
        {
            //Arrange
            decimal kwh = 0;
            decimal expectedcharge = 6m; //expected value from the calculcharge method
            decimal actualcharge; //contain actual charge that will be calculated
            int cust_id = 0;
            string name = "Paul";
            char c = 'R';
            decimal c_amount = 0;
            //Act
            //call method and calculate charge for a residential Customer
            ResidentialCustomer cust = new ResidentialCustomer( cust_id,  name,  c, c_amount);
            actualcharge=cust.CalculateCharge(kwh);
            
            //Assert
            //check if expectedcharge is == than actual charge
            Assert.AreEqual(expectedcharge, actualcharge);
        }
        [TestMethod]
        // test when Kwh=100
        public void calculatecharge_ResidentialCust_Kwh_is_100()
        {
            //Arrange
            decimal kwh = 100;
            decimal expectedcharge = 11.2m;
            decimal actualcharge;
            int cust_id = 0;
            string name = "Paul";
            char c = 'R';
            decimal c_amount = 0;
            //Act

            ResidentialCustomer cust = new ResidentialCustomer(cust_id, name, c, c_amount);
            actualcharge = cust.CalculateCharge(kwh);

            //Assert
            Assert.AreEqual(expectedcharge, actualcharge);
        }
        [TestMethod]
        //Customer is Commercial
        //test when kwh = 1000
        public void calculatecharge_CommercialCust_Kwh_is_1000()
        {
            //Arrange
            decimal kwh = 1000;
            decimal expectedcharge = 60m;
            decimal actualcharge;
            int cust_id = 0;
            string name = "Paul";
            char c = 'R';
            decimal c_amount = 0;
            //Act

            CommercialCustomer cust = new CommercialCustomer(cust_id, name, c, c_amount);
            actualcharge = cust.CalculateCharge(kwh);

            //Assert
            Assert.AreEqual(expectedcharge, actualcharge);
        }
        [TestMethod]
        //test calculatecharge when kwh=1100
        public void calculatecharge_CommercialCust_Kwh_is_1100()
        {
            //Arrange
            decimal kwh = 1100;
            decimal expectedcharge = 64.5m;
            decimal actualcharge;
            int cust_id = 0;
            string name = "Paul";
            char c = 'R';
            decimal c_amount = 0;
            //Act

            CommercialCustomer cust = new CommercialCustomer(cust_id, name, c, c_amount);
            actualcharge = cust.CalculateCharge(kwh);

            //Assert
            Assert.AreEqual(expectedcharge, actualcharge);
        }
    
        [TestMethod]
        //Customer is Industrial
        //test when PHkwh = 1000 ,OffPHkwh = 1000
        public void calculatecharge_IndustrialCust_OffPHKwh_is_1000_PHKwh_is_1000()
        {
            //Arrange
            decimal PHKwh = 1000;
            decimal OffPHKwh = 1000;
            decimal expectedcharge = 76m+40m;
            decimal actualcharge;
            int cust_id = 0;
            string name = "Paul";
            char c = 'R';
            decimal c_amount = 0;
            //Act

            IndustrialCustomer cust = new IndustrialCustomer(cust_id, name, c, c_amount);
            actualcharge = cust.CalculateCharge(PHKwh,OffPHKwh);

            //Assert
            Assert.AreEqual(expectedcharge, actualcharge);
        }
        [TestMethod]
        //Customer is Industrial
        //test when PHkwh = 1100, OffPHkwh = 1100
        public void calculatecharge_IndustrialCust_OffPHKwh_is_1100_PHKwh_is_1100()
        {
            //Arrange
            decimal PHKwh = 1100;
            decimal OffPHKwh = 1100;
            decimal expectedcharge = 76m + 40m +6.5m + 2.8m;
            decimal actualcharge;
            int cust_id = 0;
            string name = "Paul";
            char c = 'R';
            decimal c_amount = 0;
            //Act

            IndustrialCustomer cust = new IndustrialCustomer(cust_id, name, c, c_amount);
            actualcharge = cust.CalculateCharge(PHKwh, OffPHKwh);

            //Assert
            Assert.AreEqual(expectedcharge, actualcharge);
        }
    }

}
