using dtMauiAPp.ViewModels;

namespace dtMauiAPp
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            BindingContext= mainPageViewModel;
            
        }

    }

}
