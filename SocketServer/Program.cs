using System;
using SocketServer;

namespace Program
{
    class ServiceProgram
    {
        static void Main(string[] args)
        {
            try
            {
                int port = 50000;
                AsyncService service = new AsyncService(port);
                service.Run();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}