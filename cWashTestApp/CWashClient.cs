using System;
using System.Threading;
using System.Threading.Tasks;
using Cytena.CWash.ClientExample.Entities;
using Cytena.CWash.ClientExample.Helpers;
using Google.Protobuf;
using Grpc.Core;
using Sila2.Cytena.Cwash.Features.Cwashexecutionservice.V1;
using Sila2.Cytena.Cwash.Features.Cwashinstrumentsettingsservice.V1;
using Sila2.Org.Silastandard;
using Sila2.Org.Silastandard.Core.Silaservice.V1;
using Sila2.Server;
using Sila2.Utils;

namespace Cytena.CWash.ClientExample
{
    /// <summary>
    /// SiLA 2 client that can connect to the CWash SiLA 2 server and call its SiLA features.
    /// </summary>
    public class CWashClient
    {


        private readonly CWashExecutionService.CWashExecutionServiceClient _executionServiceClient;

        private readonly CWashInstrumentSettingsService.CWashInstrumentSettingsServiceClient
            _instrumentSettingsServiceClient;

        private readonly SiLAService.SiLAServiceClient _silaServiceClient;

       

        /// <summary>
        /// Create an instance of CWash SiLA2 client.
        /// </summary>
        /// <param name="channel">The channel through which gRPC connection is established</param>
        public CWashClient(Channel channel)
        {
            _silaServiceClient = new SiLAService.SiLAServiceClient(channel);
            _executionServiceClient = new CWashExecutionService.CWashExecutionServiceClient(channel);
            _instrumentSettingsServiceClient =
                new CWashInstrumentSettingsService.CWashInstrumentSettingsServiceClient(channel);
        }

        /// <summary>
        /// Returns server name.
        /// </summary>
        /// <returns>Server name</returns>
        public string GetServerName()
        {
            try
            {
                var response = _silaServiceClient.Get_ServerName(new Get_ServerName_Parameters());
                return response.ServerName.Value;
            }
            catch (RpcException e)
            {
                Console.WriteLine(ErrorHandling.HandleException(e));
                return string.Empty;
            }
        }

        /// <summary>
        /// Sends serialized binary Command object for execution and returns string value of the instrument firmware response.
        /// </summary>
        /// <param name="command">Command object</param>
        /// <returns>Instrument firmware response</returns>
        public async Task<string> ExecuteCommand(Command command)
        {
            try
            {
                var binaryCommand = Serializers.SerializeCommandToBinary(command);
                var binaryString = ByteString.CopyFrom(binaryCommand, 0, binaryCommand.Length);
                var commandParameters = new ExecuteCommand_Parameters
                {
                    Command = new Binary
                    {
                        Value = binaryString
                    }
                };
                var response = await _executionServiceClient.ExecuteCommandAsync(commandParameters);
                var commandResponseSila = response.CommandResponse.CommandResponse;
                return commandResponseSila.FirmwareResponse.Value;
            }
            catch (RpcException e)
            {
                Console.WriteLine(ErrorHandling.HandleException(e));
                return string.Empty;
            }
        }

        /// <summary>
        /// Sends serialized binary Protocol object for execution and subscribes to ExecuteProtocol_Info response stream until execution is not finished.
        /// </summary>
        /// <param name="protocol">Protocol object</param>
        /// <returns>true if protocol executed successfully, otherwise false</returns>
        public async Task<bool> ExecuteProtocol(Protocol protocol)
        {
            var binaryProtocol = Serializers.SerializeProtocolToBinary(protocol);
            var binaryString = ByteString.CopyFrom(binaryProtocol, 0, binaryProtocol.Length);
            var protocolParameters = new ExecuteProtocol_Parameters
            {
                Protocol = new Binary
                {
                    Value = binaryString
                }
            };

            try
            {
                var endExecution = false;
                var status = false;

                var response = await _executionServiceClient.ExecuteProtocolAsync(protocolParameters);
                IAsyncStreamReader<ExecutionInfo> responseStream = _executionServiceClient.ExecuteProtocol_Info(response.CommandExecutionUUID)
                    .ResponseStream;

                // Keep reading while server is streaming ExecutionInfo
                // End execution if execution FinishedSuccessfully, FinishedWithError or ProgressInfo.Value >= 1
                while (await responseStream.MoveNext(CancellationToken.None))
                {
                    var currentExecutionInfo = responseStream.Current;
                    switch (currentExecutionInfo.CommandStatus)
                    {
                        case ExecutionInfo.Types.CommandStatus.Running:
                            if (currentExecutionInfo.ProgressInfo.Value >= 1.0)
                                endExecution = status = true;
                            break;
                        case ExecutionInfo.Types.CommandStatus.FinishedSuccessfully:
                            endExecution = status = true;
                            break;
                        case ExecutionInfo.Types.CommandStatus.FinishedWithError:
                            endExecution = true;
                            break;
                        case ExecutionInfo.Types.CommandStatus.Waiting:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    if (endExecution)
                        break;
                }

                // Check if any exceptions occurred on server, exception will be thrown in that case
                await _executionServiceClient.ExecuteProtocol_ResultAsync(response.CommandExecutionUUID);
                //responseStream.Dispose();

                return status;
            }
            catch (RpcException e)
            {
                Console.WriteLine(ErrorHandling.HandleException(e));
                return false;
            }
        }

        /// <summary>
        /// Returns instrument serial number.
        /// </summary>
        /// <returns>Instrument serial number</returns>
        public async Task<string> GetInstrumentSerialNumber()
        {
            try
            {
                var response = await _instrumentSettingsServiceClient.GetInstrumentInformationAsync(
                    new GetInstrumentInformation_Parameters());
                return response.InstrumentInformation.InstrumentInformation.SerialNumber.Value;
            }
            catch (RpcException e)
            {
                Console.WriteLine(ErrorHandling.HandleException(e));
                return string.Empty;
            }
        }
    }
}
