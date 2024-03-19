# FitnessApp
This README provides an overview of the project
## Project Overview
Fitness App is a .NET MAUI app that consume an API and display data on relevent screens, with data Visualization included
## Project Structure
The project follows a MVVM architecture and Repository pattern, contains the following:
- `Constants/`: This directory contains the C# source code for all the constant values to be used in the app.
- `Models/`: All the application Models are stored here.
- `Resoures/`:Here all the images, Styles, Fonts, Colors are Stored.
- `Services/Interface/`: Here repository Interfaces are stored.
- `Services/Repository/`: Here repository classes that implement the interfaces are stored.
- `ViewModels/`: Here all the View Models/Controllers are stored.
- `View/`: Here all the Views or Pages of the application are stored.
- `App.xaml`: Start up file of the application.
- `AppShell.xaml`: This is the shell that the pages use on the application.
- `MauiProgram.cs`: The project's C# file, specifying project dependencies and build settings. 
- `README.md`: The file you are currently reading, providing information about the project.

## Project Design choices
1. MVVM design: Using the mvvm architecture allows for separation of concerns and an easier way to structure your code and debug
2. Repository Pattern: This pattern allows for coding to an interface which is much cleaner and organized. Concrete classes are created and they implement interfaces.


## Data Visualisation (In Progress)
Packages: Syncfusion.Maui.Chart and Microchart.Maui
This is still on going, Chart was implemented, but the chart builds on the screen with no data

## Getting Started
1. Clone this repository to your local machine.
2. Create a Mock API on your favourite website
3. Build and run the application using your preferred IDE.
4. Access the application in your Windows, Android, ios devices.

## Packages
1. CommunityToolkit.Mvvm
2. Newtonsoft.json
3. Syncfusion.Maui.Charts

## Feedback and Contributions
Feel free to provide feedback, report issues, or contribute to this project by opening GitHub issues or pull requests. I appreciate your contributions to make this template project better.

Happy coding!
