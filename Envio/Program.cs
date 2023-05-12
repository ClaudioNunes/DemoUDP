using System.Net.Sockets;
using System.Net;
using System.Text;

UdpClient cliente = new UdpClient();
IPAddress ipdestino = IPAddress.Parse("127.0.0.1");

IPEndPoint remoto = new IPEndPoint(ipdestino, 6969);

Console.Write("Aperte uma tecla para iniciar, [ESC] para terminar");
Console.ReadKey(); Console.WriteLine();
int n = 1;
while (true)
{
    byte[] bufMensa = Encoding.ASCII.GetBytes("Beep! " + n.ToString());
    Console.WriteLine("{0} º Envio", n);
    cliente.Send(bufMensa, bufMensa.Length, remoto);
    n++;
    System.Threading.Thread.Sleep(500);
    if (Console.KeyAvailable)
    {
        if (Console.ReadKey().Key == ConsoleKey.Escape)
        { break; }
    }
}
cliente.Close();
Console.WriteLine("Transmissão terminada! - Qualquer tecla para sair");
Console.ReadKey();
