namespace Steam.Query.GameServers
{
    internal enum GameServerResponseFormat
    {
        Simple      = -1, // 0xFFFFFFFF
        MultiPacket = -2  // oxFFFFFFFE
    }
}
