# ZCash support plugin

This plugin extends BTCPay Server to enable users to receive payments via Zcash.

> [!WARNING]
> This plugin isn't maintained and nobody but the original author knows how it works. (@hhanh00)

We are looking for a maintainer.
It seems that this plugin is more or less a copy-paste of the better-maintained [Monero Plugin](https://github.com/btcpayserver/btcpayserver-monero-plugin).

If ZCash is a fork of Monero, it is probably possible to support both in the same plugin easily.

## Configuration

Configure this plugin using the following environment variables:

| Environment variable | Description |
| --- |-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
**BTCPAY_ZEC_DAEMON_URI** | **Required**. The URI of the deamon RPC interface |
**BTCPAY_ZEC_WALLET_DAEMON_URI** | **Required**.  The URI of the wallet RPC interface | http://127.0.0.1:18082 |
**BTCPAY_ZEC_WALLET_DAEMON_WALLETDIR** | **Required**. The directory of the wallet directory |

# Licence

[MIT](LICENSE.md)