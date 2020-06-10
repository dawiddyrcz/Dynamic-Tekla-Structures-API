# Dynamic-Tekla-Structures-API
`This is alpha version of library. Tests are in progress. There are some not finded bugs.`

`Update: Something is wrong with Tekla Structures 2019i SP4 and Windows 8. Tekla API does not see running Tekla when run in release mode (or without Visual Studio debuger). `

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
Dynamic.Tekla.Api can be used like official Tekla API. Check "Example" project for all examples.

### Check if Tekla is running
```c#
using System;
using TS = Dynamic.Tekla.Structures;

namespace Examples
{
    public class Check_If_Tekla_Is_Running
    {
        public void Run()                      
        {
            if (TS.TeklaProcess.IsTeklaRunning())
            {
                Console.WriteLine("Tekla is running.\nVersion " + TS.TeklaProcess.TeklaFileVersion.ToString());
            }
            else
            {
                Console.WriteLine("Tekla is not running");
            }
        }
    }
}
```

### Get model info:
```c#
using System;
using TSM = Dynamic.Tekla.Structures.Model;

namespace Examples
{
    public class Get_Model_Info
    {
        public void Run()
        {
            var model = new TSM.Model();
            var info = model.GetInfo();

            Console.WriteLine("ModelName:\t" + info.ModelName);
            Console.WriteLine("ModelPath:\t" + info.ModelPath);
            Console.WriteLine("CurrentPhase:\t" + info.CurrentPhase);
        }
    }
}
```

### Insert beam in model:
```c#
using System;
using TSM = Dynamic.Tekla.Structures.Model;
using T3D = Dynamic.Tekla.Structures.Geometry3d;
using System.Collections;

namespace Examples
{
    public class Insert_Beam_In_Model
    {
        public void Run()
        {
            //Crate beam
            var beam = new TSM.Beam();
            beam.Material.MaterialString = "S235JR";
            beam.Profile.ProfileString = "HEB300";
            beam.StartPoint = new T3D.Point(0, 0, 0);
            beam.EndPoint = new T3D.Point(5000, 5000, 5000);
            beam.Class = "2";
            beam.Name = "Hello beam";
            beam.Insert();

            //Commit changes in model
            var model = new TSM.Model();
            model.CommitChanges();

            //Show beam identifiers
            Console.WriteLine("Beam inserted");
            Console.WriteLine("Beam id:\t" + beam.Identifier.ID);
            Console.WriteLine("Beam guid:\t" + beam.Identifier.GUID);

            //Get phase
            beam.GetPhase(out TSM.Phase phase);
            Console.WriteLine("Beam phase:\t" + phase.PhaseNumber);

            //Check weight
            double weight = 0;
            beam.GetReportProperty("WEIGHT", ref weight);
            Console.WriteLine("Beam weight:\t" + weight);

            //Select beam
            var selector = new TSM.UI.ModelObjectSelector();
            selector.Select(new ArrayList() { beam });

        }
    }
}
```
### Print drawing names:
```c#
using System;
using TSD = Dynamic.Tekla.Structures.Drawing;

namespace Examples
{
    public class Print_Drawing_Names
    {
        public void Run()
        {
            var dh = new TSD.DrawingHandler();
            dh.CloseActiveDrawing(false);

            Console.WriteLine("Getting drawings from the model...");
            var drawings = dh.GetDrawings();

            if (drawings.GetSize().Equals(0))
                Console.WriteLine("There is no drawing in the opened model");
            else
                Console.WriteLine("There are {0} drawings. Printing first 10...\n\n", drawings.GetSize());

            int i = 1;
            while (drawings.MoveNext())
            {
                var drawing = drawings.Current as TSD.Drawing;

                Console.WriteLine(i + " Mark: {4}, Name: {0}, Title1: {1}, Title2: {2}, Title3 {3}", 
                    drawing.Name, drawing.Title1, drawing.Title2, drawing.Title3, drawing.Mark);

                if (i.Equals(10)) break;
                i++;
            }
        }
    }
}
```

### Register events
```c#
using System;
using TSM = Dynamic.Tekla.Structures.Model;
using TSD = Dynamic.Tekla.Structures.Drawing;

namespace Examples
{
    public class Events_Example
    {
        public void Run()
        {
            System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                //Register model events
                var modelEvents = new TSM.Events();
                modelEvents.SelectionChange += () => Console.WriteLine("SelectionChange");
                modelEvents.ClashCheckDone += (x) => Console.WriteLine("ClashCheckDone");
                modelEvents.ClashDetected += (x) => Console.WriteLine("ClashDetected");
                modelEvents.ModelSave += () => Console.WriteLine("ModelSave");
                modelEvents.Numbering += () => Console.WriteLine("Numbering");
                modelEvents.TeklaStructuresExit += () => Console.WriteLine("TeklaStructuresExit");

                //This events are not present in official old tekla api versions
                if (Dynamic.Tekla.Structures.TeklaProcess.TeklaFileVersion.Major >= 2018)
                {
                    modelEvents.ModelObjectChanged += (x) => Console.WriteLine("ModelObjectChanged: " + x.Count);
                    modelEvents.Interrupted += () => Console.WriteLine("Interrupted");
                }
                
                modelEvents.Register();

                //Register drawing events
                var drawingEvents = new TSD.Events();
                drawingEvents.DrawingDeleted += () => Console.WriteLine("DrawingDeleted");
                drawingEvents.DrawingInserted += () => Console.WriteLine("DrawingInserted");
                drawingEvents.DrawingStatusChanged += () => Console.WriteLine("DrawingStatusChanged");

                //This events are not present in official old tekla api versions
                if (Dynamic.Tekla.Structures.TeklaProcess.TeklaFileVersion.Major >= 2019)
                {
                    drawingEvents.DrawingUpdated += (x, y) => Console.WriteLine("DrawingUpdated");
                    drawingEvents.DrawingChanged += () => Console.WriteLine("DrawingChanged");
                }
                
                drawingEvents.Register();

                //Register drawing UI events
                var drawingUIEvents = new TSD.UI.Events();
                drawingUIEvents.DrawingEditorClosed += () => Console.WriteLine("DrawingEditorClosed");
                drawingUIEvents.DrawingEditorOpened += () => Console.WriteLine("DrawingEditorOpened");
                drawingUIEvents.DrawingListSelectionChanged += () => Console.WriteLine("DrawingListSelectionChanged");
                drawingUIEvents.DrawingLoaded += () => Console.WriteLine("DrawingLoaded");
                drawingUIEvents.SelectionChange += () => Console.WriteLine("DrawingSelectionChange");

                //This events are not present in official old tekla api versions
                if (Dynamic.Tekla.Structures.TeklaProcess.TeklaFileVersion.Major >= 2018)
                {
                    drawingUIEvents.Interrupted += () => Console.WriteLine("DrawingInterrupted");
                }

                drawingUIEvents.Register();

                Console.WriteLine("Events are now registered. Do something in model. Do not close console");
                Console.WriteLine();

                while (true)
                {
                    System.Threading.Thread.Sleep(5000);
                    Console.WriteLine("Waiting for any event....");
                }
            });

            Console.ReadKey();
        }
    }
}
```
