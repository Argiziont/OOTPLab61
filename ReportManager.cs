public class ReportManager : IMediator
{
    private readonly List<IColleague> _colleagues;

    public ReportManager()
    {
        _colleagues = new List<IColleague>();
    }

    public void AddColleague(IColleague colleague)
    {
        _colleagues.Add(colleague);
        colleague.SetMediator(this);
    }

    public void SendMessage(string message, IColleague colleague)
    {
        foreach (IColleague c in _colleagues)
        {
            if (c != colleague)
            {
                c.ReceiveMessage(message);
            }
        }
    }
}