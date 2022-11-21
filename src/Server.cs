using System.Net;
using System.Net.Sockets;
using System.Text;

Console.WriteLine("Logs from your program will appear here!");

TcpListener server = new TcpListener(IPAddress.Any, 6379);
server.Start();

while (true)
{
	Socket socket = server.AcceptSocket(); // wait for client
	Console.WriteLine("Connection Accepted");

	string responseString = "+PONG\r\n";

	Byte[] sendBytes = Encoding.ASCII.GetBytes(responseString);
	int i = socket.Send(sendBytes);
	Console.WriteLine($"Bytes sent: {i.ToString()}");
	Console.WriteLine($"Message sent /> : {responseString}");

}

