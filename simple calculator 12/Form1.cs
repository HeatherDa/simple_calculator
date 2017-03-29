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
    }
}
