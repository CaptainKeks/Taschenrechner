using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Taschenrechner_V1._0
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Button currentButton;

        double number1, number2, result;
        Buttons PressedButton;
        Buttons actual_arithmetic;
        string symbol;
        public string calculated;
        private Rectangle OriganlFormRect;
        bool ResultClicked = false;
        #region ActualSize var
        float originalBtn_0Size;
        float originalBtn_1Size;
        float originalBtn_2Size;
        float originalBtn_3Size;
        float originalBtn_4Size;
        float originalBtn_5Size;
        float originalBtn_6Size;
        float originalBtn_7Size;
        float originalBtn_8Size;
        float originalBtn_9Size;
        float originalBtn_addSize;
        float originalBtn_subSize;
        float originalBtn_multSIze;
        float originalBtn_divSize;
        float orignalBtn_resultSize;
        float originalBtn_semSize;
        float originalBtn_clearSize;
        float originalBtn_deleteSize;
        float originalLabel1_Size;
        float originalLabel2_Size;
        float originalListBox_Size;
        float originalListDel_Size;
        float originalListClear_Size;
        #endregion


        enum Buttons
        {
            Zero,
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            ClearAll,
            Comma,
            Add,
            Subtract,
            Multiply,
            Divide,
            zero
        }


        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            OriganlFormRect = new Rectangle(this.Location, this.Size);
            originalBtn_0Size = btn_0.Font.Size;
            originalBtn_1Size = btn_1.Font.Size;
            originalBtn_2Size = btn_2.Font.Size;
            originalBtn_3Size = btn_3.Font.Size;
            originalBtn_4Size = btn_4.Font.Size;
            originalBtn_5Size = btn_5.Font.Size;
            originalBtn_6Size = btn_6.Font.Size;
            originalBtn_7Size = btn_7.Font.Size;
            originalBtn_8Size = btn_8.Font.Size;
            originalBtn_9Size = btn_9.Font.Size;
            originalBtn_addSize = btn_add.Font.Size;
            originalBtn_subSize = btn_sub.Font.Size;
            originalBtn_multSIze = btn_mult.Font.Size;
            originalBtn_divSize = btn_div.Font.Size;
            originalBtn_semSize = btn_semo.Font.Size;
            originalBtn_clearSize = btn_clear.Font.Size;
            originalBtn_deleteSize = btn_empty.Font.Size;
            originalLabel1_Size = label1.Font.Size;
            originalLabel2_Size = label2.Font.Size;
            originalListBox_Size = listBox1.Font.Size;
            originalListDel_Size = Btn_Delete.Font.Size;
            originalListClear_Size = Btn_Delete_all.Font.Size;
            orignalBtn_resultSize = Btn_res.Font.Size;
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            TabControl1.SelectedTab = TabControl1.TabPages[""];
        }

        #region Button_Methods


        private void Btn_add_Click(object sender, EventArgs e)
        {
            GetNumber();
            actual_arithmetic = Buttons.Add;
            label2.Text = number1 + " +";
            symbol = "+";
        }

        private void Btn_sub_Click(object sender, EventArgs e)
        {
            GetNumber();
            actual_arithmetic = Buttons.Subtract;
            label2.Text = number1 + " -";
            symbol = "-";
        }

        private void Btn_mult_Click(object sender, EventArgs e)
        {
            GetNumber();
            actual_arithmetic = Buttons.Multiply;
            label2.Text = number1 + " *";
            symbol = "*";
        }

        private void Btn_div_Click(object sender, EventArgs e)
        {
            GetNumber();
            actual_arithmetic = Buttons.Divide;
            label2.Text = number1 + " /";
            symbol = "/";
        }


        // Die rechnung als liste speichern

        private List<string> liste = new List<string>();

        private void Btn_res_Click(object sender, EventArgs e)
        {
            number2 = Convert.ToDouble(label1.Text);
            GetArithmeticOperation();
            calculated = Convert.ToString(number1) + " " + symbol + " " + Convert.ToString(number2) + " = " + result;
            label1.Text = result.ToString();
            AddToList();
            InitializeCalaculation();
            ResultClicked = false;
        }

        private void AddToList()
        {
            liste.Add(calculated);
            listBox1.Items.Add(calculated);
        }

        private void InitializeCalaculation()
        {
            actual_arithmetic = Buttons.zero;
            GetArithmeticOperation();
            ResultClicked = true;
            number1 = 0;
            number2 = 0;
            result = 0;
            symbol = "";


        }

        private void Btn_clear_Click(object sender, EventArgs e)  // initialise evereything
        {
            number1 = 0;
            number2 = 0;
            result = 0;
            symbol = "";
            label1.Text = "0";
            label2.Text = "";
            PressedButton = Buttons.ClearAll;
            actual_arithmetic = Buttons.zero;
        }

        #endregion

        #region Button_Numbers
        string label_number;
        double clicked_number;

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (System.Windows.Forms.Button)btnSender || currentButton == (System.Windows.Forms.Button)btnSender)
                {
                    currentButton = (System.Windows.Forms.Button)btnSender;
                    label_number = currentButton.Text;

                    if (label1.Text != "0" && !ResultClicked)
                    {
                        label1.Text += label_number;
                    }
                    else
                    {
                        label1.Text = label_number;
                    }
                }
                
                btnSender = null;
            }
        }


        private void Btn_empty_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Btn_semo_Click(object sender, EventArgs e)
        {
            PressedButton = Buttons.Comma;
            ProcessInput();
            ResultClicked = false;
        }

        #endregion

        private void GetNumber()
        {
            number1 = Convert.ToDouble(label1.Text);
            PressedButton = Buttons.ClearAll;
            ProcessInput();
        }

        private void GetArithmeticOperation()
        {
            switch (actual_arithmetic)             // tracks the method that is klicked
            {
                case Buttons.Add:
                    result = number1 + number2;
                    break;
                case Buttons.Subtract:
                    result = number1 - number2;
                    break;
                case Buttons.Multiply:
                    result = number1 * number2;
                    break;
                case Buttons.Divide:
                    result = number1 / number2;
                    break;
                case Buttons.zero:
                    label2.Text = "";
                    break;
            }
        }

        private void ProcessInput()
        {
            switch (PressedButton)             // tracks the number that is klicked
            {
                case Buttons.Comma:
                    if (label1.Text.Contains(',') && !ResultClicked)
                    {
                        MessageBox.Show("Es gitb keine zwei Kommas!");
                    }
                    else if (ResultClicked)
                    {
                        label1.Text = "0";
                        label1.Text += ",";
                        ResultClicked = false;
                    }
                    else
                    {
                        label1.Text += ",";
                    }
                    break;
                case Buttons.ClearAll:
                    label1.Text = "0";
                    break;
                default:
                    string number = Convert.ToString(Convert.ToInt16(PressedButton));

                    if (label1.Text != "0" && !ResultClicked)
                        label1.Text += number;
                    else
                        label1.Text = number;

                    break;
            }
        }

        private void ListBoxDelete()
        {
            MessageBox.Show("Es ist kein Eintrag ausgewählt, bitte Wähle einen aus oder gib eine Rechnung in den Taschenrechner ein!");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeFonts();
        }

        private void ResizeControl(Control control, float originalFontSize)
        {
            float ratio = (float)this.ClientRectangle.Width / (float)OriganlFormRect.Width;
            float newFontSize = originalFontSize * ratio;
            Font newFont = new Font(control.Font.FontFamily, newFontSize);
            control.Font = newFont;
        }

        private void ResizeFonts()
        {
            ResizeControl(btn_0, originalBtn_0Size);
            ResizeControl(btn_1, originalBtn_1Size);
            ResizeControl(btn_2, originalBtn_2Size);
            ResizeControl(btn_3, originalBtn_3Size);
            ResizeControl(btn_4, originalBtn_4Size);
            ResizeControl(btn_5, originalBtn_5Size);
            ResizeControl(btn_6, originalBtn_6Size);
            ResizeControl(btn_7, originalBtn_7Size);
            ResizeControl(btn_8, originalBtn_8Size);
            ResizeControl(btn_9, originalBtn_9Size);
            ResizeControl(btn_add, originalBtn_addSize);
            ResizeControl(btn_sub, originalBtn_subSize);
            ResizeControl(btn_mult, originalBtn_multSIze);
            ResizeControl(btn_div, originalBtn_divSize);
            ResizeControl(Btn_res, orignalBtn_resultSize);
            ResizeControl(btn_semo, originalBtn_semSize);
            ResizeControl(btn_empty, originalBtn_deleteSize);
            ResizeControl(btn_clear, originalBtn_clearSize);
            ResizeControl(label1, originalLabel1_Size);
            ResizeControl(label2, originalLabel2_Size);
            ResizeControl(listBox1, originalListBox_Size);
            ResizeControl(Btn_Delete, originalListDel_Size);
            ResizeControl(Btn_Delete_all, originalListClear_Size);
        }

        private void DeleteItems()
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
                }
            }
            else
            {
                ListBoxDelete();
            }
        }

        private void Tastatur(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.NumPad0:
                    {
                        btn_0.PerformClick();
                    }
                    break;

                case Keys.NumPad1:
                    {
                        btn_1.PerformClick();
                    }
                    break;

                case Keys.NumPad2:
                    {
                        btn_2.PerformClick();
                    }
                    break;

                case Keys.NumPad3:
                    {
                        btn_3.PerformClick();
                    }
                    break;

                case Keys.NumPad4:
                    {
                        btn_4.PerformClick();
                    }

                    break;

                case Keys.NumPad5:
                    {
                        btn_5.PerformClick();
                    }
                    break;

                case Keys.NumPad6:
                    {
                        btn_6.PerformClick();
                    }
                    break;

                case Keys.NumPad7:
                    {
                        btn_7.PerformClick();
                    }
                    break;

                case Keys.NumPad8:
                    {
                        btn_8.PerformClick();
                    }
                    break;

                case Keys.NumPad9:
                    {
                        btn_9.PerformClick();
                    }
                    break;

                case Keys.Add:
                    {
                        btn_add.PerformClick();
                    }
                    break;

                case Keys.Subtract:
                    {
                        btn_sub.PerformClick();
                    }
                    break;

                case Keys.Multiply:
                    {
                        btn_mult.PerformClick();
                    }
                    break;

                case Keys.Divide:
                    {
                        btn_div.PerformClick();
                    }
                    break;

                case Keys.Enter:
                    {
                        Btn_res.PerformClick();
                    }
                    break;

                case Keys.Decimal:
                    {
                        btn_semo.PerformClick();
                    }
                    break;

            }

        }

        private void TabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox1.SetSelected(i, true);
                }
            }

            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && TabControl1.SelectedTab == TabControl1.TabPages["Verlauf"])
            {
                DeleteItems();
            }

            if (TabControl1.SelectedTab == TabControl1.TabPages["Taschenrechner"])
            {
                Tastatur(e);
            }
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }


        #region DeleteHistory

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

            DeleteItems();

        }

        private void Btn_Delete_all_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                {
                    listBox1.Items.Clear();
                }
            }
            else if (listBox1.Items.Count < 1)
            {
                ListBoxDelete();
            }
        }

        #endregion

    }
}