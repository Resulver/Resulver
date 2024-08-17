### Table of content
- [Getting started](#getting-started)
    - [Installing](#1-Installing-package)
    - [Usage](#2-Usage)



## Getting started
### 1. Installing package
  ```bash
  dotnet add package Resulver
  ```

  ### 2. Usage
   ```csharp
    public Result<int> Sum(int a, int b)
    {
        var sum = a + b;

        return new Result<int>(sum);
    }

    public void Writer()
    {
        var result = Sum(3, 5);

        Console.WriteLine(result.Content);
    } 
   ```
