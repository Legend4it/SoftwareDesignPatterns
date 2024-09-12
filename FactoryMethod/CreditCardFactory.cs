public class CreditCardFactory
{

    // A registry that maps card types to their creation methods
    private static readonly Dictionary<string, Func<ICreditCard>> _registry = new();

    // Static constructor to register known types
    static CreditCardFactory(){
        Register("Visa", () => new Visa());
    }

    
     // Method to Register new card types dynamically
    public static void Register(string cardType, Func<ICreditCard> creator)
    {
        if(!_registry.ContainsKey(cardType)){
            _registry.Add(cardType, creator);
        }
    }

    // Factory method to create a card based on type
    public static ICreditCard CreateCard(string cardType){
        if(_registry.TryGetValue(cardType, out var creator)){
            return creator();
        }
        throw new Exception($"Card type '{cardType}' is not recognized.");
    }
}
