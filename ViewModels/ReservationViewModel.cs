namespace Lab4.ViewModels
{
    public class ReservationViewModel : ViewModelBase
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

        private int _CarID;
        public int CarID
        {
            get { return _CarID; }
            set
            {
                _CarID = value;
                OnPropertyChanged("CarID");
            }
        }

        private string _CustomerName;
        public string CustomerName
        {
            get { return _CustomerName; }
            set
            {
                _CustomerName = value;
                OnPropertyChanged("CustomerName");
            }
        }

        private string _CustomerSurname;
        public string CustomerSurname
        {
            get { return _CustomerSurname; }
            set
            {
                _CustomerSurname = value;
                OnPropertyChanged("CustomerSurname");
            }
        }

        private DateTime _TakeDate;
        public DateTime TakeDate
        {
            get { return _TakeDate; }
            set
            {
                _TakeDate = value;
                OnPropertyChanged("TakeDate");
            }
        }

        private DateTime _ReturnDate;
        public DateTime ReturnDate
        {
            get { return _ReturnDate; }
            set
            {
                _ReturnDate = value;
                OnPropertyChanged("ReturnDate");
            }
        }

        private string _ReservationStatus;
        public string ReservationStatus
        {
            get { return _ReservationStatus; }
            set
            {
                _ReservationStatus = value;
                OnPropertyChanged("ReservationStatus");
            }
        }
    }
}
