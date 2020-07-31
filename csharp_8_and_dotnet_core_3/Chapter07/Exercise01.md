1. What is the difference between a namespace and an assembly?

An assembly is a file that stores types.
A namespace is the address of a type.

2. How do you reference another project in a .csproj file?

You add a reference to use *.csproj file using `dotnet`.

3. What is the difference between a package and a metapackage?
Give an example of each.

A metapackage is made up of multiple packages.

4. Which .NET type does the C# float alias represent?

`System.Single`

5. What is the difference between the packages named `NETStandard.Library` and `Microsoft.NETCore.App`?

NETCore is a superset of NETStandard.

6. What is the difference between framework-dependent and self-contained deployments of .NET Core applications?

Framework depended deployments require .NET Core to be installed while self-contained deployments contain everything they need already.

7. What is a RID?

Runtime identifier. It IDs a target operating system.

8. What is the difference between the dotnet pack and dotnet publish commands?

Pack creates a NuGet package.
Publish creates a folder containing the applications and its dependencies.

9. What types of applications written for the .NET Framework can be ported to .NET Core?

ASP.NET Core MVC, ASP.NET Core Web API.

10. Can you use packages written for .NET Framework with .NET Core?

Yes, as long as they use APIs that are available in .NET Core.
There will be warnings during compilation.
