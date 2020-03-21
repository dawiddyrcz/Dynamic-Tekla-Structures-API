//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public abstract class BaseComponent  : Dynamic.Tekla.Structures.Model.ModelObject
    {

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.Int32 Number
		{
			get => teklaObject.Number;
			set { teklaObject.Number = value; }
		}

        

        


		public void SetAttribute(System.String AttrName, System.String StrValue)
		{
			return teklaObject.SetAttribute(AttrName, StrValue);
		}

		public void SetAttribute(System.String AttrName, System.Int32 Value)
		{
			return teklaObject.SetAttribute(AttrName, Value);
		}

		public void SetAttribute(System.String AttrName, System.Double DValue)
		{
			return teklaObject.SetAttribute(AttrName, DValue);
		}

		public System.Boolean GetAttribute(System.String AttrName, ref System.String StrValue)
		{
			return teklaObject.GetAttribute(AttrName, ref StrValue);
		}

		public System.Boolean GetAttribute(System.String AttrName, ref System.Int32 Value)
		{
			return teklaObject.GetAttribute(AttrName, ref Value);
		}

		public System.Boolean GetAttribute(System.String AttrName, ref System.Double DValue)
		{
			return teklaObject.GetAttribute(AttrName, ref DValue);
		}

		public System.Boolean LoadAttributesFromFile(System.String Filename)
		{
			return teklaObject.LoadAttributesFromFile(Filename);
		}





    }

    internal static class BaseComponent_
    {
        public static dynamic GetTSObject(BaseComponent dynObject)
        {
            return dynObject.teklaObject;
        }

        public static BaseComponent FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.BaseComponent)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
