using System.ComponentModel;

namespace ContadorManual.Maui.Models
{

    public class Contador : INotifyPropertyChanged
    {

        private int _conteo;
        private int _incremento;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Conteo
        {
            get => _conteo;
            set
            {
                if(_conteo != value)
                {
                    _conteo = value;
                    OnPropertyChanged(nameof(Conteo));
                }
            }
        }

        public int Incremento
        {
            get => _incremento;
            set
            {
                if (_incremento != value)
                {
                    _incremento = value;
                }
            }
        }


        public Contador()
        {
            Conteo = 0;
            Incremento = 1;
        }

        public void Contar()
        {
            Conteo += Incremento;
        }

        public void Reiniciar()
        {
            Conteo = 0;
        }

        private void OnPropertyChanged(string propertyName)
        {

            if (PropertyChanged != null) 
            { 
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
