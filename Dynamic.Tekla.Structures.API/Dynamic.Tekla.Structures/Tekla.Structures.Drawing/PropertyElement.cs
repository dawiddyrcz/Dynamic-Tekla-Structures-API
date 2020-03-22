/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing
{

    public  class PropertyElement  : Dynamic.Tekla.Structures.Drawing.ElementBase
    {

		public System.String Name
		{
			get => teklaObject.Name;
			set { teklaObject.Name = value; }
		}

		public System.String Value
		{
			get => teklaObject.Value;
			set { teklaObject.Value = value; }
		}

		public Dynamic.Tekla.Structures.Drawing.FontAttributes Font
		{
			get => Dynamic.Tekla.Structures.Drawing.FontAttributes_.FromTSObject(teklaObject.Font);
			set { teklaObject.Font = Dynamic.Tekla.Structures.Drawing.FontAttributes_.GetTSObject(value); }
		}

		public Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType PropertyType
		{
			get => Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(teklaObject.PropertyType);
			set { teklaObject.PropertyType = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.GetTSObject(value); }
		}

        

        

		public PropertyElement() {}
		public PropertyElement(Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType PropertyType)
		{
			var args = new object[1];
			args[0] = Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.GetTSObject(PropertyType);
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Drawing.PropertyElement", args);
		}

		public System.Object Clone()
		{
			return teklaObject.Clone();
		}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}

		public System.String GetUnformattedString()
		{
			return teklaObject.GetUnformattedString();
		}




    public  class PropertyElementType 
    {

        

        internal dynamic teklaObject;

		public PropertyElementType() {}

		public System.Boolean IsEqual(System.Object ObjectToCompare)
		{
			return teklaObject.IsEqual(ObjectToCompare);
		}




    public abstract class BoltMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType BoltLength()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "BoltLength", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType BoltDiameter()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "BoltDiameter", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType HoleDiameter()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "HoleDiameter", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Material()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "Material", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Standard()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "Standard", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType ShortName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "ShortName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType FullName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "FullName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType AssemblyType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "AssemblyType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType NumberOfBolts()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "NumberOfBolts", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SlotLengthX()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "SlotLengthX", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SlotLengthY()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "SlotLengthY", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SlotHeight()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "SlotHeight", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SlotLength()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "SlotLength", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Size()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "Size", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Countersunk()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "Countersunk", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType GageOfOutstandingLeg()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "GageOfOutstandingLeg", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CenterToCenterDistance()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes", "CenterToCenterDistance", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}





    }

    internal static class BoltMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(BoltMarkPropertyElementTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static BoltMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType.BoltMarkPropertyElementTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public abstract class PartMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType AssemblyPosition()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "AssemblyPosition", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType PartPosition()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "PartPosition", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Profile()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Profile", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Material()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Material", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Name()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Name", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Class()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Class", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Finish()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Finish", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Size()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Size", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Length()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Length", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Camber()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "Camber", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType FittingsNsFs()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "FittingsNsFs", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType FaceDirection()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "FaceDirection", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType GageOfOutstandingLeg()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "GageOfOutstandingLeg", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CenterToCenterDistance()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "CenterToCenterDistance", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType RotationAngle()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes", "RotationAngle", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}





    }

    internal static class PartMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(PartMarkPropertyElementTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PartMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PartMarkPropertyElementTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public abstract class ReinforcementMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Name()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Name", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Grade()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Grade", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Diameter()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Diameter", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Class()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Class", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Length()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Length", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Number()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Number", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Position()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Position", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Shape()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Shape", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Weight()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Weight", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Cc()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "Cc", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcMin()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "CcMin", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcMax()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "CcMax", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcExact()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "CcExact", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcTarget()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes", "CcTarget", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}





    }

    internal static class ReinforcementMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(ReinforcementMarkPropertyElementTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReinforcementMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMarkPropertyElementTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public abstract class ReinforcementMeshMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Name()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Name", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Grade()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Grade", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Size()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Size", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Class()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Class", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType MeshLength()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "MeshLength", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType MeshWidth()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "MeshWidth", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Number()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Number", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Position()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Position", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Shape()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Shape", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Weight()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "Weight", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcLongitudinal()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcLongitudinal", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcMinLongitudinal()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcMinLongitudinal", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcMaxLongitudinal()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcMaxLongitudinal", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcExactLongitudinal()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcExactLongitudinal", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcCrossing()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcCrossing", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcMinCrossing()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcMinCrossing", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcMaxCrossing()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcMaxCrossing", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType CcExactCrossing()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "CcExactCrossing", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DiameterLongitudinal()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "DiameterLongitudinal", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DiameterCrossing()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes", "DiameterCrossing", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}





    }

    internal static class ReinforcementMeshMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(ReinforcementMeshMarkPropertyElementTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ReinforcementMeshMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ReinforcementMeshMarkPropertyElementTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public abstract class MergedMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType BlockPrefix()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.MergedMarkPropertyElementTypes", "BlockPrefix", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SingleMarkContent()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.MergedMarkPropertyElementTypes", "SingleMarkContent", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DistancesBetweenGroups()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.MergedMarkPropertyElementTypes", "DistancesBetweenGroups", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SymbolSeparatingBlocksInMarks()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.MergedMarkPropertyElementTypes", "SymbolSeparatingBlocksInMarks", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}





    }

    internal static class MergedMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(MergedMarkPropertyElementTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static MergedMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType.MergedMarkPropertyElementTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public abstract class SurfacingMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Name()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SurfacingMarkPropertyElementTypes", "Name", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Material()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SurfacingMarkPropertyElementTypes", "Material", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Class()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SurfacingMarkPropertyElementTypes", "Class", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Code()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SurfacingMarkPropertyElementTypes", "Code", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SurfaceTreatmentName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SurfacingMarkPropertyElementTypes", "SurfaceTreatmentName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}





    }

    internal static class SurfacingMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(SurfacingMarkPropertyElementTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SurfacingMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SurfacingMarkPropertyElementTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public abstract class ChamferMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Name()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ChamferMarkPropertyElementTypes", "Name", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Length()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ChamferMarkPropertyElementTypes", "Length", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DX()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ChamferMarkPropertyElementTypes", "DX", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DY()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ChamferMarkPropertyElementTypes", "DY", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}





    }

    internal static class ChamferMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(ChamferMarkPropertyElementTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ChamferMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ChamferMarkPropertyElementTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public abstract class ConnectionMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Code()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes", "Code", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Name()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes", "Name", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DSTVCode()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes", "DSTVCode", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType ConnectionNumber()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes", "ConnectionNumber", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType RunningNumber()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes", "RunningNumber", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Group()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes", "Group", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType ConnectionError()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes", "ConnectionError", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}





    }

    internal static class ConnectionMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(ConnectionMarkPropertyElementTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ConnectionMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ConnectionMarkPropertyElementTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public abstract class DetailMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DetailName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailMarkPropertyElementTypes", "DetailName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailMarkPropertyElementTypes", "SourceDrawingName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingNameWhenMoved()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailMarkPropertyElementTypes", "SourceDrawingNameWhenMoved", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}





    }

    internal static class DetailMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(DetailMarkPropertyElementTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DetailMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailMarkPropertyElementTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public abstract class SectionMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SectionName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionMarkPropertyElementTypes", "SectionName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionMarkPropertyElementTypes", "SourceDrawingName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingNameWhenMoved()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionMarkPropertyElementTypes", "SourceDrawingNameWhenMoved", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}





    }

    internal static class SectionMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(SectionMarkPropertyElementTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SectionMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionMarkPropertyElementTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public abstract class ViewLabelMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType ViewName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ViewLabelMarkPropertyElementTypes", "ViewName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Scale()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ViewLabelMarkPropertyElementTypes", "Scale", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DrawingName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ViewLabelMarkPropertyElementTypes", "DrawingName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ViewLabelMarkPropertyElementTypes", "SourceDrawingName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingNameWhenMoved()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ViewLabelMarkPropertyElementTypes", "SourceDrawingNameWhenMoved", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}





    }

    internal static class ViewLabelMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(ViewLabelMarkPropertyElementTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static ViewLabelMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType.ViewLabelMarkPropertyElementTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public abstract class DetailViewLabelMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DetailName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailViewLabelMarkPropertyElementTypes", "DetailName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Scale()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailViewLabelMarkPropertyElementTypes", "Scale", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DrawingName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailViewLabelMarkPropertyElementTypes", "DrawingName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailViewLabelMarkPropertyElementTypes", "SourceDrawingName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingNameWhenMoved()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailViewLabelMarkPropertyElementTypes", "SourceDrawingNameWhenMoved", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}





    }

    internal static class DetailViewLabelMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(DetailViewLabelMarkPropertyElementTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static DetailViewLabelMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType.DetailViewLabelMarkPropertyElementTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public abstract class SectionViewLabelMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SectionName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionViewLabelMarkPropertyElementTypes", "SectionName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Scale()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionViewLabelMarkPropertyElementTypes", "Scale", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType DrawingName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionViewLabelMarkPropertyElementTypes", "DrawingName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingName()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionViewLabelMarkPropertyElementTypes", "SourceDrawingName", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType SourceDrawingNameWhenMoved()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionViewLabelMarkPropertyElementTypes", "SourceDrawingNameWhenMoved", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}





    }

    internal static class SectionViewLabelMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(SectionViewLabelMarkPropertyElementTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static SectionViewLabelMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType.SectionViewLabelMarkPropertyElementTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }



    public abstract class PourMarkPropertyElementTypes 
    {

        

        internal dynamic teklaObject;


		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Material()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PourMarkPropertyElementTypes", "Material", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Name()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PourMarkPropertyElementTypes", "Name", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType Class()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PourMarkPropertyElementTypes", "Class", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType PourNumber()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PourMarkPropertyElementTypes", "PourNumber", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType PourType()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PourMarkPropertyElementTypes", "PourType", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}

		public static Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType PourConcreteMixture()
		{
			var parameters = new object[0];
			dynamic result = TSActivator.InvokeStaticMethod("Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PourMarkPropertyElementTypes", "PourConcreteMixture", parameters);
			return Dynamic.Tekla.Structures.Drawing.PropertyElement.PropertyElementType_.FromTSObject(result);
		}





    }

    internal static class PourMarkPropertyElementTypes_
    {
        public static dynamic GetTSObject(PourMarkPropertyElementTypes dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PourMarkPropertyElementTypes FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType.PourMarkPropertyElementTypes)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class PropertyElementType_
    {
        public static dynamic GetTSObject(PropertyElementType dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PropertyElementType FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement.PropertyElementType)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }




    }

    internal static class PropertyElement_
    {
        public static dynamic GetTSObject(PropertyElement dynObject)
        {
            return dynObject.teklaObject;
        }

        public static PropertyElement FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Drawing.PropertyElement)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
