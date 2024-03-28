namespace Module17.Practice;

public class SalaryAccount : Account, ICalculate
{
    public void CalculateInterest()
    {
        // расчет процентной ставк зарплатного аккаунта по правилам банка
        Interest = Balance * 0.5;
    }
}