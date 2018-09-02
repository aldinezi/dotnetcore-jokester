# dotnetcore-jokester

Jokester app built entirely using blazor dotnet core framework, relaying on chucknorris jokes api.

>Demo at http://aldinezi.tech/blazorapp

https://blazor.net/
https://api.chucknorris.io/

To test locally, install dotnetcore sdk 2.1.401 and build tools.

``` bash
git clone https://github.com/aldinezi/dotnetcore-jokester.git`

# restore package
dotnet restore

# serve with hot reload at localhost:5000
dotnet watch run

# build for production with minification
dotnet publish -c Release
```