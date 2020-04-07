# Dynamic-Tekla-Structures-API
This is a wrapper of the Tekla Structures API assemblies, created to make version independent applications which connects with Tekla Structures. This library can be used instead of official Tekla Structures API. Library contains most of the types present in official Tekla API but namespaces starts with "Dynamic.Tekla.Structures" instead of "Tekla.Structures". 

## What is the Tekla Structures API
Tekla Structures API is an API which allows to connect with Tekla Structures program or create extensions to Tekla Structures.
For more information see: [Tekla Developer Center](https://developer.tekla.com/)

## What is the difference between Dynamic.Tekla.API and official Tekla Structures API
* This library is unofficial API
* This library is Tekla Version independent - you dont need to recompile your application to every Tekla Structures version
* With this library you cannot create plugins but only applications
* This applications do not contains all types, classes and methods which are present in official Tekla API

## How the Dynamic.Tekla.API works
Library checks if Tekla Structures is running. If yes then loads dll from Tekla bin folder. Types are instaced using reflection or dynamic binding. 

## How to use it the Dynamic.Tekla.API
Remove all references to official Tekla API and add reference to the Dynamic.Tekla.API.dll. Then change all using namespaces to Dynamic.Tekla.Structures.

## Documentation
Because of all types and methods have the same names as in official Tekla API then you can use official [documentation](https://developer.tekla.com/tekla-structures/api/10/8180).

## Dynamic.Tekla.API Exceptions
There are tree types of additional exceptions which you can experience while working with that library:
* `DynamicAPITeklaNotRunningException` - throw when library could not find Tekla Structures Process
* `DynamicAPINotFoundException` - throw when type, method, property or field are not present in current Tekla API version
* `DynamicAPIException` - throw when internal error or when unhandled error occurs

## How to handle changes between official Tekla API versions
This Dynamic.Tekla.API library is generated from Tekla API version 2019i. When something is not avaiable in older versions of API then `DynamicAPINotFoundException` is throwed. You, the programer have to handle this exception in your program. You have to decide how to do it. You can 
* show message box with information that this one funcion is not avaiable in current Tekla version or
* you can prevent using your application with older versions of tekla structures

## TeklaProcess class
Dynamic.Tekla.Structures.TeklaProcess class contains static properties with information about version of current process of Tekla Structures program. Here is its interface:
```c#
public static class TeklaProcess
{
    public static string BinPath { get; private set; }
    public static TeklaFileVersion TeklaFileVersion { get; private set; }
    public static Process teklaProcess { get; private set; }

    public static bool IsTeklaRunning();  
}
```
## Examples

