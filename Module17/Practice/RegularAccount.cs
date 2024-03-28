namespace Module17.Practice;

public class RegularAccount : Account, ICalculate
{
    public void CalculateInterest()
    {
        // расчет процентной ставки обычного аккаунта по правилам банка
        Interest = Balance * 0.4;

        if (Balance < 1000)
            Interest -= Balance * 0.2;

        if (Balance >= 1000)
            Interest -= Balance * 0.4;
    }
}