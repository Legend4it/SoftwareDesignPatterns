// Create Visa card
public class AmericanExpress : ICreditCard
{
    public string GetCardType() => "AmericanExpress";
    public int GetCreditLimit() => 20000;
    public int GetAnnualCharge() => 700;
}