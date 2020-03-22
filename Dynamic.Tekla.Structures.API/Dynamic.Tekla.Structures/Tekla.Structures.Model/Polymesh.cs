/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Model
{

    public  class Polymesh 
    {

		public Dynamic.Tekla.Structures.Geometry3d.FacetedBrep Brep
		{
			get => Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.FromTSObject(teklaObject.Brep);
			set { teklaObject.Brep = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.GetTSObject(value); }
		}

        

        internal dynamic teklaObject;

		public Polymesh()
		{
			this.teklaObject = TSActivator.CreateInstance("Tekla.Structures.Model.Polymesh");
		}

		public static System.String Fingerprint(Dynamic.Tekla.Structures.Geometry3d.FacetedBrep brep)
		{
			var parameters = new object[1];
			parameters[0] = Dynamic.Tekla.Structures.Geometry3d.FacetedBrep_.GetTSObject(brep);
			return (System.String) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Polymesh", "Fingerprint", parameters);
		}

		public static System.Boolean CompareFingerprints(System.String fingerprint1, System.String fingerprint2)
		{
			var parameters = new object[2];
			parameters[0] = fingerprint1;
			parameters[1] = fingerprint2;
			return (System.Boolean) TSActivator.InvokeStaticMethod("Tekla.Structures.Model.Polymesh", "CompareFingerprints", parameters);
		}




    public enum PolymeshHealthCheckEnum
    {
			PolymeshOk,
			NumOfVerticesOuterloop,
			NumOfVerticesInnerloop,
			VertexArrayOuterloop,
			VertexArrayInnerloop,
			InnerloopNotInsideOuterloop,
			VertexArrayForListOfEdges,
			NonPlanarOuterloop,
			NonPlanarInnerloop,
			SelfIntersectingOuterloop,
			SelfIntersectingInnerloop,
			LoopNormalsInvalid,
			FaceEdgesInvalidOrientation,
			FaceEdgesPartlyInvalidOrientation,
			MultishellPolymesh,
			NumberOfFaces,
			VertexArrayUniqueness,
			VertexDuplicatesOnPolygon,
			VertexCollinearOnPolygon,
			NonManifoldEdges,
			UnusedVertices,
			MultishellPolymeshByGeometry,
			PolymeshLevelError,
			PolymeshUndefined        
    }

    internal static class PolymeshHealthCheckEnum_
    {
        public static dynamic GetTSObject(PolymeshHealthCheckEnum dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Polymesh.PolymeshHealthCheckEnum").GetType();

            switch (dynEnum)
            {
				case PolymeshHealthCheckEnum.PolymeshOk:
					return System.Enum.Parse(tsType, "PolymeshOk");
				case PolymeshHealthCheckEnum.NumOfVerticesOuterloop:
					return System.Enum.Parse(tsType, "NumOfVerticesOuterloop");
				case PolymeshHealthCheckEnum.NumOfVerticesInnerloop:
					return System.Enum.Parse(tsType, "NumOfVerticesInnerloop");
				case PolymeshHealthCheckEnum.VertexArrayOuterloop:
					return System.Enum.Parse(tsType, "VertexArrayOuterloop");
				case PolymeshHealthCheckEnum.VertexArrayInnerloop:
					return System.Enum.Parse(tsType, "VertexArrayInnerloop");
				case PolymeshHealthCheckEnum.InnerloopNotInsideOuterloop:
					return System.Enum.Parse(tsType, "InnerloopNotInsideOuterloop");
				case PolymeshHealthCheckEnum.VertexArrayForListOfEdges:
					return System.Enum.Parse(tsType, "VertexArrayForListOfEdges");
				case PolymeshHealthCheckEnum.NonPlanarOuterloop:
					return System.Enum.Parse(tsType, "NonPlanarOuterloop");
				case PolymeshHealthCheckEnum.NonPlanarInnerloop:
					return System.Enum.Parse(tsType, "NonPlanarInnerloop");
				case PolymeshHealthCheckEnum.SelfIntersectingOuterloop:
					return System.Enum.Parse(tsType, "SelfIntersectingOuterloop");
				case PolymeshHealthCheckEnum.SelfIntersectingInnerloop:
					return System.Enum.Parse(tsType, "SelfIntersectingInnerloop");
				case PolymeshHealthCheckEnum.LoopNormalsInvalid:
					return System.Enum.Parse(tsType, "LoopNormalsInvalid");
				case PolymeshHealthCheckEnum.FaceEdgesInvalidOrientation:
					return System.Enum.Parse(tsType, "FaceEdgesInvalidOrientation");
				case PolymeshHealthCheckEnum.FaceEdgesPartlyInvalidOrientation:
					return System.Enum.Parse(tsType, "FaceEdgesPartlyInvalidOrientation");
				case PolymeshHealthCheckEnum.MultishellPolymesh:
					return System.Enum.Parse(tsType, "MultishellPolymesh");
				case PolymeshHealthCheckEnum.NumberOfFaces:
					return System.Enum.Parse(tsType, "NumberOfFaces");
				case PolymeshHealthCheckEnum.VertexArrayUniqueness:
					return System.Enum.Parse(tsType, "VertexArrayUniqueness");
				case PolymeshHealthCheckEnum.VertexDuplicatesOnPolygon:
					return System.Enum.Parse(tsType, "VertexDuplicatesOnPolygon");
				case PolymeshHealthCheckEnum.VertexCollinearOnPolygon:
					return System.Enum.Parse(tsType, "VertexCollinearOnPolygon");
				case PolymeshHealthCheckEnum.NonManifoldEdges:
					return System.Enum.Parse(tsType, "NonManifoldEdges");
				case PolymeshHealthCheckEnum.UnusedVertices:
					return System.Enum.Parse(tsType, "UnusedVertices");
				case PolymeshHealthCheckEnum.MultishellPolymeshByGeometry:
					return System.Enum.Parse(tsType, "MultishellPolymeshByGeometry");
				case PolymeshHealthCheckEnum.PolymeshLevelError:
					return System.Enum.Parse(tsType, "PolymeshLevelError");
				case PolymeshHealthCheckEnum.PolymeshUndefined:
					return System.Enum.Parse(tsType, "PolymeshUndefined");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static PolymeshHealthCheckEnum FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("PolymeshOk", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.PolymeshOk;
			else if (tsEnumValue.Equals("NumOfVerticesOuterloop", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.NumOfVerticesOuterloop;
			else if (tsEnumValue.Equals("NumOfVerticesInnerloop", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.NumOfVerticesInnerloop;
			else if (tsEnumValue.Equals("VertexArrayOuterloop", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.VertexArrayOuterloop;
			else if (tsEnumValue.Equals("VertexArrayInnerloop", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.VertexArrayInnerloop;
			else if (tsEnumValue.Equals("InnerloopNotInsideOuterloop", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.InnerloopNotInsideOuterloop;
			else if (tsEnumValue.Equals("VertexArrayForListOfEdges", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.VertexArrayForListOfEdges;
			else if (tsEnumValue.Equals("NonPlanarOuterloop", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.NonPlanarOuterloop;
			else if (tsEnumValue.Equals("NonPlanarInnerloop", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.NonPlanarInnerloop;
			else if (tsEnumValue.Equals("SelfIntersectingOuterloop", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.SelfIntersectingOuterloop;
			else if (tsEnumValue.Equals("SelfIntersectingInnerloop", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.SelfIntersectingInnerloop;
			else if (tsEnumValue.Equals("LoopNormalsInvalid", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.LoopNormalsInvalid;
			else if (tsEnumValue.Equals("FaceEdgesInvalidOrientation", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.FaceEdgesInvalidOrientation;
			else if (tsEnumValue.Equals("FaceEdgesPartlyInvalidOrientation", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.FaceEdgesPartlyInvalidOrientation;
			else if (tsEnumValue.Equals("MultishellPolymesh", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.MultishellPolymesh;
			else if (tsEnumValue.Equals("NumberOfFaces", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.NumberOfFaces;
			else if (tsEnumValue.Equals("VertexArrayUniqueness", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.VertexArrayUniqueness;
			else if (tsEnumValue.Equals("VertexDuplicatesOnPolygon", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.VertexDuplicatesOnPolygon;
			else if (tsEnumValue.Equals("VertexCollinearOnPolygon", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.VertexCollinearOnPolygon;
			else if (tsEnumValue.Equals("NonManifoldEdges", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.NonManifoldEdges;
			else if (tsEnumValue.Equals("UnusedVertices", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.UnusedVertices;
			else if (tsEnumValue.Equals("MultishellPolymeshByGeometry", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.MultishellPolymeshByGeometry;
			else if (tsEnumValue.Equals("PolymeshLevelError", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.PolymeshLevelError;
			else if (tsEnumValue.Equals("PolymeshUndefined", System.StringComparison.InvariantCulture))
				return PolymeshHealthCheckEnum.PolymeshUndefined;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }


    public enum PolymeshCheckerFlags
    {
			None,
			VerticesOnSameEdge,
			OuterloopPlanarity,
			OuterloopSelfIntersection,
			InnerloopPlanarity,
			InnerloopSelfIntersection,
			LoopNormalValidity,
			FaceEdgeOrientation,
			Multishellness,
			InnerloopInsideOuterloop,
			All,
			VerticesOnSamePosition,
			UnusedVertices,
			LoopVertexUnique,
			NonManifoldEdges,
			NullFaces,
			MultishellnessGeometrical        
    }

    internal static class PolymeshCheckerFlags_
    {
        public static dynamic GetTSObject(PolymeshCheckerFlags dynEnum)
        {
            var tsType = TSActivator.CreateInstance("Tekla.Structures.Model.Polymesh.PolymeshCheckerFlags").GetType();

            switch (dynEnum)
            {
				case PolymeshCheckerFlags.None:
					return System.Enum.Parse(tsType, "None");
				case PolymeshCheckerFlags.VerticesOnSameEdge:
					return System.Enum.Parse(tsType, "VerticesOnSameEdge");
				case PolymeshCheckerFlags.OuterloopPlanarity:
					return System.Enum.Parse(tsType, "OuterloopPlanarity");
				case PolymeshCheckerFlags.OuterloopSelfIntersection:
					return System.Enum.Parse(tsType, "OuterloopSelfIntersection");
				case PolymeshCheckerFlags.InnerloopPlanarity:
					return System.Enum.Parse(tsType, "InnerloopPlanarity");
				case PolymeshCheckerFlags.InnerloopSelfIntersection:
					return System.Enum.Parse(tsType, "InnerloopSelfIntersection");
				case PolymeshCheckerFlags.LoopNormalValidity:
					return System.Enum.Parse(tsType, "LoopNormalValidity");
				case PolymeshCheckerFlags.FaceEdgeOrientation:
					return System.Enum.Parse(tsType, "FaceEdgeOrientation");
				case PolymeshCheckerFlags.Multishellness:
					return System.Enum.Parse(tsType, "Multishellness");
				case PolymeshCheckerFlags.InnerloopInsideOuterloop:
					return System.Enum.Parse(tsType, "InnerloopInsideOuterloop");
				case PolymeshCheckerFlags.All:
					return System.Enum.Parse(tsType, "All");
				case PolymeshCheckerFlags.VerticesOnSamePosition:
					return System.Enum.Parse(tsType, "VerticesOnSamePosition");
				case PolymeshCheckerFlags.UnusedVertices:
					return System.Enum.Parse(tsType, "UnusedVertices");
				case PolymeshCheckerFlags.LoopVertexUnique:
					return System.Enum.Parse(tsType, "LoopVertexUnique");
				case PolymeshCheckerFlags.NonManifoldEdges:
					return System.Enum.Parse(tsType, "NonManifoldEdges");
				case PolymeshCheckerFlags.NullFaces:
					return System.Enum.Parse(tsType, "NullFaces");
				case PolymeshCheckerFlags.MultishellnessGeometrical:
					return System.Enum.Parse(tsType, "MultishellnessGeometrical");

                default:
                    throw new System.NotImplementedException(dynEnum.ToString() + "- enum value is not implemented");
            }
        }
    
        public static PolymeshCheckerFlags FromTSObject(dynamic tsEnum)
        {
            string tsEnumValue = tsEnum.ToString("G", System.Globalization.CultureInfo.InvariantCulture);
            
			if (tsEnumValue.Equals("None", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.None;
			else if (tsEnumValue.Equals("VerticesOnSameEdge", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.VerticesOnSameEdge;
			else if (tsEnumValue.Equals("OuterloopPlanarity", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.OuterloopPlanarity;
			else if (tsEnumValue.Equals("OuterloopSelfIntersection", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.OuterloopSelfIntersection;
			else if (tsEnumValue.Equals("InnerloopPlanarity", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.InnerloopPlanarity;
			else if (tsEnumValue.Equals("InnerloopSelfIntersection", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.InnerloopSelfIntersection;
			else if (tsEnumValue.Equals("LoopNormalValidity", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.LoopNormalValidity;
			else if (tsEnumValue.Equals("FaceEdgeOrientation", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.FaceEdgeOrientation;
			else if (tsEnumValue.Equals("Multishellness", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.Multishellness;
			else if (tsEnumValue.Equals("InnerloopInsideOuterloop", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.InnerloopInsideOuterloop;
			else if (tsEnumValue.Equals("All", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.All;
			else if (tsEnumValue.Equals("VerticesOnSamePosition", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.VerticesOnSamePosition;
			else if (tsEnumValue.Equals("UnusedVertices", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.UnusedVertices;
			else if (tsEnumValue.Equals("LoopVertexUnique", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.LoopVertexUnique;
			else if (tsEnumValue.Equals("NonManifoldEdges", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.NonManifoldEdges;
			else if (tsEnumValue.Equals("NullFaces", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.NullFaces;
			else if (tsEnumValue.Equals("MultishellnessGeometrical", System.StringComparison.InvariantCulture))
				return PolymeshCheckerFlags.MultishellnessGeometrical;

            else 
                throw new System.NotImplementedException(tsEnumValue + "- enum value is not implemented");
            
        }
    }



    }

    internal static class Polymesh_
    {
        public static dynamic GetTSObject(Polymesh dynObject)
        {
            return dynObject.teklaObject;
        }

        public static Polymesh FromTSObject(dynamic tsObject)
        {
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            var dynObject = (Tekla.Structures.Model.Polymesh)System.Activator.CreateInstance(type);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }


}
    
