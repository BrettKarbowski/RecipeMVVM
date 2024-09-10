using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe.Models
{
    public class RecipeItem
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Ingredients {  get; set; }
        
        public string Time {  get; set; }

        public string ImageUrl { get; set; }

        public string Directions { get; set; }
    }
}
