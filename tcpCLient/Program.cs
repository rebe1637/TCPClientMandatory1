using System;
using System.Net.Sockets;
using System.IO;

namespace tcpCLient
{
    class Program
    {
        private static string message;

        static void Main(string[] args)
        {

            TcpClient connectionSocket = new TcpClient("localhost", 6789);
            Console.WriteLine("Client started");

            Stream ns = connectionSocket.GetStream();
            StreamWriter sw = new StreamWriter(ns);
            StreamReader sr = new StreamReader(ns);
            sw.AutoFlush = true;



            while (true)
            {
                string message = Console.ReadLine();
                sw.WriteLine(message);
                if (message == "STOP") break;
                string answer = sr.ReadLine();
                Console.WriteLine("Server: " + answer);
            }

            Console.WriteLine("Client stopped, press enter");
            string s = Console.ReadLine();
            Console.ReadLine();




        }


    }
}
