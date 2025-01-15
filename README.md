# ZCsh support plugin

This plugin extends BTCPay Server to enable users to receive payments via Zcash.

> [!WARNING]
> This plugin isn't maintained and nobody but the original author knows how it works. (@hhanh00)

We are looking for a maintainer.

## Configuration

Configure this plugin using the following environment variables:

| Environment variable | Description |
| --- |-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
**BTCPAY_ZEC_DAEMON_URI** | **Required**. The URI of the deamon RPC interface |
**BTCPAY_ZEC_WALLET_DAEMON_URI** | **Required**.  The URI of the wallet RPC interface | http://127.0.0.1:18082 |
**BTCPAY_ZEC_WALLET_DAEMON_WALLETDIR** | **Required**. The directory of the wallet directory |

# Licence

[MIT](LICENSE.md)