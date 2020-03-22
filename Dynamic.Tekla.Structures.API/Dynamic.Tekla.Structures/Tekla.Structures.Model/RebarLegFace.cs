/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class RebarLegFace 
    {

		public System.Int32 Id
		{
			get => teklaObject.Id;
			set { teklaObject.Id = value; }
		}

		public System.Double AdditonalOffset
		{
			get => teklaObject.AdditonalOffset;
			set { teklaObject.AdditonalOffset = value; }
		}

		public System.Int32 LayerOrderNumber
		{
			get => teklaObject.LayerOrderNumber;
			set { teklaObject.LayerOrderNumber = value; }
		}

		public System.Boolean Reversed
		{
			get => teklaObject.Reversed;
			set { teklaObject.Reversed = value; }
		}

		public Dynamic.Tekla.Structures.Model.Contour Contour
		{
			get => Dynamic.Tekla.Structures.Model.Contour_.FromTSObject(teklaObject.Contour);
			set { teklaObject.Contour = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public RebarLegFace()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLegFace");
		}
		public RebarLegFace(Dynamic.Tekla.Structures.Model.Contour contour)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Model.Contour_.GetTSObject(contour);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.RebarLegFace", args);
		}





    }

    internal static class RebarLegFace_
    {
        public static dynamic GetTSObject(RebarLegFace dynObject)
        {
            return dynObject.teklaObject;
        }

        public static RebarLegFace FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.RebarLegFace)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
