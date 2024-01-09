public interface ICreditCard
{
    string GetCardType();
    int GetCardLimit();
    int GetAnnualCharge();
}

public class MoneyBack : ICreditCard
{
    public string GetCardType()
    {
        return "MoneyBack";
    }

    public int GetCardLimit()
    {
        return 15;
    }

    public int GetAnnualCharge()
    {
        return 5;
    }
}

public class Titanium : ICreditCard
{
    public string GetCardType()
    {
        return "Titanium";
    }

    public int GetCardLimit()
    {
        return 25;
    }

    public int GetAnnualCharge()
    {
        return 15;
    }
}

public class Platinum : ICreditCard
{
    public string GetCardType()
    {
        return "Platinum";
    }

    public int GetCardLimit()
    {
        return 35;
    }

    public int GetAnnualCharge()
    {
        return 2;
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        string cardType = "MoneyBack";

        ICreditCard creditCard = null;

        if (cardType == "MoneyBack")
        {
            creditCard = new MoneyBack();
        }
        else if (cardType == "Titanium")
        {
            creditCard = new Titanium();
        }
        else if (cardType == "Platinum")
        {
            creditCard = new Platinum();
        }

        if (creditCard != null)
        {
            Console.WriteLine(creditCard.GetCardType());
            Console.WriteLine(creditCard.GetCardLimit());
            Console.WriteLine(creditCard.GetAnnualCharge());
        }
        else
        {
            Console.WriteLine("Invalid card!");
        }

        Console.ReadLine();
    }
}

///Tight coupling
/// Add new credit card => need to modify client code , extra if else condition, violate Open-Close princible