﻿using System.Drawing;
using System.Windows.Forms;

namespace Taschenrechner_V1._0
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
      this.btn_add = new Button();
      this.btn_sub = new Button();
      this.btn_mult = new Button();
      this.btn_div = new Button();
      this.btn_1 = new Button();
      this.btn_2 = new Button();
      this.btn_3 = new Button();
      this.btn_6 = new Button();
      this.btn_5 = new Button();
      this.btn_4 = new Button();
      this.btn_9 = new Button();
      this.btn_8 = new Button();
      this.btn_7 = new Button();
      this.label1 = new Label();
      this.btn_clear = new Button();
      this.Btn_res = new Button();
      this.btn_0 = new Button();
      this.btn_empty = new Button();
      this.btn_semo = new Button();
      this.tableLayoutPanel1 = new TableLayoutPanel();
      this.tableLayoutPanel2 = new TableLayoutPanel();
      this.label2 = new Label();
      this.tableLayoutPanel3 = new TableLayoutPanel();
      this.TabControl1 = new TabControl();
      this.Taschenrechner = new TabPage();
      this.Verlauf = new TabPage();
      this.tableLayoutPanel4 = new TableLayoutPanel();
      this.tableLayoutPanel5 = new TableLayoutPanel();
      this.Btn_Delete = new Button();
      this.Btn_Delete_all = new Button();
      this.listBox1 = new ListBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.TabControl1.SuspendLayout();
      this.Taschenrechner.SuspendLayout();
      this.Verlauf.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.tableLayoutPanel5.SuspendLayout();
      this.SuspendLayout();
      // 
      // btn_add
      // 
      this.btn_add.AutoSize = true;
      this.btn_add.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_add.BackColor = SystemColors.ControlLight;
      this.btn_add.Dock = DockStyle.Fill;
      this.btn_add.Font = new Font("Segoe UI", 9F);
      this.btn_add.Location = new Point(204, 159);
      this.btn_add.Name = "btn_add";
      this.btn_add.Size = new Size(62, 46);
      this.btn_add.TabIndex = 0;
      this.btn_add.TabStop = false;
      this.btn_add.Text = "+";
      this.btn_add.UseVisualStyleBackColor = false;
      this.btn_add.Click += this.Btn_add_Click;
      // 
      // btn_sub
      // 
      this.btn_sub.AutoSize = true;
      this.btn_sub.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_sub.BackColor = SystemColors.ControlLight;
      this.btn_sub.Dock = DockStyle.Fill;
      this.btn_sub.Font = new Font("Segoe UI", 11F);
      this.btn_sub.Location = new Point(204, 107);
      this.btn_sub.Name = "btn_sub";
      this.btn_sub.Size = new Size(62, 46);
      this.btn_sub.TabIndex = 1;
      this.btn_sub.TabStop = false;
      this.btn_sub.Text = "-";
      this.btn_sub.UseVisualStyleBackColor = false;
      this.btn_sub.Click += this.Btn_sub_Click;
      // 
      // btn_mult
      // 
      this.btn_mult.AutoSize = true;
      this.btn_mult.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_mult.BackColor = SystemColors.ControlLight;
      this.btn_mult.Dock = DockStyle.Fill;
      this.btn_mult.Font = new Font("Segoe UI", 9F);
      this.btn_mult.Location = new Point(204, 55);
      this.btn_mult.Name = "btn_mult";
      this.btn_mult.Size = new Size(62, 46);
      this.btn_mult.TabIndex = 2;
      this.btn_mult.TabStop = false;
      this.btn_mult.Text = "*";
      this.btn_mult.UseVisualStyleBackColor = false;
      this.btn_mult.Click += this.Btn_mult_Click;
      // 
      // btn_div
      // 
      this.btn_div.AutoSize = true;
      this.btn_div.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_div.BackColor = SystemColors.ControlLight;
      this.btn_div.Dock = DockStyle.Fill;
      this.btn_div.Font = new Font("Segoe UI", 9F);
      this.btn_div.Location = new Point(204, 3);
      this.btn_div.Name = "btn_div";
      this.btn_div.Size = new Size(62, 46);
      this.btn_div.TabIndex = 3;
      this.btn_div.TabStop = false;
      this.btn_div.Text = "/";
      this.btn_div.UseVisualStyleBackColor = false;
      this.btn_div.Click += this.Btn_div_Click;
      // 
      // btn_1
      // 
      this.btn_1.AutoSize = true;
      this.btn_1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_1.Dock = DockStyle.Fill;
      this.btn_1.Location = new Point(3, 159);
      this.btn_1.Name = "btn_1";
      this.btn_1.Size = new Size(61, 46);
      this.btn_1.TabIndex = 4;
      this.btn_1.TabStop = false;
      this.btn_1.Text = "1";
      this.btn_1.UseVisualStyleBackColor = true;
      this.btn_1.Click += this.NumberButton_Click;
      // 
      // btn_2
      // 
      this.btn_2.AutoSize = true;
      this.btn_2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_2.Dock = DockStyle.Fill;
      this.btn_2.Location = new Point(70, 159);
      this.btn_2.Name = "btn_2";
      this.btn_2.Size = new Size(61, 46);
      this.btn_2.TabIndex = 5;
      this.btn_2.TabStop = false;
      this.btn_2.Text = "2";
      this.btn_2.UseVisualStyleBackColor = true;
      this.btn_2.Click += this.NumberButton_Click;
      // 
      // btn_3
      // 
      this.btn_3.AutoSize = true;
      this.btn_3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_3.Dock = DockStyle.Fill;
      this.btn_3.Location = new Point(137, 159);
      this.btn_3.Name = "btn_3";
      this.btn_3.Size = new Size(61, 46);
      this.btn_3.TabIndex = 6;
      this.btn_3.TabStop = false;
      this.btn_3.Text = "3";
      this.btn_3.UseVisualStyleBackColor = true;
      this.btn_3.Click += this.NumberButton_Click;
      // 
      // btn_6
      // 
      this.btn_6.AutoSize = true;
      this.btn_6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_6.Dock = DockStyle.Fill;
      this.btn_6.Location = new Point(137, 107);
      this.btn_6.Name = "btn_6";
      this.btn_6.Size = new Size(61, 46);
      this.btn_6.TabIndex = 9;
      this.btn_6.TabStop = false;
      this.btn_6.Text = "6";
      this.btn_6.UseVisualStyleBackColor = true;
      this.btn_6.Click += this.NumberButton_Click;
      // 
      // btn_5
      // 
      this.btn_5.AutoSize = true;
      this.btn_5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_5.Dock = DockStyle.Fill;
      this.btn_5.Location = new Point(70, 107);
      this.btn_5.Name = "btn_5";
      this.btn_5.Size = new Size(61, 46);
      this.btn_5.TabIndex = 8;
      this.btn_5.TabStop = false;
      this.btn_5.Text = "5";
      this.btn_5.UseVisualStyleBackColor = true;
      this.btn_5.Click += this.NumberButton_Click;
      // 
      // btn_4
      // 
      this.btn_4.AutoSize = true;
      this.btn_4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_4.Dock = DockStyle.Fill;
      this.btn_4.Location = new Point(3, 107);
      this.btn_4.Name = "btn_4";
      this.btn_4.Size = new Size(61, 46);
      this.btn_4.TabIndex = 7;
      this.btn_4.TabStop = false;
      this.btn_4.Text = "4";
      this.btn_4.UseVisualStyleBackColor = true;
      this.btn_4.Click += this.NumberButton_Click;
      // 
      // btn_9
      // 
      this.btn_9.AutoSize = true;
      this.btn_9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_9.Dock = DockStyle.Fill;
      this.btn_9.Location = new Point(137, 55);
      this.btn_9.Name = "btn_9";
      this.btn_9.Size = new Size(61, 46);
      this.btn_9.TabIndex = 12;
      this.btn_9.TabStop = false;
      this.btn_9.Text = "9";
      this.btn_9.UseVisualStyleBackColor = true;
      this.btn_9.Click += this.NumberButton_Click;
      // 
      // btn_8
      // 
      this.btn_8.AutoSize = true;
      this.btn_8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_8.Dock = DockStyle.Fill;
      this.btn_8.Location = new Point(70, 55);
      this.btn_8.Name = "btn_8";
      this.btn_8.Size = new Size(61, 46);
      this.btn_8.TabIndex = 11;
      this.btn_8.TabStop = false;
      this.btn_8.Text = "8";
      this.btn_8.UseVisualStyleBackColor = true;
      this.btn_8.Click += this.NumberButton_Click;
      // 
      // btn_7
      // 
      this.btn_7.AutoSize = true;
      this.btn_7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_7.Dock = DockStyle.Fill;
      this.btn_7.Location = new Point(3, 55);
      this.btn_7.Name = "btn_7";
      this.btn_7.Size = new Size(61, 46);
      this.btn_7.TabIndex = 10;
      this.btn_7.TabStop = false;
      this.btn_7.Text = "7";
      this.btn_7.UseVisualStyleBackColor = true;
      this.btn_7.Click += this.NumberButton_Click;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = DockStyle.Fill;
      this.label1.Font = new Font("Segoe UI", 16F);
      this.label1.Location = new Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new Size(263, 59);
      this.label1.TabIndex = 13;
      this.label1.Text = "0";
      this.label1.TextAlign = ContentAlignment.MiddleRight;
      // 
      // btn_clear
      // 
      this.btn_clear.AutoSize = true;
      this.btn_clear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_clear.BackColor = SystemColors.ControlLight;
      this.btn_clear.Dock = DockStyle.Fill;
      this.btn_clear.Font = new Font("Segoe UI", 9F);
      this.btn_clear.Location = new Point(70, 3);
      this.btn_clear.Name = "btn_clear";
      this.btn_clear.Size = new Size(61, 46);
      this.btn_clear.TabIndex = 14;
      this.btn_clear.TabStop = false;
      this.btn_clear.Text = "C";
      this.btn_clear.UseVisualStyleBackColor = false;
      this.btn_clear.Click += this.Btn_clear_Click;
      // 
      // Btn_res
      // 
      this.Btn_res.AutoSize = true;
      this.Btn_res.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.Btn_res.BackColor = SystemColors.ControlLight;
      this.Btn_res.Dock = DockStyle.Fill;
      this.Btn_res.Font = new Font("Segoe UI", 9F);
      this.Btn_res.Location = new Point(204, 211);
      this.Btn_res.Name = "Btn_res";
      this.Btn_res.Size = new Size(62, 48);
      this.Btn_res.TabIndex = 15;
      this.Btn_res.TabStop = false;
      this.Btn_res.Text = "=";
      this.Btn_res.UseVisualStyleBackColor = false;
      this.Btn_res.Click += this.Btn_res_Click;
      // 
      // btn_0
      // 
      this.btn_0.AutoSize = true;
      this.btn_0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_0.Dock = DockStyle.Fill;
      this.btn_0.Font = new Font("Microsoft Sans Serif", 8.25F);
      this.btn_0.Location = new Point(70, 211);
      this.btn_0.Name = "btn_0";
      this.btn_0.Size = new Size(61, 48);
      this.btn_0.TabIndex = 16;
      this.btn_0.TabStop = false;
      this.btn_0.Text = "0";
      this.btn_0.UseVisualStyleBackColor = true;
      this.btn_0.Click += this.NumberButton_Click;
      // 
      // btn_empty
      // 
      this.btn_empty.AutoSize = true;
      this.btn_empty.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_empty.BackColor = SystemColors.ControlLight;
      this.btn_empty.Dock = DockStyle.Fill;
      this.btn_empty.Font = new Font("Segoe UI", 9F);
      this.btn_empty.Location = new Point(137, 3);
      this.btn_empty.Name = "btn_empty";
      this.btn_empty.Size = new Size(61, 46);
      this.btn_empty.TabIndex = 17;
      this.btn_empty.TabStop = false;
      this.btn_empty.Text = "CE";
      this.btn_empty.UseVisualStyleBackColor = false;
      this.btn_empty.Click += this.Btn_empty_Click;
      // 
      // btn_semo
      // 
      this.btn_semo.AutoSize = true;
      this.btn_semo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.btn_semo.Dock = DockStyle.Fill;
      this.btn_semo.Location = new Point(137, 211);
      this.btn_semo.Name = "btn_semo";
      this.btn_semo.Size = new Size(61, 48);
      this.btn_semo.TabIndex = 19;
      this.btn_semo.TabStop = false;
      this.btn_semo.Text = ",";
      this.btn_semo.UseVisualStyleBackColor = true;
      this.btn_semo.Click += this.Btn_semo_Click;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.AutoSize = true;
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
      this.tableLayoutPanel1.Controls.Add(this.Btn_res, 3, 4);
      this.tableLayoutPanel1.Controls.Add(this.btn_5, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.btn_6, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.btn_7, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.btn_clear, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.btn_4, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.btn_3, 2, 3);
      this.tableLayoutPanel1.Controls.Add(this.btn_0, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.btn_mult, 3, 1);
      this.tableLayoutPanel1.Controls.Add(this.btn_empty, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.btn_2, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.btn_1, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.btn_8, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.btn_div, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.btn_add, 3, 3);
      this.tableLayoutPanel1.Controls.Add(this.btn_9, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.btn_sub, 3, 2);
      this.tableLayoutPanel1.Controls.Add(this.btn_semo, 2, 4);
      this.tableLayoutPanel1.Dock = DockStyle.Fill;
      this.tableLayoutPanel1.Location = new Point(3, 128);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
      this.tableLayoutPanel1.Size = new Size(269, 262);
      this.tableLayoutPanel1.TabIndex = 22;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.AutoSize = true;
      this.tableLayoutPanel2.ColumnCount = 1;
      this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel2.Dock = DockStyle.Fill;
      this.tableLayoutPanel2.Location = new Point(3, 3);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new Size(269, 119);
      this.tableLayoutPanel2.TabIndex = 23;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = DockStyle.Fill;
      this.label2.Font = new Font("Segoe UI", 12F);
      this.label2.Location = new Point(3, 59);
      this.label2.Name = "label2";
      this.label2.Size = new Size(263, 60);
      this.label2.TabIndex = 18;
      this.label2.TextAlign = ContentAlignment.MiddleRight;
      this.label2.UseMnemonic = false;
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.AutoSize = true;
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 1);
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
      this.tableLayoutPanel3.Dock = DockStyle.Fill;
      this.tableLayoutPanel3.Location = new Point(3, 3);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
      this.tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
      this.tableLayoutPanel3.Size = new Size(275, 393);
      this.tableLayoutPanel3.TabIndex = 25;
      // 
      // TabControl1
      // 
      this.TabControl1.Controls.Add(this.Taschenrechner);
      this.TabControl1.Controls.Add(this.Verlauf);
      this.TabControl1.Dock = DockStyle.Fill;
      this.TabControl1.Location = new Point(0, 0);
      this.TabControl1.Name = "TabControl1";
      this.TabControl1.SelectedIndex = 0;
      this.TabControl1.Size = new Size(289, 427);
      this.TabControl1.TabIndex = 26;
      this.TabControl1.TabStop = false;
      this.TabControl1.KeyDown += this.TabControl1_KeyDown;
      // 
      // Taschenrechner
      // 
      this.Taschenrechner.Controls.Add(this.tableLayoutPanel3);
      this.Taschenrechner.Location = new Point(4, 24);
      this.Taschenrechner.Name = "Taschenrechner";
      this.Taschenrechner.Padding = new Padding(3);
      this.Taschenrechner.Size = new Size(281, 399);
      this.Taschenrechner.TabIndex = 0;
      this.Taschenrechner.Text = "Taschenrechner";
      this.Taschenrechner.UseVisualStyleBackColor = true;
      // 
      // Verlauf
      // 
      this.Verlauf.Controls.Add(this.tableLayoutPanel4);
      this.Verlauf.Location = new Point(4, 24);
      this.Verlauf.Name = "Verlauf";
      this.Verlauf.Padding = new Padding(3);
      this.Verlauf.Size = new Size(281, 399);
      this.Verlauf.TabIndex = 1;
      this.Verlauf.Text = "Verlauf";
      this.Verlauf.UseVisualStyleBackColor = true;
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 1;
      this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
      this.tableLayoutPanel4.Controls.Add(this.listBox1, 0, 0);
      this.tableLayoutPanel4.Dock = DockStyle.Fill;
      this.tableLayoutPanel4.Location = new Point(3, 3);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 2;
      this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
      this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
      this.tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
      this.tableLayoutPanel4.Size = new Size(275, 393);
      this.tableLayoutPanel4.TabIndex = 3;
      // 
      // tableLayoutPanel5
      // 
      this.tableLayoutPanel5.ColumnCount = 2;
      this.tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      this.tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      this.tableLayoutPanel5.Controls.Add(this.Btn_Delete, 0, 0);
      this.tableLayoutPanel5.Controls.Add(this.Btn_Delete_all, 1, 0);
      this.tableLayoutPanel5.Dock = DockStyle.Fill;
      this.tableLayoutPanel5.Location = new Point(3, 356);
      this.tableLayoutPanel5.Name = "tableLayoutPanel5";
      this.tableLayoutPanel5.RowCount = 1;
      this.tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      this.tableLayoutPanel5.Size = new Size(269, 34);
      this.tableLayoutPanel5.TabIndex = 4;
      // 
      // Btn_Delete
      // 
      this.Btn_Delete.Dock = DockStyle.Fill;
      this.Btn_Delete.Location = new Point(3, 3);
      this.Btn_Delete.Name = "Btn_Delete";
      this.Btn_Delete.Size = new Size(128, 28);
      this.Btn_Delete.TabIndex = 1;
      this.Btn_Delete.TabStop = false;
      this.Btn_Delete.Text = "Löschen";
      this.Btn_Delete.UseVisualStyleBackColor = true;
      this.Btn_Delete.Click += this.Btn_Delete_Click;
      // 
      // Btn_Delete_all
      // 
      this.Btn_Delete_all.Dock = DockStyle.Fill;
      this.Btn_Delete_all.Location = new Point(137, 3);
      this.Btn_Delete_all.Name = "Btn_Delete_all";
      this.Btn_Delete_all.Size = new Size(129, 28);
      this.Btn_Delete_all.TabIndex = 2;
      this.Btn_Delete_all.TabStop = false;
      this.Btn_Delete_all.Text = "Alles Löschen";
      this.Btn_Delete_all.UseVisualStyleBackColor = true;
      this.Btn_Delete_all.Click += this.Btn_Delete_all_Click;
      // 
      // listBox1
      // 
      this.listBox1.Dock = DockStyle.Fill;
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 15;
      this.listBox1.Location = new Point(3, 3);
      this.listBox1.Name = "listBox1";
      this.listBox1.SelectionMode = SelectionMode.MultiExtended;
      this.listBox1.Size = new Size(269, 347);
      this.listBox1.TabIndex = 0;
      this.listBox1.MouseUp += this.listBox1_MouseUp;
      // 
      // Form1
      // 
      this.AutoScaleMode = AutoScaleMode.None;
      this.ClientSize = new Size(289, 427);
      this.Controls.Add(this.TabControl1);
      this.MinimumSize = new Size(305, 466);
      this.Name = "Form1";
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Taschenrechner";
      this.Load += this.Form1_Load;
      this.Resize += this.Form1_Resize;
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.TabControl1.ResumeLayout(false);
      this.Taschenrechner.ResumeLayout(false);
      this.Taschenrechner.PerformLayout();
      this.Verlauf.ResumeLayout(false);
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel5.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_mult;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private Label label1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button Btn_res;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_empty;
        private System.Windows.Forms.Button btn_semo;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private TabControl TabControl1;
        private TabPage Taschenrechner;
        private TabPage Verlauf;
        private System.Windows.Forms.Button Btn_Delete;
        private ListBox listBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button Btn_Delete_all;
    }
}

