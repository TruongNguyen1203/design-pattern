void ClientCode(CardCreator card)
{
    card.GetCard();
}

ClientCode(new TitaniumCreator());


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

abstract class CardCreator
{
    public abstract ICreditCard CreditCard();

    public void GetCard()
    {
        var card = CreditCard();
        Console.WriteLine(card.GetCardType());
        Console.WriteLine(card.GetCardLimit());
        Console.WriteLine(card.GetAnnualCharge());
    }
}

class MoneyBackCreator : CardCreator
{
    public override ICreditCard CreditCard()
    {
        return new MoneyBack();
    }
}
class TitaniumCreator : CardCreator
{
    public override ICreditCard CreditCard()
    {
        return new Titanium();
    }
}
class PlatinumCreator : CardCreator
{
    public override ICreditCard CreditCard()
    {
        return new Platinum();
    }
}