using System.ComponentModel;
using Xamarin.Forms;

namespace TestImageIssue
{
    public class OrderItemImageDocData : INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Fields

        private string _title = string.Empty;
        private ImageSource _imageData;

        #endregion

        #region Constr

        public OrderItemImageDocData(string title, ImageSource imgData)
        {
            _title = title;
            ImageData = imgData;
        }

        #endregion

        #region Properties

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Title"));
            }
        }

        public ImageSource ImageData
        {
            get { return _imageData; }
            set
            {
                _imageData = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("ImageData"));
            }
        }

        #endregion
    }
}