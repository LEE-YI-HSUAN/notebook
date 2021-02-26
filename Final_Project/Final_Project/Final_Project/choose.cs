using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class choose : Form
    {
        public choose()
        {
            InitializeComponent();
        }
        Form1 form1 = new Form1();
        private void btn_newThing_Click(object sender, EventArgs e)
        {
            Record_thing Record_thing = new Record_thing();
            Record_thing.ShowDialog();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_changeMoney_Click(object sender, EventArgs e)
        {
            Record_money record_Money = new Record_money();
            record_Money.ShowDialog();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_changeThing_Click(object sender, EventArgs e)
        {
            Change change = new Change();
            change.ShowDialog();
            this.DialogResult = DialogResult.Cancel;
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void choose_Load(object sender, EventArgs e)
        {
        }
        //monthCalendar1.SelectionStart.ToString();
    }
}
