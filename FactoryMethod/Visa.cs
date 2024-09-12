public class Visa : ICreditCard
{
    public string GetCardType() => "Visa";
    public int GetCreditLimit() => 15000;
    public int GetAnnualCharge() => 500;
}