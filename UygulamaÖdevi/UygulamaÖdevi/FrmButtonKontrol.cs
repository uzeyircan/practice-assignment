using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.Button;

namespace UygulamaÖdevi
{
    using System;
    using System.Windows.Forms;

   
        public partial class FrmButtonKontrol : Form
        {
            private double deger1 = 0;
            private double deger2 = 0;
            private string operatorler = "";

            private TextBox resultTextBox;
            private Label resultLabel;

            public FrmButtonKontrol()
            {
                InitializeComponent();
                InitializeUI();
            }

            private void InitializeUI()
            {
                resultTextBox = new TextBox
                {
                    Width = 200,
                    Height = 30,
                    Top = 10,
                    Left = 10,
                    TextAlign = HorizontalAlignment.Right
                };

                resultLabel = new Label
                {
                    Width = 200,
                    Height = 30,
                    Top = 50,
                    Left = 10,
                    TextAlign = ContentAlignment.MiddleRight,
                    Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold)
                };

                Controls.Add(resultTextBox);
                Controls.Add(resultLabel);

                string[] buttonLabels = {
                "7", "8", "9", "/",
                "4", "5", "6", "*",
                "1", "2", "3", "-",
                "0", ".", "=", "+"
            };

                int left = 10;
                int top = 90;
                int buttonWidth = 50;
                int buttonHeight = 50;

                foreach (string label in buttonLabels)
                {
                    Button button = new Button
                    {
                        Text = label,
                        Width = buttonWidth,
                        Height = buttonHeight,
                        Left = left,
                        Top = top
                    };

                    button.Click += Button_Click;
                    Controls.Add(button);

                    left += buttonWidth + 5;

                    if (left > 220)
                    {
                        left = 10;
                        top += buttonHeight + 5;
                    }
                }
            }

            private void Button_Click(object sender, EventArgs e)
            {
                Button button = (Button)sender;
                string buttonText = button.Text;

                if (buttonText == "=")
                {
                    deger2 = double.Parse(resultTextBox.Text);
                    double result = CalculateResult();
                    resultLabel.Text = result.ToString();
                    resultTextBox.Text = result.ToString();
                    deger1 = result;
                    deger2 = 0;
                    operatorler = "";
                }
                else if (buttonText == "C")
                {
                    resultTextBox.Text = "";
                    resultLabel.Text = "";
                    deger1 = 0;
                    deger2 = 0;
                    operatorler = "";
                }
                else if (buttonText == "+" || buttonText == "-" || buttonText == "*" || buttonText == "/")
                {
                    if (!string.IsNullOrEmpty(resultTextBox.Text))
                    {
                        deger1 = double.Parse(resultTextBox.Text);
                        operatorler = buttonText;
                        resultTextBox.Text = "";
                    }
                }
                else
                {
                    resultTextBox.Text += buttonText;
                }
            }

            private double CalculateResult()
            {
                switch (operatorler)
                {
                    case "+":
                        return deger1 + deger2;
                    case "-":
                        return deger1- deger2;
                    case "*":
                        return deger1 * deger2;
                    case "/":
                        if (deger2 != 0)
                        {
                            return deger1 / deger2;
                        }
                        else
                        {
                            MessageBox.Show("Sıfıra bölünemez!");
                            return 0;
                        }
                    default:
                        return 0;
                }
            }
        }

        
    }


