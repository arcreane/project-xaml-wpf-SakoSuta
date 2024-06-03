using System.Windows.Controls;

namespace EatsEngine
{
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            this.DataContext = new RecipeViewModel();
        }
    }
}
