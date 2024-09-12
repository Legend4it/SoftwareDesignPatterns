


// Create Visa card
using System.ComponentModel;

ICreditCard visaCard = CreditCardFactory.CreateCard("Visa");
Console.WriteLine("Card Type: " + visaCard.GetCardType());

// Create MasterCard
CreditCardFactory.Register("MasterCard", ()=>new AmericanExpress());
ICreditCard masterCard = CreditCardFactory.CreateCard("MasterCard");
Console.WriteLine("Card Type: " + masterCard.GetCardType());




// Register and create AmericanExpress card at runtime
CreditCardFactory.Register("AmericanExpress", ()=>new AmericanExpress());
ICreditCard amexCard=CreditCardFactory.CreateCard("AmericanExpress");
Console.WriteLine("Card Type: " + amexCard.GetCardType());