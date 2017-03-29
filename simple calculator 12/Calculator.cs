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
        List<string> operators = new List<string>();//what operator/s are in use?
        public Calculator() { }//empty constructor.  do I need it?


        public Calculator(string input)//for using with typed input.  when paired with a seperate calculate method, could make operator methods unnecessary
        {
            CurrentValue = input;
            parseInput(input);//create List of calculation elements
        }
        public void EnterValue()//enters a value into the calculator 
            //(which contains two most recent entries 
            //(entry1+entry2=entry3+entry4=entry5 etc.  so forgets previous values when it calculates))
            //this could be triggered by hitting an operator or calculate button other than "."
        {

        }
        public void Add()//pending operation is ADD
            //associated with clicking add button or typing "+"
        {

        }
        public void Subtract()//pending operation is Subtract
        {

        }
        public void Multiply()//pending operation is Multiply
        {

        }
        public void Divide()//pending operation is Divide
        {

        }

        public void Equals()//calculates the result of the pending operation
        {

        }
        public void Reciprocal()//calculates the reciprocal of the current values
        {

        }
        public void SquareRoot()//calculates the square root fo the current value
        {

        }
        public void Clear()//clears the calculator (including recent values)
        {
            
        }
        private void parseInput(string input)
        {
            String[] numbers = input.Split('+', '-', '/', '*');//string of input would, theoretically, only contain characters that exist on the keyboard

            foreach (char a in input)
            {
                
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
