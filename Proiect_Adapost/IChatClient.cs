namespace Proiect_Adapost
{
    public interface IChatClient
    {
        Task ReceiveMessage(string message);
    }
}
