using System.ComponentModel;
using System.Runtime.CompilerServices;
using SumaDosNumeros.Models;

namespace SumaDosNumeros.ViewModels
{
    public class SumarNumeros : INotifyPropertyChanged
    {
        private readonly CalcularNumeros _calcular = new CalcularNumeros();

        public double N1
        {
            get => _calcular.N1;
            set
            {
                if (_calcular.N1 != value)
                {
                    _calcular.N1 = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Result));
                }
            }
        }

        public double N2
        {
            get => _calcular.N2;
            set
            {
                if (_calcular.N2 != value)
                {
                    _calcular.N2 = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(Result));
                }
            }
        }

        public double Result => _calcular.Result;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    } 
}
