
namespace AutoCenter
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
            this.informationLabel = new System.Windows.Forms.Label();
            this.autosalesButton = new System.Windows.Forms.Button();
            this.servicecenterButton = new System.Windows.Forms.Button();
            this.detailshopButton = new System.Windows.Forms.Button();
            this.employmentopportunitiesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // informationLabel
            // 
            this.informationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.informationLabel.Location = new System.Drawing.Point(35, 34);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(236, 78);
            this.informationLabel.TabIndex = 0;
            // 
            // autosalesButton
            // 
            this.autosalesButton.Location = new System.Drawing.Point(46, 148);
            this.autosalesButton.Name = "autosalesButton";
            this.autosalesButton.Size = new System.Drawing.Size(84, 36);
            this.autosalesButton.TabIndex = 1;
            this.autosalesButton.Text = "Auto Sales";
            this.autosalesButton.UseVisualStyleBackColor = true;
            this.autosalesButton.Click += new System.EventHandler(this.autosalesButton_Click);
            // 
            // servicecenterButton
            // 
            this.servicecenterButton.Location = new System.Drawing.Point(173, 148);
            this.servicecenterButton.Name = "servicecenterButton";
            this.servicecenterButton.Size = new System.Drawing.Size(84, 36);
            this.servicecenterButton.TabIndex = 2;
            this.servicecenterButton.Text = "Service Center";
            this.servicecenterButton.UseVisualStyleBackColor = true;
            this.servicecenterButton.Click += new System.EventHandler(this.servicecenterButton_Click);
            // 
            // detailshopButton
            // 
            this.detailshopButton.Location = new System.Drawing.Point(46, 204);
            this.detailshopButton.Name = "detailshopButton";
            this.detailshopButton.Size = new System.Drawing.Size(84, 36);
            this.detailshopButton.TabIndex = 3;
            this.detailshopButton.Text = "Detail Shop";
            this.detailshopButton.UseVisualStyleBackColor = true;
            this.detailshopButton.Click += new System.EventHandler(this.detailshopButton_Click);
            // 
            // employmentopportunitiesButton
            // 
            this.employmentopportunitiesButton.Location = new System.Drawing.Point(173, 204);
            this.employmentopportunitiesButton.Name = "employmentopportunitiesButton";
            this.employmentopportunitiesButton.Size = new System.Drawing.Size(84, 36);
            this.employmentopportunitiesButton.TabIndex = 4;
            this.employmentopportunitiesButton.Text = "Employment Opportunities";
            this.employmentopportunitiesButton.UseVisualStyleBackColor = true;
            this.employmentopportunitiesButton.Click += new System.EventHandler(this.employmentopportunitiesButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(115, 264);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Programmed by C.S. Student";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 363);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.employmentopportunitiesButton);
            this.Controls.Add(this.detailshopButton);
            this.Controls.Add(this.servicecenterButton);
            this.Controls.Add(this.autosalesButton);
            this.Controls.Add(this.informationLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VB Auto Center";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.Button autosalesButton;
        private System.Windows.Forms.Button servicecenterButton;
        private System.Windows.Forms.Button detailshopButton;
        private System.Windows.Forms.Button employmentopportunitiesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}

