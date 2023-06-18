public class ReportGenerator : IColleague
{
    private IMediator _mediator;

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void GenerateReport(string context)
    {
        // Generate a report based on the context
        bool result = false;
        Expression expression = null;
        if (context.Contains("PDF"))
        {
            expression = new PDFExpression();
        }
        else if (context.Contains("CSV"))
        {
            expression = new CSVExpression();
        }
        else if (context.Contains("Excel"))
        {
            expression = new ExcelExpression();
        }
        if (expression != null)
        {
            result = expression.Interpret(context);
        }

        // Notify the mediator of the result
        _mediator.SendMessage($"Report generation result: {result}", this);
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"Report generation received message: {message}");
    }
}