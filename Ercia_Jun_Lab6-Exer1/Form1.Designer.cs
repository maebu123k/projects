
namespace Ercia_Jun_Lab6_Exer1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblSalesPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmboDescription = new System.Windows.Forms.ComboBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPartToComboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePartFromComboBoxCtrlDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addPartToListBoxCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPartListBoxCtrlCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countPartsInListBoxCtrlOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PopupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPartToListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.PopupMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstItems);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lblSalesPrice);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.cmboDescription);
            this.groupBox1.Location = new System.Drawing.Point(13, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Part and Order Information";
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(24, 76);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(401, 95);
            this.lstItems.TabIndex = 6;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(325, 50);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(203, 50);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(121, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity to be Shipped: ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(97, 50);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblSalesPrice
            // 
            this.lblSalesPrice.AutoSize = true;
            this.lblSalesPrice.Location = new System.Drawing.Point(21, 50);
            this.lblSalesPrice.Name = "lblSalesPrice";
            this.lblSalesPrice.Size = new System.Drawing.Size(63, 13);
            this.lblSalesPrice.TabIndex = 2;
            this.lblSalesPrice.Text = "Sales Price:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(18, 22);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // cmboDescription
            // 
            this.cmboDescription.FormattingEnabled = true;
            this.cmboDescription.Items.AddRange(new object[] {
            "Brake Pads",
            "Engine",
            "Injector",
            "Oil FIlter",
            "Tire",
            "Transmission",
            "Wheel Rim"});
            this.cmboDescription.Location = new System.Drawing.Point(97, 19);
            this.cmboDescription.Name = "cmboDescription";
            this.cmboDescription.Size = new System.Drawing.Size(328, 21);
            this.cmboDescription.TabIndex = 0;
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(290, 241);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(148, 20);
            this.txtOrderTotal.TabIndex = 1;
            this.txtOrderTotal.TabStop = false;
            this.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Total:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintainPartsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // maintainPartsToolStripMenuItem
            // 
            this.maintainPartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPartToComboBoxToolStripMenuItem,
            this.deletePartFromComboBoxCtrlDToolStripMenuItem,
            this.toolStripSeparator1,
            this.addPartToListBoxCtrlAToolStripMenuItem,
            this.clearPartListBoxCtrlCToolStripMenuItem,
            this.countPartsInListBoxCtrlOToolStripMenuItem});
            this.maintainPartsToolStripMenuItem.Name = "maintainPartsToolStripMenuItem";
            this.maintainPartsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.maintainPartsToolStripMenuItem.Text = "&Maintain Parts";
            // 
            // addPartToComboBoxToolStripMenuItem
            // 
            this.addPartToComboBoxToolStripMenuItem.Name = "addPartToComboBoxToolStripMenuItem";
            this.addPartToComboBoxToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.addPartToComboBoxToolStripMenuItem.Text = "Add Part to Co&mboBox   Ctrl + M";
            this.addPartToComboBoxToolStripMenuItem.Click += new System.EventHandler(this.addPartToComboBoxToolStripMenuItem_Click);
            // 
            // deletePartFromComboBoxCtrlDToolStripMenuItem
            // 
            this.deletePartFromComboBoxCtrlDToolStripMenuItem.Name = "deletePartFromComboBoxCtrlDToolStripMenuItem";
            this.deletePartFromComboBoxCtrlDToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.deletePartFromComboBoxCtrlDToolStripMenuItem.Text = "&Delete Part from ComboBox   Ctrl + D";
            this.deletePartFromComboBoxCtrlDToolStripMenuItem.Click += new System.EventHandler(this.deletePartFromComboBoxCtrlDToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(270, 6);
            // 
            // addPartToListBoxCtrlAToolStripMenuItem
            // 
            this.addPartToListBoxCtrlAToolStripMenuItem.Name = "addPartToListBoxCtrlAToolStripMenuItem";
            this.addPartToListBoxCtrlAToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.addPartToListBoxCtrlAToolStripMenuItem.Text = "&Add Part to ListBox     Ctrl + A";
            this.addPartToListBoxCtrlAToolStripMenuItem.Click += new System.EventHandler(this.addPartToListBoxCtrlAToolStripMenuItem_Click);
            // 
            // clearPartListBoxCtrlCToolStripMenuItem
            // 
            this.clearPartListBoxCtrlCToolStripMenuItem.Name = "clearPartListBoxCtrlCToolStripMenuItem";
            this.clearPartListBoxCtrlCToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.clearPartListBoxCtrlCToolStripMenuItem.Text = "&Clear Part ListBox       Ctrl + C";
            this.clearPartListBoxCtrlCToolStripMenuItem.Click += new System.EventHandler(this.clearPartListBoxCtrlCToolStripMenuItem_Click);
            // 
            // countPartsInListBoxCtrlOToolStripMenuItem
            // 
            this.countPartsInListBoxCtrlOToolStripMenuItem.Name = "countPartsInListBoxCtrlOToolStripMenuItem";
            this.countPartsInListBoxCtrlOToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.countPartsInListBoxCtrlOToolStripMenuItem.Text = "C&ount Parts in ListBox  Ctrl + O";
            this.countPartsInListBoxCtrlOToolStripMenuItem.Click += new System.EventHandler(this.countPartsInListBoxCtrlOToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // PopupMenu
            // 
            this.PopupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPartToListBoxToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem1});
            this.PopupMenu.Name = "PopupMenu";
            this.PopupMenu.Size = new System.Drawing.Size(176, 54);
            // 
            // addPartToListBoxToolStripMenuItem
            // 
            this.addPartToListBoxToolStripMenuItem.Name = "addPartToListBoxToolStripMenuItem";
            this.addPartToListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addPartToListBoxToolStripMenuItem.Text = "Add Part to ListBox";
            this.addPartToListBoxToolStripMenuItem.Click += new System.EventHandler(this.addPartToListBoxToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 278);
            this.ContextMenuStrip = this.PopupMenu;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrderTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Edwardsville Auto Store - Jun Ercia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PopupMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblSalesPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmboDescription;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainPartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePartFromComboBoxCtrlDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPartToListBoxCtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPartListBoxCtrlCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countPartsInListBoxCtrlOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPartToComboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip PopupMenu;
        private System.Windows.Forms.ToolStripMenuItem addPartToListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

