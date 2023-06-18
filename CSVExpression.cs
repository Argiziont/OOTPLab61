public class CSVExpression : Expression
{
    public override bool Interpret(string context)
    {
        // Generate a CSV report based on the context
        Console.WriteLine("Generating CSV report...");
        return true;
    }
}