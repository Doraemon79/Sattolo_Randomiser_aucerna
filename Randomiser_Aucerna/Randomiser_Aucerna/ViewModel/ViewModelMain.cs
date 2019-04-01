using Randomiser_Aucerna.Helper;
using Randomiser_Aucerna.Model.Interfaces;
using Randomiser_Aucerna.ViewModel.Interfaces;
using System;
using System.ComponentModel;

namespace Randomiser_Aucerna.ViewModel
{
    class ViewModelMain : ViewModelBase, IClosableViewModel, INotifyPropertyChanged
    {
        public event EventHandler CloseWindowEvent;
        public event PropertyChangedEventHandler PropertyChanged;

        #region Fields

        public IMyValues _myValues;
        public IRandomiser _iRandomiser;
        int[] ArrayValue;
        string TextItemValue;
        bool isBackEnabled = false;

        #endregion

        #region Properties

        /// <summary>
        /// Values to show in the listbox
        /// </summary>
        public int[] Items
        {
            get { return ArrayValue; }
            set
            {
                ArrayValue = value;
                OnPropertyChanged("Items");
            }
        }

        /// <summary>
        /// Values to show in the textbox
        /// </summary>
        public string TextItems
        {
            get { return TextItemValue; }
            set
            {
                TextItemValue = value;
                OnPropertyChanged("TextItems");
            }

        }

        /// <summary>
        /// This boolean is just to avoid somepne to click on the button several times 
        /// and cause a crash
        /// </summary>
        public bool ShowTextIsEnabledBool
        {
            get { return isBackEnabled; }
            set
            {
                isBackEnabled = value;
                OnPropertyChanged("ShowTextIsEnabledBool");
            }
        }

      
        /// <summary>
        /// Commands properties binding to the buttons
        /// </summary>
        public RelayCommand ShuffleCommand { get; set; }
        public RelayCommand ShowInTextBoxCommand { get; set; }
        public RelayCommand ResetArrayCommand { get; set; }
        #endregion

        /// <summary>
        /// Main constructor slightly violates the SOLID pattern by creating the 
        /// default start array but it makes things simpler. 
        /// 
        /// </summary>
        /// <param name="myValues"></param>
        /// <param name="randomiser"></param>
        public ViewModelMain(IMyValues myValues, IRandomiser randomiser)
        {
            _myValues = myValues;
            _iRandomiser = randomiser;

            _myValues.SetMyArrayValue(_myValues.CreateStartArray());
            Items = _myValues.GetMyArrayValue();
            ShowTextIsEnabledBool = true;

            ShuffleCommand = new RelayCommand(Shuffler, canexecute);
            ShowInTextBoxCommand = new RelayCommand(ShowInTextBox, canexecute);
            ResetArrayCommand = new RelayCommand(ResetArray, canexecute);
        }

        /// <summary>
        /// condition to start commands, in this case it can be set to true by default
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        private bool canexecute(object parameter)
        {

            bool res = true;

            return res;
        }

        /// <summary>
        /// Takes the array and fills it with its own randomised values
        /// </summary>
        /// <param name="parameter"></param>
        public void Shuffler(object parameter)
        {
            Items = null;
            Items = _iRandomiser.Shuffle(_myValues.GetMyArrayValue());
        }

        /// <summary>
        /// Command to update the textbox, uunforunately being a series of toString() newline is
        /// very slow.
        /// </summary>
        /// <param name="parameter"></param>
        public void ShowInTextBox(object parameter)
        {
            ShowTextIsEnabledBool = false;
            TextItems = null;
            foreach (var i in Items)
            {
                TextItems += i.ToString() + Environment.NewLine;
            }

            ShowTextIsEnabledBool = true;
        }

        /// <summary>
        /// rest the array to the ordered state we have by default
        /// </summary>
        /// <param name="parameter"></param>
       public void  ResetArray(object parameter)
        {
            Items = null;
            Items = _myValues.CreateStartArray();
        }

        /// <summary>
        /// To bind the events
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

