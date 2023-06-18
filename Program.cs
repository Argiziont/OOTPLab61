// Define the abstract expression class for the Interpreter pattern

// Define the concrete expression classes for the Interpreter pattern

// Define the colleague interface for the Mediator pattern

// Define the mediator interface for the Mediator pattern

// Define the concrete colleague classes for the Mediator pattern

// Example usage of the Interpreter and Mediator patterns
public class Program
{
    public static void Main()
    {
        ReportManager reportManager = new ReportManager();

        ReportGenerator pdfReportGenerator = new ReportGenerator();
        reportManager.AddColleague(pdfReportGenerator);

        ReportGenerator csvReportGenerator = new ReportGenerator();
        reportManager.AddColleague(csvReportGenerator);

        ReportGenerator excelReportGenerator = new ReportGenerator();
        reportManager.AddColleague(excelReportGenerator);

        pdfReportGenerator.GenerateReport("PDF Report");
        csvReportGenerator.GenerateReport("CSV Report");
        excelReportGenerator.GenerateReport("Excel Report");

        Console.ReadLine();
    }
}
