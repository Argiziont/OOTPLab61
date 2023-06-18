public class ExcelExpression : Expression
{
    public override bool Interpret(string context)
    {
        // Generate an Excel report based on the context
        Console.WriteLine("Generating Excel report...");
        return true;
    }
}