/**
 * Author: Rishit Patel
 * Student ID: A00089000
 * Date: December 14, 2020
 */

namespace Gyaani
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.aries = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_date_range = new System.Windows.Forms.Label();
            this.lbl_compatibility = new System.Windows.Forms.Label();
            this.lbl_mood = new System.Windows.Forms.Label();
            this.lbl_color = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_lucky_number = new System.Windows.Forms.Label();
            this.lbl_lucky_time = new System.Windows.Forms.Label();
            this.btn_get_yesterday = new System.Windows.Forms.Button();
            this.btn_get_today = new System.Windows.Forms.Button();
            this.btn_get_tomorrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Jost", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(255, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Horoscope";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.results.Cursor = System.Windows.Forms.Cursors.Default;
            this.results.Font = new System.Drawing.Font("Jost", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(86)))), ((int)(((byte)(212)))));
            this.results.Location = new System.Drawing.Point(25, 334);
            this.results.MaxLength = 99999999;
            this.results.Multiline = true;
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.results.Size = new System.Drawing.Size(872, 274);
            this.results.TabIndex = 1;
            this.results.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.menu.Font = new System.Drawing.Font("Jost", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(86)))), ((int)(((byte)(212)))));
            this.menu.Location = new System.Drawing.Point(747, 30);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(150, 50);
            this.menu.TabIndex = 15;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(367, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 16;
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // aries
            // 
            this.aries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.aries.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aries.BackgroundImage")));
            this.aries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aries.Location = new System.Drawing.Point(25, 12);
            this.aries.Name = "aries";
            this.aries.Size = new System.Drawing.Size(100, 100);
            this.aries.TabIndex = 18;
            this.aries.UseVisualStyleBackColor = false;
            this.aries.Click += new System.EventHandler(this.aries_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Jost", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(329, 290);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(264, 32);
            this.lbl_date.TabIndex = 19;
            this.lbl_date.Text = "Date: December 14, 2020";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_date.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_date_range
            // 
            this.lbl_date_range.AutoSize = true;
            this.lbl_date_range.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date_range.Font = new System.Drawing.Font("Jost", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_range.ForeColor = System.Drawing.Color.White;
            this.lbl_date_range.Location = new System.Drawing.Point(19, 139);
            this.lbl_date_range.Name = "lbl_date_range";
            this.lbl_date_range.Size = new System.Drawing.Size(297, 32);
            this.lbl_date_range.TabIndex = 21;
            this.lbl_date_range.Text = "Date Range: Aug 23 - Sep 22";
            this.lbl_date_range.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_date_range.Click += new System.EventHandler(this.lbl_date_range_Click);
            // 
            // lbl_compatibility
            // 
            this.lbl_compatibility.AutoSize = true;
            this.lbl_compatibility.BackColor = System.Drawing.Color.Transparent;
            this.lbl_compatibility.Font = new System.Drawing.Font("Jost", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_compatibility.ForeColor = System.Drawing.Color.White;
            this.lbl_compatibility.Location = new System.Drawing.Point(19, 192);
            this.lbl_compatibility.Name = "lbl_compatibility";
            this.lbl_compatibility.Size = new System.Drawing.Size(251, 32);
            this.lbl_compatibility.TabIndex = 22;
            this.lbl_compatibility.Text = "Compatibility: Sagittarius";
            this.lbl_compatibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_compatibility.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lbl_mood
            // 
            this.lbl_mood.AutoSize = true;
            this.lbl_mood.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mood.Font = new System.Drawing.Font("Jost", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mood.ForeColor = System.Drawing.Color.White;
            this.lbl_mood.Location = new System.Drawing.Point(582, 139);
            this.lbl_mood.Name = "lbl_mood";
            this.lbl_mood.Size = new System.Drawing.Size(152, 32);
            this.lbl_mood.TabIndex = 23;
            this.lbl_mood.Text = "Mood: Truthful";
            this.lbl_mood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_mood.Click += new System.EventHandler(this.label3_Click_2);
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.BackColor = System.Drawing.Color.Transparent;
            this.lbl_color.Font = new System.Drawing.Font("Jost", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.ForeColor = System.Drawing.Color.White;
            this.lbl_color.Location = new System.Drawing.Point(582, 192);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(212, 32);
            this.lbl_color.TabIndex = 24;
            this.lbl_color.Text = "Color: Shadow Black";
            this.lbl_color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Jost", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(383, 616);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 27);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Made By Rishit Patel";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbl_lucky_number
            // 
            this.lbl_lucky_number.AutoSize = true;
            this.lbl_lucky_number.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lucky_number.Font = new System.Drawing.Font("Jost", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lucky_number.ForeColor = System.Drawing.Color.White;
            this.lbl_lucky_number.Location = new System.Drawing.Point(19, 248);
            this.lbl_lucky_number.Name = "lbl_lucky_number";
            this.lbl_lucky_number.Size = new System.Drawing.Size(193, 32);
            this.lbl_lucky_number.TabIndex = 27;
            this.lbl_lucky_number.Text = "Lucky Number: 69";
            this.lbl_lucky_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_lucky_time
            // 
            this.lbl_lucky_time.AutoSize = true;
            this.lbl_lucky_time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lucky_time.Font = new System.Drawing.Font("Jost", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lucky_time.ForeColor = System.Drawing.Color.White;
            this.lbl_lucky_time.Location = new System.Drawing.Point(582, 248);
            this.lbl_lucky_time.Name = "lbl_lucky_time";
            this.lbl_lucky_time.Size = new System.Drawing.Size(216, 32);
            this.lbl_lucky_time.TabIndex = 28;
            this.lbl_lucky_time.Text = "Lucky Time: 6:09 pm";
            this.lbl_lucky_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_get_yesterday
            // 
            this.btn_get_yesterday.Font = new System.Drawing.Font("Jost", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get_yesterday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(86)))), ((int)(((byte)(212)))));
            this.btn_get_yesterday.Location = new System.Drawing.Point(154, 81);
            this.btn_get_yesterday.Name = "btn_get_yesterday";
            this.btn_get_yesterday.Size = new System.Drawing.Size(116, 31);
            this.btn_get_yesterday.TabIndex = 29;
            this.btn_get_yesterday.Text = "Get Yesterday";
            this.btn_get_yesterday.UseVisualStyleBackColor = true;
            this.btn_get_yesterday.Click += new System.EventHandler(this.btn_get_yesterday_Click);
            // 
            // btn_get_today
            // 
            this.btn_get_today.Font = new System.Drawing.Font("Jost", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get_today.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(86)))), ((int)(((byte)(212)))));
            this.btn_get_today.Location = new System.Drawing.Point(388, 81);
            this.btn_get_today.Name = "btn_get_today";
            this.btn_get_today.Size = new System.Drawing.Size(116, 31);
            this.btn_get_today.TabIndex = 30;
            this.btn_get_today.Text = "Get Today";
            this.btn_get_today.UseVisualStyleBackColor = true;
            this.btn_get_today.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_get_tomorrow
            // 
            this.btn_get_tomorrow.Font = new System.Drawing.Font("Jost", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_get_tomorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(86)))), ((int)(((byte)(212)))));
            this.btn_get_tomorrow.Location = new System.Drawing.Point(606, 81);
            this.btn_get_tomorrow.Name = "btn_get_tomorrow";
            this.btn_get_tomorrow.Size = new System.Drawing.Size(116, 31);
            this.btn_get_tomorrow.TabIndex = 31;
            this.btn_get_tomorrow.Text = "Get Tomorrow";
            this.btn_get_tomorrow.UseVisualStyleBackColor = true;
            this.btn_get_tomorrow.Click += new System.EventHandler(this.btn_get_tomorrow_Click);
            // 
            // Form2
            // 
            this.BackgroundImage = global::Gyaani.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 652);
            this.Controls.Add(this.btn_get_tomorrow);
            this.Controls.Add(this.btn_get_today);
            this.Controls.Add(this.btn_get_yesterday);
            this.Controls.Add(this.lbl_lucky_time);
            this.Controls.Add(this.lbl_lucky_number);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.lbl_mood);
            this.Controls.Add(this.lbl_compatibility);
            this.Controls.Add(this.lbl_date_range);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.aries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Jost", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox results;
        public System.Windows.Forms.Button menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button aries;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_date_range;
        private System.Windows.Forms.Label lbl_compatibility;
        private System.Windows.Forms.Label lbl_mood;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_lucky_number;
        private System.Windows.Forms.Label lbl_lucky_time;
        private System.Windows.Forms.Button btn_get_yesterday;
        private System.Windows.Forms.Button btn_get_today;
        private System.Windows.Forms.Button btn_get_tomorrow;
    }
}