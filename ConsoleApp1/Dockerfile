#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/framework/runtime:4.8-windowsservercore-ltsc2019
ARG source
WORKDIR /app
RUN powershell -Command Set-DtcNetworkSetting -AuthenticationLevel NoAuth -InboundTransactionsEnabled 1 -OutboundTransactionsEnabled 1 -RemoteClientAccessEnabled 1 -Confirm:0
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["C:\\app\\FrameworkConsole.exe"]