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
    public partial class Record_thing : Form
    {
        public Record_thing()
        {
            InitializeComponent();
        }
        int num_Rad;
        string[] re = new string[500];
        //刪除事件
        public void delinformation(int i,int I)
        {
            List<string> lines = new List<string>(File.ReadAllLines(@"C:\Temp\thing.txt"));
            for (int j = 0; j <= i; j++) lines.RemoveAt(I);
            //刪除空白的行
            for(int j  = 0;j < lines.Count;j++)
            {
                if (lines[j] == "") lines.RemoveAt(j);
            }
            File.WriteAllLines(@"C:\Temp\thing.txt", lines.ToArray());
        }
        //寫入事件
        public void inputinformation(string[] re,string A,int i)
        {
            StreamWriter wfile = File.AppendText(@"C:\Temp\thing.txt");
            wfile.WriteLine("*/\\*" + dtp_AllDay.Text.ToString() + "*/\\*");
            if (rbt_AllDay.Checked == true) wfile.WriteLine("::活動時間::整天" + dtp_AllDay.Text.ToString());
            else wfile.WriteLine("::活動時間::開始時間" + dtp_AllDay.Text.ToString() + cbx_starHour.SelectedItem.ToString() + "點" + cbx_starMin.SelectedItem.ToString() + "分 ~ " + cbx_endHour.SelectedItem.ToString() + "點" + cbx_endMin.SelectedItem.ToString() + "分");
            wfile.WriteLine("::標題::" + tbx_tile.Text.ToString());
            wfile.WriteLine("::備註::" + rtb_Remarks.Text.ToString());
            wfile.WriteLine(A);
            for (int j = 0; j <= i; j++) wfile.WriteLine(re[j]);
            wfile.Close();
            MessageBox.Show("儲存成功");
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void but_cancal_Click(object sender, EventArgs e)
        {
            Reconfirm reconfirm = new Reconfirm();
            //確認後就離開
            if (reconfirm.ShowDialog() == DialogResult.OK)
                this.DialogResult = DialogResult.Cancel;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int i = 0; int I = 0; bool a = false;
            string D;
            string d = null;
            //標題要有內容
            if (tbx_tile.Text != "")
            {
                StreamReader rfile = new StreamReader(@"C:\Temp\thing.txt");
                D = rfile.ReadLine();
                d = "*/\\*" + dtp_AllDay.Text.ToString() + "*/\\*";
                while (D != null)
                {
                    if (D == d)
                    {
                        a = true;
                        break;
                    }
                    else D = rfile.ReadLine();
                    I++;
                }
                while (D != "*/\\**/\\*" && D != null)
                {
                    D = rfile.ReadLine();
                    re[i] = D;
                    if (D == "*/\\**/\\*")
                    {
                        i++;
                        break;
                    }
                    i++;
                }
                rfile.Close();
                //若未選擇整天，一定要有時間
                if(rbt_AllDay.Checked != true && (cbx_starHour.SelectedItem == null || cbx_starMin.SelectedItem == null || cbx_endMin.SelectedItem == null || cbx_starMin.SelectedItem == null))
                    MessageBox.Show("請選擇完整時間");
                else
                {
                    if (a == true)
                    {
                        delinformation(i, I);
                        inputinformation(re, "????~~~~", i);
                    }
                    else inputinformation(re, "*/\\**/\\*", i);
                    tbx_tile.Text = "";
                    rtb_Remarks.Text = "";
                }
            }
            else MessageBox.Show("請輸入標題");
        }

        private void rbt_AllDay_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbt_AllDay_Click(object sender, EventArgs e)
        {
            if (num_Rad % 2 == 1) rbt_AllDay.Checked = false;
            else rbt_AllDay.Checked = true;
            if (rbt_AllDay.Checked == true)
            {
                cbx_endHour.Visible = false;
                cbx_starHour.Visible = false;
                cbx_starMin.Visible = false;
                cbx_endMin.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }
            else
            {
                cbx_endHour.Visible = true;
                cbx_starHour.Visible = true;
                cbx_starMin.Visible = true;
                cbx_endMin.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }
            num_Rad++;
        }

        private void Record_thing_Load(object sender, EventArgs e)
        {
            num_Rad = 1;
            rbt_AllDay.Checked = false;
            for (int i = 0; i <= 23; i++)
            {
                cbx_starHour.Items.Add(i);
                cbx_endHour.Items.Add(i);
            }
            for (int i = 0; i < 60; i += 5)
            {
                if (i < 10)
                {
                    cbx_starMin.Items.Add("0" + i);
                    cbx_endMin.Items.Add("0" + i);
                }
                else
                {
                    cbx_starMin.Items.Add(i);
                    cbx_endMin.Items.Add(i);
                }
            }
           
        }

    }
}
