//author: Salah Hadj Cherif
//created on 28 june 2019
//Contain code that add and calculate a customer bill for the city power company


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Customer_bill
{

    public partial class frm_customerbill : Form
    {
        
        const string  RESIDENTIAL= "Residential";
         const string COMMERCIAL = "Commercial";
         const string INDUSTRIAL = "Industrial";
        const int INDEX_TAB_RESIDENTIAL = 0;
        const int INDEX_TAB_COMMERCIAL = 1;
        const int INDEX_TAB_INDUSTRIAL = 2;
        List<Customer> listCustomer =new List<Customer>();
        Customer CustSelected ;

        //Initialise all component of frm_customerbill
        public frm_customerbill()
        {
            InitializeComponent();
        }
        //if user click on Exit Application end 
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Calculate bill from KWH entered by user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
       private void btncalculate_Click(object sender, EventArgs e)
        {
             decimal amount=0;// Cost calculated 
            decimal Kwh;//Kwh consumed by customer
            decimal PHKwh;// Kwh consumed by industrial customer on Peak hours
            decimal OffPHKwh;//Kwh consumed by industrial customer on Off Peak hours
            decimal amount_PH=0;//cost calculated for Peak hours Kwh
            decimal amount_OffPH=0;//cost calculated for Off Peak hours Kwh

            //get currant tab
            //get parameter (kwh) needed to calculate amount 
            //calculate amount
            //display values
            int index = tab_customer.SelectedIndex; // index of the currant tab or selected tab 
            
            
            try
            {
                //check if user selected a customer already
                if (CustSelected != null)
                {
                    
                    if (index == INDEX_TAB_RESIDENTIAL)
                    {
                        //currant tab is RESIDENTIAL
                        if (Validator.IsCustomerOfType(CustSelected, 'R') &&
                            Validator.IsPresent(txtresidential_kwh, "KWH")&&
                        Validator.IsNonNegativeDecimal(txtresidential_kwh, "KWH")) 

                        {
                            Kwh = Convert.ToDecimal(txtresidential_kwh.Text);
                            amount= CustSelected.CalculateCharge(Kwh,0);
                            txt_amount_residential.Text = amount.ToString("c");
                            //display list of customers
                            DisplayCustomers();
                            //save list of customers in the file
                            CustomerFile.SaveCustomers(listCustomer);
                        }
                    }
                    else //currant tab is COMMERCIAL
                    if (index == INDEX_TAB_COMMERCIAL)
                    {

                        if (Validator.IsCustomerOfType(CustSelected, 'C')&&
                            Validator.IsPresent(txt_commercial_kwh, "KWH") &&
                        Validator.IsNonNegativeDecimal(txt_commercial_kwh, "KWH")
                        )
                        {
                            Kwh = Convert.ToDecimal(txt_commercial_kwh.Text);
                            amount = CustSelected.CalculateCharge(Kwh, 0);
                            txt_amount_commercial.Text = amount.ToString("c");
                            //display list of customers
                            DisplayCustomers();
                            //save list of customers in the file
                            CustomerFile.SaveCustomers(listCustomer);
                        }
                    }
                    else//currant tab is INDUSTRIAL
                    if (index == INDEX_TAB_INDUSTRIAL)
                    {
                        if (Validator.IsCustomerOfType(CustSelected, 'I')&&
                            Validator.IsPresent(txt_peakhourskwh, "Peak Hours KWH") &&
                        Validator.IsNonNegativeDecimal(txt_peakhourskwh, "Peak Hours KWH") &&
                        Validator.IsPresent(txt_offpeakhourskwh, "Off Peak Hours KWH") &&
                        Validator.IsNonNegativeDecimal(txt_offpeakhourskwh, "Off Peak Hours KWH")
                        )
                        {   
                            //calculate peak hours amount
                            PHKwh = Convert.ToDecimal(txt_peakhourskwh.Text);
                            IndustrialCustomer IndCust= (IndustrialCustomer)CustSelected; 
                            
                            amount_PH = IndCust.Calculate_PH_Amount (PHKwh);
                            txt_peakhours_amount.Text = amount_PH.ToString("c");
                            //calculate Off peak hours amount
                            OffPHKwh = Convert.ToDecimal(txt_offpeakhourskwh.Text);
                            amount_OffPH = IndCust.Calculate_OFFPH_Amount(OffPHKwh);
                            txt_Offpeakhours_amount.Text = amount_OffPH.ToString("c");
                            //calculate total amount
                            amount = IndCust.CalculateCharge(PHKwh,OffPHKwh );
                            txt_amount_industrial.Text = amount.ToString("c");
                            //display list of customers
                            DisplayCustomers();
                            //save list of customers in the file
                            CustomerFile.SaveCustomers(listCustomer);
                        }
                    }
                }
                else
                {
                    if (listCustomer.Count == 0)
                        MessageBox.Show("you need to Create a new Customer, your List is empty!","Warning");
                    else MessageBox.Show("A Customer need to be Selected!","Warning");
                }
            }
            // on exception show this message 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }

        }

        //If user click on Clear this method will clear all the Text Box in the form
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear_All_Control_in_tab_customer();
        }
        //Clear all text box in grp add customer
        private void Clear_All_Control_in_Grp_AddCustomer()
        {
            txtCustname.Text = "";
            txtCustnumber.Text = "";
            CmbCustType.Text = "";
            
        }
        private void Clear_All_Control_in_tab_customer()
        { 
        //Clear all textbox controls in the tab customer groupe 

        // Clear controls in tab  RESIDENTIAL
                txtresidential_kwh.Text = "";
                txt_amount_residential.Text = "";

            //Clear controls in tab COMMERCIAL
                txt_commercial_kwh.Text = "";
                txt_amount_commercial.Text = "";

            //Clear controls in tab Industrial
                txt_offpeakhourskwh.Text = "";
                txt_Offpeakhours_amount.Text = "";
                txt_peakhourskwh.Text = "";
                txt_peakhours_amount.Text = "";
                txt_amount_industrial.Text = "";
             
        }
        private void frm_customerbill_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            listCustomer = CustomerFile.ReadCustomers();
            DisplayCustomers();

        }
        //set focus to txtCustnumber
        private void frm_customerbill_Shown(object sender, EventArgs e)
        {
            txtCustnumber.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int cust_id;//contain new cust number
            string name;//contain new cust name
            char type;//contain new cust type
            decimal c_amount=0;//contain new cust amount
            Customer newcust;//new customer
            //check if all the field in the group add account are present and valid before proceed in 
            //adding a new customer
            if (Validator.IsPresent(txtCustname, "Customer Name") &&
                     Validator.IsPresent(txtCustnumber, "Customer Number") &&
                     Validator.IsSelected(CmbCustType, "Customer Type")&&
                     Validator.IsNonNegativeInt(txtCustnumber, "Customer Number"))
            {
                //get value for the new customer we want to create
                cust_id = Convert.ToInt16(txtCustnumber.Text);
                name = txtCustname.Text;
                type = gettypefromCombo(CmbCustType );
                //create a new customer and add it to the list 
                newcust = CustomerFile.Create_customer_by_type(cust_id, name, type, c_amount);
                listCustomer.Add(newcust);
                //customer selected is the new customer
                CustSelected = newcust;
                
                //display list of customers
                DisplayCustomers();
                //save list of customers in the file
                CustomerFile.SaveCustomers(listCustomer);
                //Clear all control in add customer group
                Clear_All_Control_in_Grp_AddCustomer();
            }
            

        }

        private void DisplayCustomers()
        {
            List<Customer> listResidentialCust=new List<Customer>();//
            List<Customer> listCommercialCust= new List<Customer>();
            List<Customer> listIndustrialCust= new List<Customer>();
            lstboxCustomer.Items.Clear(); // empty the list box

            foreach (Customer Cust in listCustomer)
                lstboxCustomer.Items.Add(Cust);
            //selected item ==selected customer until user change it by selecting another one 
            if (CustSelected !=null) 
                lstboxCustomer.SelectedItem = CustSelected;
            // display Nombre of customers
            txtTotNumCust.Text = listCustomer.Count.ToString();
            //get all the separate list by type
            listResidentialCust = CustomerFile.GetListByType(listCustomer,'R');
            listCommercialCust = CustomerFile.GetListByType(listCustomer, 'C');
            listIndustrialCust = CustomerFile.GetListByType(listCustomer, 'I');
            //sum and display the charge for each list  
            txtsumofchargeCom.Text = CustomerFile.SumOfChargeForList( listCommercialCust).ToString("c");
            txtsumofchargeRes.Text = CustomerFile.SumOfChargeForList(listResidentialCust).ToString("c");
            txtsumofchargeIndust.Text = CustomerFile.SumOfChargeForList(listIndustrialCust).ToString("c");
            txtsumofallcharges.Text= CustomerFile.SumOfChargeForList(listCustomer).ToString("c");
        }
        //return type from selected combobox item
        //'C' if Itemselected is Commercial
        private Char gettypefromCombo(ComboBox cmb)
        {
            char c ;
            if (cmb.Text == RESIDENTIAL) { c= 'R'; }
            else if (cmb.Text == COMMERCIAL) {c= 'C'; }
            else   { c= 'I'; }
            return c;
        }
        //every time user select a customer display tab of calcul for it 
        private void lstboxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get customer selected
             Customer cust =  (Customer) lstboxCustomer.SelectedItem;
            //set customer selected to this customer
            CustSelected = cust;
            //set selected index of the tab customer according to its type
            tab_customer.SelectedIndex = get_index_from_Customer_type(cust.Customer_type);
            //Clear_All_Control_in_tab_customer();
        }
        //return index from type 
        private int get_index_from_Customer_type(char type)
        {
            int result=0;
            if (type== 'C') { result =1  ; }
            else if (type == 'I') { result = 2; }
            
            return result;

        }

        private void tab_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear_All_Control_in_tab_customer();
        }
    }
}
