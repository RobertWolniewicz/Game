namespace Game
{
    public partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addButtom = new System.Windows.Forms.Button();
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.foodValue = new System.Windows.Forms.Label();
            this.humanValue = new System.Windows.Forms.Label();
            this.materialsValue = new System.Windows.Forms.Label();
            this.goldvalue = new System.Windows.Forms.Label();
            this.Jedzenie = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.turnsLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(333, 634);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // addButtom
            // 
            this.addButtom.Location = new System.Drawing.Point(12, 663);
            this.addButtom.Name = "addButtom";
            this.addButtom.Size = new System.Drawing.Size(333, 139);
            this.addButtom.TabIndex = 1;
            this.addButtom.Text = "Buduj";
            this.addButtom.UseVisualStyleBackColor = true;
            this.addButtom.Click += new System.EventHandler(this.addButtom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(794, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(685, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(424, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(510, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(568, 571);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(875, 542);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1080, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 37);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(944, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 37);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1157, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 37);
            this.label9.TabIndex = 10;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1157, 689);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 37);
            this.label10.TabIndex = 11;
            this.label10.Text = "label10";
            // 
            // foodValue
            // 
            this.foodValue.AutoSize = true;
            this.foodValue.Location = new System.Drawing.Point(566, 42);
            this.foodValue.Name = "foodValue";
            this.foodValue.Size = new System.Drawing.Size(13, 15);
            this.foodValue.TabIndex = 20;
            this.foodValue.Text = "0";
            // 
            // humanValue
            // 
            this.humanValue.AutoSize = true;
            this.humanValue.Location = new System.Drawing.Point(492, 42);
            this.humanValue.Name = "humanValue";
            this.humanValue.Size = new System.Drawing.Size(13, 15);
            this.humanValue.TabIndex = 19;
            this.humanValue.Text = "0";
            // 
            // materialsValue
            // 
            this.materialsValue.AutoSize = true;
            this.materialsValue.Location = new System.Drawing.Point(412, 42);
            this.materialsValue.Name = "materialsValue";
            this.materialsValue.Size = new System.Drawing.Size(13, 15);
            this.materialsValue.TabIndex = 18;
            this.materialsValue.Text = "0";
            // 
            // goldvalue
            // 
            this.goldvalue.AutoSize = true;
            this.goldvalue.Location = new System.Drawing.Point(360, 42);
            this.goldvalue.Name = "goldvalue";
            this.goldvalue.Size = new System.Drawing.Size(13, 15);
            this.goldvalue.TabIndex = 17;
            this.goldvalue.Text = "0";
            // 
            // Jedzenie
            // 
            this.Jedzenie.AutoSize = true;
            this.Jedzenie.BackColor = System.Drawing.Color.Transparent;
            this.Jedzenie.Location = new System.Drawing.Point(549, 12);
            this.Jedzenie.Name = "Jedzenie";
            this.Jedzenie.Size = new System.Drawing.Size(51, 15);
            this.Jedzenie.TabIndex = 16;
            this.Jedzenie.Text = "Jedzenie";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(492, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Ludzie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(412, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Materiały";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(360, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Złoto";
            // 
            // turnsLabel
            // 
            this.turnsLabel.AutoSize = true;
            this.turnsLabel.Location = new System.Drawing.Point(1175, 12);
            this.turnsLabel.Name = "turnsLabel";
            this.turnsLabel.Size = new System.Drawing.Size(33, 15);
            this.turnsLabel.TabIndex = 21;
            this.turnsLabel.Text = "Tura:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1214, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 15);
            this.label15.TabIndex = 22;
            this.label15.Text = "1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 833);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.turnsLabel);
            this.Controls.Add(this.foodValue);
            this.Controls.Add(this.humanValue);
            this.Controls.Add(this.materialsValue);
            this.Controls.Add(this.goldvalue);
            this.Controls.Add(this.Jedzenie);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
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
            this.Controls.Add(this.addButtom);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ListBox listBox1;
        public Button addButtom;
        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public Label label6;
        public Label label7;
        public Label label8;
        public Label label9;
        public Label label10;
        private BindingSource bindingSource1;
        public Label foodValue;
        public Label humanValue;
        public Label materialsValue;
        public Label goldvalue;
        public Label Jedzenie;
        public Label label11;
        public Label label12;
        public Label label13;
        public Label turnsLabel;
        public Label label15;
    }
}