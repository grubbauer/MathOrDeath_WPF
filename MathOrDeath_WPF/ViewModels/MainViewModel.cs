using CommunityToolkit.Mvvm.ComponentModel;
using MathOrDeath_WPF.Equation;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Threading;

namespace MathOrDeath_WPF.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private EquationGenerator _equationGenerator = new EquationGenerator();
        private GenerateResult _generateResult = new GenerateResult();
        private DispatcherTimer _timer;

        [ObservableProperty]
        private string _input;

        [ObservableProperty]
        private string _equation;

        [ObservableProperty]
        private bool _isCorrect;

        [ObservableProperty]
        private bool _isWrong;

        [ObservableProperty]
        private double _correctValue;

        [ObservableProperty]
        private double _progress;

        private int lvl = 1;

        public void Initialize()
        {
            _timer = new DispatcherTimer();
            _timer.Tick += TimerTick;
            _timer.Interval = TimeSpan.FromSeconds(0.1);
            _timer.Start();
        }

        private void TimerTick(object? sender, EventArgs e)
        {
            Progress += 1;
            if (Progress >= 100)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }

        [RelayCommand]
        private void Check()
        {
            Input = Input.Replace('.', ',');
            if (double.TryParse(Input, out var parsedResult))
            {
                Console.WriteLine(Math.Round(_generateResult.getEquationResult(Equation), 2));
                double result = Math.Round(_generateResult.getEquationResult(Equation), 2);
                IsCorrect = result == parsedResult;
                IsWrong = result != parsedResult;
            }

            if (IsCorrect)
            {
                Console.WriteLine("Correct!");
                lvl++;
                Equation = _equationGenerator.GenerateEquation(lvl);
                Input = string.Empty;
                Progress = 0;
                _timer.Stop();
                _timer.Start();
            }
            if (IsWrong)
            {
                System.Windows.Application.Current.Shutdown();
            }

        }

        public MainViewModel()
        {
            Equation = _equationGenerator.GenerateEquation(lvl);
        }
    }
}
