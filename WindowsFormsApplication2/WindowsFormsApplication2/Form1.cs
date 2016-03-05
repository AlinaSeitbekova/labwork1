using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication2.Model;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Model.BaseCalculator caclulator = new Model.BaseCalculator();
        public Form1()
        {
            InitializeComponent();
        }





        private void tab_click(object sender, EventArgs e)// object and its condition
        {
            if (display.Text == "0")
                display.Clear();
            Button btn = sender as Button;

            switch (caclulator.currentState)// now CS is waiting1number
            {
                case State.WaitingForFirstNumber:
                    caclulator.currentState = State.WaitingForOperation;
                    break;
                case State.WaitingForSecondNumber: // ввели 2 число 
                     display.Text = "";//чтобы обнулился экран от 1 числа
                     caclulator.currentState = State.WaitingForResult;
                     break;
              //  case State.WaitingForResult:
                   // caclulator.secondNumber = double.Parse(display.Text);
                    //break;
               
            }
            if (btn.Text == ".")
            {
                if (!display.Text.Contains("."))
                    display.Text += btn.Text;// если уже содержит эту точку то ничего
            }
            else

                display.Text += btn.Text;// считывает число и выводит на экран
        }





        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            
                      
            
            if (caclulator.currentState == State.WaitingForResult)//!!то есть если уже два числа ввели и хотим дальше продолжить(сложить с 3)
            {
                display.Text = caclulator.Evaluate(display.Text);// к этому моменту первое число уже преобразовано,второе на  экране// отобразится результат 1+2 как одно новое первое число
                // evaluate- first and second number evaluation
            }
            // они внизу,так как иначе он считывает второе число как первое в случае  прибавления третьего числа
            caclulator.firstNumber = double.Parse(display.Text);//чтобы преобразовать в числовое выражение 
            caclulator.currentState = State.WaitingForSecondNumber;
            

            switch (btn.Text)
            {
                case "+":
                    caclulator.operation = Operation.Plus;
                    break;
                case "-":
                    caclulator.operation = Operation.Minus;
                    break;
                case "*":
                    caclulator.operation = Operation.Multiplication;
                    break;
                case "/":
                    caclulator.operation = Operation.Divide;
                    break;
            }
        }
        


        private void resultoper_click(object sender, EventArgs e)
        {   
            Button operationresult = sender as Button;
            string operationres = operationresult.Text;


           

                if (caclulator.currentState == State.WaitingForOperation)//to est vveli odno chislo            {
                {
                    caclulator.firstNumber = double.Parse(display.Text);
                    switch (operationres)
                    {
                        case "sqrt":
                            caclulator.firstNumber = Math.Sqrt(caclulator.firstNumber);
                            break;

                        case "%":
                            caclulator.firstNumber = 0.0;
                            break;

                        case "1/x":
                            caclulator.firstNumber = 1.0 / caclulator.firstNumber;
                            break;

                        default:
                            break;
                    }


                    display.Text = caclulator.firstNumber.ToString();
                }
              
            // to est vveli dva chisla bez ravno
                if (caclulator.currentState == State.WaitingForResult)
                {   //считываем 2 число и вычисляем корень для него,используется для 2 и 3 случая(без равно и с )
                    caclulator.secondNumber = double.Parse(display.Text);
                    switch (operationres)
                    {
                        case "sqrt":
                            caclulator.secondNumber = Math.Sqrt(caclulator.secondNumber);
                            break;

                        case "%":
                            caclulator.secondNumber = (caclulator.firstNumber * caclulator.secondNumber) / 100.0;
                            break;

                        case "1/x":
                            caclulator.secondNumber = 1.0 / caclulator.secondNumber;
                            break;

                        default:
                            break;
                    }


                    display.Text = caclulator.secondNumber.ToString();
                }
                
            }

            
            
        


        private void result_click(object sender, EventArgs e)
        {
            
            display.Text = caclulator.Evaluate(display.Text);//
        }





        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void clear_click(object sender, EventArgs e)
        {
            Button clear = sender as Button;
            string operationclear = clear.Text;

            switch (operationclear)
            {
                case "CE"://ydalit poslednee vvedennoe chislo
                    {
                        if (caclulator.currentState == State.WaitingForOperation)//to est vveli odno chislo   
                            caclulator.firstNumber = 0;
                        else if (caclulator.currentState == State.WaitingForResult)//to est vveli 2 chisla   
                        {
                            caclulator.secondNumber = 0;
                            display.Text = "0";
                        }
                    }

                    break;
                case "C":// ydalit vse
                   display.Text = "0";
                    break;
                
                default:
                    break;
            }
           

        }

        private void display_click(object sender, EventArgs e)
        {

        }
        private void memory_click(object sender, EventArgs e)
        {

            Button operationMemoryButton = sender as Button;
            string operationMemory = operationMemoryButton.Text;

            switch (operationMemory)
            {
                case "MS"://zapis znacheniya v  bufer
                    caclulator.memoryNumber = double.Parse(display.Text);
                    break;
                case "MC":// ochistka bufera
                    caclulator.memoryNumber = 0;
                    break;
                case "MR":// vivod znacheniya iz bufera na display
                    display.Text = caclulator.memoryNumber.ToString();
                    break;
                case "M+":// pribavit znachenie k znacheniu iz bufera
                    caclulator.memoryNumber = caclulator.memoryNumber + double.Parse(display.Text);
                    break;
            }
            memory.Text = caclulator.memoryNumber.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
