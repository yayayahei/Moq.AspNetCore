$version=$args[0]
$key=$args[1]
$projName="MoqAspNetCoreExtension"
dotnet pack -p:PackageVersion=$version --include-symbols -o "../../packages" "./src/$($projName)/$($projName).csproj"
dotnet nuget push "./packages/$($projName).$($version).symbols.nupkg" -k $key -s "https://www.nuget.org"