namespace WebAssemblyDemo.Client;

public class DiContainerStorage
{
    private string message;

    public string Get()
    {
        return message;
    }
    public void Set(string message)
    {
        this.message = message;
    }
}
