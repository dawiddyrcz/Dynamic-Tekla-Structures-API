//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public abstract class GridSurface  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public Dynamic.Tekla.Structures.Model.GridBase Parent
		{
			get => Dynamic.Tekla.Structures.Model.GridBase_.FromTSObject(teklaObject.Parent);
			set { teklaObject.Parent = Dynamic.Tekla.Structures.Model.GridBase_.GetTSObject(value); }
		}

		public System.String Label
		{
			get => teklaObject.Label;
			set { teklaObject.Label = value; }
		}

		public System.Boolean IsMagnetic
		{
			get => teklaObject.IsMagnetic;
			set { teklaObject.IsMagnetic = value; }
		}

		public System.Double ExtensionLeft
		{
			get => teklaObject.ExtensionLeft;
			set { teklaObject.ExtensionLeft = value; }
		}

		public System.Double ExtensionRight
		{
			get => teklaObject.ExtensionRight;
			set { teklaObject.ExtensionRight = value; }
		}

		public System.Double ExtensionBelow
		{
			get => teklaObject.ExtensionBelow;
			set { teklaObject.ExtensionBelow = value; }
		}

		public System.Double ExtensionAbove
		{
			get => teklaObject.ExtensionAbove;
			set { teklaObject.ExtensionAbove = value; }
		}

		public System.Boolean DrawingVisibility
		{
			get => teklaObject.DrawingVisibility;
			set { teklaObject.DrawingVisibility = value; }
		}

		public System.Boolean IsManual
		{
			get => teklaObject.IsManual;
			set { teklaObject.IsManual = value; }
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





    }

    internal static class GridSurface_
    {
        public static dynamic GetTSObject(GridSurface dynObject)
        {
            return dynObject.teklaObject;
        }

        public static GridSurface FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.GridSurface)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
