namespace Taxation;
public static class TaxationService{
    public static void PayIncometax(float amount)
    {
        Console.WriteLine("Income taxt "+amount+" will be deducted");
    }
    public static void PayServicetax(float amount)
    {
        Console.WriteLine("service taxt "+amount+" will be deducted");
    }
    public static void PayGSTtax(float amount)
    {
        Console.WriteLine("GST taxt "+amount+" will be deducted");
    }
}