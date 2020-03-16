//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures
{

    public sealed class Identifier 
    {

		public System.Int32 ID
		{
			get => identifier.ID;
			set { identifier.ID = value; }
		}

		public System.Int32 ID2
		{
			get => identifier.ID2;
			set { identifier.ID2 = value; }
		}

		public System.Guid GUID
		{
			get => identifier.GUID;
			set { identifier.GUID = value; }
		}

        

        dynamic identifier;
        
        public Identifier()
        {
            this.identifier =  new Tekla.Structures.Identifier();
        }

        public Identifier(dynamic tsObject)
        {
            this.identifier = tsObject;
			this.ID = identifier.ID;
			this.ID2 = identifier.ID2;
			this.GUID = identifier.GUID;

        }


        public dynamic GetTSObject() => identifier;

		public System.Boolean IsValid()
			 => identifier.IsValid();





    }

}
    
