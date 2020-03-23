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
			get => teklaObject.PhaseNumber;
			set { teklaObject.PhaseNumber = value; }
		}

		public System.String PhaseName
		{
			get => teklaObject.PhaseName;
			set { teklaObject.PhaseName = value; }
		}

		public System.String PhaseComment
		{
			get => teklaObject.PhaseComment;
			set { teklaObject.PhaseComment = value; }
		}

		public System.Int32 IsCurrentPhase
		{
			get => teklaObject.IsCurrentPhase;
			set { teklaObject.IsCurrentPhase = value; }
		}

        

        internal dynamic teklaObject;

		public Phase()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Phase");
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
			return teklaObject.Insert();
		}

		public System.Boolean Select()
		{
			return teklaObject.Select();
		}

		public System.Boolean Modify()
		{
			return teklaObject.Modify();
		}

		public System.Boolean Delete()
		{
			return teklaObject.Delete();
		}

		public System.Boolean SetUserProperty(System.String Name, System.String Value)
		{
			return teklaObject.SetUserProperty(Name, Value);
		}

		public System.Boolean SetUserProperty(System.String Name, System.Double Value)
		{
			return teklaObject.SetUserProperty(Name, Value);
		}

		public System.Boolean SetUserProperty(System.String Name, System.Int32 Value)
		{
			return teklaObject.SetUserProperty(Name, Value);
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.String Value)
		{
			return teklaObject.GetUserProperty(Name, ref Value);
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.Double Value)
		{
			return teklaObject.GetUserProperty(Name, ref Value);
		}

		public System.Boolean GetUserProperty(System.String Name, ref System.Int32 Value)
		{
			return teklaObject.GetUserProperty(Name, ref Value);
		}





    }

    internal static class Phase_
    {
        public static dynamic GetTSObject(Phase dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Phase FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.Phase)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PhaseArray_
    {
        public static dynamic GetTSObject(Phase[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Phase_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Phase[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Phase>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Phase_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
