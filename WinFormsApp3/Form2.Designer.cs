namespace WinFormsApp3
{
    partial class fTown
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            chbHasPort = new CheckBox();
            chbHasAirport = new CheckBox();
            btnOk = new Button();
            btnCancel = new Button();
            tbName = new TextBox();
            tbCountry = new TextBox();
            tbRegion = new TextBox();
            tbPopulation = new TextBox();
            tbYearIncome = new TextBox();
            tbSquare = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Назва міста";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 56);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Країна";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 87);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Регіон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 117);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 3;
            label4.Text = "Кількість мешканців";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 152);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 4;
            label5.Text = "Річний дохід грн.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 187);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 5;
            label6.Text = "Площа кв. км.";
            // 
            // chbHasPort
            // 
            chbHasPort.AutoSize = true;
            chbHasPort.Location = new Point(27, 35);
            chbHasPort.Name = "chbHasPort";
            chbHasPort.Size = new Size(137, 24);
            chbHasPort.TabIndex = 6;
            chbHasPort.Text = "Місто має порт";
            chbHasPort.UseVisualStyleBackColor = true;
            // 
            // chbHasAirport
            // 
            chbHasAirport.AutoSize = true;
            chbHasAirport.Location = new Point(27, 84);
            chbHasAirport.Name = "chbHasAirport";
            chbHasAirport.Size = new Size(171, 24);
            chbHasAirport.TabIndex = 7;
            chbHasAirport.Text = "Місто має аеропорт";
            chbHasAirport.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(442, 28);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(123, 40);
            btnOk.TabIndex = 8;
            btnOk.Text = "Ок";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(442, 95);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 39);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            tbName.Location = new Point(187, 22);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 10;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(187, 53);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(125, 27);
            tbCountry.TabIndex = 11;
            // 
            // tbRegion
            // 
            tbRegion.Location = new Point(187, 84);
            tbRegion.Name = "tbRegion";
            tbRegion.Size = new Size(125, 27);
            tbRegion.TabIndex = 12;
            // 
            // tbPopulation
            // 
            tbPopulation.Location = new Point(187, 114);
            tbPopulation.Name = "tbPopulation";
            tbPopulation.Size = new Size(125, 27);
            tbPopulation.TabIndex = 13;
            // 
            // tbYearIncome
            // 
            tbYearIncome.Location = new Point(187, 145);
            tbYearIncome.Name = "tbYearIncome";
            tbYearIncome.Size = new Size(125, 27);
            tbYearIncome.TabIndex = 14;
            // 
            // tbSquare
            // 
            tbSquare.Location = new Point(187, 184);
            tbSquare.Name = "tbSquare";
            tbSquare.Size = new Size(125, 27);
            tbSquare.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbSquare);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbYearIncome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbPopulation);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbRegion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbCountry);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbName);
            groupBox1.Location = new Point(59, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 255);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Загальні дані";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chbHasPort);
            groupBox2.Controls.Add(chbHasAirport);
            groupBox2.Location = new Point(59, 287);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 125);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Транспорт";
            // 
            // fTown
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Name = "fTown";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            Load += fTown_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox chbHasPort;
        private CheckBox chbHasAirport;
        private Button btnOk;
        private Button btnCancel;
        private TextBox tbName;
        private TextBox tbCountry;
        private TextBox tbRegion;
        private TextBox tbPopulation;
        private TextBox tbYearIncome;
        private TextBox tbSquare;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}