/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Phase 
    {

		public System.Int32 PhaseNumber
		{
			get
			{
				try {
					return teklaObject.PhaseNumber;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PhaseNumber"); }
			}
			set
			{
				try {
					teklaObject.PhaseNumber = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PhaseNumber"); }
			}
		}

		public System.String PhaseName
		{
			get
			{
				try {
					return teklaObject.PhaseName;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PhaseName"); }
			}
			set
			{
				try {
					teklaObject.PhaseName = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PhaseName"); }
			}
		}

		public System.String PhaseComment
		{
			get
			{
				try {
					return teklaObject.PhaseComment;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PhaseComment"); }
			}
			set
			{
				try {
					teklaObject.PhaseComment = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("PhaseComment"); }
			}
		}

		public System.Int32 IsCurrentPhase
		{
			get
			{
				try {
					return teklaObject.IsCurrentPhase;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsCurrentPhase"); }
			}
			set
			{
				try {
					teklaObject.IsCurrentPhase = value;
				} catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
				 { throw DynamicAPINotFoundException.CouldNotFindProperty("IsCurrentPhase"); }
			}
		}

        

        internal dynamic teklaObject;

		public Phase()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Phase");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Phase(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}
		public Phase(System.Int32 PhaseNumber)
		{
			var args = new object[1];
			args[0] = PhaseNumber;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Phase", args);
		}
		public Phase(System.Int32 PhaseNumber, System.String PhaseName, System.String PhaseComment, System.Int32 IsCurrentPhase)
		{
			var args = new object[4];
			args[0] = PhaseNumber;
			args[1] = PhaseName;
			args[2] = PhaseComment;
			args[3] = IsCurrentPhase;
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Phase", args);
		}

		public System.Boolean Insert()
		{
			try {
			return teklaObject.Insert();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Insert()"); }
		}

		public System.Boolean Select()
		{
			try {
			return teklaObject.Select();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Select()"); }
		}

		public System.Boolean Modify()
		{
			try {
			return teklaObject.Modify();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Modify()"); }
		}

		public System.Boolean Delete()
		{
			try {
			return teklaObject.Delete();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("Delete()"); }
		}

		public System.Boolean SetUserProperty(System.String Name, System.String Value)
		{
			try {
			return teklaObject.SetUserProperty(Name, Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetUserProperty()"); }
		}

		public System.Boolean SetUserProperty(System.String Name, System.Double Value)
		{
			try {
			return teklaObject.SetUserProperty(Name, Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetUserProperty()"); }
		}

		public System.Boolean SetUserProperty(System.String Name, System.Int32 Value)
		{
			try {
			return teklaObject.SetUserProperty(Name, Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("SetUserProperty()"); }
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.String Value)
		{
			try {
			return teklaObject.GetUserProperty(Name, ref Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetUserProperty()"); }
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.Double Value)
		{
			try {
			return teklaObject.GetUserProperty(Name, ref Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetUserProperty()"); }
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.Int32 Value)
		{
			try {
			return teklaObject.GetUserProperty(Name, ref Value);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("GetUserProperty()"); }
		}





    }

    internal static class Phase_
    {
        public static dynamic GetTSObject(Phase dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Phase FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Phase)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PhaseArray_
    {
        public static dynamic GetTSObject(Phase[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Phase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Phase[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Phase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Phase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
