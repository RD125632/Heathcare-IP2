using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Server
    {
        private TcpListener server;
        private List<ClientHandler> clients;

        static void Main(string[] args)
        {
            new Server();
        }

        public Server()
        {
            this.clients = new List<ClientHandler>();


            Console.WriteLine("Starting server");
            server = new TcpListener(IPAddress.Any, 8888);
            server.Start();
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += (o, args) =>
            {
                while (true)
                {
                    clients.Add(new ClientHandler(server.AcceptTcpClient()));
                }

            };
            bgw.RunWorkerAsync();
            Console.ReadLine();
        }
    }

    class ClientHandler
    {
        private StreamReader r;
        private StreamWriter w;
        private TcpClient client;

        BackgroundWorker bgw = new BackgroundWorker();

        public ClientHandler(TcpClient client)
        {
            this.client = client;
            this.r = new StreamReader(client.GetStream());
            this.w = new StreamWriter(client.GetStream());
            bgw.DoWork += (o, args) =>
            {
                while (true)
                {
                    string text = r.ReadLine();
                    if (text != null)
                    {
                        string[] values = text.Split('|');
                        string command = values[0];
                        switch (command)
                        {
                            case "get":
                                Console.WriteLine("Getting data: "+ text);
                                List<String> stringList = GetClientData(values[1]);
                                if (stringList.Count > 0)
                                {
                                    stringList.ForEach(s =>
                                    {
                                        w.WriteLine(s);
                                        w.Flush();
                                    });
                                }
                                else
                                {
                                    w.WriteLine("ER|No files available.");
                                    w.Flush();
                                }
                                
                                break;
                            case "set":
                                Console.WriteLine("Setting data: "+ text);
                                bool written = SetClientData(values[1],values[2]);
                                if (written)
                                {
                                    w.WriteLine("OK|Write succesful.");
                                    w.Flush();
                                }
                                else
                                {
                                    w.WriteLine("ER|Write unsuccesful.");
                                    w.Flush();
                                }
                                break;

                        }
                    }
                }
            };
            bgw.RunWorkerAsync();
        }

        private bool SetClientData(string clientname, string data)
        {
            bool done;
            List<String> existingData = GetClientData(clientname);

            try
            {
                using (StreamWriter stw = new StreamWriter(Environment.CurrentDirectory + "\\" + clientname + ".txt"))
                {
                    existingData.ForEach(s =>
                    {
                        stw.WriteLine(s);
                    });
                    stw.WriteLine(data);
                    stw.Flush();
                    done = true;
                }
            }
            catch (Exception) {
                done = false;
            }
            return done;

        }

        private List<string> GetClientData(string clientname)
        {
            List<String> stringList = new List<string>();
            try {
                using (StreamReader str = new StreamReader(Environment.CurrentDirectory + "\\" + clientname + ".txt"))
                {
                    string readLine;
                    while ((readLine = str.ReadLine()) != null)
                    {
                        stringList.Add(readLine);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                
            }
            
            return stringList;
        }
    }
}
