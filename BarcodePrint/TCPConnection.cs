using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodePrint
{
    internal class TCPConnection
    {
        private Socket clientSocket;
        private string message;

        private static IPAddress GetEthernetIPv4Address()
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    UnicastIPAddressInformation ipv4Info = networkInterface
                        .GetIPProperties()
                        .UnicastAddresses
                        .FirstOrDefault(addr => addr.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);

                    if (ipv4Info != null)
                    {
                        return ipv4Info.Address;
                    }
                }
            }

            return null;
        }

        public async Task StartServerAsync()
        {
            IPAddress ipAddress = GetEthernetIPv4Address(); // Fix here

            if (ipAddress == null)
            {
                MessageBox.Show("No IPv4 address found.");
                return;
            }

            // Create the local endpoint
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11000);

            // Create a TCP/IP socket.
            clientSocket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                // Connect the socket to the remote endpoint.
                clientSocket.Connect(remoteEP);

                message = "Connected to the server!";

                // Send a message to the server.
                byte[] msg = Encoding.ASCII.GetBytes("Hello from client!");
                int bytesSent = await clientSocket.SendAsync(new ArraySegment<byte>(msg), SocketFlags.None);

                // Start receiving messages from the server in the background.
                _ = HandleClientMessagesAsync(clientSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to the server: {ex.Message}");
            }
        }

        private async Task HandleClientMessagesAsync(Socket handler)
        {
            // Continuous loop to receive messages from the server.
            while (handler.Connected)
            {
                // Receive the server's response.
                byte[] bytes = new byte[1024];
                int bytesRec = await handler.ReceiveAsync(new ArraySegment<byte>(bytes), SocketFlags.None);

                if (bytesRec == 0) // Server has disconnected
                {
                    MessageBox.Show("Server disconnected.");
                    break;
                }

                string receivedMessage = Encoding.ASCII.GetString(bytes, 0, bytesRec);

                // Invoke on UI thread to update the UI.
                MessageBox.Show($"Received: {receivedMessage}");
            }
        }
    }
}
