﻿namespace Exam_Cell
{
    partial class Registered_Students_Management
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
            this.Registered_dgv = new System.Windows.Forms.DataGridView();
            this.Series_radiobtn = new System.Windows.Forms.RadioButton();
            this.Univrsty_radiobtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.DeleteAll_btn = new System.Windows.Forms.Button();
            this.AllotGroupbox = new System.Windows.Forms.GroupBox();
            this.AllotSeries_radiobtn = new System.Windows.Forms.RadioButton();
            this.AllotUniversty_radiobtn = new System.Windows.Forms.RadioButton();
            this.Branch_combobox = new System.Windows.Forms.ComboBox();
            this.Semester_combobox = new System.Windows.Forms.ComboBox();
            this.Regno_textbox = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Registered_dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.AllotGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Registered_dgv
            // 
            this.Registered_dgv.AllowUserToAddRows = false;
            this.Registered_dgv.AllowUserToDeleteRows = false;
            this.Registered_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Registered_dgv.Location = new System.Drawing.Point(23, 109);
            this.Registered_dgv.Name = "Registered_dgv";
            this.Registered_dgv.RowTemplate.Height = 24;
            this.Registered_dgv.Size = new System.Drawing.Size(621, 423);
            this.Registered_dgv.TabIndex = 0;
            // 
            // Series_radiobtn
            // 
            this.Series_radiobtn.AutoSize = true;
            this.Series_radiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Series_radiobtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Series_radiobtn.Location = new System.Drawing.Point(180, 31);
            this.Series_radiobtn.Name = "Series_radiobtn";
            this.Series_radiobtn.Size = new System.Drawing.Size(83, 24);
            this.Series_radiobtn.TabIndex = 1;
            this.Series_radiobtn.TabStop = true;
            this.Series_radiobtn.Text = "Series ";
            this.Series_radiobtn.UseVisualStyleBackColor = true;
            this.Series_radiobtn.CheckedChanged += new System.EventHandler(this.Series_radiobtn_CheckedChanged);
            // 
            // Univrsty_radiobtn
            // 
            this.Univrsty_radiobtn.AutoSize = true;
            this.Univrsty_radiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Univrsty_radiobtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Univrsty_radiobtn.Location = new System.Drawing.Point(18, 31);
            this.Univrsty_radiobtn.Name = "Univrsty_radiobtn";
            this.Univrsty_radiobtn.Size = new System.Drawing.Size(104, 24);
            this.Univrsty_radiobtn.TabIndex = 1;
            this.Univrsty_radiobtn.TabStop = true;
            this.Univrsty_radiobtn.Text = "University";
            this.Univrsty_radiobtn.UseVisualStyleBackColor = true;
            this.Univrsty_radiobtn.CheckedChanged += new System.EventHandler(this.Univrsty_radiobtn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Series_radiobtn);
            this.groupBox1.Controls.Add(this.Univrsty_radiobtn);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(23, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Exam";
            // 
            // Delete_btn
            // 
            this.Delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.Color.Red;
            this.Delete_btn.Location = new System.Drawing.Point(661, 292);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(122, 35);
            this.Delete_btn.TabIndex = 2;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // DeleteAll_btn
            // 
            this.DeleteAll_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAll_btn.ForeColor = System.Drawing.Color.Red;
            this.DeleteAll_btn.Location = new System.Drawing.Point(661, 370);
            this.DeleteAll_btn.Name = "DeleteAll_btn";
            this.DeleteAll_btn.Size = new System.Drawing.Size(122, 35);
            this.DeleteAll_btn.TabIndex = 2;
            this.DeleteAll_btn.Text = "CLEANUP";
            this.DeleteAll_btn.UseVisualStyleBackColor = true;
            this.DeleteAll_btn.Click += new System.EventHandler(this.DeleteAll_btn_Click);
            // 
            // AllotGroupbox
            // 
            this.AllotGroupbox.Controls.Add(this.AllotSeries_radiobtn);
            this.AllotGroupbox.Controls.Add(this.AllotUniversty_radiobtn);
            this.AllotGroupbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllotGroupbox.Location = new System.Drawing.Point(330, 21);
            this.AllotGroupbox.Name = "AllotGroupbox";
            this.AllotGroupbox.Size = new System.Drawing.Size(314, 73);
            this.AllotGroupbox.TabIndex = 4;
            this.AllotGroupbox.TabStop = false;
            this.AllotGroupbox.Text = "Allotment";
            // 
            // AllotSeries_radiobtn
            // 
            this.AllotSeries_radiobtn.AutoSize = true;
            this.AllotSeries_radiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllotSeries_radiobtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllotSeries_radiobtn.Location = new System.Drawing.Point(203, 31);
            this.AllotSeries_radiobtn.Name = "AllotSeries_radiobtn";
            this.AllotSeries_radiobtn.Size = new System.Drawing.Size(83, 24);
            this.AllotSeries_radiobtn.TabIndex = 1;
            this.AllotSeries_radiobtn.TabStop = true;
            this.AllotSeries_radiobtn.Text = "Series ";
            this.AllotSeries_radiobtn.UseVisualStyleBackColor = true;
            this.AllotSeries_radiobtn.CheckedChanged += new System.EventHandler(this.AllotSeries_radiobtn_CheckedChanged);
            // 
            // AllotUniversty_radiobtn
            // 
            this.AllotUniversty_radiobtn.AutoSize = true;
            this.AllotUniversty_radiobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllotUniversty_radiobtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllotUniversty_radiobtn.Location = new System.Drawing.Point(41, 31);
            this.AllotUniversty_radiobtn.Name = "AllotUniversty_radiobtn";
            this.AllotUniversty_radiobtn.Size = new System.Drawing.Size(104, 24);
            this.AllotUniversty_radiobtn.TabIndex = 1;
            this.AllotUniversty_radiobtn.TabStop = true;
            this.AllotUniversty_radiobtn.Text = "University";
            this.AllotUniversty_radiobtn.UseVisualStyleBackColor = true;
            this.AllotUniversty_radiobtn.CheckedChanged += new System.EventHandler(this.AllotUniversty_radiobtn_CheckedChanged);
            // 
            // Branch_combobox
            // 
            this.Branch_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Branch_combobox.FormattingEnabled = true;
            this.Branch_combobox.Location = new System.Drawing.Point(661, 175);
            this.Branch_combobox.Name = "Branch_combobox";
            this.Branch_combobox.Size = new System.Drawing.Size(283, 24);
            this.Branch_combobox.TabIndex = 6;
            this.Branch_combobox.SelectedIndexChanged += new System.EventHandler(this.Branch_combobox_SelectedIndexChanged);
            // 
            // Semester_combobox
            // 
            this.Semester_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Semester_combobox.FormattingEnabled = true;
            this.Semester_combobox.Items.AddRange(new object[] {
            "-Select Semester-",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.Semester_combobox.Location = new System.Drawing.Point(661, 205);
            this.Semester_combobox.Name = "Semester_combobox";
            this.Semester_combobox.Size = new System.Drawing.Size(283, 24);
            this.Semester_combobox.TabIndex = 6;
            this.Semester_combobox.SelectedIndexChanged += new System.EventHandler(this.Semester_combobox_SelectedIndexChanged);
            // 
            // Regno_textbox
            // 
            this.Regno_textbox.Location = new System.Drawing.Point(661, 147);
            this.Regno_textbox.Name = "Regno_textbox";
            this.Regno_textbox.Size = new System.Drawing.Size(283, 22);
            this.Regno_textbox.TabIndex = 7;
            this.Regno_textbox.Tag = "";
            this.Regno_textbox.TextChanged += new System.EventHandler(this.Regno_textbox_TextChanged);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(852, 235);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(92, 32);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(661, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reg_No";
            // 
            // Registered_Students_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(956, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Regno_textbox);
            this.Controls.Add(this.Semester_combobox);
            this.Controls.Add(this.Branch_combobox);
            this.Controls.Add(this.AllotGroupbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteAll_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Registered_dgv);
            this.Name = "Registered_Students_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registered_Students_Management";
            this.Load += new System.EventHandler(this.Registered_Students_Management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Registered_dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AllotGroupbox.ResumeLayout(false);
            this.AllotGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Registered_dgv;
        private System.Windows.Forms.RadioButton Series_radiobtn;
        private System.Windows.Forms.RadioButton Univrsty_radiobtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.Button DeleteAll_btn;
        private System.Windows.Forms.GroupBox AllotGroupbox;
        private System.Windows.Forms.RadioButton AllotSeries_radiobtn;
        private System.Windows.Forms.RadioButton AllotUniversty_radiobtn;
        private System.Windows.Forms.ComboBox Branch_combobox;
        private System.Windows.Forms.ComboBox Semester_combobox;
        private System.Windows.Forms.TextBox Regno_textbox;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label label1;
    }
}