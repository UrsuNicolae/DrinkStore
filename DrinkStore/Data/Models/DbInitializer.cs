using DrinkStore.Data;
using DrinkStore.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DrinkAndGo.Data
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Drinks.Any())
            {
                context.AddRange
                (
                    new Drink
                    {
                        Name = "Beer",
                        Price = 7.95M,
                        ShortDescription = "The most widely consumed alcohol",
                        LongDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://www.holidify.com/images/cmsuploads/compressed/684133728_20180601001931.jpg",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://steptohealth.com/wp-content/uploads/2015/10/beer.jpg"
                    },
                    new Drink
                    {
                        Name = "Rum & Coke",
                        Price = 12.95M,
                        ShortDescription = "Cocktail made of cola, lime and rum.",
                        LongDescription = "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://www.thespruceeats.com/thmb/AmLtrs-JBC7Yq_rNwwIWF09CNp0=/1000x562/smart/filters:no_upscale()/rum-coke-5a8f3360875db90036ac14ca.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://assets3.thrillist.com/v1/image/2767672/size/tmg-article_default_mobile.jpg"
                    },
                    new Drink
                    {
                        Name = "Tequila ",
                        Price = 12.95M,
                        ShortDescription = "Beverage made from the blue agave plant.",
                        LongDescription = "Tequila (Spanish About this sound [teˈkila] (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://previews.123rf.com/images/malinkaphoto/malinkaphoto1610/malinkaphoto161000047/65179678-tequila-gold-mexican-alcohol-in-shot-glasses-lime-and-salt-toned-image-selective-focus.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://previews.123rf.com/images/tasipas/tasipas1604/tasipas160400019/55903531-three-shots-of-gold-tequila-with-lime-and-salt-on-the-black-background-tequila-shot-gold-mexican-teq.jpg"
                    },
                    new Drink
                    {
                        Name = "Wine ",
                        Price = 16.75M,
                        ShortDescription = "A very elegant alcoholic drink",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://bestdecantersets.com/wp-content/uploads/2018/10/Wine-Glasses-Cover.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://cms.splendidtable.org/sites/default/files/styles/w2000/public/wine-glasses_andresr-iStock-GettyImagesPlus-468917818-LEDE.jpg?itok=atCY6SJT"
                    },
                    new Drink
                    {
                        Name = "Margarita",
                        Price = 17.95M,
                        ShortDescription = "A cocktail with sec, tequila and lime",
                        Category = Categories["Alcoholic"],
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        ImageUrl = "https://tendercrate.com/wp-content/uploads/2019/04/Margarita002-500x375.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/gettyimages-957892610-1554995400.jpg"
                    },
                    new Drink
                    {
                        Name = "Whiskey with Ice",
                        Price = 15.95M,
                        ShortDescription = "The best way to taste whiskey",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://www.pulse.lk/wp-content/uploads/2016/08/Whiskey-on-the-rocks.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://assets3.thrillist.com/v1/image/2704804/size/tmg-article_default_mobile.jpg"
                    },
                    new Drink
                    {
                        Name = "Jägermeister",
                        Price = 15.95M,
                        ShortDescription = "A German digestif made with 56 herbs",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://images.ctfassets.net/kjc0jmow0idt/eJnaiTnZOSo4ieEqA40AY/33f973e817e2a517e8ef692319eae435/teaser_instagram.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://images.ctfassets.net/mj09inqdun29/1N3lTkTacE2eywUs8MaOEw/96c4f63a53407355f30197d76ce1cce2/jaegermusic.jpg"
                    },
                    new Drink
                    {
                        Name = "Champagne",
                        Price = 15.95M,
                        ShortDescription = "That is how sparkling wine can be called",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://www.urlaub-obertauern.at/media/product/b26/sekt-champagner-d95.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://www.handelsblatt.com/images/prickelnde-probleme/19569686/2-format2020.jpg"
                    },
                    new Drink
                    {
                        Name = "Piña colada ",
                        Price = 15.95M,
                        ShortDescription = "A sweet cocktail made with rum.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://cdn2.cocinadelirante.com/sites/default/files/styles/gallerie/public/images/2019/03/receta-pina-colada-sin-alcohol.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://d1u8lt4eqehkou.cloudfront.net/wp-content/uploads/easy-pina-colada-recipe.jpg"
                    },
                    new Drink
                    {
                        Name = "White Russian",
                        Price = 15.95M,
                        ShortDescription = "A cocktail made with vodka ",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://basilandbubbly.com/wp-content/uploads/2016/10/chocolate-white-russian-2.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://i.pinimg.com/originals/af/d2/4c/afd24c5047e6aaa1cfbe4dd8e8d7468f.jpg"
                    },
                    new Drink
                    {
                        Name = "Long Island Iced Tea",
                        Price = 15.95M,
                        ShortDescription = "Aa mixed drink made with tequila.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://i.ytimg.com/vi/f_ueupISFFo/maxresdefault.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://i.ytimg.com/vi/cUZTStHFePw/maxresdefault.jpg"
                    },
                    new Drink
                    {
                        Name = "Vodka",
                        Price = 15.95M,
                        ShortDescription = "A distilled beverage with water and ethanol.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://static.vinepair.com/wp-content/uploads/2019/08/belvedere_article2_header_2.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://static.vinepair.com/wp-content/uploads/2019/09/belvedere_article3_header.jpg"
                    },
                    new Drink
                    {
                        Name = "Gin and tonic",
                        Price = 15.95M,
                        ShortDescription = "Made with gin and tonic water poured over ice.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://www.shop-spiegelau.com/media/catalog/product/cache/3/image/800x800/9df78eab33525d08d6e5fb8d27136e95/1/0/41ba40841db9ca100110746d60c9f058/Nachtmann-Gin-and-Tonic-Glass,-Set-of-4-102892.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://images.getbento.com/accounts/1657f4f6b3896dd6586d99c265a97178/media/images/69780Ultimate_GT.jpg?fit=max&w=1800&auto=format,compress"
                    },
                    new Drink
                    {
                        Name = "Cosmopolitan",
                        Price = 15.95M,
                        ShortDescription = "Made with vodka, triple sec, cranberry juice.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://i.ytimg.com/vi/FSj3lpFHZOg/maxresdefault.jpg",
                        InStock = false,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://previews.123rf.com/images/ivanmateev/ivanmateev1502/ivanmateev150201700/36191524-a-cosmopolitan-is-a-cocktail-made-with-vodka-.jpg"
                    },
                    new Drink
                    {
                        Name = "Tea ",
                        Price = 12.95M,
                        ShortDescription = "Made by leaves of the tea plant in hot water.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://i0.wp.com/cdn-prod.medicalnewstoday.com/content/images/articles/322/322624/herbal-tea-for-constipation.jpg?w=1155&h=1541",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://cdn1.sph.harvard.edu/wp-content/uploads/sites/30/2019/07/beverage-blur-cup-370018-1200x875.jpg"
                    },
                    new Drink
                    {
                        Name = "Water ",
                        Price = 12.95M,
                        ShortDescription = " It makes up more than half of your body weight ",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://nnimgt-a.akamaihd.net/transform/v1/crop/frm/A3aygSSaTF7hiCbjiqBAXx/e24cc52a-ebc6-4342-9d87-59ef79e20693.jpg/r0_0_1000_563_w1200_h678_fmax.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://i0.wp.com/cdn-prod.medicalnewstoday.com/content/images/articles/327/327185/a-glass-of-pure-water-with-a-ph-of-7.jpg?w=1155&h=1444"
                    },
                    new Drink
                    {
                        Name = "Coffee ",
                        Price = 12.95M,
                        ShortDescription = " A beverage prepared from coffee beans",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://i0.wp.com/cdn-prod.medicalnewstoday.com/content/images/articles/322/322649/coffee.jpg?w=1155&h=1541",
                        InStock = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl = "https://yournews.com/wp-content/uploads/2019/11/coffee_main_envat-1280x720.jpg"
                    },
                    new Drink
                    {
                        Name = "Kvass",
                        Price = 12.95M,
                        ShortDescription = "A very refreshing Russian beverage",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://cdni.rbth.com/rbthmedia/images/web/en-rbth/images/2012-06/big/Lori_LegionMedia_kvas_468.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://cdni.rbth.com/rbthmedia/images/2017.11/article/5a02f86c15e9f930c9451fce.jpg"
                    },
                    new Drink
                    {
                        Name = "Juice ",
                        Price = 12.95M,
                        ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://www.newtimes.co.rw/sites/default/files/styles/mystyle/public/main/articles/2019/11/27/xraju-fruit-juice-kirti-nagar-delhi-juice-centres-1bkb8kg.jpg.pagespeed.ic.CCL_UNKhP8.jpg",
                        InStock = true,
                        IsPreferredDrink = false,
                        ImageThumbnailUrl = "https://res.cloudinary.com/popmenu/image/upload/c_limit,f_auto,h_1440,q_auto,w_1440/axkwnptxya0b78itwlfx.jpg"
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Alcoholic", Description="All alcoholic drinks" },
                        new Category { CategoryName = "Non-alcoholic", Description="All non-alcoholic drinks" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}