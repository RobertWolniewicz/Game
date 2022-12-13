namespace Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.powerButton = new System.Windows.Forms.Button();
            this.religionButton = new System.Windows.Forms.Button();
            this.militaryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Jedzenie = new System.Windows.Forms.Label();
            this.goldvalue = new System.Windows.Forms.Label();
            this.materialsValue = new System.Windows.Forms.Label();
            this.humanValue = new System.Windows.Forms.Label();
            this.foodValue = new System.Windows.Forms.Label();
            this.tradeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // powerButton
            // 
            this.powerButton.Location = new System.Drawing.Point(189, 170);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(230, 123);
            this.powerButton.TabIndex = 0;
            this.powerButton.Text = "Władza";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            this.powerButton.MouseEnter += new System.EventHandler(this.powerButton_Select);
            this.powerButton.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // religionButton
            // 
            this.religionButton.Location = new System.Drawing.Point(189, 356);
            this.religionButton.Name = "religionButton";
            this.religionButton.Size = new System.Drawing.Size(230, 123);
            this.religionButton.TabIndex = 1;
            this.religionButton.Text = "Religia";
            this.religionButton.UseVisualStyleBackColor = true;
            this.religionButton.Click += new System.EventHandler(this.religionButton_Click);
            this.religionButton.MouseEnter += new System.EventHandler(this.religionButton_Select);
            this.religionButton.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // militaryButton
            // 
            this.militaryButton.Location = new System.Drawing.Point(555, 170);
            this.militaryButton.Name = "militaryButton";
            this.militaryButton.Size = new System.Drawing.Size(230, 123);
            this.militaryButton.TabIndex = 2;
            this.militaryButton.Text = "Wojsko";
            this.militaryButton.UseVisualStyleBackColor = true;
            this.militaryButton.Click += new System.EventHandler(this.militaryButton_Click);
            this.militaryButton.MouseEnter += new System.EventHandler(this.militaryButton_Select);
            this.militaryButton.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Złoto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Materiały";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ludzie";
            // 
            // Jedzenie
            // 
            this.Jedzenie.AutoSize = true;
            this.Jedzenie.Location = new System.Drawing.Point(232, 18);
            this.Jedzenie.Name = "Jedzenie";
            this.Jedzenie.Size = new System.Drawing.Size(51, 15);
            this.Jedzenie.TabIndex = 6;
            this.Jedzenie.Text = "Jedzenie";
            // 
            // goldvalue
            // 
            this.goldvalue.AutoSize = true;
            this.goldvalue.Location = new System.Drawing.Point(26, 48);
            this.goldvalue.Name = "goldvalue";
            this.goldvalue.Size = new System.Drawing.Size(13, 15);
            this.goldvalue.TabIndex = 7;
            this.goldvalue.Text = "0";
            // 
            // materialsValue
            // 
            this.materialsValue.AutoSize = true;
            this.materialsValue.Location = new System.Drawing.Point(78, 48);
            this.materialsValue.Name = "materialsValue";
            this.materialsValue.Size = new System.Drawing.Size(13, 15);
            this.materialsValue.TabIndex = 8;
            this.materialsValue.Text = "0";
            // 
            // humanValue
            // 
            this.humanValue.AutoSize = true;
            this.humanValue.Location = new System.Drawing.Point(158, 48);
            this.humanValue.Name = "humanValue";
            this.humanValue.Size = new System.Drawing.Size(13, 15);
            this.humanValue.TabIndex = 9;
            this.humanValue.Text = "0";
            // 
            // foodValue
            // 
            this.foodValue.AutoSize = true;
            this.foodValue.Location = new System.Drawing.Point(232, 48);
            this.foodValue.Name = "foodValue";
            this.foodValue.Size = new System.Drawing.Size(13, 15);
            this.foodValue.TabIndex = 10;
            this.foodValue.Text = "0";
            // 
            // tradeButton
            // 
            this.tradeButton.Location = new System.Drawing.Point(555, 356);
            this.tradeButton.Name = "tradeButton";
            this.tradeButton.Size = new System.Drawing.Size(230, 123);
            this.tradeButton.TabIndex = 11;
            this.tradeButton.Text = "Handel";
            this.tradeButton.UseVisualStyleBackColor = true;
            this.tradeButton.Click += new System.EventHandler(this.tradeButton_Click);
            this.tradeButton.MouseEnter += new System.EventHandler(this.tradeButton_Select);
            this.tradeButton.MouseLeave += new System.EventHandler(this.button_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 634);
            this.Controls.Add(this.tradeButton);
            this.Controls.Add(this.foodValue);
            this.Controls.Add(this.humanValue);
            this.Controls.Add(this.materialsValue);
            this.Controls.Add(this.goldvalue);
            this.Controls.Add(this.Jedzenie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.militaryButton);
            this.Controls.Add(this.religionButton);
            this.Controls.Add(this.powerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button powerButton;
        private Button religionButton;
        private Button militaryButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Jedzenie;
        private Label goldvalue;
        private Label materialsValue;
        private Label humanValue;
        private Label foodValue;
        private Button tradeButton;
    }
}