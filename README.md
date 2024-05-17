### Table of content
- [Getting started](#getting-started)
    - [Installing](#Installing-package)
    - [Create result class](#2-Create-result-class)
    - [Usage](#3.-Usage)



## Getting started
### Installing package
  ```bash
  dotnet add package Resulver
  ```


### 2. Create result class
 ```csharp
 public class MyResult : Result<string>
 {
      public MyResult(string content, string? message) : base(content, message) { }
 }
 ```
  In this case 'string' is result content type.
  
  You can change it to any other type you want.

  ## 3. Usage
   ```csharp
   public MyResult Foo()
   {
        return new MyResult(content: "this is content" , message: "this is message");
   }

   public void ShowResult()
   {
        var result = Do();
  
        Console.WriteLine(result.Content);
   }  
   ```
