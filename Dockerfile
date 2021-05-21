#Compile
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app
#Copy and restore everything under it
COPY . ./
RUN dotnet restore
#Publish to out directory
RUN dotnet publish -c Release -o out

FROM nginx:alpine
EXPOSE 80
COPY --from=build-env /app/out/wwwroot /usr/share/nginx/html
COPY nginx.conf /etc/nginx/nginx.conf