namespace Calculator.Models
{
    internal abstract class CalcModel
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double Result { get; protected set; }
        public abstract void Calculate();

    }
}
