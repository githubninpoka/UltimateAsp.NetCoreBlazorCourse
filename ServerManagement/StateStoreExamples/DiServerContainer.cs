using ServerManagement.Models;

namespace ServerManagement.StateStoreExamples;

public class DiServerContainer
{
    private Server _server = new Server();

    public Server Server { get => _server; set { _server = value; } }
}
