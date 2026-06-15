FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY NotepadOnline.API/NotepadOnline.API.csproj ./NotepadOnline.API/
RUN dotnet restore "NotepadOnline.API/NotepadOnline.API.csproj"
COPY . .
WORKDIR "/src/NotepadOnline.API"
RUN dotnet build "NotepadOnline.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NotepadOnline.API.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NotepadOnline.API.dll"]
