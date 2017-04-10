using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_calculator_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //need button click handling method for all buttons (or maybe one for numbers and decimal and one for operators and one for calculations?)
        //need error handling for divide by zero
        //need error handling for clicking operator before number ("." and "+/-" excluded ("." would add 0 before "." and "+/-" would add "-" sign.))
        //if using typed feedback, need error handling for isNumber


        /*
         Here's my btn handler from other version:
         private void btn_Handler(object sender, EventArgs e)
        {
            string btnName = "";
            if (sender == btn1) btnName = btnName + "1";
            else if (sender == btn2) btnName = "2";
            else if (sender == btn3) btnName = "3";
            else if (sender == btn4) btnName = "4";
            else if (sender == btn5) btnName = "5";
            else if (sender == btn6) btnName = "6";
            else if (sender == btn7) btnName = "7";
            else if (sender == btn8) btnName = "8";
            else if (sender == btn9) btnName = "9";
            else if (sender == btn0) btnName = "0";
            else if (sender == btnDecimal) btnName = btnName + ".";

            else if (sender == btnDivide) btnName = btnName + " / ";
            else if (sender == btnMultiply) btnName = btnName + " * ";
            else if (sender == btnSub) btnName = btnName + " - ";
            else if (sender == btnAdd) btnName = btnName + " + ";
            
            THE FOLLOWING SHOULD REFERE TO CALCULATOR CLASS:
            else if (sender == btnSign) Sign(display);//toggle positive /negative
            else if (sender == btnSqrt) Sqrt(display);//calculate and display square root
            else if (sender == btnReciprocal) Reciprocal(display);//calculate and display reciprocal
            else if (sender == btnEquals) Calculate(display);//calculate results of other equations
            
            display = display + btnName;
            txtDisplay.Text = display;
        }

        private void Calculate(string display)
        {
            throw new NotImplementedException();
            //use string to calculate result of equation
        }

        private void Sign(string display)//toggle sign
        {
            throw new NotImplementedException();
            //set display to result
        }

        private void Reciprocal(string btnName)//calculate reciprocal
        {
            throw new NotImplementedException();
            //set display to result
        }

        private void Sqrt(string btnName)//calculate square root
        {
            throw new NotImplementedException();
            //set display to result
        }
         */
    }
}
