using System;
using Xamarin.Forms;

namespace TestImageIssue
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            BindingContext = new MainPageViewModel();
        }
        
        private void BtnSave_OnClicked(object sender, EventArgs e)
        {
            var test = new OrderItemImageDocData(Title = "test", ImageSource.FromUri(new Uri(@"https://upload.wikimedia.org/wikipedia/commons/7/7b/Dark_brown.PNG")));
            if (BindingContext is MainPageViewModel pageViewModel)
            {
                pageViewModel.OrderItemImages.Add(test);
                // pageViewModel.OrderItemImages.Last().ImageData = Xamarin.Forms.ImageSource.FromUri(new Uri(@"https://upload.wikimedia.org/wikipedia/commons/7/7b/Dark_brown.PNG"));
            }
        }
    }
}