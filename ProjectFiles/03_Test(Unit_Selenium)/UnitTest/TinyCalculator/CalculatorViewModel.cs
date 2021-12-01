using Prism.Commands;
using System.ComponentModel;
using System.Windows.Input;

namespace TinyCalculator
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public CalculatorViewModel()
        {
            _calculateCommand = new DelegateCommand(() =>
            {
                Calculator calculator = new Calculator();
                Result = calculator.Calculate(Input);
            });
        }

        public string Input { get; set; }

        ICommand _calculateCommand;
        public ICommand CalculateCommand {
            get 
            {
                return _calculateCommand;
            }
        }

        int _result;
        public int Result
        {
            get
            {
                return _result;
            }
            set
            {
                _result = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Result"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}