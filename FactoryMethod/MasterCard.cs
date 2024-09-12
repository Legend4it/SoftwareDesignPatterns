public class MasterCard : ICreditCard
{
    public string GetCardType() => "MasterCard";
    public int GetCreditLimit() => 10000;
    public int GetAnnualCharge() => 300;
}