using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator_12
{
    class Calculator
    {
        private string CurrentValue = "";//it's what's displayed in the txtbox, so string
        public Calculator() { }//empty constructor.  do I need it?
        public Calculator(string input)//for using with typed input
        {
            CurrentValue = input;
            parseInput(input);//create List of calculation elements
        }

        private void parseInput(string input)
        {
            String[] numbers = input.Split('+', '-', '/', '*');//string of input would, theoretically, only contain characters that exist on the keyboard

            foreach (char a in input)
            {
                string num1 = "";
                List<string> operators = new List<string>();
                if (Operator(a)) operators.Add(Convert.ToString(a));//collect operators
            }
        }
        private Boolean Operator(char a)
        {
            bool isOperator= false;
            string operators = "/*-+";
            foreach(char b in operators)
            {

                if (a.Equals(b)){
                    isOperator = true;
                }
            }

            return isOperator;
                

        }
    }
}
