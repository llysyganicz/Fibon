FROM microsoft/dotnet:runtime

WORKDIR /dotnetapp

COPY ./bin/Docker .

ENV ASPNETCORE ENVIRONMENT docker

ENTRYPOINT ["dotnet", "Fibon.Service.dll"]