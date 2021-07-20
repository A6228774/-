
namespace Car_tax
{
    partial class car_tax
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CarType = new System.Windows.Forms.ComboBox();
            this.motorcc = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorlabel2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorlabel1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelto = new System.Windows.Forms.Label();
            this.labelfrom = new System.Windows.Forms.Label();
            this.EndDateError = new System.Windows.Forms.Label();
            this.StartDateError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用期間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(38, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "用途";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(38, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "汽缸CC數";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(38, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "試算結果";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton1.Location = new System.Drawing.Point(254, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 37);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "全年度";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.WholeYear_Countrbt);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton2.Location = new System.Drawing.Point(520, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 37);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "依期間";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.Period_Countrbt);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(544, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "送出試算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.taxCalculate_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(685, 572);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "重新輸入";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clear_ButtonClick);
            // 
            // CarType
            // 
            this.CarType.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CarType.FormattingEnabled = true;
            this.CarType.Items.AddRange(new object[] {
            "請選擇用途",
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.CarType.Location = new System.Drawing.Point(254, 116);
            this.CarType.Name = "CarType";
            this.CarType.Size = new System.Drawing.Size(233, 32);
            this.CarType.TabIndex = 9;
            this.CarType.SelectedIndexChanged += new System.EventHandler(this.Car_IndexChanged);
            // 
            // motorcc
            // 
            this.motorcc.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.motorcc.FormattingEnabled = true;
            this.motorcc.Location = new System.Drawing.Point(254, 191);
            this.motorcc.Name = "motorcc";
            this.motorcc.Size = new System.Drawing.Size(233, 32);
            this.motorcc.TabIndex = 10;
            this.motorcc.SelectedIndexChanged += new System.EventHandler(this.motorcc_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(44, 346);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(443, 276);
            this.textBox1.TabIndex = 11;
            // 
            // errorlabel2
            // 
            this.errorlabel2.AutoSize = true;
            this.errorlabel2.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.errorlabel2.ForeColor = System.Drawing.Color.Red;
            this.errorlabel2.Location = new System.Drawing.Point(250, 226);
            this.errorlabel2.Name = "errorlabel2";
            this.errorlabel2.Size = new System.Drawing.Size(163, 20);
            this.errorlabel2.TabIndex = 12;
            this.errorlabel2.Text = "請下拉選單選擇CC數";
            this.errorlabel2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.label6.Location = new System.Drawing.Point(248, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 13;
            this.label6.Visible = false;
            // 
            // errorlabel1
            // 
            this.errorlabel1.AutoSize = true;
            this.errorlabel1.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.errorlabel1.ForeColor = System.Drawing.Color.Red;
            this.errorlabel1.Location = new System.Drawing.Point(250, 151);
            this.errorlabel1.Name = "errorlabel1";
            this.errorlabel1.Size = new System.Drawing.Size(162, 20);
            this.errorlabel1.TabIndex = 14;
            this.errorlabel1.Text = "請下拉選單選擇用途";
            this.errorlabel1.UseWaitCursor = true;
            this.errorlabel1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker1.Location = new System.Drawing.Point(613, 119);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1946, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2021, 7, 20, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePicker2.Location = new System.Drawing.Point(613, 196);
            this.dateTimePicker2.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1946, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker2.TabIndex = 16;
            this.dateTimePicker2.Value = new System.DateTime(2021, 7, 20, 11, 10, 41, 0);
            this.dateTimePicker2.Visible = false;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // labelto
            // 
            this.labelto.AutoSize = true;
            this.labelto.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelto.ForeColor = System.Drawing.Color.Black;
            this.labelto.Location = new System.Drawing.Point(581, 203);
            this.labelto.Name = "labelto";
            this.labelto.Size = new System.Drawing.Size(26, 20);
            this.labelto.TabIndex = 17;
            this.labelto.Text = "至";
            this.labelto.UseWaitCursor = true;
            this.labelto.Visible = false;
            // 
            // labelfrom
            // 
            this.labelfrom.AutoSize = true;
            this.labelfrom.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelfrom.ForeColor = System.Drawing.Color.Black;
            this.labelfrom.Location = new System.Drawing.Point(581, 126);
            this.labelfrom.Name = "labelfrom";
            this.labelfrom.Size = new System.Drawing.Size(26, 20);
            this.labelfrom.TabIndex = 18;
            this.labelfrom.Text = "從";
            this.labelfrom.UseWaitCursor = true;
            this.labelfrom.Visible = false;
            // 
            // EndDateError
            // 
            this.EndDateError.AutoSize = true;
            this.EndDateError.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EndDateError.ForeColor = System.Drawing.Color.Red;
            this.EndDateError.Location = new System.Drawing.Point(610, 226);
            this.EndDateError.Name = "EndDateError";
            this.EndDateError.Size = new System.Drawing.Size(173, 17);
            this.EndDateError.TabIndex = 19;
            this.EndDateError.Text = "此日期必須大於開始日期";
            this.EndDateError.UseWaitCursor = true;
            this.EndDateError.Visible = false;
            // 
            // StartDateError
            // 
            this.StartDateError.AutoSize = true;
            this.StartDateError.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartDateError.ForeColor = System.Drawing.Color.Red;
            this.StartDateError.Location = new System.Drawing.Point(610, 149);
            this.StartDateError.Name = "StartDateError";
            this.StartDateError.Size = new System.Drawing.Size(173, 17);
            this.StartDateError.TabIndex = 20;
            this.StartDateError.Text = "此日期必須小於結束日期";
            this.StartDateError.UseWaitCursor = true;
            this.StartDateError.Visible = false;
            // 
            // car_tax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 652);
            this.Controls.Add(this.StartDateError);
            this.Controls.Add(this.EndDateError);
            this.Controls.Add(this.labelfrom);
            this.Controls.Add(this.labelto);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.errorlabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.errorlabel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.motorcc);
            this.Controls.Add(this.CarType);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "car_tax";
            this.Text = "car_tax";
            this.Load += new System.EventHandler(this.car_tax_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox CarType;
        private System.Windows.Forms.ComboBox motorcc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label errorlabel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label errorlabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelto;
        private System.Windows.Forms.Label labelfrom;
        private System.Windows.Forms.Label EndDateError;
        private System.Windows.Forms.Label StartDateError;
    }
}