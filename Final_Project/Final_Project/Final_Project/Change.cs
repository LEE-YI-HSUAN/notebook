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
    public partial class Change : Form
    {
        string date = "";
        string add = "";
        Form1 form1 = new Form1();
        int num_Rad = 0;
        public Change()
        {
            InitializeComponent();
        }
        //將事件內容轉成想要形式並輸出在對應位置
        public void outItem(string D)
        {
            int i;
            if (D.StartsWith("::標題::"))
            {
                D = D.Replace("::標題::", "");
                tbx_tile.Text = D;
            }
            if (D.StartsWith("::活動時間::整天"))
            {
                rbt_AllDay.Checked = true;
            }
            if (D.StartsWith("::活動時間::開始時間"))
            {
                rbt_AllDay.Checked = false;
                D = D.Replace("::活動時間::開始時間", "");
                D = D.Replace("點", " ");
                D = D.Replace("分", " ");
                D = D.Replace("年", " ");
                D = D.Replace("月", " ");
                D = D.Replace(" ~ ", "");
                D = D.Replace("日", " ");
                string[] Da = new string[7];
                Da = D.Split(' ');
                for (i = 3; i < 7; i++)
                    if (Da[i] == "00") Da[i] = "0";
                cbx_starHour.SelectedIndex = Convert.ToInt32(Da[3]);
                cbx_endHour.SelectedIndex = Convert.ToInt32(Da[5]);
                cbx_starMin.SelectedIndex = Convert.ToInt32(Da[4]) / 5;
                cbx_endMin.SelectedIndex = Convert.ToInt32(Da[6]) / 5;
            }
            if (D.StartsWith("::備註::"))
            {
                D = D.Replace("::備註::", "");
                rtb_Remarks.Text = D;
            }
        }
        //將事件處裡後放入comboBox

        public void changeDayitem()
        {
            cbx_Item.Items.Clear();
            date = monthCalendar1.SelectionStart.ToString();
            date = form1.change_Date_format(date);
            StreamReader rfile = new StreamReader(@"C:\Temp\thing.txt");
            string D = rfile.ReadLine();
            string d = null;
            d = "*/\\*" + date + "*/\\*";
            while (D != null)
            {
                if (D == d)   
                    break;
                else D = rfile.ReadLine();
            }
            while (D != "*/\\**/\\*" && D != null)
            {
                D = rfile.ReadLine();
                if (D == "*/\\**/\\*")
                    break;
                if (D.StartsWith("::活動時間::整天"))
                {
                    add = "";
                    D = D.Replace("::活動時間::", "");
                    D = D.Replace(date, "");
                    add += D + ' ';
                }
                if (D.StartsWith("::活動時間::開始時間"))
                {
                    add = "";
                    D = D.Replace("::活動時間::開始時間", "");
                    D = D.Replace(date, "");
                    add += D + ' ';
                }
                else if (D.StartsWith("::標題::"))
                {
                    D = D.Replace("::標題::", "");
                    add += D + ' ';
                }
                else if (D.StartsWith("::備註::"))
                {
                    D = D.Replace("::備註::", "備註");
                    if (D == "備註") add += D + ":無";
                    add += D;
                    cbx_Item.Items.Add(add);
                }
            }
            rfile.Close();
        }
        //將txt更新，I為開始刪除位置，i為刪除行數。
        public void changetxt(int i,int I)
        {
            //將該事件刪除
            List<string> lines = new List<string>(File.ReadAllLines(@"C:\Temp\thing.txt"));
            for (int j = 0; j <= i; j++) lines.RemoveAt(I);
            //插入更新後事件
            if(cbx_Item.Items.Count == 1)  
            {
                lines.Insert(I, "*/\\*" + date + "*/\\*");
                if (rbt_AllDay.Checked == true) lines.Insert(++I, "::活動時間::整天" + date);
                else lines.Insert(++I, "::活動時間::開始時間" + date + cbx_starHour.SelectedItem.ToString() + "點" + cbx_starMin.SelectedItem.ToString() + "分 ~ " + cbx_endHour.SelectedItem.ToString() + "點" + cbx_endMin.SelectedItem.ToString() + "分");
            }
            else
            {
                if (rbt_AllDay.Checked == true) lines.Insert(I, "::活動時間::整天" + date);
                else lines.Insert(I, "::活動時間::開始時間" + date + cbx_starHour.SelectedItem.ToString() + "點" + cbx_starMin.SelectedItem.ToString() + "分 ~ " + cbx_endHour.SelectedItem.ToString() + "點" + cbx_endMin.SelectedItem.ToString() + "分");
            }
            lines.Insert(++I, "::標題::" + tbx_tile.Text.ToString());
            lines.Insert(++I, "::備註::" + rtb_Remarks.Text.ToString());
            if (cbx_Item.SelectedIndex == cbx_Item.Items.Count - 1) lines.Insert(++I, "*/\\**/\\*");
            else lines.Insert(++I, "????~~~~");
            File.WriteAllLines(@"C:\Temp\thing.txt", lines.ToArray());
            MessageBox.Show("更改成功");
        }
        private void btn_cancal_Click(object sender, EventArgs e)
        {
            Reconfirm reconfirm = new Reconfirm();
            //如果確定刪除
            if (reconfirm.ShowDialog() == DialogResult.OK)
            {
                date = monthCalendar1.SelectionStart.ToString();
                date = form1.change_Date_format(date);
                int i = 0; int I = 0;
                string D; string d = "*/\\*" + date + "*/\\*";
                int num = 0;
                //如果項目只有一項，直接刪掉就好
                if (cbx_Item.Items.Count == 1)
                {
                    StreamReader rfile = new StreamReader(@"C:\Temp\thing.txt");
                    D = rfile.ReadLine();
                    while (D != null)
                    {
                        if (D == d)
                        {
                            D = rfile.ReadLine();
                            i++;
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
                    List<string> lines = new List<string>(File.ReadAllLines(@"C:\Temp\thing.txt"));
                    for (int j = 0; j <= i; j++) lines.RemoveAt(I);
                    File.WriteAllLines(@"C:\Temp\thing.txt", lines.ToArray());
                }
                //如果項目有兩個以上，要先找出項目位置，用num計算
                else
                {
                    StreamReader rfile = new StreamReader(@"C:\Temp\thing.txt");
                    D = rfile.ReadLine();
                    i = 0; I = 0; d = "*/\\*" + date + "*/\\*";
                    while (D != null)
                    {
                        I++;
                        if (D == d) break;
                        D = rfile.ReadLine();
                    }
                    while (D != "*/\\**/\\*" && D != null)
                    {
                        D = rfile.ReadLine();
                        if (D == "????~~~~") num++;
                        I++;
                        if (num == cbx_Item.SelectedIndex) break;
                        //if (D == "*/\\**/\\*") break;
                    }
                    if (cbx_Item.SelectedIndex == 0 || cbx_Item.SelectedIndex == cbx_Item.Items.Count - 1) I--;
                    while (D != "*/\\**/\\*" && D != null)
                    {
                        D = rfile.ReadLine(); i++;
                        if (D == "*/\\**/\\*" || D == "????~~~~") break;
                    }
                    rfile.Close();
                    List<string> lines = new List<string>(File.ReadAllLines(@"C:\Temp\thing.txt"));
                    if (cbx_Item.SelectedIndex == 0) //要將????~~~~刪除
                    {
                        for (int j = 0; j <= i; j++) lines.RemoveAt(I);
                    }
                    else
                    {
                        for (int j = 0; j < i; j++) lines.RemoveAt(I);
                    }
                    File.WriteAllLines(@"C:\Temp\thing.txt", lines.ToArray());
                }
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            date = monthCalendar1.SelectionStart.ToString();
            date = form1.change_Date_format(date);
            string D; string d = "*/\\*" + date + "*/\\*";
            int I = 0; int i = 0;
            if (cbx_Item.Items.Count == 1)
            {
                StreamReader rfile = new StreamReader(@"C:\Temp\thing.txt");
                D = rfile.ReadLine();
                while (D != null)
                {
                    if (D == d) break;
                    D = rfile.ReadLine();
                    I++;
                }
                while (D != "*/\\**/\\*" && D != null)
                {
                    D = rfile.ReadLine();
                    if (D == "*/\\**/\\*")
                    {
                        i++;
                        break;
                    }
                    i++;
                }
                rfile.Close();
                if (rbt_AllDay.Checked != true && (cbx_starHour.SelectedItem == null || cbx_starMin.SelectedItem == null || cbx_endMin.SelectedItem == null || cbx_starMin.SelectedItem == null))
                    MessageBox.Show("請選擇完整時間");
                else
                {
                    changetxt(i, I);
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                StreamReader rfile = new StreamReader(@"C:\Temp\thing.txt");
                D = rfile.ReadLine();int  num = 0;
                i = 0; I = 0; d = "*/\\*" + date + "*/\\*";
                while (D != null)
                {
                    I++;
                    if (D == d) break;
                    D = rfile.ReadLine();
                }
                while (D != "*/\\**/\\*" && D != null)
                {
                    D = rfile.ReadLine();
                    if (num == cbx_Item.SelectedIndex) break;
                    if (D == "????~~~~") num++;
                    I++;
                }
                while (D != "*/\\**/\\*" && D != null)
                {
                    D = rfile.ReadLine(); i++;
                    if (D == "*/\\**/\\*" || D == "????~~~~") break;
                }
                rfile.Close();
                if (rbt_AllDay.Checked != true && (cbx_starHour.SelectedItem == null || cbx_starMin.SelectedItem == null || cbx_endMin.SelectedItem == null || cbx_starMin.SelectedItem == null))
                    MessageBox.Show("請選擇完整時間");
                else
                {
                    changetxt(i, I);
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            changeDayitem();
        }

        private void Change_Load(object sender, EventArgs e)
        {
            changeDayitem();

            num_Rad = 0; //用這個奇偶來判斷radioButton true or false
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

        private void button1_Click(object sender, EventArgs e)
        {
            Reconfirm reconfirm = new Reconfirm();
            //確定不更改後就離開
            if (reconfirm.ShowDialog() == DialogResult.OK)
                this.Close();
        }

        private void cbx_Item_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Date = monthCalendar1.SelectionStart.ToString();
            int i = 0;
            string s = "";
            while (Date[i] != ' ')
            {
                s += Date[i];
                i++;
            }
            string[] da = new string[5];
            da = s.Split('/');
            date = null;
            date = monthCalendar1.SelectionStart.ToString();
            date = form1.change_Date_format(date);
            string D; string d = "*/\\*" + date + "*/\\*";
            if (cbx_Item.Items.Count == 1)
            {
                StreamReader rfile = new StreamReader(@"C:\Temp\thing.txt");
                D = rfile.ReadLine();
                while (D != null)
                {
                    if (D == d)   //找到日期後更改並跳出
                    {
                        D = rfile.ReadLine();
                        dtp_AllDay.Value = new DateTime(Convert.ToInt32(da[0]), Convert.ToInt32(da[1]), Convert.ToInt32(da[2]));
                        break;
                    }
                    else D = rfile.ReadLine();
                }
                while (D != "*/\\**/\\*" && D != null)
                {
                    if (D == "*/\\**/\\*") break;  //事件結束後就離開
                    outItem(D);
                    D = rfile.ReadLine();
                }
                rfile.Close();
            }
            else
            {
                StreamReader rfile = new StreamReader(@"C:\Temp\thing.txt");
                D = rfile.ReadLine(); int num = 0;
                d = "*/\\*" + date + "*/\\*";
                while (D != null)
                {
                    if (D == d) break;
                    D = rfile.ReadLine();
                }
                while (D != "*/\\**/\\*" && D != null)
                {
                    D = rfile.ReadLine();
                    if (D == "????~~~~") num++;
                    if (num == cbx_Item.SelectedIndex) break;
                }
                while (D != "*/\\**/\\*" && D != null)
                {
                    outItem(D);
                    D = rfile.ReadLine();
                    if (D == "*/\\**/\\*" || D == "????~~~~") break;
                }
                rfile.Close();
            }
        }

        private void rbt_AllDay_CheckedChanged(object sender, EventArgs e)
        {
            //rbt_AllDay被選取就將時間隱藏
            if (rbt_AllDay.Checked == true)
            {
                cbx_endHour.Visible = false;
                cbx_starHour.Visible = false;
                cbx_starMin.Visible = false;
                cbx_endMin.Visible = false;
                //dtp_AllDay.Visible = true;
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
                //dtp_AllDay.Visible = false;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }
        }

        private void rbt_AllDay_Click(object sender, EventArgs e)
        {
            if (num_Rad % 2 == 1) rbt_AllDay.Checked = false;
            else rbt_AllDay.Checked = true;
            num_Rad++;
        }
    }
}
