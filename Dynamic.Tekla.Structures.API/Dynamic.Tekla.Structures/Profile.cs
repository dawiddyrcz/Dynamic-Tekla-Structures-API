//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class Profile 
    {

		public System.String ProfileString
		{
			get => profile.ProfileString;
			set { profile.ProfileString = value; }
		}

        

        dynamic profile;
        
        public Profile()
        {
            this.profile =  new Tekla.Structures.Model.Profile();
        }

        public Profile(dynamic tsObject)
        {
            this.profile = tsObject;
			this.ProfileString = profile.ProfileString;

        }


        public dynamic GetTSObject() => profile;

		public System.String ParseProfileString(System.String profileString)
			 => profile.ParseProfileString(profileString);

		public System.String FormatProfileString(System.String profileString)
			 => profile.FormatProfileString(profileString);





    }

}
    
