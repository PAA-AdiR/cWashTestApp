using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using cWashTestApp;
using cWashTestApp.Entities;
using Grpc.Core;
using Sila2.Discovery;

using CommandType = System.Data.CommandType;

namespace cWashTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnAction1_Click(object sender, EventArgs e)
        {
             await Connect();
        }

        static async Task Connect()
        {
            var channel = FindCWashServer();
            if (channel == null)
            {
                Console.ReadKey();
                return;
            }

            var client = new CWashClient(channel);

            var serverName = client.GetServerName();
            Console.WriteLine($"Server name: {serverName}");

            var instrumentSerial = await client.GetInstrumentSerialNumber();
            Console.WriteLine($"CWash serial number: {instrumentSerial}");

            var command = new Command
            {
                Name = "getstatus",
                Type = "command",
                Parameters = null
            };
            var commandResponse = await client.ExecuteCommand(command);
            Console.WriteLine($"\"{command.Name}\" response: {commandResponse}");

            var protocol = new Protocol
            {
                Name = "PrimeProtocolExample",
                PlateFormat = PlateFormat.Well_384,
                Commands = new List<Command>
                {
                    new Command
                    {
                        Name = "insertplate",
                        Type = "action"
                    },
                    new Command
                    {
                        Name = "prime",
                        Type = "action",
                        Parameters = new List<string>
                        {
                            "blue", "50"
                        }
                    },
                    new Command
                    {
                        Name = "ejectplate",
                        Type = "action"
                    }
                }
            };
            var result = await client.ExecuteProtocol(protocol);
            Console.WriteLine($"{protocol.Name} executed: {result}");

            channel.ShutdownAsync().Wait();
            Console.ReadKey();
        }

        #region HelperMethods

        /// <summary>
        /// Search for all SiLA servers with SiLADiscovery and return the one that matches CytenaCWashServer server type
        /// </summary>
        /// <returns>Grpc channel</returns>
        static Channel FindCWashServer()
        {
            var servers = Sila2.Discovery.SiLADiscovery.GetServers();
            //var servers = new List<Sila2.ServerData>;

            var server = servers.FirstOrDefault(s => s.Info.Type == "CytenaCWashServer");
            if (server == null)
            {
                Console.WriteLine("No SiLA server found");
                return null;
            }

            return server.Channel;
        }

        #endregion
    }
}
