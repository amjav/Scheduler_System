namespace Meeting_Scheduler_Prototype
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.PsName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.meetingsScheduledlbl = new System.Windows.Forms.Label();
            this.schedulerslbl = new System.Windows.Forms.Label();
            this.purposelbl = new System.Windows.Forms.Label();
            this.dateTimelbl = new System.Windows.Forms.Label();
            this.locationlbl = new System.Windows.Forms.Label();
            this.schedulerPenlbl = new System.Windows.Forms.Label();
            this.PurposePenlbl = new System.Windows.Forms.Label();
            this.meetingStatuslbl = new System.Windows.Forms.Label();
            this.dateTimePenlbl = new System.Windows.Forms.Label();
            this.actionlbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 496);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PsName
            // 
            this.PsName.AutoSize = true;
            this.PsName.Location = new System.Drawing.Point(11, 34);
            this.PsName.Name = "PsName";
            this.PsName.Size = new System.Drawing.Size(134, 20);
            this.PsName.TabIndex = 1;
            this.PsName.Text = "Participant Name:";
            this.PsName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.PsName);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(339, 655);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Preference Set:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(166, 96);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(134, 104);
            this.listBox1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(805, 252);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 60);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(805, 252);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // meetingsScheduledlbl
            // 
            this.meetingsScheduledlbl.AutoSize = true;
            this.meetingsScheduledlbl.Location = new System.Drawing.Point(334, 71);
            this.meetingsScheduledlbl.Name = "meetingsScheduledlbl";
            this.meetingsScheduledlbl.Size = new System.Drawing.Size(0, 20);
            this.meetingsScheduledlbl.TabIndex = 7;
            this.meetingsScheduledlbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // schedulerslbl
            // 
            this.schedulerslbl.AutoSize = true;
            this.schedulerslbl.Location = new System.Drawing.Point(77, 42);
            this.schedulerslbl.Name = "schedulerslbl";
            this.schedulerslbl.Size = new System.Drawing.Size(81, 20);
            this.schedulerslbl.TabIndex = 9;
            this.schedulerslbl.Text = "Scheduler";
            // 
            // purposelbl
            // 
            this.purposelbl.AutoSize = true;
            this.purposelbl.Location = new System.Drawing.Point(257, 37);
            this.purposelbl.Name = "purposelbl";
            this.purposelbl.Size = new System.Drawing.Size(128, 20);
            this.purposelbl.TabIndex = 10;
            this.purposelbl.Text = "Meeting purpose";
            this.purposelbl.Click += new System.EventHandler(this.purposelbl_Click);
            // 
            // dateTimelbl
            // 
            this.dateTimelbl.AutoSize = true;
            this.dateTimelbl.Location = new System.Drawing.Point(482, 37);
            this.dateTimelbl.Name = "dateTimelbl";
            this.dateTimelbl.Size = new System.Drawing.Size(82, 20);
            this.dateTimelbl.TabIndex = 11;
            this.dateTimelbl.Text = "Date/Time";
            // 
            // locationlbl
            // 
            this.locationlbl.AutoSize = true;
            this.locationlbl.Location = new System.Drawing.Point(690, 37);
            this.locationlbl.Name = "locationlbl";
            this.locationlbl.Size = new System.Drawing.Size(70, 20);
            this.locationlbl.TabIndex = 12;
            this.locationlbl.Text = "Location";
            // 
            // schedulerPenlbl
            // 
            this.schedulerPenlbl.AutoSize = true;
            this.schedulerPenlbl.Location = new System.Drawing.Point(45, 33);
            this.schedulerPenlbl.Name = "schedulerPenlbl";
            this.schedulerPenlbl.Size = new System.Drawing.Size(81, 20);
            this.schedulerPenlbl.TabIndex = 13;
            this.schedulerPenlbl.Text = "Scheduler";
            // 
            // PurposePenlbl
            // 
            this.PurposePenlbl.AutoSize = true;
            this.PurposePenlbl.Location = new System.Drawing.Point(194, 33);
            this.PurposePenlbl.Name = "PurposePenlbl";
            this.PurposePenlbl.Size = new System.Drawing.Size(128, 20);
            this.PurposePenlbl.TabIndex = 14;
            this.PurposePenlbl.Text = "Meeting purpose";
            // 
            // meetingStatuslbl
            // 
            this.meetingStatuslbl.AutoSize = true;
            this.meetingStatuslbl.Location = new System.Drawing.Point(360, 33);
            this.meetingStatuslbl.Name = "meetingStatuslbl";
            this.meetingStatuslbl.Size = new System.Drawing.Size(117, 20);
            this.meetingStatuslbl.TabIndex = 15;
            this.meetingStatuslbl.Text = "Meeting Status";
            // 
            // dateTimePenlbl
            // 
            this.dateTimePenlbl.AutoSize = true;
            this.dateTimePenlbl.Location = new System.Drawing.Point(531, 33);
            this.dateTimePenlbl.Name = "dateTimePenlbl";
            this.dateTimePenlbl.Size = new System.Drawing.Size(82, 20);
            this.dateTimePenlbl.TabIndex = 16;
            this.dateTimePenlbl.Text = "Date/Time";
            // 
            // actionlbl
            // 
            this.actionlbl.AutoSize = true;
            this.actionlbl.Location = new System.Drawing.Point(713, 33);
            this.actionlbl.Name = "actionlbl";
            this.actionlbl.Size = new System.Drawing.Size(54, 20);
            this.actionlbl.TabIndex = 17;
            this.actionlbl.Text = "Action";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.actionlbl);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.dateTimePenlbl);
            this.groupBox2.Controls.Add(this.schedulerPenlbl);
            this.groupBox2.Controls.Add(this.meetingStatuslbl);
            this.groupBox2.Controls.Add(this.PurposePenlbl);
            this.groupBox2.Location = new System.Drawing.Point(357, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 314);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meetings Pending";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.meetingsScheduledlbl);
            this.groupBox3.Controls.Add(this.tableLayoutPanel2);
            this.groupBox3.Controls.Add(this.locationlbl);
            this.groupBox3.Controls.Add(this.schedulerslbl);
            this.groupBox3.Controls.Add(this.dateTimelbl);
            this.groupBox3.Controls.Add(this.purposelbl);
            this.groupBox3.Location = new System.Drawing.Point(357, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(829, 329);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Meetings Scheduled";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 687);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PsName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label meetingsScheduledlbl;
        private System.Windows.Forms.Label schedulerslbl;
        private System.Windows.Forms.Label purposelbl;
        private System.Windows.Forms.Label dateTimelbl;
        private System.Windows.Forms.Label locationlbl;
        private System.Windows.Forms.Label schedulerPenlbl;
        private System.Windows.Forms.Label PurposePenlbl;
        private System.Windows.Forms.Label meetingStatuslbl;
        private System.Windows.Forms.Label dateTimePenlbl;
        private System.Windows.Forms.Label actionlbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

