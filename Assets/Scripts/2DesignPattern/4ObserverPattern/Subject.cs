public interface Subject
{
    public void Register(Observer obj);
    public void Unregister(Observer obj);
    public void NotifyObservers();
    public object GetUpdate();
}