using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using ServerManagement.Models;

namespace ServerManagement.StateStoreExamples;

public class SessionStorageContainer
{
    private readonly ProtectedSessionStorage _pss;


    public SessionStorageContainer(ProtectedSessionStorage pss)
    {
        _pss = pss;
    }

    public async Task SetAsync(Server server)
    {
        if (server != null)
        {
            await _pss.SetAsync("server", server);
        }
    }
    public async Task<Server> GetAsync()
    {
        var x = await _pss.GetAsync<Server>("server");

        if (x.Success && x.Value is Server)
        {
            return x.Value;

        }
        else
        {
            return null;
        }
    }
    public async Task DeleteAsync()
    {
        await _pss.DeleteAsync("server");
    }

}
