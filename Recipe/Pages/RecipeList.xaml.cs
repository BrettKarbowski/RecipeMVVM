using Microsoft.Maui.Controls;
using Recipe.Models;
using System.Collections.Generic;

namespace Recipe.Pages
{
    public partial class RecipeList : ContentPage
    {
        public RecipeList()
        {
            InitializeComponent();

            var items = new List<RecipeItem>
            {
                new RecipeItem {
                    Title = "Ramos Gin Fizz",
                    ImageUrl = "https://dropinblog.net/34252347/files/featured/Ramos_Gin_Fizz_Elixir_Post__1_.png",
                    Time = "5 minutes",
                    Description = "A sweet and sour dessert cocktail.",
                    Ingredients = "2 ounces Gin\r\n1.5 ounces Raw syrup\r\n2 ounces heavy cream\r\n1 ounce lemon juice," +
                                " freshly squeezed\r\n1 ounce lime juice, freshly squeezed\r\n3 dashes orange flower water\r\n1 fresh" +
                                " egg white\r\nClub soda, chilled, to top",
                    Directions = "Add the Gin, Raw syrup, heavy cream, lemon and lime juices, orange flower water and " +
                                 "egg white into a shaker and shake vigorously until well chilled. Remove ice and shake again for " +
                                 "at least 40 seconds. Strain into a Collins glass and set in freezer for" +
                                 " 60 seconds. Poke a hole through the middle of the foam and pour club soda until foam rises"
                },

                new RecipeItem {
                    Title = "Mai Tai",
                    ImageUrl = "https://tastecocktails.com/wp-content/uploads/2016/06/Mai-tai-feature.png",
                    Time = "2 Minutes",
                    Description = "A tropical spirit forward cocktail",
                    Ingredients = "1.5 ounces white rum\r\n0.75 ounces orange curaçao\r\n0.75 ounces lime juice, freshly" +
                                " squeezed\r\n0.5 ounces orgeat\r\n0.5 ounces dark rum\r\nGarnish: lime wheel\r\nGarnish: mint" +
                                " sprig",
                    Directions = "Add the white rum, curaçao, lime juice and orgeat into a shaker with crushed ice\r\n" +
                                 " and shake lightly (about 3 seconds). Pour into a double rocks glass. Float " +
                                 "the dark rum over the top. Garnish with a lime wheel and mint sprig."
                },

                new RecipeItem {
                    Title = "Flan",
                    ImageUrl = "https://www.createwithnestle.ph/sites/default/files/srh_recipes/ba2bcd7939a1629882e40613a4bb513d.png",
                    Time = "1 Hour",
                    Description = "A sweet dessert",
                    Ingredients = "1 cup white sugar\r\n3 large eggs\r\n1 (14 ounce) can sweetened condensed milk\r\n1" +
                                  "(12 fluid ounce) can evaporated milk\r\n1 tablespoon vanilla extract", 
                    Directions = "Preheat the oven to 350 degrees F (175 degrees C).\r\nMelt sugar in a medium saucepan over medium-low heat " +
                                "until liquefied and golden in color. Carefully pour hot syrup into a deep 9-inch round glass baking dish, turning the dish" +
                                " to evenly coat the bottom; set aside.\r\nBeat eggs in a large bowl. Add condensed milk, evaporated milk, and vanilla; beat " +
                                "until smooth. Pour egg mixture on top of caramel in the baking dish; place in a deep roasting pan. Carefully pour in enough " +
                                "hot water to come 1 inch up the sides of the dish.\r\nBake in the preheated oven until just set with a slight jiggle in the" +
                                " center, about 1 hour, checking after 55 minutes. Keep in mind the flan will continue to set as it cools. Remove from the " +
                                "oven and carefully transfer baking dish to a wire rack; cool to room temperature, then cover with plastic wrap to prevent" +
                                " a skin forming. Refrigerate for 3 hours or up to 3 days.\r\n"
                },

                new RecipeItem {
                    Title = "Chicken Noodle Soup",
                    ImageUrl = "https://soulfoodcooking101.com/wp-content/uploads/2023/11/Screenshot-2023-11-07-at-10.36.12%E2%80%AFAM-1024x566.png",
                    Time = "30 Minutes",
                    Description = "A hearty soup.",
                    Ingredients = "1/2 Tablespoon butter\r\n2 ribs celery, diced\r\n3-4 large carrots diced\r\n1 clove" +
                                " garlic, minced\r\n10 cups chicken stock, or broth*\r\n1 teaspoon salt, to taste\r\n0.5 teaspoon freshly" +
                                " ground black pepper, to taste\r\n0.1 teaspoon dried rosemary\r\n0.1 teaspoon dried sage\r\n0.1 teaspoon" +
                                " crushed red pepper flakes\r\n5 cups dry egg noodles\r\n3 cups rotisserie chicken \r\n1 teaspoon better" +
                                " than bouillon chicken flavor", 
                    Directions = "Add butter, diced celery and carrots to a large stock pot over medium-high heat. Sauté for 3 minutes." +
                                " Add garlic and cook for another 30 seconds. \r\nAdd chicken stock and season the broth with rosemary, sage, crushed" +
                                " red pepper, salt, and pepper. \r\nBring broth to a boil. Add noodles and cook just until noodles are al dente." +
                                " \r\nRemove pot from heat as soon as they are just barely tender. \r\nAdd chicken meat from the rotisserie chicken. Taste the " +
                                "broth again and add more seasonings, if needed.\r\n"
                },

                new RecipeItem {
                    Title = "BLT Sandwich",
                    ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/06/BLT-Sanwich.png",
                    Time = "20 Minutes",
                    Description = "The Best Gosh Darn BLT Ever!",
                    Ingredients = "3 slices bacon \r\n1 small tomato\r\nKosher salt\r\nFreshly ground black pepper\r\n2 slices " +
                                  "hearty white sandwich bread\r\n2 tablespoons mayonnaise\r\n1 romaine lettuce leaf\r\n",
                    Directions = "Cook the bacon. \r\nSlice and season the tomato. Slice 1 small tomato crosswise with a serrated " +
                                "knife into 1/3-inch-thick slices. Place the slices in a single layer on a double layer of paper towels. Season" +
                                " lightly with kosher salt and some black pepper. Let sit while you toast the bread.\r\nToast the bread. Toast 2 " +
                                "slices of white sandwich bread until light golden brown.\r\nBuild the BLT. Spread 1 tablespoon mayonnaise on each " +
                                "slice of bread. Place 1 romaine lettuce leaf on one slice of bread, folding it as needed to fit neatly on the bread." +
                                " Top with the seasoned tomato slices in a single layer, cutting them in half as needed to fit in a single layer. Tear" +
                                " the 3 bacon slices in half and place on top of the tomatoes in 2 layers. Close the sandwich with the second slice of" +
                                " bread mayonnaise-side down.\r\nCut the BLT in half. Gently press down on the top of the sandwich to compact slightly. " +
                                "Cut in half with the serrated knife and serve immediately.\r\n"
                },

                new RecipeItem {
                    Title = "Beet Deviled Eggs",
                    ImageUrl = "https://www.awellcraftedparty.com/wp-content/uploads/2024/03/Pink-Deviled-Eggs-A-Well-Crafted-Party-Spring-Appetizer-640x457.png",
                    Time = "30 Minutes",
                    Description = "A twist on a classic deviled egg!",
                    Ingredients = "hard boiled eggs\r\n3 tablespoons mayonnaise\r\n1 teaspoon Dijon mustard \r\n1 teaspoon apple" +
                                " cider vinegar \r\nsalt and pepper, to taste\r\npaprika for garnish\r\nFor the Beet staining:\r\n2 " +
                                "medium beets, peeled and sliced\r\n3 cups water\r\n1 cup apple cider vinegar\r\n1 teaspoon kosher " +
                                "salt\r\n",
                    Directions = "Add the beets, water, vinegar, and salt to a pot over medium heat. Simmer for 20 to 25 minutes covered, " +
                                "until the beet is tender.\r\nLet the beet mixture cool completely, then transfer it to a large bowl." +
                                " Add the peeled eggs, making sure they're completely covered, then chill (stirring once or twice), for" +
                                " at least 2 hours. Chilling overnight will give a thicker pink color.\r\nRemove the eggs and pat dry." +
                                " Slice them in half lengthwise. Remove the yolk to a small bowl with a spoon and place the egg whites on" +
                                " a plate.\r\nMash the yolks with a fork and add the mayonnaise, mustard, vinegar, salt and pepper. Stir " +
                                "everything together until it's smooth.\r\nUse a spoon to add a portion of the deviled egg mixture back into" +
                                " the hole of each egg white. Sprinkle sliced chives on top for garnish.\r\n"
                },

                new RecipeItem
                {
                    Title = "Paloma",
                    ImageUrl = "https://images.getrecipekit.com/20220805042021-old-fashioned-paloma.png?aspect_ratio=4:3&quality=90&",
                    Time = "2 Minutes",
                    Description = "A refreshing grapefruit cocktail!",
                    Ingredients = "2 ounces of Reposado Tequila or any good quality Blanco\r\nJuice of half a ruby grapefruit\r\n0.75" +
                                " ounces of agave syrup or sugar syrup\r\nSplash of club soda\r\nA squirt of fresh lime juice optional\r\n",
                    Directions = "Mix the grapefruit juice, tequila and sugar syrup until well mixed.\r\nPour over a tall glass " +
                                "filled with ice and top up with soda water. You could add a squirt of lime juice which is nice and I did, and you" +
                                " could also rim the glass with salt.\r\n"
                }
            };

            listView.ItemsSource = items;
        }

        public Command<RecipeItem> ViewDetailsCommand => new Command<RecipeItem>(async (item) =>
        {
            if (item != null)
            {
                await Navigation.PushAsync(new RecipeDetails(item));
            }
        });

        private async void OnDetailButtonClicked(object sender, EventArgs e)
        {
            // Ensure the button's CommandParameter is bound and passed to the handler
            if (sender is Button button && button.CommandParameter is RecipeItem item)
            {
                await Navigation.PushAsync(new RecipeDetails(item));
            }
        }
    }
}
