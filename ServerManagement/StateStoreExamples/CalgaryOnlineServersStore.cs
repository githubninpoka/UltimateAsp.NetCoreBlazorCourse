﻿namespace ServerManagement.StateStoreExamples;

public class CalgaryOnlineServersStore : Observer
{
    private int _numberOfServersOnline;

    public int GetNumberOfOnlineServers()
    {
        return _numberOfServersOnline;
    }
    public void SetNumbersOfOnlineServers(int number)
    {
        _numberOfServersOnline = number;
        base.BroadcastStateChange();
    }
}