### Table of content
- [Getting started](#getting-started)
    - [Installing](#1-Installing-package)
    - [Usage](#2-Usage)
    - [ResultMessage](#Result-Message)


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

### Result Message
```csharp
public Result<User> AddUser(User user)
{
    // implementation

    return new Result<User>(user, message: "User Created");
}

public void Writer()
{
    var user = new User();

    var result = AddUser(user);

    Console.WriteLine(result.Message);
}
```
