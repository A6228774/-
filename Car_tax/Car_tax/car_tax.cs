using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Car_tax
{
    public partial class car_tax : Form
    {
        public car_tax()
        {
            InitializeComponent();
        }
        private void car_tax_Load(object sender, EventArgs e)
        {
            init_form();
        }
        private void WholeYear_Countrbt(object sender, EventArgs e)
        {
            init_form();
        }
        private void Period_Countrbt(object sender, EventArgs e)
        {
            this.dateTimePicker1.Visible = true;
            this.dateTimePicker2.Visible = true;
            this.dateTimePicker1.Enabled = true;
            this.dateTimePicker2.Enabled = true;
            this.labelfrom.Visible = true;
            this.labelto.Visible = true;

        }
        private void Clear_ButtonClick(object sender, EventArgs e)
        {
            init_form();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (this.dateTimePicker1.Value > this.dateTimePicker2.Value)
            {
                this.StartDateError.Visible = true;
                this.button1.Enabled = false;
            }
            else
            {
                this.StartDateError.Visible = false;
                this.button1.Enabled = true;
            }
                
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (this.dateTimePicker2.Value < this.dateTimePicker1.Value)
            {
                this.EndDateError.Visible = true;
                this.button1.Enabled = false;
            }
            else
            {
                this.EndDateError.Visible = false;
                this.button1.Enabled = true;
            }
        }
        private void Car_IndexChanged(object sender, EventArgs e)
        {
            this.motorcc.Items.Clear();
            this.motorcc.Enabled = true;
            this.errorlabel1.Visible = false;

            if (CarType.SelectedItem == "機車")
            {
                this.motorcc.Items.AddRange(motorbikecc);
            }
            else if (CarType.SelectedItem == "貨車" || CarType.SelectedItem == "大客車")
            {
                this.motorcc.Items.AddRange(bigcarcc);
            }
            else if (CarType.SelectedItem == "自用小客車" || CarType.SelectedItem == "營業用小客車")
            {
                this.motorcc.Items.AddRange(smallcarcc);
            }
            else
            {
                this.motorcc.Enabled = false;
                this.motorcc.Text = "請下拉選單選擇CC數";
            }
        }
        private void motorcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.errorlabel2.Visible = false;
        }
        private void taxCalculate_Click(object sender, EventArgs e)
        {
            decimal period = 0;
            decimal tax = (decimal)tax_calculation();
            decimal result = period * tax;
            result = Math.Truncate(result);


            if (this.radioButton2.Checked)
            {
                this.dateTimePicker1.Enabled = true;
                this.dateTimePicker2.Enabled = true;

                if (this.CarType.SelectedIndex == 0)
                {
                    this.textBox1.Text = "輸入無效，請重新輸入各項資料";
                    this.errorlabel1.Visible = true;
                }

                else if (this.motorcc.SelectedIndex == -1)
                {
                    this.textBox1.Text = "輸入無效，請重新輸入各項資料";
                    this.errorlabel2.Visible = true;
                    this.errorlabel1.Visible = false;
                }

                else
                {
                    this.errorlabel1.Visible = false;
                    this.errorlabel2.Visible = false;

                    DateTime startDate = dateTimePicker1.Value;
                    DateTime endDate = dateTimePicker2.Value;
                    int ts_year = endDate.Year - startDate.Year;
                    int days = endDate.Subtract(startDate).Days;
                    DateTime dateStamp = startDate;

                    bool bReachEndDate = false;
                    ArrayList total_result = new ArrayList();

                    this.textBox1.Text = string.Empty;

                    while (! bReachEndDate)
                    {
                        DateTime firstDate;
                        DateTime lastDate;
                        int y;
                        int m;
                        int d;

                        firstDate = dateStamp;

                        if (dateStamp.Year < endDate.Year)
                        {
                            y = dateStamp.Year;
                            m = 12;
                            d = 31;
                            lastDate = new DateTime(y, m, d);

                            y = dateStamp.Year + 1;
                            m = 1;
                            d = 1;
                            dateStamp = new DateTime(y, m, d);
                        }
                        else
                        {
                            lastDate = endDate;
                            bReachEndDate = true;
                        }

                        int YearDaysCount;
                        if (DateTime.IsLeapYear(firstDate.Year) == true)
                        {
                            YearDaysCount = 366;
                        }
                        else
                        {
                            YearDaysCount = 356;
                        }
                        int daysCount = lastDate.Subtract(firstDate).Days;
                        period = daysCount + 1;
                        result = period * (tax / (YearDaysCount));
                        result = Math.Truncate(result);

                        this.textBox1.Text += $"使用期間: {firstDate.ToLongDateString()} 至 " +
                                              $"{lastDate.ToLongDateString()}" + Environment.NewLine +
                                              $"計算天數: {daysCount + 1}" + Environment.NewLine +
                                              $"用途: {this.CarType.Text}" + Environment.NewLine +
                                              $"汽缸CC數: { this.motorcc.Text}" + Environment.NewLine +
                                              $"計算公式: {tax} / {YearDaysCount} * {daysCount + 1} = {result}" + Environment.NewLine +
                                              $"應納税額: 共 {result} 元" + Environment.NewLine + Environment.NewLine;
                        total_result.Add(result);
                    }

                    decimal sum = 0;
                    foreach (decimal item in total_result)
                    {
                        sum = sum + item;
                    }
                    this.textBox1.Text += $"全部應納税額: 共 {sum} 元";
                }
            }
            else
            {
                period = 1;


                if (this.CarType.SelectedIndex == 0)
                {
                    this.textBox1.Text = "輸入無效，請重新輸入各項資料";
                    this.errorlabel1.Visible = true;
                }

                else if (this.motorcc.SelectedIndex == -1)
                {
                    this.textBox1.Text = "輸入無效，請重新輸入各項資料";
                    this.errorlabel2.Visible = true;
                    this.errorlabel1.Visible = false;
                }

                else
                {
                    this.errorlabel2.Visible = false;
                    this.errorlabel1.Visible = false;

                    DateTime wholeYear_s = new DateTime(DateTime.Now.Year, 1, 1);
                    DateTime wholeYear_e = new DateTime(DateTime.Now.Year, 12, 31);

                    result = period * tax;
                    result = Math.Truncate(result);

                    this.textBox1.Text = $"使用期間: {wholeYear_s.ToLongDateString()} 至 " +
                                         $"{wholeYear_e.ToLongDateString()}" + Environment.NewLine +
                                         $"計算天數: 全年度" + Environment.NewLine +
                                         $"用途: {this.CarType.Text}" + Environment.NewLine +
                                         $"汽缸CC數: { this.motorcc.Text}" + Environment.NewLine +
                                         $"計算公式: {tax} / 365 * 365 = {result}" + Environment.NewLine +
                                         $"應納税額: 共 {result} 元";
                }
            }
        }


        #region
        private void init_form()
        {
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker2.Visible = false;
            this.dateTimePicker1.Value = DateTime.Today;
            this.dateTimePicker1.Value = DateTime.Today;
            this.CarType.SelectedIndex = 0;
            this.motorcc.Enabled = false;
            this.textBox1.Text = string.Empty;
            this.errorlabel2.Visible = false;
            this.errorlabel1.Visible = false;
            this.EndDateError.Visible = false;
            this.StartDateError.Visible = false;
            this.labelfrom.Visible = false;
            this.labelto.Visible = false;
            this.radioButton1.Checked = true;
        }

        public string[] motorbikecc = new string[]
        {
           "150cc 以下",
           "151cc~ 250cc",
           "251cc~ 500cc",
           "501cc~ 600cc",
           "601cc~1200cc",
           "1201cc~1800cc",
           "1801cc 以上",
        };

        public string[] bigcarcc = new string[]
        {
            "500cc 以下",
            "501cc - 600cc",
            "601cc - 1200cc",
            "1201cc - 1800cc",
            "1801cc - 2400cc",
            "2401cc - 3000cc",
            "3001cc~3600cc",
            "3601cc~4200cc",
            "4201cc~4800cc",
            "4801cc~5400cc",
            "5401cc~6000cc",
            "6001cc~6600cc",
            "6601cc~7200cc",
            "7201cc~7800cc",
            "7801cc~8400cc",
            "8401cc~9000cc",
            "9001cc~9600cc",
            "9601cc~10200cc",
            "10201cc 以上",
        };

        public string[] smallcarcc = new string[]
        {
            "500cc 以下",
            "501cc - 600cc",
            "601cc - 1200cc",
            "1201cc - 1800cc",
            "1801cc - 2400cc",
            "2401cc - 3000cc",
            "3001cc - 4200cc",
            "4201cc - 5400cc",
            "5401cc - 6600cc",
            "6601cc - 7800cc",
            "7801cc 以上",
        };
        /// <summary> 稅率對照表 </summary>
        private int tax_calculation()
        {
            if (CarType.SelectedItem == "機車")
            {
                string m_tax = this.motorcc.Text;
                switch (m_tax)
                {
                    case "150cc 以下":
                        return 0;
                    case "151cc~ 250cc":
                        return 800;
                    case "251cc~ 500cc":
                        return 1620;
                    case "501cc~ 600cc":
                        return 2160;
                    case "601cc~1200cc":
                        return 4320;
                    case "1201cc~1800cc":
                        return 7120;
                    case "1801cc 以上":
                        return 11230;
                    default:
                        return 0;
                }
            }
            else if (CarType.SelectedItem == "貨車" || CarType.SelectedItem == "大客車")
            {
                string truck = this.motorcc.Text;
                switch (truck)
                {
                    case "500cc 以下":
                        return 900;
                    case "501cc - 600cc":
                        return 1080;
                    case "601cc - 1200cc":
                        return 1800;
                    case "1201cc - 1800cc":
                        return 2700;
                    case "1801cc - 2400cc":
                        return 3600;
                    case "2401cc - 3000cc":
                        return 4500;
                    case "3001cc~3600cc":
                        return 5400;
                    case "3601cc~4200cc":
                        return 6300;
                    case "4201cc~4800cc":
                        return 7200;
                    case "4801cc~5400cc":
                        return 8100;
                    case "5401cc~6000cc":
                        return 9000;
                    case "6001cc~6600cc":
                        return 9900;
                    case "6601cc~7200cc":
                        return 10800;
                    case "7201cc~7800cc":
                        return 11700;
                    case "7801cc~8400cc":
                        return 12600;
                    case "8401cc~9000cc":
                        return 13500;
                    case "9001cc~9600cc":
                        return 14400;
                    case "9601cc~10200cc":
                        return 15300;
                    case "10201cc 以上":
                        return 16200;
                    default:
                        return 0;
                }
            }
            else if (CarType.SelectedItem == "自用小客車")
            {
                string pri_car = this.motorcc.Text;
                switch (pri_car)
                {
                    case "500cc 以下":
                        return 1620;
                    case "501cc - 600cc":
                        return 2160;
                    case "601cc - 1200cc":
                        return 4320;
                    case "1201cc - 1800cc":
                        return 7120;
                    case "1801cc - 2400cc":
                        return 11230;
                    case "2401cc - 3000cc":
                        return 15210;
                    case "3001cc - 4200cc":
                        return 28220;
                    case "4201cc - 5400cc":
                        return 46170;
                    case "5401cc - 6600cc":
                        return 69690;
                    case "6601cc - 7800cc":
                        return 117000;
                    case "7801cc 以上":
                        return 151200;
                    default:
                        return 0;
                }
            }
            else if (CarType.SelectedItem == "營業用小客車")
            {
                string com_car = this.motorcc.Text;
                switch (com_car)
                {
                    case "500cc 以下":
                        return 900;
                    case "501cc - 600cc":
                        return 1260;
                    case "601cc - 1200cc":
                        return 2160;
                    case "1201cc - 1800cc":
                        return 3060;
                    case "1801cc - 2400cc":
                        return 6480;
                    case "2401cc - 3000cc":
                        return 9900;
                    case "3001cc - 4200cc":
                        return 16380;
                    case "4201cc - 5400cc":
                        return 24300;
                    case "5401cc - 6600cc":
                        return 33660;
                    case "6601cc - 7800cc":
                        return 44460;
                    case "7801cc 以上":
                        return 56700;
                    default:
                        return 0;
                }
            }
            else
                return 0;
        }
        /// <returns></returns>
        #endregion
    }

}

