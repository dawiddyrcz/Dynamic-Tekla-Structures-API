/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures
{

    public  class MacroBuilder 
    {

        

        internal dynamic teklaObject;

		public MacroBuilder()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.MacroBuilder");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public MacroBuilder(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public MacroBuilder(System.String script)
		{
			var args = new object[1];
			args[0] = script;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.MacroBuilder", args);
		}

		public Dynamic.Tekla.Structures.MacroBuilder Activate(System.String dialog, System.String field)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.Activate(dialog, field));
		}

		public Dynamic.Tekla.Structures.MacroBuilder Callback(System.String callback)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.Callback(callback));
		}

		public Dynamic.Tekla.Structures.MacroBuilder Callback(System.String callback, System.String parameter)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.Callback(callback, parameter));
		}

		public Dynamic.Tekla.Structures.MacroBuilder Callback(System.String callback, System.String parameter, System.String frame)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.Callback(callback, parameter, frame));
		}

		public Dynamic.Tekla.Structures.MacroBuilder CheckValue(System.String name, System.Int32 value)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.CheckValue(name, value));
		}

		public Dynamic.Tekla.Structures.MacroBuilder CommandEnd()
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.CommandEnd());
		}

		public Dynamic.Tekla.Structures.MacroBuilder CommandStart(System.String command, System.String parameter, System.String frame)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.CommandStart(command, parameter, frame));
		}

		public Dynamic.Tekla.Structures.MacroBuilder FileSelection( params System.String[] items)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.FileSelection(items));
		}

		public Dynamic.Tekla.Structures.MacroBuilder ListSelect(System.String dialog, System.String field,  params System.String[] items)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.ListSelect(dialog, field, items));
		}

		public Dynamic.Tekla.Structures.MacroBuilder ModalDialog(System.Int32 value)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.ModalDialog(value));
		}

		public Dynamic.Tekla.Structures.MacroBuilder MouseDown(System.String frame, System.String subframe, System.Int32 x, System.Int32 y, System.Int32 modifier)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.MouseDown(frame, subframe, x, y, modifier));
		}

		public Dynamic.Tekla.Structures.MacroBuilder MouseUp(System.String frame, System.String subframe, System.Int32 x, System.Int32 y, System.Int32 modifier)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.MouseUp(frame, subframe, x, y, modifier));
		}

		public Dynamic.Tekla.Structures.MacroBuilder PushButton(System.String button, System.String frame)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.PushButton(button, frame));
		}

		public void Run()
		{
			teklaObject.Run();
		}

		public void Run(Dynamic.Tekla.Structures.IConnection connection)
		{
			teklaObject.Run(Dynamic.Tekla.Structures.IConnection_.GetTSObject(connection));
		}

		public Dynamic.Tekla.Structures.MacroBuilder TabChange(System.String dialog, System.String field, System.String item)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.TabChange(dialog, field, item));
		}

		public Dynamic.Tekla.Structures.MacroBuilder TableSelect(System.String dialog, System.String field,  params System.Int32[] items)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.TableSelect(dialog, field, items));
		}

		public Dynamic.Tekla.Structures.MacroBuilder TreeSelect(System.String dialog, System.String field, System.String rowstring)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.TreeSelect(dialog, field, rowstring));
		}

		public Dynamic.Tekla.Structures.MacroBuilder ValueChange(System.String dialog, System.String field, System.String data)
		{
			return Dynamic.Tekla.Structures.MacroBuilder_.FromTSObject(teklaObject.ValueChange(dialog, field, data));
		}





    }

    internal static class MacroBuilder_
    {
        public static dynamic GetTSObject(MacroBuilder dynObject)
        {
            if (dynObject == null) return null;
            return dynObject.teklaObject;
        }

        public static MacroBuilder FromTSObject(dynamic tsObject)
        {
            if (tsObject == null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.MacroBuilder)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class MacroBuilderArray_
    {
        public static dynamic GetTSObject(MacroBuilder[] dynArray)
        {
            if (dynArray == null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(MacroBuilder_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static MacroBuilder[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray == null) return null;
            var list = new System.Collections.Generic.List<MacroBuilder>();
            foreach(var tsItem in tsArray)
            {
                list.Add(MacroBuilder_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
