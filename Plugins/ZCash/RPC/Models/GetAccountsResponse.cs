using System.Collections.Generic;
using Newtonsoft.Json;

namespace BTCPayServer.Plugins.ZCash.RPC
{
    public partial class GetAccountsResponse
    {
        [JsonProperty("subaddress_accounts")] public List<SubaddressAccount> SubaddressAccounts { get; set; }
        [JsonProperty("total_balance")] public decimal TotalBalance { get; set; }

        [JsonProperty("total_unlocked_balance")]
        public decimal TotalUnlockedBalance { get; set; }
    }
}
