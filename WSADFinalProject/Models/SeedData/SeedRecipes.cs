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
                            },
                new Recipe { RecipeId = 3, 
                            RecipeName = "Cheese and ham omelette", 
                            RecipeCategoryId = "breakfast", 
                            RecipeDesc = "Try this classic omelette for brunch or serve with lots of green salad for a quick and satisfying dinner.", 
                            RecipePrepTime = "less than 30 mins", 
                            RecipeCookTime = "less than 10 mins",
                            RecipeServings = "Serves 1", 
                            RecipeMethod = "Gently beat the eggs together in a mixing bowl and season, to taste, with salt and pepper. Heat the butter in a frying pan until foaming. Pour in the eggs and cook for a few seconds, until the bottom of the omelette is lightly set. Push the set parts of the omelette into the uncooked centre of the omelette. Cook again, until the omelette has set further, then push those set parts into the centre of the omelette again. Repeat the process until the eggs have just set but the omelette is still soft in the centre. Put the cheese and three-quarters of the ham in the centre of the omelette and cook until the cheese has melted. Increase the heat to high and cook the omelette for a further 30 seconds, or until it browns on the bottom. Fold the omelette in half, then remove the pan from the heat and tilt it slightly to move the omelette to the edge of the pan. Slide the omelette onto a serving plate, then shape it into a neat roll. Sprinkle over the remaining ham."
                            },
                new Recipe { RecipeId = 4, 
                            RecipeName = "Club Sandwich", 
                            RecipeCategoryId = "sandwich", 
                            RecipeDesc = "A club sandwich is a thing of beauty. You can fancy it up with extra fillings like avocado, mustard, thinly sliced red onion, but you can also keep it simple. This double layer sandwich is definitely filling enough for dinner with a side of soup or some crispy chips.", 
                            RecipePrepTime = "less than 30 mins", 
                            RecipeCookTime = "10 to 30 minss",
                            RecipeServings = "Serves 1", 
                            RecipeMethod = "Heat a frying pan over a medium heat. Add a drizzle of oil, then the bacon slices to the pan and fry for 5–10 minutes, turning the bacon every so often, until it is crisp and browned all over. Transfer to a plate lined with kitchen paper. Slice the chicken breast horizontally in two, so you have two thinner pieces. Season with salt and pepper, then fry the chicken in the hot bacon fat over a medium–high heat until they are browned and completely cooked through. Meanwhile, toast the bread to your liking. Spread each slice with a teaspoon of mayonnaise. Build the sandwich by adding lettuce leaves and tomato slices to the bottom piece of toast, season with salt and black pepper, then top with a slice of the crisp hot bacon. Slice each large piece of chicken breast into 4 or 5 equal pieces on a diagonal so they are easy to spread across the sandwich. Place the second piece of toast on top, then repeat the layering again finishing with the final piece of toast. Cut the sandwich diagonally in both directions to create 4 triangles, securing each with a cocktail stick."
                            }
                );
        }
    }

}
