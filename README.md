# Rocket-Elevators-Csharp-Controller
This project is about implementing an elevator controller for commercial purposes.  The program is based on a pseudocode file given and for this version written in C#. C# ist a compiled language  designed by Microsoft and because ist a compiled language it is faster than an interpreted language but handles less abstraction.Here a [video](https://drive.google.com/file/) that I explain my work


### Usage 
To run the script with dotnet run the command in the 
`donet run`
Make sure to be at the right path
`~/Desktop/Rocket-Elevators-Csharp-Controller/Commercial_Controller$`

### Running the tests

To launch the tests, make sure to be at the root of the repository and run:

`dotnet test`

![](https://github.com/JulienCharbonneau/Rocket-Elevators-Csharp-Controller/blob/main/Peek%202022-10-20%2019-26.gif)


## Description
This program creates a number of columns and elevators as needed and supports the needs of elevator request button and floor access request button with a system-based efficiency management point allowing to evaluate the best choice taking into account the floor where the request was initiated versus the availability and the direction of the cage. For commercial buildings, the first column is assigned at the basement and others are split between floors to serve.


#### Dependencies

`C#` `dotnet`
