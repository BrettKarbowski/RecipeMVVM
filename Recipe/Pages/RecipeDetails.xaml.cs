using Recipe.Models;
using Microsoft.Maui.Controls;

namespace Recipe.Pages;

public partial class RecipeDetails : ContentPage
{
	public RecipeDetails(object item)
	{
		InitializeComponent();

        if (item is RecipeItem recipeItem)
        {
            itemTitle.Text = recipeItem.Title;
            itemImage.Source = ImageSource.FromUri(new Uri(recipeItem.ImageUrl));
            itemDescription.Text = recipeItem.Description;
            itemTime.Text = recipeItem.Time;
            itemIngredients.Text = recipeItem.Ingredients;
            itemDirections.Text = recipeItem.Directions;

        }
    }
}