//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class RebarProperties 
    {

		public System.String Size
		{
			get => rebarproperties.Size;
			set { rebarproperties.Size = value; }
		}

		public System.String Grade
		{
			get => rebarproperties.Grade;
			set { rebarproperties.Grade = value; }
		}

		public System.String Name
		{
			get => rebarproperties.Name;
			set { rebarproperties.Name = value; }
		}

		public System.Int32 Class
		{
			get => rebarproperties.Class;
			set { rebarproperties.Class = value; }
		}

		public Dynamic.Tekla.Structures.Model.NumberingSeries NumberingSeries
		{
			get => new Dynamic.Tekla.Structures.Model.NumberingSeries(rebarproperties.NumberingSeries.GetTSObject());
			set { rebarproperties.NumberingSeries = value.GetTSObject(); }
		}

		public System.Double BendingRadius
		{
			get => rebarproperties.BendingRadius;
			set { rebarproperties.BendingRadius = value; }
		}

        

        dynamic rebarproperties;
        
        public RebarProperties()
        {
            this.rebarproperties =  new Tekla.Structures.Model.RebarProperties();
        }

        public RebarProperties(dynamic tsObject)
        {
            this.rebarproperties = tsObject;
			this.Size = rebarproperties.Size;
			this.Grade = rebarproperties.Grade;
			this.Name = rebarproperties.Name;
			this.Class = rebarproperties.Class;
			this.NumberingSeries = new Dynamic.Tekla.Structures.Model.NumberingSeries(rebarproperties.NumberingSeries);
			this.BendingRadius = rebarproperties.BendingRadius;

        }


        public dynamic GetTSObject() => rebarproperties;

		public System.Boolean Equals(System.Object obj)
			 => rebarproperties.Equals(obj);

		public System.Int32 GetHashCode()
			 => rebarproperties.GetHashCode();

		public System.Type GetType()
			 => rebarproperties.GetType();

		public System.String ToString()
			 => rebarproperties.ToString();





    }

}
    
