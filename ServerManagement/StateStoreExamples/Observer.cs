namespace ServerManagement.StateStoreExamples;

public abstract class Observer
{
    protected Action? _listeners;

    public void AddStateChangeListener(Action? listener)
    {
        if (listener is not null)
        {
            _listeners += listener;
        }
    }

    public void RemoveStateChangeListener(Action? listener)
    {
        if(listener is not null)
        {
            _listeners -= listener;
        }
    }

    public void BroadcastStateChange()
    {
        _listeners?.Invoke();
    }
}
