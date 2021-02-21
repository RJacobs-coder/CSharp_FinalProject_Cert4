using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace FinalProject_Programming2_V1
{
    // Name: Robert Jacobs 30018755
    // Date: 16/11/2020
    // Project: Drone Storage Final Project.
    // Description: Application to allow users to enter Drone and Customer information into seperate Binary Files.
    // The Transaction information is recorded from inputs via the Customer and Drone sections of the application.
    // The code is split into 4 parts. Drone stuff, Customer Stuff, Transaction stuff, Other stuff.
    // All questions are tested and completed.

    public partial class Form1 : Form
    {
        // Transaction "Class" Globals.
        private string transactionNum, custID, serialNum;

        // Various Counters to control different array indexes.

        private int transactionNullPointer;
        private int customerNullPointer;
        private int droneNullPointer;

        // Arrays for main Class.
        private string[,] transactionArray = new string[20, 3];
        private DroneClass[] droneArray = new DroneClass[20];
        private CustomerClass[] customerArray = new CustomerClass[20];

        public Form1()
        {
            InitializeComponent();

        }
        // Functionality when Form first loads up along side files.
        private void Form1_Load(object sender, EventArgs e)
        {
            droneLoadFile();
            customerLoadFile();
            transactionLoadFile();
        }
        // Functionality when Form is closing down along side files.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            droneSaveFile();
            customerSaveFile();
            transactionSaveFile();
        }

        // ***************************** DRONE FUNCTIONALITY ************************************************
        // ***************************** DRONE FUNCTIONALITY ************************************************
        // ***************************** DRONE FUNCTIONALITY ************************************************


        // Add button to allow items within the Drone Text boxes to be loaded into the array and listbox.
        private void addDroneButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(droneSNTB.Text)))
            {

                string[] dataCheck = new string[7];


                //Filling up Data Check Array for Testing.

                dataCheck[0] = droneSNTB.Text;
                dataCheck[1] = droneModelTB.Text;
                dataCheck[2] = droneEngineTB.Text;
                dataCheck[3] = droneRangeTB.Text;
                dataCheck[4] = droneAccTB.Text;
                dataCheck[5] = dronePriceTB.Text;
                dataCheck[6] = dronePurchTB.Text;

                // Uses DataCheck Array to make sure all the boxes are full. Question 4A Complete.
                for (int i = 0; i < dataCheck.Length; i++)
                {
                    // Checks each box to see if any null values are present.
                    if (dataCheck[i] == "")
                    {   // Question 4B Complete. Error Message if too many or too few boxes are complete.
                        MessageBox.Show("Please Fill all the boxes in the Form.");
                        droneArray[i] = null;
                        clearDroneMethod();
                        break;
                    }
                    // Once checking is complete (Last Index) adds the Instance of the Drone Class to the array.
                    else if (dataCheck[6] != "")
                    {
                        // Creates new Class Instance. 4C.
                        DroneClass drone = new DroneClass();

                        // Object Filled up with values. 4C
                        drone.gsSerialNumber = dataCheck[0];
                        drone.gsModel = dataCheck[1];
                        drone.gsEngineConfig = dataCheck[2];
                        drone.gsRange = dataCheck[3];
                        drone.gsAccessories = dataCheck[4];
                        drone.gsPrice = dataCheck[5];
                        drone.gsDate = dataCheck[6];

                        // Class Object Added to Array. 4C
                        droneArray[droneNullPointer] = drone;
                    }
                    else
                    {
                        errorMessage.Items.Clear();
                        errorMessage.Text = "Add Drone Button Null Reference.";
                    }
                }

                // Bubble Sort Method organises Array Based on Serial Number. 4D Complete.
                bubbleSort();

                // Clear Happens before the Array is Displayed (After Sort) but the values are in the Array. 4E Complete.
                
                droneDisplayBox.Items.Clear();

                try
                {
                    if (!(string.IsNullOrEmpty(droneSNTB.Text)))
                    {
                        for (int j = 0; j <= droneNullPointer; j++)
                        {
                            // Using values from Drone Class Instance inside the J Index. Add 3 values to the list box. Question 4C + 4D Complete.

                            droneDisplayBox.Items.Add(droneArray[j].gsSerialNumber + " - " + droneArray[j].gsEngineConfig + " - " + droneArray[j].gsPrice);

                        }
                    }
                    else
                    {

                    }
                    clearDroneMethod();

                }
                catch (NullReferenceException)
                {
                    errorMessage.Items.Clear();
                    errorMessage.Text = "Add Drone Button Null Reference / List Filling.";
                }

                // Null Pointer for drone Array.
                droneNullPointer++;
                

            }
            else
            {
                MessageBox.Show("Text box empty", "Please fill out all the text boxes.");
            }

        }

        // Drone Loading is not yet Implemented.
        public void droneLoadFile()
        {
            try
            {
                // Binery file is checked and opened. The information is read and added to the list.
                if (File.Exists("drones.dat"))
                {

                    using (BinaryReader br = new BinaryReader(File.Open("drones.dat",
                    FileMode.Open)))
                    {
                        //To avoid Null errors the fileLength is defined and assigned as an Integer.
                        int fileLength = (int)br.BaseStream.Length / 7;
                        //NullPointer set to zero --- VERY IMPORTANT
                        droneNullPointer = 0;
                        for (int i = 0; i < fileLength; i++)
                        {
                            DroneClass a = new DroneClass();

                            a.gsSerialNumber = br.ReadString();
                            a.gsModel = br.ReadString();
                            a.gsEngineConfig = br.ReadString();
                            a.gsRange = br.ReadString();
                            a.gsAccessories = br.ReadString();
                            a.gsPrice = br.ReadString();
                            a.gsDate = br.ReadString();

                            droneArray[droneNullPointer] = a;

                            //To ensure clear viewing the arrays are loaded into a string which will be displayed in the box.
                            droneDisplayBox.Items.Add(droneArray[i].gsSerialNumber + " - " + droneArray[i].gsEngineConfig + " - " + droneArray[i].gsPrice);

                            //Nullpointer extends Array to avoid out of index errors.This is why it was set to zero before.
                            //This program has no delete button so there was no way to reduce the array size for the load function.
                            droneNullPointer++;
                        }

                    }
                }
                else if (!(File.Exists("drones.dat")))
                {
                    using (BinaryReader br = new BinaryReader(File.Open("drones.dat", FileMode.Create)))
                    {
                        errorMessage.Items.Clear();
                        errorMessage.Text = "Drone File does not currently Exist";
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("Error Loading File", "Check file is in the correct folder");
                }
            }
            catch (EndOfStreamException)
            {
                errorMessage.Items.Clear();
                errorMessage.Text = "End of Stream Exception Drone Load File";
            }

        }

        // Allows the Drone File to be created and store arrays once the closing of the program has been initiated.
        public void droneSaveFile()
        {

            if (File.Exists("drones.dat"))
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open("drones.dat", FileMode.OpenOrCreate)))
                {
                    droneNullPointer = 0;
                    for (int i = 0; i < droneNullPointer + 1; i++)
                    {

                        if (droneArray[i] != null)
                        {
                            // Current drone array index set to I and written one by one in for loop.
                            DroneClass a = droneArray[i];

                            bw.Write(a.gsSerialNumber);
                            bw.Write(a.gsModel);
                            bw.Write(a.gsEngineConfig);
                            bw.Write(a.gsRange);
                            bw.Write(a.gsAccessories);
                            bw.Write(a.gsPrice);
                            bw.Write(a.gsDate);

                            droneNullPointer++;
                        }
                        else
                        {
                            break;
                        }
                    }

                }
            }

        }

        // Method to all User to click onto listboxes to select data for later use.
        // Once Clicked all Revelevant Information is added to the Relevant Text Boxes. Question 6 Complete.
        private void droneDisplayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clearDroneMethod();
                // int index = droneDisplayBox.SelectedIndex;
                // Assings the Current index to a temp DroneClass Instance.
                DroneClass d = droneArray[droneDisplayBox.SelectedIndex];

                // All values get put into text boxes in the Drone Section.
                droneSNTB.Text = d.gsSerialNumber;
                droneModelTB.Text = d.gsModel;
                droneEngineTB.Text = d.gsEngineConfig;
                droneRangeTB.Text = d.gsRange;
                droneAccTB.Text = d.gsAccessories;
                dronePriceTB.Text = d.gsPrice;
                dronePurchTB.Text = d.gsDate;

                // The Serial Number is added to the Transaction Section.
                transactionSNTB.Text = d.gsSerialNumber;

            }
            catch (IndexOutOfRangeException)
            {
                errorMessage.Items.Clear();
                errorMessage.Text = "Out of Index Exception - Drone DisplayBox";
            }


        }

        // Event for when the Drone Serial Number Text Box is double clicked via the mouse. Question 8 Complete.
        private void droneSNTB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // When the Text box is double clicked all the text boxes will clear. Question 8 Complete.
            clearDroneMethod();
        }

        // Event for the when Drone Display Box is double clicked via the mouse.

        private void droneDisplayBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clearDroneMethod();
        }
        
        // Drone Clear method to clear text boxes.
        public void clearDroneMethod()
        {
            droneSNTB.Clear();
            droneModelTB.Clear();
            droneEngineTB.Clear();
            droneRangeTB.Clear();
            droneAccTB.Clear();
            droneAccTB.Clear();
            dronePriceTB.Clear();
            dronePurchTB.Clear();
            droneSNTB.Focus();
        }

        // ************************* CUSTOMER FUNCTIONALITY *********************************************
        // ************************* CUSTOMER FUNCTIONALITY *********************************************
        // ************************* CUSTOMER FUNCTIONALITY *********************************************

        // Add button to allow items within the Customer Text boxes to be loaded into the array and listbox.
        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(customerIDTB.Text)))
            {

                string[] dataCheck = new string[4];

                //Filling up Data Check Array for Testing.

                dataCheck[0] = customerIDTB.Text;
                dataCheck[1] = customerNameTB.Text;
                dataCheck[2] = customerCityTB.Text;
                dataCheck[3] = customerCountryTB.Text;

                // Uses DataCheck Array to make sure all the boxes are full. Question 5A Complete.
                for (int i = 0; i < dataCheck.Length; i++)
                {
                    if (dataCheck[i] == "")
                    {
                        MessageBox.Show("Text Boxes are Empty", "Please Fill all the Boxes in the Form.");
                        customerArray[i] = null;
                        break;
                    }
                    else if (dataCheck[3] != "")
                    {
                        CustomerClass customer = new CustomerClass();

                        customer.gsCustomerID = dataCheck[0];
                        customer.gsCusName = dataCheck[1];
                        customer.gsCusCity = dataCheck[2];
                        customer.gsCusCountry = dataCheck[3];

                        customerArray[customerNullPointer] = customer;
                    }
                    else
                    {
                        errorMessage.Items.Clear();
                        errorMessage.Text = "Data Checking In progress";
                    }
                }

                try
                {
                    bubbleSort();
                    
                    customerDisplayBox.Items.Clear();
                    // Customer Array is Displayed in Text Box.
                    if (!(string.IsNullOrEmpty(customerIDTB.Text)))
                    {
                        for (int j = 0; j <= customerNullPointer; j++)
                        {
                            customerDisplayBox.Items.Add(customerArray[j].gsCustomerID + " - " + customerArray[j].gsCusName + " - " + customerArray[j].gsCusCity + " - " + customerArray[j].gsCusCountry);
                        }
                    }
                    else
                    {

                    }
                    clearCustomerMethod();
                }
                catch (NullReferenceException)
                {
                    errorMessage.Items.Clear();
                    errorMessage.Text = "Null Reference at Add Customer Button.";
                }
            }

            // Else If Statement to give user option to put in a Default Customer. Question 5B Complete.
            else if (string.IsNullOrEmpty(droneSNTB.Text))
            {
                // Diaglog box to allow a default customer to be made.
                DialogResult defaultCustomer = MessageBox.Show("Would you like to create a default customer?", "Please press Yes / No",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                // If clicked "YES". Default Customer will be Added to text boxes. Must click again to be added to Array. Question 5C Complete.
                if (defaultCustomer == DialogResult.Yes)
                {
                    MessageBox.Show("Yes Button Pressed.", "Default Customer created");
                    MessageBox.Show("Not in Array Yet", "Please push Add Button again to add Default Customer to Array");
                    customerIDTB.Text = "Default";
                    customerNameTB.Text = "Default";
                    customerCityTB.Text = "Default";
                    customerCountryTB.Text = "Default";
                    return;
                }
                // If Clicked "NO". No Further Action Taken. Question 5D Complete.
                else if (defaultCustomer == DialogResult.No)
                {
                    MessageBox.Show("No Button Pressed", "No further action taken.");
                }
            }
            // Error Message if boxes are missing inputs from User.
            else
            {

                MessageBox.Show("Text box empty", "Please fill out all the text boxes.");
            }

            // Array Sorted and Boxes are Cleared. Question 5F is complete.
            bubbleSort();
            clearCustomerMethod();

            customerNullPointer++;
        }
        // Customer Loading not yet implemented.
        public void customerLoadFile()
        {
            try
            {
                // Binery file is checked and opened. The information is read and added to the list.
                if (File.Exists("customers.dat"))
                {

                    using (BinaryReader br = new BinaryReader(File.Open("customers.dat",
                    FileMode.Open)))
                    {
                        //To avoid Null errors the fileLength is defined and assigned as an Integer.
                        int fileLength = (int)br.BaseStream.Length / 4;
                        //NullPointer set to zero --- VERY IMPORTANT
                        customerNullPointer = 0;
                        for (int i = 0; i < fileLength; i++)
                        {
                            CustomerClass a = new CustomerClass();

                            a.gsCustomerID = br.ReadString();
                            a.gsCusName = br.ReadString();
                            a.gsCusCity = br.ReadString();
                            a.gsCusCountry = br.ReadString();

                            customerArray[customerNullPointer] = a;

                            customerDisplayBox.Items.Add(customerArray[i].gsCustomerID + " - " + customerArray[i].gsCusName + " - " + customerArray[i].gsCusCity + " - " + customerArray[i].gsCusCountry);

                            //To ensure clear viewing the arrays are loaded into a string which will be displayed in the box.

                            //Nullpointer extends Array to avoid out of index errors.This is why it was set to zero before.
                            //This program has no delete button so there was no way to reduce the array size for the load function.
                            customerNullPointer++;
                        }

                    }
                }
                else if (!(File.Exists("customers.dat")))
                {
                    using (BinaryReader br = new BinaryReader(File.Open("customers.dat", FileMode.Create)))
                    {
                        errorMessage.Text = "Customer.dat does not currently exist.";
                        return;
                    }
                }

                else
                {
                    MessageBox.Show("Error Loading File", "Check file is in the correct folder");
                }
            }
            catch (EndOfStreamException)
            {
                errorMessage.Items.Clear();
                errorMessage.Text = "End of Stream Exception - Customer Loader";
            }

        }

        // Customer Arrays stored into binary file as program is closing down.
        public void customerSaveFile()
        {

            if (File.Exists("customers.dat"))
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open("customers.dat", FileMode.OpenOrCreate)))
                {
                    customerNullPointer = 0;
                    for (int i = 0; i < customerNullPointer + 1; i++)
                    {
                        if (customerArray[i] != null)
                        {
                            // Class called from current array index and saved into binary data. Loops around for each index.
                            CustomerClass a = customerArray[i];

                            bw.Write(a.gsCustomerID);
                            bw.Write(a.gsCusName);
                            bw.Write(a.gsCusCity);
                            bw.Write(a.gsCusCountry);
                            customerNullPointer++;
                        }
                        else
                        {
                            break;
                        }

                    }

                }
            }
        }

        // Method to all User to click onto listboxes to select data for later use.
        // Once Clicked all Revelevant Information is added to the Relevant Text Boxes. Question 6 Complete.
        private void customerDisplayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Assigns the Current index to a temp DroneClass Instance.
                CustomerClass c = customerArray[customerDisplayBox.SelectedIndex];

                // All Values get pt into text boxes in the Customer Section.
                customerIDTB.Text = c.gsCustomerID;
                customerNameTB.Text = c.gsCusName;
                customerCityTB.Text = c.gsCusCity;
                customerCountryTB.Text = c.gsCusCountry;

                // Customer ID Number is added to the Transaction Section.
                transactionCusTB.Text = c.gsCustomerID;
            }
            catch (IndexOutOfRangeException)
            {
                errorMessage.Text = "Customer Display Box out of Index.";
            }
        }
        // Event for when the Customer ID Text box is clicked via the mouse.
        private void customerIDTB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // When the Customer ID Text Box is cleared all the Text boxes will clear. Question 9 Complete.
            clearCustomerMethod();
        }

        // Method to use Mouse Down Function to enable a right click to run a Binary Search for the value.

        private void customerIDTB_MouseDown(object sender, MouseEventArgs e)
        {
            Point mouseDownLocation = new Point(e.X, e.Y);
            switch (e.Button)
            {
                case MouseButtons.Right:
                    bubbleSort();
                    customerBSearch();
                    break;
                default:
                    
                    break;
            }
        }
      
        // Binary Search is initiated on the right mouse click on the Customer ID TextBox.
        public void customerBSearch()
        {
            // Mid, Lower, Higher are all defined.
            int mid = 0, lowbound = 0;
            int highbound = customerNullPointer;

            try
            {
                while (lowbound <= highbound)
                {
                    //Initial mid value is 5.
                    //The lowbound / highbound is manipulated by assigning it to the current mid with either -1 or + 1.
                    mid = (lowbound + highbound) / 2;
                    // Comparaison is made within loop. The new mid index is compared against what is currently in the text box.
                    //int target = globalArray[mid, 0].ToLower().CompareTo(gametitletextbox.Text.ToLower());
                    int target = customerArray[mid].gsCustomerID.CompareTo(customerIDTB.Text);

                    // 3 values are given after "CompareTo" 0 means that the two objects match.
                    if (target == 0)
                    {
                        MessageBox.Show("Customer Found " + customerArray[mid].gsCustomerID + " - " + customerArray[mid].gsCusName, "Binary Search result");
                        break;
                    }
                    // Greater than zero means the target is LOWER than the current mid. The top section needs to be reduced.
                    else if (target > 0)
                    {
                        highbound = mid - 1;
                    }
                    
                    // Else is the same as target < 0. This means the target is HIGHER than the current mid. The bottom section is reduced.
                    else
                    {
                        lowbound = mid + 1;
                    }
                    
                }
            }catch(NullReferenceException)
            {
                errorMessage.Text = "Null Reference Error at Bin Search";
                MessageBox.Show("Sorry, Data not found", "Data not Found");
            }
        }

        // Clear Method for Customer Text Boxes.
        public void clearCustomerMethod()
        {
            customerIDTB.Clear();
            customerNameTB.Clear();
            customerCityTB.Clear();
            customerCountryTB.Clear();
            customerIDTB.Focus();
        }

        // ***************************** TRANSACTION FUNCTIONALITY ************************************************
        // ***************************** TRANSACTION FUNCTIONALITY ************************************************
        // ***************************** TRANSACTION FUNCTIONALITY ************************************************

        //Add button to allow items within the Transaction Text boxes to be loaded into the array and listbox.
        private void addTransactionButton_Click(object sender, EventArgs e)
        {

            if (!(string.IsNullOrEmpty(transactionIDTB.Text)))
            {
                string[] dataCheck = new string[3];

                // Filling up DataCheck Array for Testing.

                dataCheck[0] = transactionIDTB.Text;
                dataCheck[1] = transactionCusTB.Text;
                dataCheck[2] = transactionSNTB.Text;

                // Uses DataCheck Array to make sure all the boxes are full.

                for (int i = 0; i < dataCheck.Length; i++)
                {
                    // Checks each box to see if any null values are present.
                    if (dataCheck[i] == "")
                    {
                        MessageBox.Show("Please make sure all the boxes are full.", "Some Boxes are Read Only");
                        break;
                    }
                    //Once Checking is complete (Last Index) adds the Instance of the Transaction 2D Array.
                    else if (dataCheck[2] != "")
                    {//The Transaction is Not a class. The info will be stored normally into a 2D Array.
                        transactionArray[transactionNullPointer, 0] = transactionIDTB.Text;
                        transactionArray[transactionNullPointer, 1] = transactionCusTB.Text;
                        transactionArray[transactionNullPointer, 2] = transactionSNTB.Text;

                    }
                    else
                    {
                        errorMessage.Items.Clear();
                        errorMessage.Text = " Continues Add Transaction Loop";
                    }

                    transactionDisplayBox.Items.Add(transactionArray[transactionNullPointer, 0] + " - " + transactionArray[transactionNullPointer, 1] + " - " + transactionArray[transactionNullPointer, 2]);
                }

                // Bubble Sort Method organises Array Based on Transaction ID Number.
                transactionBubbleSort();
                clearTransactionMethod();
                transactionDisplayBox.Items.Clear();
                try
                {
                    if (!(string.IsNullOrEmpty(transactionArray[transactionNullPointer, 0])))
                    {
                        for (int j = 0; j <= transactionNullPointer; j++)
                        {
                            //Using values from Transaction Array and displaying them in the List Box.
                            transactionDisplayBox.Items.Add(transactionArray[j, 0] + " - " + transactionArray[j, 1] + " - " + transactionArray[j, 2]);
                        }
                    }
                    else
                    {

                    }
                }
                catch (NullReferenceException)
                {
                    errorMessage.Items.Clear();
                    errorMessage.Text = " Null Reference Exception Add Transaction Button";
                }

            }
            else
            {
                MessageBox.Show("Text Box was Empty", "Please make sure all the boxes are filled");
            }

            // Null Poiner for Transaction Array.
            transactionNullPointer++;

        }
       // Loads transaction.dat file apon program initiation.
        public void transactionLoadFile()
        {
            try
            {
                // Binery file is checked and opened. The information is read and added to the list.
                if (File.Exists("transactions.dat"))
                {

                    using (BinaryReader br = new BinaryReader(File.Open("transactions.dat",
                    FileMode.Open)))
                    {
                        //To avoid Null errors the fileLength is defined and assigned as an Integer.
                        int fileLength = (int)br.BaseStream.Length / 4;
                        //NullPointer set to zero --- VERY IMPORTANT
                        transactionNullPointer = 0;
                        for (int i = 0; i < fileLength; i++)
                        {

                            //Array is filled up individually.
                            transactionArray[i, 0] = br.ReadString();
                            transactionArray[i, 1] = br.ReadString();
                            transactionArray[i, 2] = br.ReadString();

                            transactionDisplayBox.Items.Add(transactionArray[i, 0] + " - " + transactionArray[i, 1] + " - " + transactionArray[i, 2]);

                            //To ensure clear viewing the arrays are loaded into a string which will be displayed in the box.

                            //Nullpointer extends Array to avoid out of index errors. This is why it was set to zero before.
                            //This program has no delete button so there was no way to reduce the array size for the load function.
                            transactionNullPointer++;
                        }

                    }
                }
                else if (!(File.Exists("transactions.dat")))
                {
                    errorMessage.Items.Clear();
                    errorMessage.Text = "Transactions.Dat does not exist.";
                    using (BinaryReader br = new BinaryReader(File.Open("transactions.dat", FileMode.Create)))
                        return;
                }
                else
                {
                    errorMessage.Items.Clear();
                    errorMessage.Text = "Loading Eror Transactions File.";
                }
            }
            catch (EndOfStreamException)
            {
                errorMessage.Items.Clear();
                errorMessage.Text = " End of Stream Exception - Transactions Load";
            }

        }
        // Saves transaction array into binary file termination of program.
        public void transactionSaveFile()
        {

            if (File.Exists("transactions.dat"))
            {
                using (BinaryWriter bw = new BinaryWriter(File.Open("transactions.dat", FileMode.OpenOrCreate)))
                {
                    try
                    {
                        transactionNullPointer = 0;
                        for (int i = 0; i < transactionNullPointer + 1; i++)
                        {
                            if (transactionArray[i, 0] != null)
                            {
                                bw.Write(transactionArray[transactionNullPointer, 0]);
                                bw.Write(transactionArray[transactionNullPointer, 1]);
                                bw.Write(transactionArray[transactionNullPointer, 2]);

                                transactionNullPointer++;
                            }
                            else
                            {
                                errorMessage.Items.Clear();
                                errorMessage.Text = "Null Reference Exception at Transaction Saver.";
                                break;
                            }

                        }
                        MessageBox.Show("Binery File Saved, Binery File Saved");
                    }
                    catch(NullReferenceException)
                    {
                        errorMessage.Items.Clear();
                        errorMessage.Text = "Null Reference Exception at Transaction Saver.";
                    }
                }
            }
        }
        // Method to all User to click onto listboxes to select data for later use.
        private void transactionDisplayBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Rip values out of Array.
            string value0 = transactionArray[transactionDisplayBox.SelectedIndex, 0];
            string value1 = transactionArray[transactionDisplayBox.SelectedIndex, 1];
            string value2 = transactionArray[transactionDisplayBox.SelectedIndex, 2];

            // Puts all the selected list values into the boxees for the Transaction Section of the Form.
            transactionIDTB.Text = value0;
            transactionCusTB.Text = value1;
            transactionSNTB.Text = value2;

        }

        // Event for when the Transaction ID Number Text Boxe is double clicked via the mouse. Queston 11 Complete.
        private void transactionIDTB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            clearTransactionMethod();
        }

        // Event for the when Transaction Display Box is double clicked via the mouse.
        private void transactionDisplayBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Not being used.
        }

        // Clear Method for Transaction Text Boxes.
        public void clearTransactionMethod()
        {
            transactionIDTB.Clear();
            transactionCusTB.Clear();
            transactionSNTB.Clear();
            transactionIDTB.Focus();

        }

        // Bubble Sort to sort the transaction Array. It is seperate due to the if conditions and the face it is a different type of Array.
        public void transactionBubbleSort()
        {
            if (!(string.IsNullOrEmpty(transactionIDTB.Text)))
            {
                try
                {
                    for (int j = 0; j < transactionNullPointer; j++)
                    {
                        for (int i = 0; i < transactionNullPointer; i++)
                        {
                            int target = transactionArray[i, 0].CompareTo(transactionArray[i + 1, 0]);
                            if (target > 0)
                            {

                                string temp = transactionArray[i + 1, 0];
                                transactionArray[i + 1, 0] = transactionArray[i, 0];
                                transactionArray[i, 0] = temp;

                            }

                        }
                    }
                }
                catch (NullReferenceException)
                {
                    errorMessage.Items.Clear();
                    errorMessage.Text = "Transaction Bubble Error - Null Reference";
                }
                catch (IndexOutOfRangeException)
                {
                    errorMessage.Items.Clear();
                    errorMessage.Text = "Transaction Bubble Error - Index out of Range";
                }
                catch (Exception)
                {
                    errorMessage.Items.Clear();
                    errorMessage.Text = "Transaction Bubble Error - Exception";
                }
            }
        }

        //*************************** OTHER FUNCTIONALITY ***************************************
        //*************************** OTHER FUNCTIONALITY ***************************************
        //*************************** OTHER FUNCTIONALITY ***************************************

        // Basic Bubble sort to sort arrays. Both Customer and Drone arrays are sorted here.
        public void bubbleSort()
        {
            // To get a single method to take care of two different sorts I have used an if > else statement. (Drone sort + Customer Sort)
            // The text boxes will only be filled if they are about to add.
            // If the drone box is full. Do this.
            if (!(string.IsNullOrEmpty(droneSNTB.Text)))
            {
                try
                {
                    for (int j = 0; j < droneNullPointer; j++)
                    {
                        for (int i = 0; i < droneNullPointer; i++)
                        {
                            if (!(string.IsNullOrEmpty(droneSNTB.Text)))
                            {

                                // Uses the serial number from the Drone Class to do the CompareTo Method.
                                int target = droneArray[i].gsSerialNumber.CompareTo(droneArray[i + 1].gsSerialNumber);
                                if (target > 0)
                                {

                                    DroneClass temp = droneArray[i + 1];
                                    droneArray[i + 1] = droneArray[i];
                                    droneArray[i] = temp;
                                }
                                
                                else
                                {
                                    errorMessage.Items.Clear();
                                    errorMessage.Text = "Null Error Handled at Bubble Sort";
                                    //break;
                                }
                            }
                            else
                            {
                                //Null Reference
                                //break;
                            }
                        }
                    }
                }
                catch (NullReferenceException)
                {
                    errorMessage.Items.Clear();
                    errorMessage.Text = "Null Error Reference at Bubble Sort / Drone";
                }
                catch (IndexOutOfRangeException)
                {
                    errorMessage.Items.Clear();
                    errorMessage.Text = "Index out of Range Error at Bubble Sort / Drone";
                }
                catch (Exception)
                {
                    errorMessage.Items.Clear();
                    errorMessage.Text = "Unknown Exception at Bubble Sort / Drone";
                }

            }
            else
            {
                //Null Reference

            }

            // If the Customer Text box is full. Do this.
            if (!(string.IsNullOrEmpty(customerIDTB.Text)))
            {
                try
                {
                    for (int j = 0; j < customerNullPointer; j++)
                    {
                        for (int i = 0; i < customerNullPointer; i++)
                        {
                            if (!(string.IsNullOrEmpty(customerIDTB.Text)))
                            {


                                // Uses the serial Number from the Customer Class to do the CompareTo Method.
                                int target = customerArray[i].gsCustomerID.CompareTo(customerArray[i + 1].gsCustomerID);
                                if (target > 0)
                                {
                                    CustomerClass temp = customerArray[i + 1];
                                    customerArray[i + 1] = customerArray[i];
                                    customerArray[i] = temp;
                                }
                                else
                                {
                                    errorMessage.Items.Clear();
                                    errorMessage.Text = "Null Error Handled at Bubble Sort";
                                    
                                }
                            }
                            else
                            {
                            }

                        }
                    }
                }
                catch (NullReferenceException)
                {
                    errorMessage.Items.Clear();
                    errorMessage.Text = "Null Error Reference at Bubble Sort / Customer";
                }
                catch (IndexOutOfRangeException)
                {
                    errorMessage.Items.Clear();
                    errorMessage.Text = "Index out of Range Error at Bubble Sort / Customer";
                }
                catch (Exception)
                {
                    errorMessage.Items.Clear();
                    errorMessage.Text = "Unknown Exception at Bubble Sort / Customer";
                }
            }
            // Error Catch for Null values.
            else
            {
                errorMessage.Items.Clear();
                errorMessage.Text = "Unknown Exception at Bubble Sort / Customer";
            }
        }
        // Getters and setters for Form Class.
        public string TransactionNum { get => transactionNum; set => transactionNum = value; }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            // Not in use.
        }
    }
}
