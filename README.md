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
   public Result<string> Foo()
   {
        return new Result<string>(content: "this is content" , message: "this is message");
   }

   public void ShowResult()
   {
        var result = Do();
  
        Console.WriteLine(result.Content);
   }  
   ```
