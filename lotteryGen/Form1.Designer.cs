namespace lotteryGen
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
            this.title = new System.Windows.Forms.Label();
            this.infoText = new System.Windows.Forms.Label();
            this.genButt = new System.Windows.Forms.Button();
            this.numText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Wheat;
            this.title.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(410, 54);
            this.title.TabIndex = 0;
            this.title.Text = "Lottery Number Generator";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoText
            // 
            this.infoText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.Location = new System.Drawing.Point(12, 63);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(407, 63);
            this.infoText.TabIndex = 1;
            this.infoText.Text = "Press the button below to generate your quick-pick Lotto 6/49 numbers!";
            this.infoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // genButt
            // 
            this.genButt.AutoSize = true;
            this.genButt.BackColor = System.Drawing.Color.Khaki;
            this.genButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genButt.Location = new System.Drawing.Point(178, 138);
            this.genButt.Name = "genButt";
            this.genButt.Size = new System.Drawing.Size(82, 29);
            this.genButt.TabIndex = 2;
            this.genButt.Text = "Generate";
            this.genButt.UseVisualStyleBackColor = false;
            this.genButt.Click += new System.EventHandler(this.genButt_Click);
            // 
            // numText
            // 
            this.numText.BackColor = System.Drawing.Color.FloralWhite;
            this.numText.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numText.Location = new System.Drawing.Point(12, 181);
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(410, 65);
            this.numText.TabIndex = 3;
            this.numText.Text = "Your winning numbers are just one button press away!";
            this.numText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.numText);
            this.Controls.Add(this.genButt);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Not_A_Scam.exe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label infoText;
        private System.Windows.Forms.Button genButt;
        private System.Windows.Forms.Label numText;
    }
}

