using System.Drawing;
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
            btn_add = new System.Windows.Forms.Button();
            btn_sub = new System.Windows.Forms.Button();
            btn_mult = new System.Windows.Forms.Button();
            btn_div = new System.Windows.Forms.Button();
            btn_1 = new System.Windows.Forms.Button();
            btn_2 = new System.Windows.Forms.Button();
            btn_3 = new System.Windows.Forms.Button();
            btn_6 = new System.Windows.Forms.Button();
            btn_5 = new System.Windows.Forms.Button();
            btn_4 = new System.Windows.Forms.Button();
            btn_9 = new System.Windows.Forms.Button();
            btn_8 = new System.Windows.Forms.Button();
            btn_7 = new System.Windows.Forms.Button();
            label1 = new Label();
            btn_clear = new System.Windows.Forms.Button();
            Btn_res = new System.Windows.Forms.Button();
            btn_0 = new System.Windows.Forms.Button();
            btn_empty = new System.Windows.Forms.Button();
            btn_semo = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            TabControl1 = new TabControl();
            Taschenrechner = new TabPage();
            Verlauf = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            Btn_Delete = new System.Windows.Forms.Button();
            Btn_Delete_all = new System.Windows.Forms.Button();
            listBox1 = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            TabControl1.SuspendLayout();
            Taschenrechner.SuspendLayout();
            Verlauf.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.AutoSize = true;
            btn_add.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_add.BackColor = SystemColors.ControlLight;
            btn_add.Dock = DockStyle.Fill;
            btn_add.Font = new Font("Segoe UI", 9F);
            btn_add.Location = new Point(204, 159);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(62, 46);
            btn_add.TabIndex = 0;
            btn_add.TabStop = false;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += Btn_add_Click;
            // 
            // btn_sub
            // 
            btn_sub.AutoSize = true;
            btn_sub.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_sub.BackColor = SystemColors.ControlLight;
            btn_sub.Dock = DockStyle.Fill;
            btn_sub.Font = new Font("Segoe UI", 11F);
            btn_sub.Location = new Point(204, 107);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(62, 46);
            btn_sub.TabIndex = 1;
            btn_sub.TabStop = false;
            btn_sub.Text = "-";
            btn_sub.UseVisualStyleBackColor = false;
            btn_sub.Click += Btn_sub_Click;
            // 
            // btn_mult
            // 
            btn_mult.AutoSize = true;
            btn_mult.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_mult.BackColor = SystemColors.ControlLight;
            btn_mult.Dock = DockStyle.Fill;
            btn_mult.Font = new Font("Segoe UI", 9F);
            btn_mult.Location = new Point(204, 55);
            btn_mult.Name = "btn_mult";
            btn_mult.Size = new Size(62, 46);
            btn_mult.TabIndex = 2;
            btn_mult.TabStop = false;
            btn_mult.Text = "*";
            btn_mult.UseVisualStyleBackColor = false;
            btn_mult.Click += Btn_mult_Click;
            // 
            // btn_div
            // 
            btn_div.AutoSize = true;
            btn_div.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_div.BackColor = SystemColors.ControlLight;
            btn_div.Dock = DockStyle.Fill;
            btn_div.Font = new Font("Segoe UI", 9F);
            btn_div.Location = new Point(204, 3);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(62, 46);
            btn_div.TabIndex = 3;
            btn_div.TabStop = false;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = false;
            btn_div.Click += Btn_div_Click;
            // 
            // btn_1
            // 
            btn_1.AutoSize = true;
            btn_1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_1.Dock = DockStyle.Fill;
            btn_1.Location = new Point(3, 159);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(61, 46);
            btn_1.TabIndex = 4;
            btn_1.TabStop = false;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += Btn_1_Click;
            // 
            // btn_2
            // 
            btn_2.AutoSize = true;
            btn_2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_2.Dock = DockStyle.Fill;
            btn_2.Location = new Point(70, 159);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(61, 46);
            btn_2.TabIndex = 5;
            btn_2.TabStop = false;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += Btn_2_Click;
            // 
            // btn_3
            // 
            btn_3.AutoSize = true;
            btn_3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_3.Dock = DockStyle.Fill;
            btn_3.Location = new Point(137, 159);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(61, 46);
            btn_3.TabIndex = 6;
            btn_3.TabStop = false;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += Btn_3_Click;
            // 
            // btn_6
            // 
            btn_6.AutoSize = true;
            btn_6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_6.Dock = DockStyle.Fill;
            btn_6.Location = new Point(137, 107);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(61, 46);
            btn_6.TabIndex = 9;
            btn_6.TabStop = false;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += Btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.AutoSize = true;
            btn_5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_5.Dock = DockStyle.Fill;
            btn_5.Location = new Point(70, 107);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(61, 46);
            btn_5.TabIndex = 8;
            btn_5.TabStop = false;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += Btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.AutoSize = true;
            btn_4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_4.Dock = DockStyle.Fill;
            btn_4.Location = new Point(3, 107);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(61, 46);
            btn_4.TabIndex = 7;
            btn_4.TabStop = false;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += Btn_4_Click;
            // 
            // btn_9
            // 
            btn_9.AutoSize = true;
            btn_9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_9.Dock = DockStyle.Fill;
            btn_9.Location = new Point(137, 55);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(61, 46);
            btn_9.TabIndex = 12;
            btn_9.TabStop = false;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += Btn_9_Click;
            // 
            // btn_8
            // 
            btn_8.AutoSize = true;
            btn_8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_8.Dock = DockStyle.Fill;
            btn_8.Location = new Point(70, 55);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(61, 46);
            btn_8.TabIndex = 11;
            btn_8.TabStop = false;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += Btn_8_Click;
            // 
            // btn_7
            // 
            btn_7.AutoSize = true;
            btn_7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_7.Dock = DockStyle.Fill;
            btn_7.Location = new Point(3, 55);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(61, 46);
            btn_7.TabIndex = 10;
            btn_7.TabStop = false;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += Btn_7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(263, 59);
            label1.TabIndex = 13;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_clear
            // 
            btn_clear.AutoSize = true;
            btn_clear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_clear.BackColor = SystemColors.ControlLight;
            btn_clear.Dock = DockStyle.Fill;
            btn_clear.Font = new Font("Segoe UI", 9F);
            btn_clear.Location = new Point(70, 3);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(61, 46);
            btn_clear.TabIndex = 14;
            btn_clear.TabStop = false;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += Btn_clear_Click;
            // 
            // Btn_res
            // 
            Btn_res.AutoSize = true;
            Btn_res.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn_res.BackColor = SystemColors.ControlLight;
            Btn_res.Dock = DockStyle.Fill;
            Btn_res.Font = new Font("Segoe UI", 9F);
            Btn_res.Location = new Point(204, 211);
            Btn_res.Name = "Btn_res";
            Btn_res.Size = new Size(62, 48);
            Btn_res.TabIndex = 15;
            Btn_res.TabStop = false;
            Btn_res.Text = "=";
            Btn_res.UseVisualStyleBackColor = false;
            Btn_res.Click += Btn_res_Click;
            // 
            // btn_0
            // 
            btn_0.AutoSize = true;
            btn_0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_0.Dock = DockStyle.Fill;
            btn_0.Font = new Font("Microsoft Sans Serif", 8.25F);
            btn_0.Location = new Point(70, 211);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(61, 48);
            btn_0.TabIndex = 16;
            btn_0.TabStop = false;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += Btn_0_Click;
            // 
            // btn_empty
            // 
            btn_empty.AutoSize = true;
            btn_empty.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_empty.BackColor = SystemColors.ControlLight;
            btn_empty.Dock = DockStyle.Fill;
            btn_empty.Font = new Font("Segoe UI", 9F);
            btn_empty.Location = new Point(137, 3);
            btn_empty.Name = "btn_empty";
            btn_empty.Size = new Size(61, 46);
            btn_empty.TabIndex = 17;
            btn_empty.TabStop = false;
            btn_empty.Text = "CE";
            btn_empty.UseVisualStyleBackColor = false;
            btn_empty.Click += Btn_empty_Click;
            // 
            // btn_semo
            // 
            btn_semo.AutoSize = true;
            btn_semo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_semo.Dock = DockStyle.Fill;
            btn_semo.Location = new Point(137, 211);
            btn_semo.Name = "btn_semo";
            btn_semo.Size = new Size(61, 48);
            btn_semo.TabIndex = 19;
            btn_semo.TabStop = false;
            btn_semo.Text = ",";
            btn_semo.UseVisualStyleBackColor = true;
            btn_semo.Click += Btn_semo_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(Btn_res, 3, 4);
            tableLayoutPanel1.Controls.Add(btn_5, 1, 2);
            tableLayoutPanel1.Controls.Add(btn_6, 2, 2);
            tableLayoutPanel1.Controls.Add(btn_7, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_clear, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_4, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_3, 2, 3);
            tableLayoutPanel1.Controls.Add(btn_0, 1, 4);
            tableLayoutPanel1.Controls.Add(btn_mult, 3, 1);
            tableLayoutPanel1.Controls.Add(btn_empty, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_2, 1, 3);
            tableLayoutPanel1.Controls.Add(btn_1, 0, 3);
            tableLayoutPanel1.Controls.Add(btn_8, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_div, 3, 0);
            tableLayoutPanel1.Controls.Add(btn_add, 3, 3);
            tableLayoutPanel1.Controls.Add(btn_9, 2, 1);
            tableLayoutPanel1.Controls.Add(btn_sub, 3, 2);
            tableLayoutPanel1.Controls.Add(btn_semo, 2, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 128);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(269, 262);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(269, 119);
            tableLayoutPanel2.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 59);
            label2.Name = "label2";
            label2.Size = new Size(263, 60);
            label2.TabIndex = 18;
            label2.TextAlign = ContentAlignment.MiddleRight;
            label2.UseMnemonic = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 32F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 68F));
            tableLayoutPanel3.Size = new Size(275, 393);
            tableLayoutPanel3.TabIndex = 25;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(Taschenrechner);
            TabControl1.Controls.Add(Verlauf);
            TabControl1.Dock = DockStyle.Fill;
            TabControl1.Location = new Point(0, 0);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(289, 427);
            TabControl1.TabIndex = 26;
            TabControl1.TabStop = false;
            TabControl1.KeyDown += TabControl1_KeyDown;
            // 
            // Taschenrechner
            // 
            Taschenrechner.Controls.Add(tableLayoutPanel3);
            Taschenrechner.Location = new Point(4, 24);
            Taschenrechner.Name = "Taschenrechner";
            Taschenrechner.Padding = new Padding(3);
            Taschenrechner.Size = new Size(281, 399);
            Taschenrechner.TabIndex = 0;
            Taschenrechner.Text = "Taschenrechner";
            Taschenrechner.UseVisualStyleBackColor = true;
            // 
            // Verlauf
            // 
            Verlauf.Controls.Add(tableLayoutPanel4);
            Verlauf.Location = new Point(4, 24);
            Verlauf.Name = "Verlauf";
            Verlauf.Padding = new Padding(3);
            Verlauf.Size = new Size(281, 399);
            Verlauf.TabIndex = 1;
            Verlauf.Text = "Verlauf";
            Verlauf.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Controls.Add(listBox1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(275, 393);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(Btn_Delete, 0, 0);
            tableLayoutPanel5.Controls.Add(Btn_Delete_all, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 356);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(269, 34);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // Btn_Delete
            // 
            Btn_Delete.Dock = DockStyle.Fill;
            Btn_Delete.Location = new Point(3, 3);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Size = new Size(128, 28);
            Btn_Delete.TabIndex = 1;
            Btn_Delete.TabStop = false;
            Btn_Delete.Text = "Löschen";
            Btn_Delete.UseVisualStyleBackColor = true;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // Btn_Delete_all
            // 
            Btn_Delete_all.Dock = DockStyle.Fill;
            Btn_Delete_all.Location = new Point(137, 3);
            Btn_Delete_all.Name = "Btn_Delete_all";
            Btn_Delete_all.Size = new Size(129, 28);
            Btn_Delete_all.TabIndex = 2;
            Btn_Delete_all.TabStop = false;
            Btn_Delete_all.Text = "Alles Löschen";
            Btn_Delete_all.UseVisualStyleBackColor = true;
            Btn_Delete_all.Click += Btn_Delete_all_Click;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(269, 347);
            listBox1.TabIndex = 0;
            listBox1.MouseUp += listBox1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(289, 427);
            Controls.Add(TabControl1);
            MinimumSize = new Size(305, 466);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Taschenrechner";
            Load += Form1_Load;
            Resize += Form1_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            TabControl1.ResumeLayout(false);
            Taschenrechner.ResumeLayout(false);
            Taschenrechner.PerformLayout();
            Verlauf.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
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

