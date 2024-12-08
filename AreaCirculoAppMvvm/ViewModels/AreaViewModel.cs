
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using System.Windows.Input;

namespace AreaCirculoAppMvvm.ViewModels
{
    public partial class AreaViewModel: ObservableObject
    {
        public const double PI = 3.1415926535897931;

        [ObservableProperty]
        private double radio;

        [ObservableProperty]
        private double resultado;





        [RelayCommand]

        private void CalcularArea()
        {
            Resultado = PI * Radio * Radio;
        }
        [RelayCommand]
        private void LimpiarCampos()
        {
            Radio = 0;
            Resultado = 0;
        }
    }
}
