using Recipe.Pages;

namespace Recipe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set the main page to a NavigationPage containing the RecipeList page
            MainPage = new NavigationPage(new RecipeList());
        }
    }
}
