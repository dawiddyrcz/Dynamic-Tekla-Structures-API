//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures
{

    public abstract class TeklaStructuresVariables 
    {

        

        internal dynamic teklaObject;


		public void Add(System.String key)
		{
			return teklaObject.Add(key);
		}

		public System.String Get(System.String key)
		{
			return teklaObject.Get(key);
		}

		public System.Boolean ContainsVariable(System.String key)
		{
			return teklaObject.ContainsVariable(key);
		}





    }

    internal static class TeklaStructuresVariables_
    {
        public static dynamic GetTSObject(TeklaStructuresVariables dynObject)
        {
            return dynObject.teklaObject;
        }

        public static TeklaStructuresVariables FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.TeklaStructuresVariables)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
