# Dynamic-Tekla-Structures-API
This is a wrapper of the Tekla Structures API assemblies, created to make version independent applications which connects with Tekla Structures. This library can be used instead of official Tekla Structures API. Library contains most of the types present in official Tekla API but namespaces starts with "Dynamic.Tekla.Structures" instead of "Tekla.Structures". 

## What is the Tekla Structures API
Tekla Structures API is an API which allows to connect with Tekla Structures program or create extensions to Tekla Structures.
For more information see: [Tekla Developer Center](https://developer.tekla.com/)

## What is the difference between Dynamic.Tekla.Structures.API and official Tekla Structures API
* This library is unofficial API
* This library is Tekla Version independent - you dont need to recompile your application to every Tekla Structures version
* With this library you cannot create plugins but only applications
* This applications do not contains all types, classes and methods which are present in official Tekla API

## How it works
Library checks if Tekla Structures is running. If yes then loads dll from Tekla bin folder. Types are instaced using reflection or dynamic binding. 

## How to use it
Remove all references to official Tekla API and add reference to the Dynamic.Tekla.API.dll. Then change all using namespaces to Dynamic.Tekla.Structures.

## Examples

