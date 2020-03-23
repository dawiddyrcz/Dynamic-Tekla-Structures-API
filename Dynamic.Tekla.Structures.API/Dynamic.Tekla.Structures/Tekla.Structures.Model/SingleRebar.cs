/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class SingleRebar  : Dynamic.Tekla.Structures.Model.Reinforcement
    {

		public System.String Size
		{
			get => teklaObject.Size;
			set { teklaObject.Size = value; }
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData StartHook
		{
			get => Dynamic.Tekla.Structures.Model.RebarHookData_.FromTSObject(teklaObject.StartHook);
			set { teklaObject.StartHook = Dynamic.Tekla.Structures.Model.RebarHookData_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.RebarHookData EndHook
		{
			get => Dynamic.Tekla.Structures.Model.RebarHookData_.FromTSObject(teklaObject.EndHook);
			set { teklaObject.EndHook = Dynamic.Tekla.Structures.Model.RebarHookData_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Model.Polygon Polygon
		{
			get => Dynamic.Tekla.Structures.Model.Polygon_.FromTSObject(teklaObject.Polygon);
			set { teklaObject.Polygon = Dynamic.Tekla.Structures.Model.Polygon_.GetTSObject(value); }
		}

        

        

		public SingleRebar()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.SingleRebar");
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

		public Dynamic.Tekla.Structures.Model.RebarSet GetRebarSet()
		{
			return Dynamic.Tekla.Structures.Model.RebarSet_.FromTSObject(teklaObject.GetRebarSet());
		}





    }

    internal static class SingleRebar_
    {
        public static dynamic GetTSObject(SingleRebar dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SingleRebar FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.SingleRebar)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class SingleRebarArray_
    {
        public static dynamic GetTSObject(SingleRebar[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(SingleRebar_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static SingleRebar[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<SingleRebar>();
            foreach(var tsItem in tsArray)
            {
                list.Add(SingleRebar_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
