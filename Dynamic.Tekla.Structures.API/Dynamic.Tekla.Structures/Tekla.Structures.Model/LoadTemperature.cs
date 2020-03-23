/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class LoadTemperature  : Dynamic.Tekla.Structures.Model.Load
    {

		public Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum Spanning
		{
			get => Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.FromTSObject(teklaObject.Spanning);
			set { teklaObject.Spanning = Dynamic.Tekla.Structures.Model.Load.LoadSpanningEnum_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Vector PrimaryAxisDirection
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Vector_.FromTSObject(teklaObject.PrimaryAxisDirection);
			set { teklaObject.PrimaryAxisDirection = Dynamic.Tekla.Structures.Geometry3d.Vector_.GetTSObject(value); }
		}

		public System.Boolean AutomaticPrimaryAxisWeight
		{
			get => teklaObject.AutomaticPrimaryAxisWeight;
			set { teklaObject.AutomaticPrimaryAxisWeight = value; }
		}

		public System.Double Weight
		{
			get => teklaObject.Weight;
			set { teklaObject.Weight = value; }
		}

		public System.Double LoadDispersionAngle
		{
			get => teklaObject.LoadDispersionAngle;
			set { teklaObject.LoadDispersionAngle = value; }
		}

		public System.Boolean CreateFixedSupportConditionsAutomatically
		{
			get => teklaObject.CreateFixedSupportConditionsAutomatically;
			set { teklaObject.CreateFixedSupportConditionsAutomatically = value; }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Position1
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Position1);
			set { teklaObject.Position1 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Geometry3d.Point Position2
		{
			get => Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(teklaObject.Position2);
			set { teklaObject.Position2 = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(value); }
		}

		public System.Double TemperatureChangeForAxialElongation
		{
			get => teklaObject.TemperatureChangeForAxialElongation;
			set { teklaObject.TemperatureChangeForAxialElongation = value; }
		}

		public System.Double TemperatureDifferentialTopToBottom
		{
			get => teklaObject.TemperatureDifferentialTopToBottom;
			set { teklaObject.TemperatureDifferentialTopToBottom = value; }
		}

		public System.Double TemperatureDifferentialSideToSide
		{
			get => teklaObject.TemperatureDifferentialSideToSide;
			set { teklaObject.TemperatureDifferentialSideToSide = value; }
		}

		public System.Double InitialAxialElongation
		{
			get => teklaObject.InitialAxialElongation;
			set { teklaObject.InitialAxialElongation = value; }
		}

        

        

		public LoadTemperature()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.LoadTemperature");
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

    internal static class LoadTemperature_
    {
        public static dynamic GetTSObject(LoadTemperature dynObject)
        {
            return dynObject.teklaObject;
        }

        public static LoadTemperature FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Dynamic.Tekla.Structures.Model.LoadTemperature)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
