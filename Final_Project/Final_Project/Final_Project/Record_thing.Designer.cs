namespace Final_Project
{
    partial class Record_thing
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
            this.rbt_AllDay = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_tile = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtb_Remarks = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.but_cancal = new System.Windows.Forms.Button();
            this.dtp_AllDay = new System.Windows.Forms.DateTimePicker();
            this.cbx_starHour = new System.Windows.Forms.ComboBox();
            this.cbx_starMin = new System.Windows.Forms.ComboBox();
            this.cbx_endMin = new System.Windows.Forms.ComboBox();
            this.cbx_endHour = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rbt_AllDay
            // 
            this.rbt_AllDay.AutoSize = true;
            this.rbt_AllDay.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbt_AllDay.Location = new System.Drawing.Point(33, 109);
            this.rbt_AllDay.Name = "rbt_AllDay";
            this.rbt_AllDay.Size = new System.Drawing.Size(65, 26);
            this.rbt_AllDay.TabIndex = 2;
            this.rbt_AllDay.TabStop = true;
            this.rbt_AllDay.Text = "整天";
            this.rbt_AllDay.UseVisualStyleBackColor = true;
            this.rbt_AllDay.CheckedChanged += new System.EventHandler(this.rbt_AllDay_CheckedChanged);
            this.rbt_AllDay.Click += new System.EventHandler(this.rbt_AllDay_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(30, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "開始時間";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(32, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "結束時間";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(157, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "點";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(157, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "點";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(239, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "分";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(239, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "分";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(30, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "標題";
            // 
            // tbx_tile
            // 
            this.tbx_tile.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_tile.Location = new System.Drawing.Point(103, 27);
            this.tbx_tile.Name = "tbx_tile";
            this.tbx_tile.Size = new System.Drawing.Size(345, 30);
            this.tbx_tile.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(32, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 22);
            this.label10.TabIndex = 17;
            this.label10.Text = "備註";
            // 
            // rtb_Remarks
            // 
            this.rtb_Remarks.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtb_Remarks.Location = new System.Drawing.Point(33, 274);
            this.rtb_Remarks.Name = "rtb_Remarks";
            this.rtb_Remarks.Size = new System.Drawing.Size(416, 217);
            this.rtb_Remarks.TabIndex = 18;
            this.rtb_Remarks.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_save.Location = new System.Drawing.Point(471, 345);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(128, 62);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "儲存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // but_cancal
            // 
            this.but_cancal.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_cancal.Location = new System.Drawing.Point(471, 428);
            this.but_cancal.Name = "but_cancal";
            this.but_cancal.Size = new System.Drawing.Size(128, 62);
            this.but_cancal.TabIndex = 21;
            this.but_cancal.Text = "取消";
            this.but_cancal.UseVisualStyleBackColor = true;
            this.but_cancal.Click += new System.EventHandler(this.but_cancal_Click);
            // 
            // dtp_AllDay
            // 
            this.dtp_AllDay.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp_AllDay.Location = new System.Drawing.Point(33, 71);
            this.dtp_AllDay.Name = "dtp_AllDay";
            this.dtp_AllDay.Size = new System.Drawing.Size(158, 30);
            this.dtp_AllDay.TabIndex = 28;
            // 
            // cbx_starHour
            // 
            this.cbx_starHour.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_starHour.FormattingEnabled = true;
            this.cbx_starHour.Location = new System.Drawing.Point(106, 149);
            this.cbx_starHour.Name = "cbx_starHour";
            this.cbx_starHour.Size = new System.Drawing.Size(44, 30);
            this.cbx_starHour.TabIndex = 29;
            // 
            // cbx_starMin
            // 
            this.cbx_starMin.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_starMin.FormattingEnabled = true;
            this.cbx_starMin.Location = new System.Drawing.Point(185, 151);
            this.cbx_starMin.Name = "cbx_starMin";
            this.cbx_starMin.Size = new System.Drawing.Size(44, 30);
            this.cbx_starMin.TabIndex = 30;
            // 
            // cbx_endMin
            // 
            this.cbx_endMin.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_endMin.FormattingEnabled = true;
            this.cbx_endMin.Location = new System.Drawing.Point(189, 206);
            this.cbx_endMin.Name = "cbx_endMin";
            this.cbx_endMin.Size = new System.Drawing.Size(44, 30);
            this.cbx_endMin.TabIndex = 31;
            // 
            // cbx_endHour
            // 
            this.cbx_endHour.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_endHour.FormattingEnabled = true;
            this.cbx_endHour.Location = new System.Drawing.Point(107, 206);
            this.cbx_endHour.Name = "cbx_endHour";
            this.cbx_endHour.Size = new System.Drawing.Size(44, 30);
            this.cbx_endHour.TabIndex = 32;
            // 
            // Record_thing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 518);
            this.Controls.Add(this.cbx_endHour);
            this.Controls.Add(this.cbx_endMin);
            this.Controls.Add(this.cbx_starMin);
            this.Controls.Add(this.cbx_starHour);
            this.Controls.Add(this.dtp_AllDay);
            this.Controls.Add(this.but_cancal);
            this.Controls.Add(this.btn_save);
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
            this.Name = "Record_thing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record";
            this.Load += new System.EventHandler(this.Record_thing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbt_AllDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_tile;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtb_Remarks;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button but_cancal;
        private System.Windows.Forms.DateTimePicker dtp_AllDay;
        private System.Windows.Forms.ComboBox cbx_starHour;
        private System.Windows.Forms.ComboBox cbx_starMin;
        private System.Windows.Forms.ComboBox cbx_endMin;
        private System.Windows.Forms.ComboBox cbx_endHour;
    }
}