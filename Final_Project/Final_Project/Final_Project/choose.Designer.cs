namespace Final_Project
{
    partial class choose
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
            this.btn_newThing = new System.Windows.Forms.Button();
            this.btn_changeMoney = new System.Windows.Forms.Button();
            this.btn_changeThing = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_newThing
            // 
            this.btn_newThing.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_newThing.Location = new System.Drawing.Point(53, 39);
            this.btn_newThing.Name = "btn_newThing";
            this.btn_newThing.Size = new System.Drawing.Size(333, 101);
            this.btn_newThing.TabIndex = 0;
            this.btn_newThing.Text = "新增事項";
            this.btn_newThing.UseVisualStyleBackColor = true;
            this.btn_newThing.Click += new System.EventHandler(this.btn_newThing_Click);
            // 
            // btn_changeMoney
            // 
            this.btn_changeMoney.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_changeMoney.Location = new System.Drawing.Point(53, 185);
            this.btn_changeMoney.Name = "btn_changeMoney";
            this.btn_changeMoney.Size = new System.Drawing.Size(333, 101);
            this.btn_changeMoney.TabIndex = 1;
            this.btn_changeMoney.Text = "新增/更改記帳";
            this.btn_changeMoney.UseVisualStyleBackColor = true;
            this.btn_changeMoney.Click += new System.EventHandler(this.btn_changeMoney_Click);
            // 
            // btn_changeThing
            // 
            this.btn_changeThing.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_changeThing.Location = new System.Drawing.Point(53, 331);
            this.btn_changeThing.Name = "btn_changeThing";
            this.btn_changeThing.Size = new System.Drawing.Size(333, 101);
            this.btn_changeThing.TabIndex = 2;
            this.btn_changeThing.Text = "更改待辦事項";
            this.btn_changeThing.UseVisualStyleBackColor = true;
            this.btn_changeThing.Click += new System.EventHandler(this.btn_changeThing_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Back.Location = new System.Drawing.Point(53, 477);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(333, 101);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "回前頁";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 609);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_changeThing);
            this.Controls.Add(this.btn_changeMoney);
            this.Controls.Add(this.btn_newThing);
            this.Name = "choose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "choose";
            this.Load += new System.EventHandler(this.choose_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_newThing;
        private System.Windows.Forms.Button btn_changeMoney;
        private System.Windows.Forms.Button btn_changeThing;
        private System.Windows.Forms.Button btn_Back;
    }
}