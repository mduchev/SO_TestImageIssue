using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TestImageIssue.Annotations;

namespace TestImageIssue
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<OrderItemImageDocData> orderItemImages =
            new ObservableCollection<OrderItemImageDocData>();

        public ObservableCollection<OrderItemImageDocData> OrderItemImages
        {
            get => orderItemImages;
            set
            {
                orderItemImages = value;
                OnPropertyChanged(nameof(OrderItemImages));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}