using System.ComponentModel;

namespace Randomiser_Aucerna
{
    /// <summary>
    /// Base class for the other ViewModelBases
    /// usuallz I make it more complex, in this case I just need to implement Inotifzpropertychanged
    /// </summary>
    class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// raise the event of PropertyChanged
        /// </summary>
        /// <param name="prop"></param>
        internal void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        // Declare the event
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// OnPropertyChanged method to raise the event of property changed
        /// </summary>
        /// <param name="propertyname"></param>
        private void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }


    }
}


