namespace Lab4.ViewModels
{
    public class CarViewModel : ViewModelBase
    {
        private int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;
                OnPropertyChanged("ID");
            }
        }

        private string _Model;
        public string Model
        {
            get { return _Model; }
            set
            {
                _Model = value;
                OnPropertyChanged("Model");
            }
        }

        private string _Number;
        public string Number
        {
            get { return _Number; }
            set
            {
                _Number = value;
                OnPropertyChanged("Number");
            }
        }

        private double _Price;
        public double Price
        {
            get { return _Price; }
            set
            {
                _Price = value;
                OnPropertyChanged("Price");
            }
        }

        private bool _IsAvaliable;
        public bool IsAvaliable
        {
            get { return _IsAvaliable; }
            set
            {
                _IsAvaliable = value;
                OnPropertyChanged("Price");
            }
        }

        private string _Fuel;
        public string Fuel
        {
            get { return _Fuel; }
            set
            {
                _Fuel = value;
                OnPropertyChanged("Fuel");
            }
        }
    }
}
