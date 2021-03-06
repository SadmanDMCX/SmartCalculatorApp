﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartCalculatorApp.Properties;
using CenterLizerProgramList;
using CalculationalLibrary;
using MetroFramework;
using static System.Double;

namespace SmartCalculatorApp
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {

        // Global Constants
        private const string NO_OPRATOR_AT_FITST = "No Oparator";
        // Global Constants End

        // Global variable
        private double leftVar = 0;
        private double rightVar = 0;
        private double finalResult = 0;

        private bool leftAddition = false;
        private bool isResultShowing = false;
        private bool isOparatorEnable = false;
        private bool isTextBoxNull = false;
        private bool isPositive = false;
        private bool isPositiveFirst = false;
        private bool isNotFirstValue = false;

        private int indexOfAnswers;
        private int isOprator = 0;
        private int randomColor = 0;

        private Button oparatorButton;
        // Global variable End 

        // Global Array
        private string[] holdAnswers;
        // Global Array End 

        // Global queue
        private Queue<string> oparator;
        // Global queue End

        // Global Enum 
        private enum Oparators
        {
            Plus = 1, Minus = 2, Mul = 3, Divide = 4
        }
        // Global Enum End



        // My Methods

        private void SetValueToTextBox(string getValue)
        {
            isOparatorEnable = true;
            if (!isResultShowing)
            {
                calculationTextBox.Text += getValue;
            }
            else
            {
                calculationTextBox.Text = getValue;
                isResultShowing = false;
            }

        }

        private void EqualMethodExecution()
        {
            if (oparatorButton.Text == "+")
            {
                try
                {
                    rightVar += Convert.ToDouble(calculationTextBox.Text.Remove(0, 2));
                    double result = 0;
                    maincenterofcalcbase.BasicCalculatorAdd(leftVar, rightVar, out result);
                    var temp = Convert.ToString(result);
                    showLastCalculation.Text += " " + calculationTextBox.Text + "\n";
                    holdAnswers[indexOfAnswers] = temp;
                    showCalculatedValue.Text = "";
                    foreach (var getAnswer in holdAnswers)
                    {
                        if (getAnswer != null)
                            showCalculatedValue.Text += getAnswer + "\n";
                        else
                            break;
                    }
                    indexOfAnswers++;
                    calculationTextBox.Text = temp;

                    leftVar = 0;
                    rightVar = 0;
                    leftAddition = false;
                    isResultShowing = true;
                    finalResult = result;
                }
                catch (Exception)
                {
                    MessageBox.Show(Resources.MainWindow_btnEqual_Click_You_have_to_enter_a_number_after__plus___sign_, Resources.MainWindow_btnEqual_Click_Error, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            else if (oparatorButton.Text == "-")
            {
                try
                {
                    rightVar += Convert.ToDouble(calculationTextBox.Text.Remove(0, 2));
                    double result = 0;
                    maincenterofcalcbase.BasicCalculatorSub(leftVar, rightVar, out result);
                    var temp = Convert.ToString(result);
                    showLastCalculation.Text += " " + calculationTextBox.Text + "\n";
                    holdAnswers[indexOfAnswers] = temp;
                    showCalculatedValue.Text = "";
                    foreach (var getAnswer in holdAnswers)
                    {
                        if (getAnswer != null)
                            showCalculatedValue.Text += getAnswer + "\n";
                        else
                            break;
                    }
                    indexOfAnswers++;
                    calculationTextBox.Text = temp;

                    leftVar = 0;
                    rightVar = 0;
                    leftAddition = false;
                    isResultShowing = true;
                    finalResult = result;
                }
                catch (Exception)
                {
                    MessageBox.Show(Resources.MainWindow_btnEqual_Click_You_have_to_enter_a_number_after__minus___sign_, Resources.MainWindow_btnEqual_Click_Error, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if (oparatorButton.Text == "*")
            {
                try
                {
                    rightVar += Convert.ToDouble(calculationTextBox.Text.Remove(0, 2));
                    double result = 0;
                    maincenterofcalcbase.BasicCalculatorMul(leftVar, rightVar, out result);
                    var temp = Convert.ToString(result);
                    showLastCalculation.Text += " " + calculationTextBox.Text + "\n";
                    holdAnswers[indexOfAnswers] = temp;
                    showCalculatedValue.Text = "";
                    foreach (var getAnswer in holdAnswers)
                    {
                        if (getAnswer != null)
                            showCalculatedValue.Text += getAnswer + "\n";
                        else
                            break;
                    }
                    indexOfAnswers++;
                    calculationTextBox.Text = temp;

                    leftVar = 0;
                    rightVar = 0;
                    leftAddition = false;
                    isResultShowing = true;
                    finalResult = result;
                }
                catch (Exception)
                {
                    MessageBox.Show("You have to enter a number after '*' sign!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if (oparatorButton.Text == "/")
            {
                try
                {
                    rightVar += Convert.ToDouble(calculationTextBox.Text.Remove(0, 2));
                    double result = 0;
                    maincenterofcalcbase.BasicCalculatorDiv(leftVar, rightVar, out result);
                    var temp = Convert.ToString(result);
                    showLastCalculation.Text += " " + calculationTextBox.Text + "\n";
                    holdAnswers[indexOfAnswers] = temp;
                    showCalculatedValue.Text = "";
                    foreach (var getAnswer in holdAnswers)
                    {
                        if (getAnswer != null)
                            showCalculatedValue.Text += getAnswer + "\n";
                        else
                            break;
                    }
                    indexOfAnswers++;
                    calculationTextBox.Text = temp;

                    leftVar = 0;
                    rightVar = 0;
                    leftAddition = false;
                    isResultShowing = true;
                    finalResult = result;
                }
                catch (Exception)
                {
                    MessageBox.Show("You have to enter a number after '/' sign!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            calculatelibmain.SetIndex(finalResult);
            finalResult = 0;
        }

        // Method End

        public MainWindow()
        {
            InitializeComponent();
            holdAnswers = new string[10000];
            indexOfAnswers = 0;
            oparator = new Queue<string>();
            oparator.Enqueue(NO_OPRATOR_AT_FITST);
            calculatelibmain.OnStartState();
            btnEqual.Enabled = false;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            basicToolStripMenuItem.Enabled = false;
        }
        
        private void OnClick_Number(object sender, EventArgs e)
        {
            Button get = (Button) sender;

            if (get.Text == ".")
            {
                if (!calculationTextBox.Text.Contains("."))
                {
                    SetValueToTextBox(get.Text);
                }
            }
                
            else
            {
                SetValueToTextBox(get.Text);
            }
        }

        private void ArithmeticOparation_PlusMinusDivideMultiply(object sender, EventArgs e)
        {
            isNotFirstValue = true;
            if (isOparatorEnable)
            {
                btnEqual.Enabled = true;
                oparatorButton = (Button) sender;

                oparator.Enqueue(oparatorButton.Text);

                if (oparator.Peek() == NO_OPRATOR_AT_FITST)
                {
                    oparator.Dequeue();
                    leftVar = Parse(calculationTextBox.Text);
                    showLastCalculation.Text += " " + calculationTextBox.Text;
                    calculationTextBox.Text = "";
                    leftAddition = true;
                    isResultShowing = false;
                    calculationTextBox.Text += oparator.Peek() + " ";

                }
                else if (oparator.Peek() == "+")
                {
                    oparator.Dequeue();
                    calculatelibmain.OnClickBtnPlus_Execution(ref leftAddition, ref leftVar, ref calculationTextBox,
                        ref showLastCalculation, ref showCalculatedValue, ref isResultShowing, oparatorButton.Text);
                }
                else if (oparator.Peek() == "-")
                {
                    oparator.Dequeue();
                    calculatelibmain.OnClickBtnMinus_Execution(ref leftAddition, ref leftVar, ref calculationTextBox,
                        ref showLastCalculation, ref showCalculatedValue, ref isResultShowing, oparatorButton.Text);
                }
                else if (oparator.Peek() == "*")
                {
                    oparator.Dequeue();
                    calculatelibmain.OnClickBtnMultiply_Execution(ref leftAddition, ref leftVar, ref calculationTextBox,
                        ref showLastCalculation, ref showCalculatedValue, ref isResultShowing, oparatorButton.Text);
                }
                else if (oparator.Peek() == "/")
                {
                    oparator.Dequeue();
                    calculatelibmain.OnClickBtnDivide_Execution(ref leftAddition, ref leftVar, ref calculationTextBox,
                        ref showLastCalculation, ref showCalculatedValue, ref isResultShowing, oparatorButton.Text);
                }
                isOparatorEnable = false;
            }
            else
            {
                MessageBox.Show("Error. Same Oparator!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            EqualMethodExecution();
            btnEqual.Enabled = false;
            isNotFirstValue = false;
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            leftVar = 0;
            rightVar = 0;
            leftAddition = false;
            isPositiveFirst = false;
            calculationTextBox.Text = "";
            showCalculatedValue.Text = "";
            showLastCalculation.Text = "";
            indexOfAnswers = 0;
            holdAnswers = new string[1000];
        }

        private void clearOne_Click(object sender, EventArgs e)
        {
            if (calculationTextBox.Text != "")
            {
                if (
                    calculationTextBox.Text.Equals("+ ") ||
                    calculationTextBox.Text.Equals("- ") ||
                    calculationTextBox.Text.Equals("* ") ||
                    calculationTextBox.Text.Equals("/ ") 
                    )
                {
                    
                }
                else
                {
                    calculationTextBox.Text =
                        calculationTextBox.Text.Remove(calculationTextBox.TextLength - 1, 1);
                }
                    
            }
            else
            {
                MessageBox.Show("Error null exception found.\nAdd something in the text box.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            if (
                (
                calculationTextBox.Text.Contains("+") ||
                calculationTextBox.Text.Contains("-") ||
                calculationTextBox.Text.Contains("*") ||
                calculationTextBox.Text.Contains("/") 
                ) && isNotFirstValue
            )
            {
                if (!isPositive)
                {
                    var getStrng = calculationTextBox.Text.Remove(0, 2);
                    calculationTextBox.Text = calculationTextBox.Text.Substring(0, 2) + "-" + getStrng;
                    isPositive = true;
                }
                else
                {
                    calculationTextBox.Text = calculationTextBox.Text.Remove(2, 1);
                    isPositive = false;
                }
                
            }
            else
            {
                if (!isPositiveFirst)
                {
                    if (!calculationTextBox.Text.Contains("-"))
                    {
                        calculationTextBox.Text = "-" + calculationTextBox.Text;
                        isPositiveFirst = true;
                    }
                    else
                    {
                        calculationTextBox.Text = calculationTextBox.Text.Remove(0, 1);
                        isPositiveFirst = false;
                    }
                }
                else
                {
                    calculationTextBox.Text = calculationTextBox.Text.Remove(0, 1);
                    isPositiveFirst = false;
                }    
            }
            
        }
        
        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindowSC sc = new MainWindowSC();
            sc.Show();
            this.Hide();
            basicToolStripMenuItem.Enabled = false;
        }

        private void OnClickColorChangePanel_OnClick(object sender, EventArgs e)
        {
            Color color;
            if (randomColor == 0)
            {
                randomColor = 1;
                color = Color.Black;
            }
            else if (randomColor == 1)
            {
                color = Color.DodgerBlue;
                randomColor = 2;
            }
            else
            {
                color = Color.DeepSkyBlue;
                randomColor = 0;
            }
            
            colorChangePanel.BackColor = color;

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
