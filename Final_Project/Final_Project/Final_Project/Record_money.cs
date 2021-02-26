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
    public partial class Record_money : Form
    {
       Form1 form1 = new Form1();
        public Record_money()
        {
            InitializeComponent();
        }
        //讀取txt並輸出在richTextBox2
        public void ReadTxt()
        {
            richTextBox2.Text = null;
            StreamReader rfile = new StreamReader(@"C:\Temp\Money.txt");
            string D = rfile.ReadLine(); string d = "*/\\*" + dateTimePicker1.Text.ToString() + "*/\\*";
            while (D != null)
            {
                if (D == d)
                {
                    D = rfile.ReadLine();
                    break;
                }
                D = rfile.ReadLine();
            }
            while (D != "*/\\**/\\*" && D != null)
            {
                richTextBox2.Text += D + '\n';
                D = rfile.ReadLine();
            }
            rfile.Close();
        }

        private void btn_allDel_Click(object sender, EventArgs e)
        {
            Reconfirm reconfirm = new Reconfirm();
            //確定刪除
            if(reconfirm.ShowDialog() == DialogResult.OK)
            {
                StreamReader rfile = new StreamReader(@"C:\Temp\Money.txt");
                int i = 0;int I = 0; bool a = false;
                string D = rfile.ReadLine(); string d = "*/\\*" + dateTimePicker1.Text.ToString() + "*/\\*";
                while (D != null)
                {
                    if (D == d)
                    {
                         D = rfile.ReadLine();
                        i++;
                        a = true;
                        break;
                    }
                    else
                    {
                        D = rfile.ReadLine();
                        I++;
                    }
                }
                while (D != "*/\\**/\\*" && D != null)
                {
                    D = rfile.ReadLine();
                    i++;
                    if (D == "*/\\**/\\*") break;
                }
                rfile.Close();
                //要已有該日期記帳才會走進
                if (a == true)
                {
                    List<string> lines = new List<string>(File.ReadAllLines(@"C:\Temp\Money.txt"));
                    for (int j = 0; j <= i; j++) lines.RemoveAt(I);
                    File.WriteAllLines(@"C:\Temp\Money.txt", lines.ToArray());
                }
                richTextBox2.Text = null;
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            StreamReader rfile = new StreamReader(@"C:\Temp\Money.txt");
            int i = 0; int I = 0; bool a = false;
            string D = rfile.ReadLine(); string d = "*/\\*" + dateTimePicker1.Text.ToString() + "*/\\*";
            while (D != null)
            {
                if (D == d)
                {
                    D = rfile.ReadLine();
                    i++;
                    a = true;
                    break;
                }
                else
                {
                    D = rfile.ReadLine();
                    I++;
                }
            }
            while (D != "*/\\**/\\*" && D != null)
            {
                D = rfile.ReadLine();
                i++;
                if (D == "*/\\**/\\*") break;
            }
            rfile.Close();
            //將那天記帳刪除後重寫
            if (a == true)
            {
                List<string> lines = new List<string>(File.ReadAllLines(@"C:\Temp\Money.txt"));
                for (int j = 0; j <= i; j++) lines.RemoveAt(I);
                File.WriteAllLines(@"C:\Temp\Money.txt", lines.ToArray());
            }
            StreamWriter wfile = File.AppendText(@"C:\Temp\Money.txt");
            wfile.WriteLine("*/\\*" + dateTimePicker1.Text.ToString() + "*/\\*");
            wfile.WriteLine(richTextBox2.Text);
            wfile.WriteLine("*/\\**/\\*");
            wfile.Close();
            MessageBox.Show("儲存成功");
            //this.DialogResult = DialogResult.Cancel;
        }

        private void btn_cancal_Click(object sender, EventArgs e)
        {
            Reconfirm reconfirm = new Reconfirm();
            if (reconfirm.ShowDialog() == DialogResult.OK)
                this.DialogResult = DialogResult.Cancel;
        }

        private void Record_money_Load(object sender, EventArgs e)
        {
            ReadTxt();
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            ReadTxt();
        }
    }
}
