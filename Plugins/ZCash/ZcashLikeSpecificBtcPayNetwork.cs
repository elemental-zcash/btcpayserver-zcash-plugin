namespace BTCPayServer.Plugins.ZCash;

public class ZcashLikeSpecificBtcPayNetwork : BTCPayNetworkBase
{
    public int MaxTrackedConfirmation = 10;
    public string UriScheme { get; set; }
}
