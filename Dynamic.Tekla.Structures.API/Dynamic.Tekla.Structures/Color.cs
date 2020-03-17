//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model.UI
{

    public sealed class Color 
    {

		public System.Double Red
		{
			get => color.Red;
			set { color.Red = value; }
		}

		public System.Double Green
		{
			get => color.Green;
			set { color.Green = value; }
		}

		public System.Double Blue
		{
			get => color.Blue;
			set { color.Blue = value; }
		}

		public System.Double Transparency
		{
			get => color.Transparency;
			set { color.Transparency = value; }
		}

        

        dynamic color;
        
        public Color()
        {
            this.color =  TSActivator.CreateInstance("Tekla.Structures.Model.UI.Color");
        }

        public Color(dynamic tsObject)
        {
            this.color = tsObject;
			this.Red = color.Red;
			this.Green = color.Green;
			this.Blue = color.Blue;
			this.Transparency = color.Transparency;

        }


        public dynamic GetTSObject() => color;





    }

}
    
