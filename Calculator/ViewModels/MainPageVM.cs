using Calculator.Models;
using Calculator.ModelsLogic;
using System.Windows.Input;

namespace Calculator.ViewModels
{
    internal class MainPageVM:ObservableObject
    {
        private readonly Calc c = new() ;
        public ICommand AddCommand => new Command(Add);
        public string Result { get => c.Result.ToString(); }
        public double FirstNumber { get => c.FirstNumber; set => c.FirstNumber = value; }
        public double SecondNumber { get => c.SecondNumber; set => c.SecondNumber = value; }
        public void Add()
        {
            c.Calculate();
            OnPropertyChanged(nameof(Result));
        }
    }
}
