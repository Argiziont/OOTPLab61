public class PDFExpression : Expression
{
    public override bool Interpret(string context)
    {
        // Generate a PDF report based on the context
        Console.WriteLine("Generating PDF report...");
        return true;
    }
}