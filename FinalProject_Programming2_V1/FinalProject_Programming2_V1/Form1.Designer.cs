namespace FinalProject_Programming2_V1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.droneDisplayBox = new System.Windows.Forms.ListBox();
            this.customerDisplayBox = new System.Windows.Forms.ListBox();
            this.transactionDisplayBox = new System.Windows.Forms.ListBox();
            this.droneSNTB = new System.Windows.Forms.TextBox();
            this.droneModelTB = new System.Windows.Forms.TextBox();
            this.droneEngineTB = new System.Windows.Forms.TextBox();
            this.droneRangeTB = new System.Windows.Forms.TextBox();
            this.droneAccTB = new System.Windows.Forms.TextBox();
            this.dronePriceTB = new System.Windows.Forms.TextBox();
            this.dronePurchTB = new System.Windows.Forms.TextBox();
            this.customerIDTB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.customerNameTB = new System.Windows.Forms.TextBox();
            this.customerCityTB = new System.Windows.Forms.TextBox();
            this.customerCountryTB = new System.Windows.Forms.TextBox();
            this.transactionIDTB = new System.Windows.Forms.TextBox();
            this.transactionCusTB = new System.Windows.Forms.TextBox();
            this.transactionSNTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.addDroneButton = new System.Windows.Forms.Button();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.addTransactionButton = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.StatusStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // droneDisplayBox
            // 
            this.droneDisplayBox.FormattingEnabled = true;
            this.droneDisplayBox.ItemHeight = 25;
            this.droneDisplayBox.Location = new System.Drawing.Point(564, 55);
            this.droneDisplayBox.Name = "droneDisplayBox";
            this.droneDisplayBox.Size = new System.Drawing.Size(472, 804);
            this.droneDisplayBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.droneDisplayBox, "Display Box for all Drones. Click an entry to populate Text Boxes.");
            this.droneDisplayBox.SelectedIndexChanged += new System.EventHandler(this.droneDisplayBox_SelectedIndexChanged);
            // 
            // customerDisplayBox
            // 
            this.customerDisplayBox.FormattingEnabled = true;
            this.customerDisplayBox.ItemHeight = 25;
            this.customerDisplayBox.Location = new System.Drawing.Point(1720, 55);
            this.customerDisplayBox.Name = "customerDisplayBox";
            this.customerDisplayBox.Size = new System.Drawing.Size(622, 329);
            this.customerDisplayBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.customerDisplayBox, "Customer Display Box showing all the customers in the system. Click an entry to f" +
        "ill up text boxes.");
            this.customerDisplayBox.SelectedIndexChanged += new System.EventHandler(this.customerDisplayBox_SelectedIndexChanged);
            // 
            // transactionDisplayBox
            // 
            this.transactionDisplayBox.FormattingEnabled = true;
            this.transactionDisplayBox.ItemHeight = 25;
            this.transactionDisplayBox.Location = new System.Drawing.Point(1720, 483);
            this.transactionDisplayBox.Name = "transactionDisplayBox";
            this.transactionDisplayBox.Size = new System.Drawing.Size(622, 354);
            this.transactionDisplayBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.transactionDisplayBox, "Transaction Display Box. Click an Entry to populate Boxes.");
            this.transactionDisplayBox.SelectedIndexChanged += new System.EventHandler(this.transactionDisplayBox_SelectedIndexChanged);
            // 
            // droneSNTB
            // 
            this.droneSNTB.Location = new System.Drawing.Point(326, 55);
            this.droneSNTB.Multiline = true;
            this.droneSNTB.Name = "droneSNTB";
            this.droneSNTB.Size = new System.Drawing.Size(199, 51);
            this.droneSNTB.TabIndex = 3;
            this.toolTip1.SetToolTip(this.droneSNTB, "Drone Serial Number - String");
            this.droneSNTB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.droneSNTB_MouseDoubleClick);
            // 
            // droneModelTB
            // 
            this.droneModelTB.Location = new System.Drawing.Point(326, 123);
            this.droneModelTB.Multiline = true;
            this.droneModelTB.Name = "droneModelTB";
            this.droneModelTB.Size = new System.Drawing.Size(199, 51);
            this.droneModelTB.TabIndex = 4;
            this.toolTip1.SetToolTip(this.droneModelTB, "Drone Model - String");
            // 
            // droneEngineTB
            // 
            this.droneEngineTB.Location = new System.Drawing.Point(326, 193);
            this.droneEngineTB.Multiline = true;
            this.droneEngineTB.Name = "droneEngineTB";
            this.droneEngineTB.Size = new System.Drawing.Size(199, 51);
            this.droneEngineTB.TabIndex = 5;
            this.toolTip1.SetToolTip(this.droneEngineTB, "Engine Configuation - String");
            // 
            // droneRangeTB
            // 
            this.droneRangeTB.Location = new System.Drawing.Point(326, 264);
            this.droneRangeTB.Multiline = true;
            this.droneRangeTB.Name = "droneRangeTB";
            this.droneRangeTB.Size = new System.Drawing.Size(199, 51);
            this.droneRangeTB.TabIndex = 6;
            this.toolTip1.SetToolTip(this.droneRangeTB, "Drone Range of Movement - String");
            // 
            // droneAccTB
            // 
            this.droneAccTB.Location = new System.Drawing.Point(326, 333);
            this.droneAccTB.Multiline = true;
            this.droneAccTB.Name = "droneAccTB";
            this.droneAccTB.Size = new System.Drawing.Size(199, 51);
            this.droneAccTB.TabIndex = 7;
            this.toolTip1.SetToolTip(this.droneAccTB, "Drone Accessories - String");
            // 
            // dronePriceTB
            // 
            this.dronePriceTB.Location = new System.Drawing.Point(326, 407);
            this.dronePriceTB.Multiline = true;
            this.dronePriceTB.Name = "dronePriceTB";
            this.dronePriceTB.Size = new System.Drawing.Size(199, 51);
            this.dronePriceTB.TabIndex = 8;
            this.toolTip1.SetToolTip(this.dronePriceTB, "Drone Price - String");
            // 
            // dronePurchTB
            // 
            this.dronePurchTB.Location = new System.Drawing.Point(326, 483);
            this.dronePurchTB.Multiline = true;
            this.dronePurchTB.Name = "dronePurchTB";
            this.dronePurchTB.Size = new System.Drawing.Size(199, 51);
            this.dronePurchTB.TabIndex = 9;
            this.toolTip1.SetToolTip(this.dronePurchTB, "Purchase Date - String");
            // 
            // customerIDTB
            // 
            this.customerIDTB.ContextMenuStrip = this.contextMenuStrip1;
            this.customerIDTB.Location = new System.Drawing.Point(1486, 64);
            this.customerIDTB.Multiline = true;
            this.customerIDTB.Name = "customerIDTB";
            this.customerIDTB.Size = new System.Drawing.Size(199, 51);
            this.customerIDTB.TabIndex = 10;
            this.toolTip1.SetToolTip(this.customerIDTB, "Customer ID Number - String. Right Click box to use Binary Search. Make sure all " +
        "boxes are full first.");
            this.customerIDTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.customerIDTB_MouseDown);
            this.customerIDTB.TextChanged += new System.EventHandler(this.customerDisplayBox_SelectedIndexChanged);
            this.customerIDTB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.customerIDTB_MouseDoubleClick);
            this.customerIDTB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customerIDTB_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // customerNameTB
            // 
            this.customerNameTB.Location = new System.Drawing.Point(1486, 142);
            this.customerNameTB.Multiline = true;
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.Size = new System.Drawing.Size(199, 51);
            this.customerNameTB.TabIndex = 11;
            this.toolTip1.SetToolTip(this.customerNameTB, "Full Name of Customer - String");
            // 
            // customerCityTB
            // 
            this.customerCityTB.Location = new System.Drawing.Point(1486, 215);
            this.customerCityTB.Multiline = true;
            this.customerCityTB.Name = "customerCityTB";
            this.customerCityTB.Size = new System.Drawing.Size(199, 51);
            this.customerCityTB.TabIndex = 12;
            this.toolTip1.SetToolTip(this.customerCityTB, "Customer\'s City of residence.");
            // 
            // customerCountryTB
            // 
            this.customerCountryTB.Location = new System.Drawing.Point(1486, 290);
            this.customerCountryTB.Multiline = true;
            this.customerCountryTB.Name = "customerCountryTB";
            this.customerCountryTB.Size = new System.Drawing.Size(199, 51);
            this.customerCountryTB.TabIndex = 13;
            this.toolTip1.SetToolTip(this.customerCountryTB, "Customer\'s Country of Residence. - String");
            // 
            // transactionIDTB
            // 
            this.transactionIDTB.Location = new System.Drawing.Point(1486, 639);
            this.transactionIDTB.Multiline = true;
            this.transactionIDTB.Name = "transactionIDTB";
            this.transactionIDTB.Size = new System.Drawing.Size(199, 51);
            this.transactionIDTB.TabIndex = 14;
            this.toolTip1.SetToolTip(this.transactionIDTB, "Transaction ID - String");
            this.transactionIDTB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.transactionIDTB_MouseDoubleClick);
            // 
            // transactionCusTB
            // 
            this.transactionCusTB.Location = new System.Drawing.Point(1486, 712);
            this.transactionCusTB.Multiline = true;
            this.transactionCusTB.Name = "transactionCusTB";
            this.transactionCusTB.ReadOnly = true;
            this.transactionCusTB.Size = new System.Drawing.Size(199, 51);
            this.transactionCusTB.TabIndex = 15;
            this.toolTip1.SetToolTip(this.transactionCusTB, "Customer ID (Read only) - String. Data comes from the Customer Section of the for" +
        "m.");
            // 
            // transactionSNTB
            // 
            this.transactionSNTB.Location = new System.Drawing.Point(1486, 786);
            this.transactionSNTB.Multiline = true;
            this.transactionSNTB.Name = "transactionSNTB";
            this.transactionSNTB.ReadOnly = true;
            this.transactionSNTB.Size = new System.Drawing.Size(199, 51);
            this.transactionSNTB.TabIndex = 16;
            this.toolTip1.SetToolTip(this.transactionSNTB, "Serial Number (Read Only) - String. Data comes from Drone Section of the form.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 44);
            this.label1.TabIndex = 17;
            this.label1.Text = "Drone Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1217, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 44);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1162, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(523, 44);
            this.label3.TabIndex = 19;
            this.label3.Text = "Transaction Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Serial Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Engine Config";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(236, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Range";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Accessories";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 25;
            this.label9.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(147, 497);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Purchase Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1337, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Customer ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1355, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Full Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1426, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 25);
            this.label13.TabIndex = 29;
            this.label13.Text = "City";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1378, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 25);
            this.label14.TabIndex = 30;
            this.label14.Text = "Country";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1298, 654);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "Transaction ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1335, 725);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 25);
            this.label16.TabIndex = 32;
            this.label16.Text = "Customer ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Stencil", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1307, 801);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(173, 25);
            this.label17.TabIndex = 33;
            this.label17.Text = "Serial Number";
            // 
            // addDroneButton
            // 
            this.addDroneButton.Location = new System.Drawing.Point(635, 12);
            this.addDroneButton.Name = "addDroneButton";
            this.addDroneButton.Size = new System.Drawing.Size(300, 36);
            this.addDroneButton.TabIndex = 34;
            this.addDroneButton.Text = "Add Drone";
            this.toolTip1.SetToolTip(this.addDroneButton, "Add Button, All text boxes must be full.");
            this.addDroneButton.UseVisualStyleBackColor = true;
            this.addDroneButton.Click += new System.EventHandler(this.addDroneButton_Click);
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(1878, 12);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(300, 36);
            this.addCustomerButton.TabIndex = 35;
            this.addCustomerButton.Text = "Add Customer";
            this.toolTip1.SetToolTip(this.addCustomerButton, "Button to Add customers. Make sure all boxes are full. ");
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.Location = new System.Drawing.Point(1878, 419);
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(300, 36);
            this.addTransactionButton.TabIndex = 36;
            this.addTransactionButton.Text = "Add Transaction";
            this.toolTip1.SetToolTip(this.addTransactionButton, "Add Button to save transaction. Make sure you fill in the text box. Make sure you" +
        " have selected an entry from Customer and Drone.");
            this.addTransactionButton.UseVisualStyleBackColor = true;
            this.addTransactionButton.Click += new System.EventHandler(this.addTransactionButton_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.errorMessage.Location = new System.Drawing.Point(0, 881);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(2354, 22);
            this.errorMessage.TabIndex = 37;
            this.errorMessage.Text = "statusStrip1";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2354, 903);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.addTransactionButton);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.addDroneButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transactionSNTB);
            this.Controls.Add(this.transactionCusTB);
            this.Controls.Add(this.transactionIDTB);
            this.Controls.Add(this.customerCountryTB);
            this.Controls.Add(this.customerCityTB);
            this.Controls.Add(this.customerNameTB);
            this.Controls.Add(this.customerIDTB);
            this.Controls.Add(this.dronePurchTB);
            this.Controls.Add(this.dronePriceTB);
            this.Controls.Add(this.droneAccTB);
            this.Controls.Add(this.droneRangeTB);
            this.Controls.Add(this.droneEngineTB);
            this.Controls.Add(this.droneModelTB);
            this.Controls.Add(this.droneSNTB);
            this.Controls.Add(this.transactionDisplayBox);
            this.Controls.Add(this.customerDisplayBox);
            this.Controls.Add(this.droneDisplayBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox droneDisplayBox;
        private System.Windows.Forms.ListBox customerDisplayBox;
        private System.Windows.Forms.ListBox transactionDisplayBox;
        private System.Windows.Forms.TextBox droneModelTB;
        private System.Windows.Forms.TextBox droneEngineTB;
        private System.Windows.Forms.TextBox droneRangeTB;
        private System.Windows.Forms.TextBox droneAccTB;
        private System.Windows.Forms.TextBox dronePriceTB;
        private System.Windows.Forms.TextBox dronePurchTB;
        private System.Windows.Forms.TextBox customerIDTB;
        private System.Windows.Forms.TextBox customerNameTB;
        private System.Windows.Forms.TextBox customerCityTB;
        private System.Windows.Forms.TextBox customerCountryTB;
        private System.Windows.Forms.TextBox transactionIDTB;
        private System.Windows.Forms.TextBox transactionCusTB;
        private System.Windows.Forms.TextBox transactionSNTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button addDroneButton;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Button addTransactionButton;
        public System.Windows.Forms.TextBox droneSNTB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip errorMessage;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

