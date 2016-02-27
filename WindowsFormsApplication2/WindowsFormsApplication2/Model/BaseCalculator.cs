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

        public string Evaluate(string text)//secondnumbers text
        {
            secondNumber = double.Parse(text);


            switch (operation)
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
            return resultNumber.ToString();
           

        }


     /*   public string Evaluateoper(string text)
        {
            secondNumber = double.Parse(text);
           // currentState = State.WaitingForFirstNumber;

            //
            // рассмотреть 3 случая надо
            switch (currentState)// now CS is waiting1number
            {
                case State.WaitingForOperation:// значит тут только одно число ,либо нечетное количество(то есть sqrt for firstnumber ввели только что)
                    currentState = State.WaitingForResult;

                    break;
                case State.WaitingForSecondNumber:
                    currentState = State.WaitingForResult;
                    text = "";
                    break;

                case State.WaitingForResult:
                    currentState = State.WaitingForResult;
                    text = "";
                    break;
            }
            return resultNumber.ToString();
        }


        /*  public string Evaluateoper(string text)
          {
              secondNumber = double.Parse(text);
              currentState = State.WaitingForFirstNumber;

              switch (operationres)
              {
                  case "sqrt":
                      resultNumber = Math.Sqrt(secondNumber);
                      break;

                  case "%":

                      switch (operation)
                      {
                          case Operation.None:
                              break;
                          case Operation.Plus:
                              resultNumber = firstNumber + (secondNumber / 100.0) * firstNumber;
                              break;
                          case Operation.Minus:
                              resultNumber = firstNumber - (secondNumber / 100.0) * firstNumber;
                              break;
                          case Operation.Divide:
                              resultNumber = 100.0 / secondNumber;
                              break;
                          case Operation.Multiplication:
                              resultNumber = firstNumber * secondNumber * (firstNumber / 100.0);
                              break;

                          default:
                              break;
                      }
                      break;

                  case "1/x":
                      resultNumber = 1 / secondNumber;
                      break;



                      return resultNumber.ToString();

              }
          }
          */
    }
}
