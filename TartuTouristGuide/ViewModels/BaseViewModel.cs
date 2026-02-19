using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TartuTouristGuide.ViewModels
{
    // Base class for all ViewModels to handle property change notifications (MVVM pattern)
    public class BaseViewModel : INotifyPropertyChanged
    {
        // Event triggered when a property value changes
        public event PropertyChangedEventHandler? PropertyChanged;

        // Notifies the UI that a specific property has been updated
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Updates a property's value and raises a change notification if the value actually changed
        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
