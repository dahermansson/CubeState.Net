# CubeState.Net
dotnet lib to keep state of Rubiks Cube

## Usage

```
// Create CubeState
var cubeState = new CubeState();

// Do turns
cubeState.DoManyTurns("R U F L' D2 B);

// Check if solved
if(cubeState.IsSolved())
    Console.WriteLine("cubeState is solved");
else
    Console.WriteLine("CubeState is not solved");
```

