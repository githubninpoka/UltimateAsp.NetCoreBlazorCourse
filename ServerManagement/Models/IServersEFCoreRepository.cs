
namespace ServerManagement.Models
{
    public interface IServersEFCoreRepository
    {
        void AddServer(Server server);
        void DeleteServer(int serverId);
        List<Server> GetServersByCity(string cityName);
        Server? GetServerById(int id);
        List<Server> GetServers();
        List<Server> SearchServers(string serverFilter);
        void UpdateServer(int serverId, Server server);
    }
}