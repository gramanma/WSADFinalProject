using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WSADFinalProject.Models
{
    internal class SeedRecipes : IEntityTypeConfiguration<Recipe>
    {

        public void Configure(EntityTypeBuilder<Recipe> entity)
        {
            entity.HasData(
                new Recipe { RecipeId = 1, 
                            RecipeName = "Pumpkin Soup", 
                            RecipeCategoryId = "soups", 
                            RecipeDesc = "You need to have this delightfully warming pumpkin soup in your little black book of dinners. Serve with a swirl of cream.", 
                            RecipePrepTime = "less than 30 mins", 
                            RecipeCookTime = "30 mins to 1 hour",
                            RecipeServings = "Serves 6–8", 
                            RecipeMethod = "Put the onion, carrots, garlic bay leaf, butter and half the olive oil into a large pan. Cook over a low–medium heat for about 10 minutes until the vegetables are tender but not coloured. \n Add the squash and potato, mix to combine and cook for a further 2–3 minutes. Pour in the stock, season well and bring to the boil. Reduce the heat to a gentle simmer, half cover the pan with a lid and continue to cook for about 40 minutes until the squash is really tender when tested with the point of a knife. \n Pick out the bay leaf and blend the soup until smooth using a stick blender. \n Add the cream and a little more stock if the soup is on the thick side, taste for seasoning, adding more salt and pepper as required. \n Meanwhile, heat the remaining oil in a frying pan over a medium heat and add the pumpkin seeds and fry quickly until the seeds start to pop. Remove from the pan. \n Ladle the soup into bowls and serve with a swirl of cream and the toasted pumpkin seeds."
                            },
                new Recipe { RecipeId = 2, 
                            RecipeName = "Chocolate Cake", 
                            RecipeCategoryId = "desserts", 
                            RecipeDesc = "Our really easy chocolate cake recipe is moist and fudgy and will keep well for 4–5 days.", 
                            RecipePrepTime = "less than 30 mins", 
                            RecipeCookTime = "30 mins to 1 hour",
                            RecipeServings = "Serves 12", 
                            RecipeMethod = "Preheat the oven to 180C/160C Fan/Gas 4. Grease and line two 20cm/8in sandwich tins.\n For the cake, place all of the cake ingredients, except the boiling water, into a large mixing bowl. Using a wooden spoon, or electric whisk, beat the mixture until smooth and well combined. \n Add the boiling water to the mixture, a little at a time, until smooth. (The cake mixture will now be very liquid.) \n Divide the cake batter between the sandwich tins and bake in the oven for 25–35 minutes, or until the top is firm to the touch and a skewer inserted into the centre of the cake comes out clean. \n Remove the cakes from the oven and allow to cool completely, still in their tins, before icing. \n For the chocolate icing, heat the chocolate and cream in a saucepan over a low heat until the chocolate melts. Remove the pan from the heat and whisk the mixture until smooth, glossy and thickened. Set aside to cool for 1–2 hours, or until thick enough to spread over the cake. \n To assemble the cake, run a round-bladed knife around the inside of the cake tins to loosen the cakes. Carefully remove the cakes from the tins. \n Spread a little chocolate icing over the top of one of the chocolate cakes, then carefully top with the other cake. \n Transfer the cake to a serving plate and ice the cake all over with the chocolate icing, using a palette knife."
                            }
                );
        }
    }

}
