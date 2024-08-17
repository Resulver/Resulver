### Table of content
- [Installing](#Installation)
- [Usage](#Usage)
- [Result Message](#Result-Message)
- [Result Errors](#Result-Errors)

### Installation
  ```bash
  dotnet add package Resulver
  ```

### Usage
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
### Result Errors
```csharp
public class UserNotFoundError() : ResultError(message: "User not found");
public class UserIdIsNotValidError() : ResultError(message:   "User ID is not valid");

public Result RemoveUser(int userId)
{
    //Implementation



    return new UserNotFoundError();

    //or for multiple errors
    return new Result(new UserNotFoundError(), new UserIdIsNotValidError());
}

public void Writer()
{
    var result = RemoveUser(1);

    if (result.IsFailure)
    {
        foreach (var error in result.Errors)
        {
            Console.WriteLine(error.Message);
        }
    }
}
```
