# Stateless C# Native AOT Example

This repository demonstrates how to create a C# native AOT console app using the Stateless NuGet package.

## Getting Started

1. Prerequisites:

- Visual Studio 2022 (or later) with .NET SDK 6.0 (or later)
- .NET Native development tools

2. Clone the Repository:
```
git clone [https://github.com/Jignesh-Darji/.NET-Core-Native-AOT-App.git](https://github.com/Jignesh-Darji/.NET-Core-Native-AOT-App.git)
```
3. Restore NuGet Packages:

- Open the solution in Visual Studio.
- Right-click on the project in Solution Explorer and select "Manage NuGet Packages."
- Restore any missing packages.

4. Configure AOT (if necessary):

- If the Stateless package requires specific runtime directives for AOT, create an rd.xml file in the project's root directory.
- Edit the project file (.csproj) to enable AOT publishing:
```
<PropertyGroup>
  <PublishAot>true</PublishAot>
</PropertyGroup>
``` 
5. Build and Publish:

- Build the solution in Release mode.
- Right-click on the project in Solution Explorer and select "Publish."
- Choose the "Self-Contained" deployment mode and select "Produce a single file" for a standalone executable.

## Usage

- Run the published executable from the command line.
- Observe the state machine behavior as it transitions between states based on triggers.
 
## Additional Information

- Stateless Documentation: [[Link to official documentation]](https://www.nuget.org/packages/Stateless/)
- .NET Native AOT: [[Link to .NET documentation on AOT]](https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/?tabs=net7%2Cwindows)

## Contributing

Feel free to open issues or pull requests for improvements or bug fixes.
Please adhere to the code style and guidelines in the project.

## License

This project is licensed under the MIT License.
