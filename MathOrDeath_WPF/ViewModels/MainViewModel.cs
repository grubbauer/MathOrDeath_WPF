using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MathOrDeath_WPF.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _input;

        [ObservableProperty]
        private string _equation;

        [ObservableProperty]
        private bool _isCorrect;

        [ObservableProperty]
        private double _CorrectValue;
    }
}
