using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public string date;
        public Form1()
        {
            InitializeComponent();
        }
        //顯示monry.txt內容
        public void Showinformation_money()
        {
            StreamReader rfile = new StreamReader(@"C:\Temp\Money.txt");
            string D = rfile.ReadLine();
            string d = null;
            d = "*/\\*" + date + "*/\\*";
            //找到何選擇日期相同就跳出
            while (D != null)
            {
                if (D == d) break;
                else D = rfile.ReadLine();
            }
            //選擇日期記帳結束就跳出
            while (D != "*/\\**/\\*" && D != null)
            {
                D = rfile.ReadLine();
                if (D != "*/\\**/\\*") rtb_account.Text += D + '\n'; //將內容逐行輸出
                if (D == "*/\\**/\\*") break;
            }
            rfile.Close();
        }
        //將日期改成想要的格式
        public string change_Date_format(string Date)
        {
            int i = 0; date = null;
            while (Date[i] != ' ')
            {
                date += Date[i];
                i++;
            }
            string[] D = new string[3];
            D = date.Split('/');
            date = null;
            date = D[0] + "年" + D[1] + "月" + D[2] + "日";
            return date;
        }
        //顯示thing.txt內容
        public void Showinformation_thing()
        {
            StreamReader rfile = new StreamReader(@"C:\Temp\thing.txt");
            string D = rfile.ReadLine();
            string d = null;
            d = "*/\\*" + date + "*/\\*";
            string re;
            while (D != null)
            {
                if (D == d) break;
                else D = rfile.ReadLine();
            }
            while (D != "*/\\**/\\*" && D != null)
            {
                D = rfile.ReadLine();
                if (D == "*/\\**/\\*") break;
                re = D;
                //將內容換成想要形式並輸出
                if (re.StartsWith("::活動時間::整天"))  
                {
                    re = re.Replace("::活動時間::", "");
                    re = re.Replace(label3.Text, "");
                    rtb_thing.Text += re + ' ';
                }
                if (re.StartsWith("::活動時間::開始時間"))
                {
                    re = re.Replace("::活動時間::開始時間", "");
                    re = re.Replace(label3.Text, "");
                    rtb_thing.Text += re + ' ';
                }
                else if (re.StartsWith("::標題::"))
                {
                    re = re.Replace("::標題::", "");
                    rtb_thing.Text += re + '\n';
                }
                else if (re.StartsWith("::備註::"))
                {
                    re = re.Replace("::備註::", "備註");
                    if (re == "備註") re += ":無";
                    rtb_thing.Text += re + '\n';
                    rtb_thing.Text += '\n';
                }
            }
            rfile.Close();
        }
        private void btn_addandchange_Click(object sender, EventArgs e)
        {
            choose Choose = new choose();
            Choose.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string fileName = @"C:\Temp\thing.txt";
            FileInfo fileInfo = new FileInfo(fileName);
            //如果沒有資料夾就創一個
            if (fileInfo.Directory.Exists == false)
                fileInfo.Directory.Create();
            //創thing.txt
            FileStream mystream = new FileStream(fileName, FileMode.OpenOrCreate);
            //StreamWriter Mything = new StreamWriter(mystream, Encoding.Default);
            mystream.Close();
            //創thing.txt
            fileName = @"C:\Temp\Money.txt";
            mystream = new FileStream(fileName, FileMode.OpenOrCreate);
            //StreamWriter Mymoney = new StreamWriter(mystream, Encoding.Default);
            mystream.Close();
            
            date = monthCalendar1.SelectionStart.ToString();
            date = change_Date_format(date);
            label3.Text = date;

            Showinformation_money();
            Showinformation_thing();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            rtb_account.Text = null;
            rtb_thing.Text = null;
            date = monthCalendar1.SelectionStart.ToString();
            date = change_Date_format(date);
            label3.Text = date;
            Showinformation_money();
            Showinformation_thing();
        }

        private void rtb_thing_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
