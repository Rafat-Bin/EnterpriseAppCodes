# Exercise LINQ
# Coffee House Interactive Menu

Use LINQ to design an interactive menu for a coffee shop order. The system will allow a user to interact with an existing coffee order to group, sort, and filter the data.

Do not worry about repeating until a user enters a valid value. Focus on the queries.

## Requirements

Implement the following methods in the `Program.cs`

1. `SortDrinksByPrice()`
    - Sorts all of the drinks by price in descending order
    - Print all of the drinks (see sample output)
    - Use Query Syntax for this method
2. `GroupDrinksByPrice(List<Coffee> order)`
    - Group each of the coffees by Price in descending order
    - Print all of the drinks grouped by price (see sample output)
    - Use Query Syntax for this method
3. `GroupDrinksBySize(List<Coffee> order)`
    - Group each of the coffees by Size in ascending order
    - Print all of the drinks grouped by size
    - Use Query Syntax for this method
4. `GroupDrinksByHasMilk(List<Coffee> order)`
    - Group each of the coffees by if they have milk ordered by Price in descending order. (use the OrderByDescending() method here: https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/method-based-query-syntax-examples-ordering-linq-to-dataset)
    - Print all of the drinks grouped by if they have milk
    - Use Method Syntax for this method
5. `GroupDrinksByRoast(List<Coffee> order)`
    - Group each of the coffees by Roast in ascending order (use the OrderBy() method here: https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/method-based-query-syntax-examples-ordering-linq-to-dataset)
    - Print all of the drinks grouped by Roast
    - Use Method Syntax for this method
6. `FilterByPrice(List<Coffee> order)`
    - The user enters a double representing the minimum price
    - Filter the order for all menu items that have a price greater than this.
    - Print all the filter data in descending order by price. (See sample output)
    - Use Query Syntax for this method.

7. `FilterBySize(List<Coffee> order)`
    - The user enters a size ("Small", "Medium", "Large", "Extra Large").
    - Filter the order for all menu items of that size.
    - Include only Roast in the __query results__. (see sample output)
    - The method must be cast insensitive ("small" is the same as "SMALL")
    - Use Query Syntax for this method

8. `FilterByMilkContent(List<Coffee> order)`
    - The enters "yes" or "no" if the drink has milk.
    - Filter the order for all menu items with milk.
    - Include only Size in the __query results__.
    - The method must be case insenstive ("yes" is the same as "YES")
    - Use Method Syntax for this method

9. `CountRoasts(List<Coffee> order)`
    - The user enters a roast ("Light", "Medium", "Dark").
    - Filter the order for all menu items of that roast.
    - The method must be cast insensitive ("small" is the same as "SMALL")
    - Count the number of drinks of that roast (see sample output)
    - Make use of the Count() method.
    - Use Method Syntax for this method
    
## Sample Output

Sorting:

```
---------------------
Price: 8.99 | Size: Extra Large | Has Milk? Yes | Roast: Dark
Price: 8.99 | Size: Extra Large | Has Milk? Yes | Roast: Dark
Price: 8.99 | Size: Extra Large | Has Milk? Yes | Roast: Medium
Price: 7.99 | Size: Extra Large | Has Milk? No | Roast: Light
Price: 7.99 | Size: Extra Large | Has Milk? No | Roast: Dark
Price: 6.99 | Size: Large | Has Milk? Yes | Roast: Dark
Price: 6.99 | Size: Medium | Has Milk? No | Roast: Light
Price: 6.99 | Size: Large | Has Milk? Yes | Roast: Light
Price: 6.99 | Size: Medium | Has Milk? Yes | Roast: Dark
Price: 6.49 | Size: Medium | Has Milk? No | Roast: Dark
Price: 5.99 | Size: Small | Has Milk? Yes | Roast: Light
Price: 5.99 | Size: Small | Has Milk? Yes | Roast: Dark
Price: 5.99 | Size: Small | Has Milk? Yes | Roast: Dark
Price: 4.99 | Size: Small | Has Milk? No | Roast: Medium
Price: 4.99 | Size: Small | Has Milk? No | Roast: Medium
---------------------
```

Group by Price:
```
8.99:
    Size: Extra Large | Has Milk? Yes | Roast: Dark
    Size: Extra Large | Has Milk? Yes | Roast: Dark
    Size: Extra Large | Has Milk? Yes | Roast: Medium
7.99:
    Size: Extra Large | Has Milk? No | Roast: Light
    Size: Extra Large | Has Milk? No | Roast: Dark
6.99:
    Size: Large | Has Milk? Yes | Roast: Dark
    Size: Medium | Has Milk? No | Roast: Light
    Size: Large | Has Milk? Yes | Roast: Light
    Size: Medium | Has Milk? Yes | Roast: Dark
6.49:
    Size: Medium | Has Milk? No | Roast: Dark
5.99:
    Size: Small | Has Milk? Yes | Roast: Light
    Size: Small | Has Milk? Yes | Roast: Dark
    Size: Small | Has Milk? Yes | Roast: Dark
4.99:
    Size: Small | Has Milk? No | Roast: Medium
    Size: Small | Has Milk? No | Roast: Medium
```
Filter By Price:
```
What is the minimum price? 7.00
Price: 8.99 | Size: Extra Large | Has Milk? Yes | Roast: Dark
Price: 8.99 | Size: Extra Large | Has Milk? Yes | Roast: Dark
Price: 8.99 | Size: Extra Large | Has Milk? Yes | Roast: Medium
Price: 7.99 | Size: Extra Large | Has Milk? No | Roast: Light
Price: 7.99 | Size: Extra Large | Has Milk? No | Roast: Dark
```

Filter by Size
```
Which Size? Extra LARGE
- Dark Roast
- Dark Roast
- Light Roast
- Dark Roast
- Medium Roast
```

Count Roasts
```
Which Roast? Medium
There are 3 medium roast drinks.
```