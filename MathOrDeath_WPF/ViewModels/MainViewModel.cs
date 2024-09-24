using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MathOrDeath_WPF.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private EquationGenerator _equationGenerator = new EquationGenerator();
        private GenerateResult _generateResult = new GenerateResult();

        [ObservableProperty]
        private string _input;

        [ObservableProperty]
        private string _equation;

        [ObservableProperty]
        private bool _isCorrect;

        [ObservableProperty]
        private double _CorrectValue;

        [RelayCommand]
        private void Check()
        {
            if (double.TryParse(Input, out var parsedResult))
            {
                double result = _generateResult.getEquationResult(Equation);
                IsCorrect = result == parsedResult;
            }

        }

        public MainViewModel()
        {
            Equation = _equationGenerator.GenerateEquation(10);
        }
    }
}
