namespace Final_Project
{
    partial class Change
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cbx_Item = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancal = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.cbx_endHour = new System.Windows.Forms.ComboBox();
            this.cbx_endMin = new System.Windows.Forms.ComboBox();
            this.cbx_starMin = new System.Windows.Forms.ComboBox();
            this.cbx_starHour = new System.Windows.Forms.ComboBox();
            this.dtp_AllDay = new System.Windows.Forms.DateTimePicker();
            this.rtb_Remarks = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_tile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbt_AllDay = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 4);
            this.monthCalendar1.Location = new System.Drawing.Point(18, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // cbx_Item
            // 
            this.cbx_Item.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_Item.FormattingEnabled = true;
            this.cbx_Item.Location = new System.Drawing.Point(352, 55);
            this.cbx_Item.Name = "cbx_Item";
            this.cbx_Item.Size = new System.Drawing.Size(435, 30);
            this.cbx_Item.TabIndex = 9;
            this.cbx_Item.SelectedIndexChanged += new System.EventHandler(this.cbx_Item_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(476, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "選擇想更動的事項";
            // 
            // btn_cancal
            // 
            this.btn_cancal.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancal.Location = new System.Drawing.Point(791, 518);
            this.btn_cancal.Name = "btn_cancal";
            this.btn_cancal.Size = new System.Drawing.Size(116, 51);
            this.btn_cancal.TabIndex = 11;
            this.btn_cancal.Text = "刪除";
            this.btn_cancal.UseVisualStyleBackColor = true;
            this.btn_cancal.Click += new System.EventHandler(this.btn_cancal_Click);
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_change.Location = new System.Drawing.Point(791, 461);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(116, 51);
            this.btn_change.TabIndex = 12;
            this.btn_change.Text = "儲存";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // cbx_endHour
            // 
            this.cbx_endHour.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_endHour.FormattingEnabled = true;
            this.cbx_endHour.Location = new System.Drawing.Point(432, 285);
            this.cbx_endHour.Name = "cbx_endHour";
            this.cbx_endHour.Size = new System.Drawing.Size(44, 30);
            this.cbx_endHour.TabIndex = 48;
            // 
            // cbx_endMin
            // 
            this.cbx_endMin.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_endMin.FormattingEnabled = true;
            this.cbx_endMin.Location = new System.Drawing.Point(509, 285);
            this.cbx_endMin.Name = "cbx_endMin";
            this.cbx_endMin.Size = new System.Drawing.Size(44, 30);
            this.cbx_endMin.TabIndex = 47;
            // 
            // cbx_starMin
            // 
            this.cbx_starMin.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_starMin.FormattingEnabled = true;
            this.cbx_starMin.Location = new System.Drawing.Point(510, 229);
            this.cbx_starMin.Name = "cbx_starMin";
            this.cbx_starMin.Size = new System.Drawing.Size(44, 30);
            this.cbx_starMin.TabIndex = 46;
            // 
            // cbx_starHour
            // 
            this.cbx_starHour.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_starHour.FormattingEnabled = true;
            this.cbx_starHour.Location = new System.Drawing.Point(431, 229);
            this.cbx_starHour.Name = "cbx_starHour";
            this.cbx_starHour.Size = new System.Drawing.Size(44, 30);
            this.cbx_starHour.TabIndex = 45;
            // 
            // dtp_AllDay
            // 
            this.dtp_AllDay.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_AllDay.Location = new System.Drawing.Point(352, 150);
            this.dtp_AllDay.Name = "dtp_AllDay";
            this.dtp_AllDay.Size = new System.Drawing.Size(170, 30);
            this.dtp_AllDay.TabIndex = 44;
            // 
            // rtb_Remarks
            // 
            this.rtb_Remarks.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtb_Remarks.Location = new System.Drawing.Point(352, 353);
            this.rtb_Remarks.Name = "rtb_Remarks";
            this.rtb_Remarks.Size = new System.Drawing.Size(416, 217);
            this.rtb_Remarks.TabIndex = 43;
            this.rtb_Remarks.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(351, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 22);
            this.label10.TabIndex = 42;
            this.label10.Text = "備註";
            // 
            // tbx_tile
            // 
            this.tbx_tile.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_tile.Location = new System.Drawing.Point(426, 106);
            this.tbx_tile.Name = "tbx_tile";
            this.tbx_tile.Size = new System.Drawing.Size(345, 30);
            this.tbx_tile.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(349, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 22);
            this.label9.TabIndex = 40;
            this.label9.Text = "標題";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(556, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(558, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 22);
            this.label7.TabIndex = 38;
            this.label7.Text = "分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(479, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "點";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(479, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "點";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(351, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "結束時間";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(349, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "開始時間";
            // 
            // rbt_AllDay
            // 
            this.rbt_AllDay.AutoSize = true;
            this.rbt_AllDay.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_AllDay.Location = new System.Drawing.Point(352, 188);
            this.rbt_AllDay.Name = "rbt_AllDay";
            this.rbt_AllDay.Size = new System.Drawing.Size(65, 26);
            this.rbt_AllDay.TabIndex = 33;
            this.rbt_AllDay.TabStop = true;
            this.rbt_AllDay.Text = "整天";
            this.rbt_AllDay.UseVisualStyleBackColor = true;
            this.rbt_AllDay.CheckedChanged += new System.EventHandler(this.rbt_AllDay_CheckedChanged);
            this.rbt_AllDay.Click += new System.EventHandler(this.rbt_AllDay_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(791, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 51);
            this.button1.TabIndex = 49;
            this.button1.Text = "放棄更動";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_endHour);
            this.Controls.Add(this.cbx_endMin);
            this.Controls.Add(this.cbx_starMin);
            this.Controls.Add(this.cbx_starHour);
            this.Controls.Add(this.dtp_AllDay);
            this.Controls.Add(this.rtb_Remarks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_tile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbt_AllDay);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_cancal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_Item);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change";
            this.Load += new System.EventHandler(this.Change_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cbx_Item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancal;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.ComboBox cbx_endHour;
        private System.Windows.Forms.ComboBox cbx_endMin;
        private System.Windows.Forms.ComboBox cbx_starMin;
        private System.Windows.Forms.ComboBox cbx_starHour;
        private System.Windows.Forms.DateTimePicker dtp_AllDay;
        private System.Windows.Forms.RichTextBox rtb_Remarks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_tile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbt_AllDay;
        private System.Windows.Forms.Button button1;
    }
}