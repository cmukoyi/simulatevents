## MProfiler ThirdPartyGatewayApi Samples ##

MProfiler ThirdPartyGatewayApi Sample applications


### EventSending application ###

It is sending one Non Trip Position event when executed and logging information on the console and also in log files.

The configuration parameters are in the EventSending.exe.config file (or App.config in the source).
* UnitId - the unit id, it must exist in MProfiler and must be assigned to the specified service provider
* BaseUrl - base url for API, in case of US MProfiler it is: https://us.scopemp.net/Scope.MProfiler.ThirdPartyGateway.Api
* ServiceProviderName - the name of the service provider
* ServiceProviderApiKey - the API key for that service provider


### CommandReceiving application ###

It is receiving and decoding all commands for the specified service provider.

The configuration parameters are in the CommandReceiving.exe.config file (or App.config in the source).
* BaseUrl - base url for API, in case of US MProfiler it is: https://us.scopemp.net/Scope.MProfiler.ThirdPartyGateway.Api
* ServiceProviderName - the name of the service provider
* ServiceProviderApiKey - the API key for that service provider


### EventSerializationTestApp application ###

It allows you to test base64 encoded proto buffer data by deserializing it.
* Choose template id from the list
* Paste base64 encoded data
And you will see the decoded data for the specified template.


### Scope.FiveC.Protocol library ###

It is .NET library with .proto files and their generated C# classes for all supported events and commands.
For .cs file generation from .proto files ProtoGen of protobuf-net project is used.
The source code is located here: https://github.com/mgravell/protobuf-net
We use the same library in MProfiler.
This library is added as submodule, do not forget to run
```
git submodule update --init --recursive
```
to fetch the library.


## MProfiler API Samples ##

MProfiler Api Sample applications

### EventReceiving ###

It is a simple program which receives events through API and logs event data into logfile and on console application screen.
After event reception those events will be deleted from the client queue on MProfiler.
The configuration parameters are in the EventReceiving.exe.config file (or App.config in the source).
* MProfilerApiUrl - API base url, in case of US MProfiler it is: https://us.scopemp.net/Scope.MProfiler.Api
* Username - client account username
* Password - client account password
* MessageBatchSize - how many messages will be read by each api call
* ReceiveInterval - if less than MessageBatchSize messages were returned by the previous call, the program will wait for ReceiveInterval before trying again
