# Ecommerce kata

This is a two part kata for building a simple ecommerce website in dotnet

The first part is building a product catalouge api in ASP dotnet. The API should allow you to get products from the calalouge JSON file. The API should allow you to query by:

* A Product Name
* One or more tags
* A product category

The API should also allow you to order the result by:

* Name [A-z] or [z-A]
* Price lowest to highest or highest to lowest

An example query may look like: GET http://localhost:8080/api/products?category=fruit&orderBy=nameDesc

The second part is to build a react SPA that acts as an interface for the API and displays the search results. Here is a sample JSON file of the catalouge, you may additional products for testing as needed:

```
{
    Items: [
        {
            "id": 1,
            "name": "Apple",
            "price": 12.50,
            "image": "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fzaproduce.com%2Fwholesale%2Fwp-content%2Fuploads%2F2020%2F04%2Fred-delicious-1024x1024.jpg&f=1&nofb=1",
            "description": "An apple is an edible fruit produced by an apple tree (Malus domestica). Apple trees are cultivated worldwide and are the most widely grown species in the genus Malus. The tree originated in Central Asia, where its wild ancestor, Malus sieversii, is still found today. Apples have been grown for thousands of years in Asia and Europe and were brought to North America by European colonists. Apples have religious and mythological significance in many cultures, including Norse, Greek, and European Christian tradition.",
            "tags": ["fruit", "red"],
            "category": "fruit"
        },
        {
            "id": 2,
            "name": "Lemon & Ginger Tea",
            "price": 130.47,
            "image": "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP.b3CRlkojJbOBZEDtIJjJ9gHaEZ%26pid%3DApi&f=1",
            "description": "A popular herbal tea, often in teabags, combining lemon and ginger as the principal components.",
            "tags": ["fruit", "ingredients","spice","yellow","brown"],
            "category": "tea"
    },
        {
            "id": 3,
            "name": "aubergine",
            "price": 3.00,
            "image": "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.EJKmAoKlOtBisUvStKa7dAHaFj%26pid%3DApi&f=1",
            "description": "Most commonly purple, the spongy, absorbent fruit is used in several cuisines. Typically used as a vegetable in cooking, it is a berry by botanical definition. As a member of the genus Solanum, it is related to the tomato, chili pepper, and potato, although those are of the New World where the eggplant, like nightshade, is Old World. Like the tomato, its skin and seeds can be eaten, but, like the potato, it is usually eaten cooked. Eggplant is nutritionally low in macronutrient and micronutrient content, but the capability of the fruit to absorb oils and flavors into its flesh through cooking expands its use in the culinary arts.",
            "tags": ["vegetable", "purple"],
            "category": "vegetables"
        }
    ]
}
```