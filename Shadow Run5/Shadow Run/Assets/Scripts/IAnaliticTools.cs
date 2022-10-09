public interface IAnaliticTools
{
    void SendMessage(string nameEvent);
    void SendMessage(string nameEvent, (string, object) data);
}
