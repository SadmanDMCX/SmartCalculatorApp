using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace CalculationalLibrary
{
    public class calculatelibmain
    {

        private static string[] arrayOfLeft;
        private static int index;

        public static void OnStartState()
        {
            arrayOfLeft = new string[10000];
            index = 0;
        }

        // Add
        public static void OnClickBtnPlus_Execution(ref bool isLeft, ref double leftVar, ref TextBox calculationTextBox, ref MetroLabel showLastCalculation, ref MetroLabel showCalculatedValue, ref bool isResultShowing, string oparatorButton)
        {
            if (isLeft == false)
            {
                leftVar = Convert.ToDouble(calculationTextBox.Text);
                showLastCalculation.Text += " " + calculationTextBox.Text;
                calculationTextBox.Text = "";
                isLeft = true;
                isResultShowing = false;
            }
            else
            {
                leftVar += Convert.ToDouble(calculationTextBox.Text.Remove(0, 2));
                showLastCalculation.Text += " " + calculationTextBox.Text;
                showCalculatedValue.Text = "";
                arrayOfLeft[index] = leftVar.ToString();
                foreach (var get in arrayOfLeft)
                {
                    if (get != null)
                    {
                        showCalculatedValue.Text += get;
                    }
                    else
                    {
                        break;
                    }
                }
                calculationTextBox.Text = "";
            }
            calculationTextBox.Text += oparatorButton + " ";
        }

        // Minus
        public static void OnClickBtnMinus_Execution(ref bool isLeft, ref double leftVar, ref TextBox calculationTextBox, ref MetroLabel showLastCalculation, ref MetroLabel showCalculatedValue, ref bool isResultShowing, string oparatorButton)
        {
            if (isLeft == false)
            {
                leftVar = Convert.ToDouble(calculationTextBox.Text);
                showLastCalculation.Text += " " + calculationTextBox.Text;
                calculationTextBox.Text = "";
                isLeft = true;
                isResultShowing = false;
            }
            else
            {
                leftVar -= Convert.ToDouble(calculationTextBox.Text.Remove(0, 2));
                showLastCalculation.Text += " " + calculationTextBox.Text;
                showCalculatedValue.Text = "";
                arrayOfLeft[index] = leftVar.ToString();
                foreach (var get in arrayOfLeft)
                {
                    if (get != null)
                    {
                        showCalculatedValue.Text += get;
                    }
                    else
                    {
                        break;
                    }
                }
                calculationTextBox.Text = "";
            }
            calculationTextBox.Text += oparatorButton + " ";
        }


        // Multiply
        public static void OnClickBtnMultiply_Execution(ref bool isLeft, ref double leftVar, ref TextBox calculationTextBox, ref MetroLabel showLastCalculation, ref MetroLabel showCalculatedValue, ref bool isResultShowing, string oparatorButton)
        {
            if (isLeft == false)
            {
                leftVar = Convert.ToDouble(calculationTextBox.Text);
                showLastCalculation.Text += " " + calculationTextBox.Text;
                calculationTextBox.Text = "";
                isLeft = true;
                isResultShowing = false;
            }
            else
            {
                leftVar *= Convert.ToDouble(calculationTextBox.Text.Remove(0, 2));
                showLastCalculation.Text += " " + calculationTextBox.Text;
                showCalculatedValue.Text = "";
                arrayOfLeft[index] = leftVar.ToString();
                foreach (var get in arrayOfLeft)
                {
                    if (get != null)
                    {
                        showCalculatedValue.Text += get;
                    }
                    else
                    {
                        break;
                    }
                }
                calculationTextBox.Text = "";
            }
            calculationTextBox.Text += oparatorButton + " ";
        }


        // Divide
        public static void OnClickBtnDivide_Execution(ref bool isLeft, ref double leftVar, ref TextBox calculationTextBox, ref MetroLabel showLastCalculation, ref MetroLabel showCalculatedValue, ref bool isResultShowing, string oparatorButton)
        {
            if (isLeft == false)
            {
                leftVar = Convert.ToDouble(calculationTextBox.Text);
                showLastCalculation.Text += " " + calculationTextBox.Text;
                calculationTextBox.Text = "";
                isLeft = true;
                isResultShowing = false;
            }
            else
            {
                leftVar /= Convert.ToDouble(calculationTextBox.Text.Remove(0, 2));
                showLastCalculation.Text += " " + calculationTextBox.Text;
                showCalculatedValue.Text = "";
                arrayOfLeft[index] = leftVar.ToString();
                foreach (var get in arrayOfLeft)
                {
                    if (get != null)
                    {
                        showCalculatedValue.Text += get;
                    }
                    else
                    {
                        break;
                    }
                }
                calculationTextBox.Text = "";
            }
            calculationTextBox.Text += oparatorButton + " ";
        }


        // Mod
        public static void OnClickBtnMod_Execution(ref bool isLeft, ref double leftVar, ref TextBox calculationTextBox, ref MetroLabel showLastCalculation, ref MetroLabel showCalculatedValue, ref bool isResultShowing, string oparatorButton)
        {
            if (isLeft == false)
            {
                leftVar = Convert.ToDouble(calculationTextBox.Text);
                showLastCalculation.Text += " " + calculationTextBox.Text;
                calculationTextBox.Text = "";
                isLeft = true;
                isResultShowing = false;
            }
            else
            {
                leftVar %= Convert.ToDouble(calculationTextBox.Text.Remove(0, 3));
                showLastCalculation.Text += " " + calculationTextBox.Text;
                showCalculatedValue.Text = "";
                arrayOfLeft[index] = leftVar.ToString();
                foreach (var get in arrayOfLeft)
                {
                    if (get != null)
                    {
                        showCalculatedValue.Text += get;
                    }
                    else
                    {
                        break;
                    }
                }
                calculationTextBox.Text = "";
            }
            calculationTextBox.Text += oparatorButton + " ";
        }


        public static void SetIndex(double finalResult)
        {
            arrayOfLeft[index] = finalResult + "\n";
            index++;
        }

    }
}
