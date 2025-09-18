using Calculator.Models;

namespace Calculator.ModelsLogic
{
    internal class Calc : CalcModel
    {
        public override void Calculate()
        {
           Result = FirstNumber + SecondNumber;
        }
    }
}
