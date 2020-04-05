/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
namespace Dynamic.Tekla.Structures.Drawing.UI
{

    public  class Picker 
    {

        

        internal dynamic teklaObject;

		internal Picker() {}
		//This constructor creates wrapper object using teklaObject. DateTime is never used but it is here to avoid conflicts with constructors with one argument
		public Picker(dynamic tsObject, System.DateTime nonConflictParameter)
		{
			this.teklaObject = tsObject;
		}

		public System.Boolean IsInteractive()
		{
			try {
			return teklaObject.IsInteractive();
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("IsInteractive()"); }
		}

		public void PickPoint(System.String prompt, out Dynamic.Tekla.Structures.Geometry3d.Point pickedPoint, out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView)
		{
			var parameters = new object[3];
			parameters[0] = prompt;
			pickedPoint = null;
			parameters[1] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(pickedPoint);
			pickedView = null;
			parameters[2] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(pickedView);
			TSActivator.InvokeMethod(teklaObject, "Tekla.Structures.Drawing.UI.Picker", "PickPoint", parameters);
			pickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(parameters[1]);
			pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(parameters[2]);
		}

		public System.Tuple<Dynamic.Tekla.Structures.Geometry3d.Point, Dynamic.Tekla.Structures.Drawing.ViewBase> PickPoint(System.String prompt)
		{
			try {
			return teklaObject.PickPoint(prompt);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PickPoint()"); }
		}

		public void PickTwoPoints(System.String firstPrompt, System.String secondPrompt, out Dynamic.Tekla.Structures.Geometry3d.Point firstPickedPoint, out Dynamic.Tekla.Structures.Geometry3d.Point secondPickedPoint, out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView)
		{
			var parameters = new object[5];
			parameters[0] = firstPrompt;
			parameters[1] = secondPrompt;
			firstPickedPoint = null;
			parameters[2] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(firstPickedPoint);
			secondPickedPoint = null;
			parameters[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(secondPickedPoint);
			pickedView = null;
			parameters[4] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(pickedView);
			TSActivator.InvokeMethod(teklaObject, "Tekla.Structures.Drawing.UI.Picker", "PickTwoPoints", parameters);
			firstPickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(parameters[2]);
			secondPickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(parameters[3]);
			pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(parameters[4]);
		}

		public void PickThreePoints(System.String firstPrompt, System.String secondPrompt, System.String thirdPrompt, out Dynamic.Tekla.Structures.Geometry3d.Point firstPickedPoint, out Dynamic.Tekla.Structures.Geometry3d.Point secondPickedPoint, out Dynamic.Tekla.Structures.Geometry3d.Point thirdPickedPoint, out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView)
		{
			var parameters = new object[7];
			parameters[0] = firstPrompt;
			parameters[1] = secondPrompt;
			parameters[2] = thirdPrompt;
			firstPickedPoint = null;
			parameters[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(firstPickedPoint);
			secondPickedPoint = null;
			parameters[4] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(secondPickedPoint);
			thirdPickedPoint = null;
			parameters[5] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(thirdPickedPoint);
			pickedView = null;
			parameters[6] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(pickedView);
			TSActivator.InvokeMethod(teklaObject, "Tekla.Structures.Drawing.UI.Picker", "PickThreePoints", parameters);
			firstPickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(parameters[3]);
			secondPickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(parameters[4]);
			thirdPickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(parameters[5]);
			pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(parameters[6]);
		}

		public void PickPoints(System.Int32 numberOfPicks, Dynamic.Tekla.Structures.Drawing.StringList prompts, out Dynamic.Tekla.Structures.Drawing.PointList pickedPoints, out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView)
		{
			var parameters = new object[4];
			parameters[0] = numberOfPicks;
			parameters[1] = Dynamic.Tekla.Structures.Drawing.StringList_.GetTSObject(prompts);
			pickedPoints = null;
			parameters[2] = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(pickedPoints);
			pickedView = null;
			parameters[3] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(pickedView);
			TSActivator.InvokeMethod(teklaObject, "Tekla.Structures.Drawing.UI.Picker", "PickPoints", parameters);
			pickedPoints = Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(parameters[2]);
			pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(parameters[3]);
		}

		public System.Tuple<Dynamic.Tekla.Structures.Drawing.PointList, Dynamic.Tekla.Structures.Drawing.ViewBase> PickPoints(System.Int32 numberOfPicks, Dynamic.Tekla.Structures.Drawing.StringList prompts)
		{
			try {
			return teklaObject.PickPoints(numberOfPicks, Dynamic.Tekla.Structures.Drawing.StringList_.GetTSObject(prompts));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PickPoints()"); }
		}

		public void PickPoints(Dynamic.Tekla.Structures.Drawing.StringList prompts, out Dynamic.Tekla.Structures.Drawing.PointList pickedPoints, out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView)
		{
			var parameters = new object[3];
			parameters[0] = Dynamic.Tekla.Structures.Drawing.StringList_.GetTSObject(prompts);
			pickedPoints = null;
			parameters[1] = Dynamic.Tekla.Structures.Drawing.PointList_.GetTSObject(pickedPoints);
			pickedView = null;
			parameters[2] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(pickedView);
			TSActivator.InvokeMethod(teklaObject, "Tekla.Structures.Drawing.UI.Picker", "PickPoints", parameters);
			pickedPoints = Dynamic.Tekla.Structures.Drawing.PointList_.FromTSObject(parameters[1]);
			pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(parameters[2]);
		}

		public System.Tuple<Dynamic.Tekla.Structures.Drawing.PointList, Dynamic.Tekla.Structures.Drawing.ViewBase> PickPoints(Dynamic.Tekla.Structures.Drawing.StringList prompts)
		{
			try {
			return teklaObject.PickPoints(Dynamic.Tekla.Structures.Drawing.StringList_.GetTSObject(prompts));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PickPoints()"); }
		}

		public void PickObject(System.String prompt, out Dynamic.Tekla.Structures.Drawing.DrawingObject pickedObject, out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView)
		{
			var parameters = new object[3];
			parameters[0] = prompt;
			pickedObject = null;
			parameters[1] = Dynamic.Tekla.Structures.Drawing.DrawingObject_.GetTSObject(pickedObject);
			pickedView = null;
			parameters[2] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(pickedView);
			TSActivator.InvokeMethod(teklaObject, "Tekla.Structures.Drawing.UI.Picker", "PickObject", parameters);
			pickedObject = Dynamic.Tekla.Structures.Drawing.DrawingObject_.FromTSObject(parameters[1]);
			pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(parameters[2]);
		}

		public System.Tuple<Dynamic.Tekla.Structures.Drawing.DrawingObject, Dynamic.Tekla.Structures.Drawing.ViewBase> PickObject(System.String prompt)
		{
			try {
			return teklaObject.PickObject(prompt);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PickObject()"); }
		}

		public void PickObject(System.String prompt, out Dynamic.Tekla.Structures.Drawing.DrawingObject pickedObject, out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView, out Dynamic.Tekla.Structures.Geometry3d.Point pickedPoint)
		{
			var parameters = new object[4];
			parameters[0] = prompt;
			pickedObject = null;
			parameters[1] = Dynamic.Tekla.Structures.Drawing.DrawingObject_.GetTSObject(pickedObject);
			pickedView = null;
			parameters[2] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(pickedView);
			pickedPoint = null;
			parameters[3] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(pickedPoint);
			TSActivator.InvokeMethod(teklaObject, "Tekla.Structures.Drawing.UI.Picker", "PickObject", parameters);
			pickedObject = Dynamic.Tekla.Structures.Drawing.DrawingObject_.FromTSObject(parameters[1]);
			pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(parameters[2]);
			pickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(parameters[3]);
		}

		public System.Tuple<Dynamic.Tekla.Structures.Drawing.DrawingObject, Dynamic.Tekla.Structures.Drawing.ViewBase, Dynamic.Tekla.Structures.Geometry3d.Point> PickObjectAndPoint(System.String prompt)
		{
			try {
			return teklaObject.PickObjectAndPoint(prompt);
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
			 { throw DynamicAPINotFoundException.CouldNotFindMethod("PickObjectAndPoint()"); }
		}

		public void PickObject(System.String prompt, System.Type[] typeFilter, out Dynamic.Tekla.Structures.Drawing.DrawingObject pickedObject, out Dynamic.Tekla.Structures.Drawing.ViewBase pickedView, out Dynamic.Tekla.Structures.Geometry3d.Point pickedPoint)
		{
			var parameters = new object[5];
			parameters[0] = prompt;
			parameters[1] = typeFilter;
			pickedObject = null;
			parameters[2] = Dynamic.Tekla.Structures.Drawing.DrawingObject_.GetTSObject(pickedObject);
			pickedView = null;
			parameters[3] = Dynamic.Tekla.Structures.Drawing.ViewBase_.GetTSObject(pickedView);
			pickedPoint = null;
			parameters[4] = Dynamic.Tekla.Structures.Geometry3d.Point_.GetTSObject(pickedPoint);
			TSActivator.InvokeMethod(teklaObject, "Tekla.Structures.Drawing.UI.Picker", "PickObject", parameters);
			pickedObject = Dynamic.Tekla.Structures.Drawing.DrawingObject_.FromTSObject(parameters[2]);
			pickedView = Dynamic.Tekla.Structures.Drawing.ViewBase_.FromTSObject(parameters[3]);
			pickedPoint = Dynamic.Tekla.Structures.Geometry3d.Point_.FromTSObject(parameters[4]);
		}





    }

    internal static class Picker_
    {
        public static dynamic GetTSObject(Picker dynObject)
        {
            if (dynObject is null) return null;
            return dynObject.teklaObject;
        }

        public static Picker FromTSObject(dynamic tsObject)
        {
            if (tsObject is null) return null;
            var typeName = "Dynamic." + tsObject.GetType().FullName;
            var type = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);
            
            var parameters = new object[2];
            parameters[0] = tsObject;
            parameters[1] = new System.DateTime();

            var dynObject = (Dynamic.Tekla.Structures.Drawing.UI.Picker)System.Activator.CreateInstance(type, parameters);
            dynObject.teklaObject = tsObject;
            return dynObject;
        }
    }

    internal static class PickerArray_
    {
        public static dynamic GetTSObject(Picker[] dynArray)
        {
            if (dynArray is null) return null;
            var list = new System.Collections.Generic.List<dynamic>();
            foreach(var dynItem in dynArray)
            {
                list.Add(Picker_.GetTSObject(dynItem));
            }
            return list.ToArray();
        }

        public static Picker[] FromTSObject(dynamic[] tsArray)
        {
            if (tsArray is null) return null;
            var list = new System.Collections.Generic.List<Picker>();
            foreach(var tsItem in tsArray)
            {
                list.Add(Picker_.FromTSObject(tsItem));
            }
            return list.ToArray();
        }
    }


}
    
