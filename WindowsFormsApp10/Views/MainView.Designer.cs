namespace WindowsFormsApp10.Views
{
    partial class MainView
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
            this.label1 = new System.Windows.Forms.Label();
            this.VendorLbl = new System.Windows.Forms.Label();
            this.ColorLbl = new System.Windows.Forms.Label();
            this.YearLbl = new System.Windows.Forms.Label();
            this.TransmissionLbl = new System.Windows.Forms.Label();
            this.ModelTxtB = new System.Windows.Forms.TextBox();
            this.YearTxtB = new System.Windows.Forms.TextBox();
            this.TransmissionTxtBx = new System.Windows.Forms.TextBox();
            this.ColorTxtb = new System.Windows.Forms.TextBox();
            this.VendorTxtB = new System.Windows.Forms.TextBox();
            this.dataListBx = new System.Windows.Forms.ListBox();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SansSerif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            // 
            // VendorLbl
            // 
            this.VendorLbl.AutoSize = true;
            this.VendorLbl.Font = new System.Drawing.Font("SansSerif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.VendorLbl.Location = new System.Drawing.Point(13, 102);
            this.VendorLbl.Name = "VendorLbl";
            this.VendorLbl.Size = new System.Drawing.Size(121, 37);
            this.VendorLbl.TabIndex = 1;
            this.VendorLbl.Text = "Vendor";
            // 
            // ColorLbl
            // 
            this.ColorLbl.AutoSize = true;
            this.ColorLbl.Font = new System.Drawing.Font("SansSerif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ColorLbl.Location = new System.Drawing.Point(13, 157);
            this.ColorLbl.Name = "ColorLbl";
            this.ColorLbl.Size = new System.Drawing.Size(94, 37);
            this.ColorLbl.TabIndex = 2;
            this.ColorLbl.Text = "Color";
            // 
            // YearLbl
            // 
            this.YearLbl.AutoSize = true;
            this.YearLbl.Font = new System.Drawing.Font("SansSerif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.YearLbl.Location = new System.Drawing.Point(13, 210);
            this.YearLbl.Name = "YearLbl";
            this.YearLbl.Size = new System.Drawing.Size(85, 37);
            this.YearLbl.TabIndex = 5;
            this.YearLbl.Text = "Year";
            // 
            // TransmissionLbl
            // 
            this.TransmissionLbl.AutoSize = true;
            this.TransmissionLbl.Font = new System.Drawing.Font("SansSerif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TransmissionLbl.Location = new System.Drawing.Point(12, 276);
            this.TransmissionLbl.Name = "TransmissionLbl";
            this.TransmissionLbl.Size = new System.Drawing.Size(209, 37);
            this.TransmissionLbl.TabIndex = 4;
            this.TransmissionLbl.Text = "Transmission";
            // 
            // ModelTxtB
            // 
            this.ModelTxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModelTxtB.Location = new System.Drawing.Point(160, 48);
            this.ModelTxtB.Name = "ModelTxtB";
            this.ModelTxtB.Size = new System.Drawing.Size(100, 29);
            this.ModelTxtB.TabIndex = 6;
            // 
            // YearTxtB
            // 
            this.YearTxtB.Location = new System.Drawing.Point(160, 221);
            this.YearTxtB.Name = "YearTxtB";
            this.YearTxtB.Size = new System.Drawing.Size(100, 20);
            this.YearTxtB.TabIndex = 7;
            // 
            // TransmissionTxtBx
            // 
            this.TransmissionTxtBx.Location = new System.Drawing.Point(252, 288);
            this.TransmissionTxtBx.Name = "TransmissionTxtBx";
            this.TransmissionTxtBx.Size = new System.Drawing.Size(100, 20);
            this.TransmissionTxtBx.TabIndex = 8;
            // 
            // ColorTxtb
            // 
            this.ColorTxtb.Location = new System.Drawing.Point(160, 168);
            this.ColorTxtb.Name = "ColorTxtb";
            this.ColorTxtb.Size = new System.Drawing.Size(100, 20);
            this.ColorTxtb.TabIndex = 9;
            // 
            // VendorTxtB
            // 
            this.VendorTxtB.Location = new System.Drawing.Point(160, 109);
            this.VendorTxtB.Name = "VendorTxtB";
            this.VendorTxtB.Size = new System.Drawing.Size(100, 20);
            this.VendorTxtB.TabIndex = 10;
            // 
            // dataListBx
            // 
            this.dataListBx.FormattingEnabled = true;
            this.dataListBx.Location = new System.Drawing.Point(491, 48);
            this.dataListBx.Name = "dataListBx";
            this.dataListBx.Size = new System.Drawing.Size(236, 173);
            this.dataListBx.TabIndex = 11;
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(584, 236);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 12;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(228, 351);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(105, 39);
            this.AddBtn.TabIndex = 13;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.dataListBx);
            this.Controls.Add(this.VendorTxtB);
            this.Controls.Add(this.ColorTxtb);
            this.Controls.Add(this.TransmissionTxtBx);
            this.Controls.Add(this.YearTxtB);
            this.Controls.Add(this.ModelTxtB);
            this.Controls.Add(this.YearLbl);
            this.Controls.Add(this.TransmissionLbl);
            this.Controls.Add(this.ColorLbl);
            this.Controls.Add(this.VendorLbl);
            this.Controls.Add(this.label1);
            this.Name = "MainView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VendorLbl;
        private System.Windows.Forms.Label ColorLbl;
        private System.Windows.Forms.Label YearLbl;
        private System.Windows.Forms.Label TransmissionLbl;
        private System.Windows.Forms.TextBox ModelTxtB;
        private System.Windows.Forms.TextBox YearTxtB;
        private System.Windows.Forms.TextBox TransmissionTxtBx;
        private System.Windows.Forms.TextBox ColorTxtb;
        private System.Windows.Forms.TextBox VendorTxtB;
        private System.Windows.Forms.ListBox dataListBx;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button AddBtn;
    }
}