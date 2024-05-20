/*
var pizza = new Pizza();

pizza.AddIngredient(new Chedder());
pizza.AddIngredient(new TomatoSauce());
pizza.AddIngredient(new Mozarella());


Console.WriteLine(pizza.DescribePizzaIngredients());

*/

var chedder = new Chedder();

chedder.LaunchPublicIngredientMethod();

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient)
    {
        _ingredients.Add(ingredient);
    }
    public string DescribePizzaIngredients () 
     => $"This is an ingredient with {string.Join(",", _ingredients)}";
}

public class Ingredient
{

    public string PublicMethod() 
    => "=> .This method is public for the Ingredient class. <=";

    protected string ProtedtedMethod()
    => "This method is protected, it can only be access into the various classes";
    private string PrivateMethod()
    => "=> .This method can only be accessible from the Ingredient class. <=";

}

public class Chedder : Ingredient
{
    public string Name => "Chedder sheez";
    public int AgeForMonths {get;}

    public void LaunchPublicIngredientMethod()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtedtedMethod());
        
    }


}

public class TomatoSauce : Ingredient
{
    public string Name => "Tomato Sauce";
    public int TomatosIn100grams {get;}

}

public class Mozarella : Ingredient
{
    public string Name => "Mozarella";
    public bool IsLight {get;}
}