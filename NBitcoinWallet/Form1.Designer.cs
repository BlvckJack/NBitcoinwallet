namespace NBitcoinWallet
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrivateKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblprivatekey = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblprivkeyaddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateSeed = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblmnemonic = new System.Windows.Forms.Label();
            this.lbladdressmnemonic = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblbalance1 = new System.Windows.Forms.Label();
            this.lblbalance2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Address by Private Key";
            // 
            // btnPrivateKey
            // 
            this.btnPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrivateKey.Location = new System.Drawing.Point(67, 74);
            this.btnPrivateKey.Name = "btnPrivateKey";
            this.btnPrivateKey.Size = new System.Drawing.Size(225, 40);
            this.btnPrivateKey.TabIndex = 1;
            this.btnPrivateKey.Text = "Generate Via Private Key";
            this.btnPrivateKey.UseVisualStyleBackColor = true;
            this.btnPrivateKey.Click += new System.EventHandler(this.btnPrivateKey_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Private Key";
            // 
            // lblprivatekey
            // 
            this.lblprivatekey.AutoSize = true;
            this.lblprivatekey.Location = new System.Drawing.Point(251, 148);
            this.lblprivatekey.Name = "lblprivatekey";
            this.lblprivatekey.Size = new System.Drawing.Size(0, 16);
            this.lblprivatekey.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Addresss";
            // 
            // lblprivkeyaddress
            // 
            this.lblprivkeyaddress.AutoSize = true;
            this.lblprivkeyaddress.Location = new System.Drawing.Point(250, 218);
            this.lblprivkeyaddress.Name = "lblprivkeyaddress";
            this.lblprivkeyaddress.Size = new System.Drawing.Size(0, 16);
            this.lblprivkeyaddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Generate Address by Seed Phrase";
            // 
            // btnGenerateSeed
            // 
            this.btnGenerateSeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSeed.Location = new System.Drawing.Point(67, 368);
            this.btnGenerateSeed.Name = "btnGenerateSeed";
            this.btnGenerateSeed.Size = new System.Drawing.Size(225, 38);
            this.btnGenerateSeed.TabIndex = 7;
            this.btnGenerateSeed.Text = "Generate Via Seed Phrase";
            this.btnGenerateSeed.UseVisualStyleBackColor = true;
            this.btnGenerateSeed.Click += new System.EventHandler(this.btnGenerateSeed_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mnemonic Phrase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Address";
            // 
            // lblmnemonic
            // 
            this.lblmnemonic.AutoSize = true;
            this.lblmnemonic.Location = new System.Drawing.Point(296, 464);
            this.lblmnemonic.Name = "lblmnemonic";
            this.lblmnemonic.Size = new System.Drawing.Size(0, 16);
            this.lblmnemonic.TabIndex = 10;
            // 
            // lbladdressmnemonic
            // 
            this.lbladdressmnemonic.AutoSize = true;
            this.lbladdressmnemonic.Location = new System.Drawing.Point(296, 517);
            this.lbladdressmnemonic.Name = "lbladdressmnemonic";
            this.lbladdressmnemonic.Size = new System.Drawing.Size(0, 16);
            this.lbladdressmnemonic.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Balance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 641);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Balance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "label9";
            // 
            // lblbalance1
            // 
            this.lblbalance1.AutoSize = true;
            this.lblbalance1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalance1.Location = new System.Drawing.Point(178, 279);
            this.lblbalance1.Name = "lblbalance1";
            this.lblbalance1.Size = new System.Drawing.Size(0, 20);
            this.lblbalance1.TabIndex = 15;
            // 
            // lblbalance2
            // 
            this.lblbalance2.AutoSize = true;
            this.lblbalance2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbalance2.Location = new System.Drawing.Point(179, 641);
            this.lblbalance2.Name = "lblbalance2";
            this.lblbalance2.Size = new System.Drawing.Size(0, 20);
            this.lblbalance2.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1022, 769);
            this.Controls.Add(this.lblbalance2);
            this.Controls.Add(this.lblbalance1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbladdressmnemonic);
            this.Controls.Add(this.lblmnemonic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerateSeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblprivkeyaddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblprivatekey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrivateKey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrivateKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblprivatekey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblprivkeyaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerateSeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblmnemonic;
        private System.Windows.Forms.Label lbladdressmnemonic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblbalance1;
        private System.Windows.Forms.Label lblbalance2;
    }
}

