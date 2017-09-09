FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /app

COPY *.sln */*.csproj ./
RUN perl -e 'foreach(@ARGV){/(.*).csproj/;mkdir($1);rename($&,"$1/$&")}' *.csproj
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o ../out Mayope.Server.Http/*.csproj

FROM microsoft/aspnetcore:2.0
WORKDIR /app

COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "Mayope.Server.Http.dll"]
