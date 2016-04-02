using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2.Model
{

    public enum State
    {
        WaitingForFirstNumber,
        WaitingForSecondNumber,
        WaitingForOperation,
        WaitingForResult,
    }

    public enum Operation
    {
        None,
        Plus,
        Minus,
        Divide,
        Multiplication
    }



    public class BaseCalculator
    {
        public double firstNumber = 0;
        public double secondNumber = 0;
        public double resultNumber = 0;
        public State currentState = State.WaitingForFirstNumber;
        public Operation operation = Operation.None;
        public string operationres;
        public double memoryNumber = 0;

        public string Evaluate(string text)//secondnumbers text(+в случае когда прибавляем() третье число к первому и второму сразу без равно
        {
             
            secondNumber = double.Parse(text);

                       
                switch (operation)//  если в случае 5+2-3 то операция первая (+)
                {
                    case Operation.None:
                        break;
                    case Operation.Plus:
                        resultNumber = firstNumber + secondNumber;
                        break;
                    case Operation.Minus:
                        resultNumber = firstNumber - secondNumber;
                        break;
                    case Operation.Divide:
                        resultNumber = firstNumber / secondNumber;
                        break;
                    case Operation.Multiplication:
                        resultNumber = firstNumber * secondNumber;
                        break;

                    default:
                        break;
                }
                firstNumber = resultNumber;
                currentState = State.WaitingForOperation;//!!
                

           
               
         
            return resultNumber.ToString();// выводит на экран,поэтому как только нажали вторую операцию(и тд) он сразу выводит трезультат 


        }
    }
}
    

        