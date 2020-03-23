/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Profile 
    {

		public System.String ProfileString
		{
			get => teklaObject.ProfileString;
			set { teklaObject.ProfileString = value; }
		}

        

        internal dynamic teklaObject;

		public Profile()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Profile");
		}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Profile(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public static System.String ParseProfileString(System.String profileString)
		{
			var parameters = new object[1];
			parameters[0] = profileString;
			var result = (System.String) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Profile", "ParseProfileString", parameters);
			return result;
		}

		public static System.String FormatProfileString(System.String profileString)
		{
			var parameters = new object[1];
			parameters[0] = profileString;
			var result = (System.String) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Profile", "FormatProfileString", parameters);
			return result;
		}





    }

    internal static class Profile_
    {
        public static dynamic GetTSObject(Profile dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Profile FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Model.Profile)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class ProfileArray_
    {
        public static dynamic GetTSObject(Profile[] dynArray)
        {
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Profile_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Profile[] FromTSObject(dynamic[] tsArray)
        {
            var list = new System.Collections.Generic.List<Profile>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Profile_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
