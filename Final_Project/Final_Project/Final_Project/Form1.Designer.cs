namespace Final_Project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_account = new System.Windows.Forms.RichTextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_addandchange = new System.Windows.Forms.Button();
            this.rtb_thing = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(434, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "記帳";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(174, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "待辦事項";
            // 
            // rtb_account
            // 
            this.rtb_account.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtb_account.Location = new System.Drawing.Point(335, 290);
            this.rtb_account.Name = "rtb_account";
            this.rtb_account.ReadOnly = true;
            this.rtb_account.Size = new System.Drawing.Size(256, 208);
            this.rtb_account.TabIndex = 11;
            this.rtb_account.Text = "";
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_close.Location = new System.Drawing.Point(559, 524);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(128, 51);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "關閉";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_addandchange
            // 
            this.btn_addandchange.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addandchange.Location = new System.Drawing.Point(405, 524);
            this.btn_addandchange.Name = "btn_addandchange";
            this.btn_addandchange.Size = new System.Drawing.Size(125, 51);
            this.btn_addandchange.TabIndex = 9;
            this.btn_addandchange.Text = "增加/更改";
            this.btn_addandchange.UseVisualStyleBackColor = true;
            this.btn_addandchange.Click += new System.EventHandler(this.btn_addandchange_Click);
            // 
            // rtb_thing
            // 
            this.rtb_thing.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtb_thing.Location = new System.Drawing.Point(81, 290);
            this.rtb_thing.Name = "rtb_thing";
            this.rtb_thing.ReadOnly = true;
            this.rtb_thing.Size = new System.Drawing.Size(256, 208);
            this.rtb_thing.TabIndex = 8;
            this.rtb_thing.Text = "";
            this.rtb_thing.TextChanged += new System.EventHandler(this.rtb_thing_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(37, 18);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(272, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 587);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_account);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_addandchange);
            this.Controls.Add(this.rtb_thing);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "記事，記帳";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_account;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_addandchange;
        private System.Windows.Forms.RichTextBox rtb_thing;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label3;
    }
}

