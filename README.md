# tunnel-SSH-VPN

<img width="1438" height="1060" alt="Screenshot 2026-09-17 012500" src="https://github.com/user-attachments/assets/2dbf84f0-96b7-4f8b-9a1b-334a28c15133" />

A lightweight, free Windows client that creates an encrypted SSH tunnel to provide a local SOCKS5 proxy (port 9000).
All traffic is encrypted and obfuscated as ordinary SSH, making it difficult for authorities to detect or block.

✨ Features 

Free to use – no subscription or hidden costs.
Strong encryption – SSH protocol (AES‑256, etc.) protects your data from eavesdropping.
Stealthy traffic – looks like regular SSH, hard to fingerprint or block by firewalls/DPI.
Auto‑configuration – loads server details from a remote config on startup.
Kill‑switch – Windows session‑ending event disconnects the tunnel to prevent leaks.
Portable – single executable, no installer required.
Low footprint – minimal CPU/RAM usage.





🔧  How It Works

Start ssh-vpn.exe.
The app reads SSH connection settings (host, port, user, password) and establishes an SSH session.
It opens a dynamic port forward on localhost:9000 (SOCKS5 proxy).
Configure your system or browser to use this proxy:
Windows Settings → Network & Internet → Proxy → Manual proxy setup → SOCKS host: localhost, Port: 9000
All traffic routed through localhost:9000 is encrypted inside the SSH tunnel, hiding both content and destination.





🚀 Getting Started

Binary: Download the latest release from the Downloads section of the repo.
Source: Build with Visual Studio (requires .NET Framework 4.6+ and the SSH.NET NuGet package).
Run the executable; adjust ignored-host.txt if you need to exclude certain hosts from the proxy.
Set the system/browser proxy to localhost:9000 as described above.
Close the app to stop the tunnel.




🔒 Security & Privacy

The tunnel encrypts traffic between your PC and the SSH server. The server sees the final destination, so use a trusted SSH server you control.
No logs are stored locally.
For maximum anonymity, pair the client with a SSH server located in a jurisdiction resistant to censorship.




📋 Requirements

Windows 7 or later ( .NET Framework 4.6+ )
SSH.NET library (bundled via NuGet)




📄 License

MIT License – see the LICENSE file for details.

🙋‍♂️ Support

For issues, questions, or contributions, please open a GitHub issue or pull request.

Stay private, stay free.
