FROM mcr.microsoft.com/dotnet/framework/runtime:4.8

WORKDIR /app

COPY bin/Release/ .

CMD ["StockTrackerV4.exe"]