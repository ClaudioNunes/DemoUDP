using System.Net.Sockets;
using System.Net;
using System.Text;

UdpClient cliente = new UdpClient(6969);
while (true)
{
    IPEndPoint remoto = new IPEndPoint(IPAddress.Any, 0);
    byte[] dados = cliente.Receive(ref remoto);
    string mensa = Encoding.ASCII.GetString(dados);
    Console.WriteLine("Recebido de {0} => {1}", remoto, mensa);
}

