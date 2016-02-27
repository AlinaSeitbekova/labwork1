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
                case State.WaitingForSecondNumber:
                    caclulator.currentState = State.WaitingForResult;
                    display.Text = "";
                    break;
            }
            if (btn.Text == ".")
            {
                if (!display.Text.Contains("."))
                    display.Text += btn.Text;// если уже содержит эту точку то ничего
            }
            else

                display.Text += btn.Text;
        }





        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

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
            /*Button operationresult = sender as Button;
            string operationres = operationresult.Text;
            display.Text = caclulator.Evaluateoper(display.Text);
           //Button btn = sender as Button;
          */
            //calculator.secondNumber = double.Parse(display.Text)
        }


        private void result_click(object sender, EventArgs e)
        {
            display.Text = caclulator.Evaluate(display.Text);
        }





        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void clear_click(object sender, EventArgs e)
        {

        }

        private void display_click(object sender, EventArgs e)
        {

        }
        private void memory_click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
