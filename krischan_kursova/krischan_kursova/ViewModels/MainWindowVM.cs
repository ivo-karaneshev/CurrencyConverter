using krischan_kursova.Models;
using krischan_kursova.Services;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace krischan_kursova.ViewModels
{
    class MainWindowVM : INotifyPropertyChanged
    {
        #region Fields

        private Array currencies;

        private DelegateCommand btnConvertCommand;

        private CurrencyConverter currencyConverter;

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion



        #region Properties

        public double InputFirst { get; set; }

        public Currency CurrencyFirst { get; set; }

        public string OutputFirst { get; set; }

        public double InputSecond { get; set; }

        public Currency CurrencySecond { get; set; }

        public string OutputSecond { get; set; }

        public Array Currencies
        {
            get
            {
                if (currencies == null || currencies.Length == 0)
                {
                    currencies = Enum.GetValues(typeof(Currency));
                }

                return currencies;
            }
        }

        public ICommand BtnConvertCommand
        {
            get
            {
                if (btnConvertCommand == null)
                {
                    btnConvertCommand = new DelegateCommand(BtnConvertClick, BtnConvertValidate);
                }

                return btnConvertCommand;
            }
        }

        #endregion



        public MainWindowVM()
        {
            this.currencyConverter = new CurrencyConverter();
        }

        private void BtnConvertClick()
        {
            OutputFirst = currencyConverter.ConvertFrom(CurrencyFirst, InputFirst).ToString("F2");
            OnPropertyChanged("OutputFirst");
            OutputSecond = currencyConverter.ConvertTo(CurrencySecond, InputSecond).ToString("F2");
            OnPropertyChanged("OutputSecond");
        }

        private bool BtnConvertValidate()
        {
            // Validation logic
            return true;
        }

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
