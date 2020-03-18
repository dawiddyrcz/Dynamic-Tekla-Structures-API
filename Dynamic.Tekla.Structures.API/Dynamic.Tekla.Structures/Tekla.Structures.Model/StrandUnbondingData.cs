//Generated by script in project CodeGenerator
//Copyright Dawid Dyrcz 2020 see license file

namespace Dynamic.Tekla.Structures.Model
{

    public sealed class StrandUnbondingData 
    {

		public System.Int32 StrandIndex
		{
			get => strandunbondingdata.StrandIndex;
			set { strandunbondingdata.StrandIndex = value; }
		}

		public System.Double FromStart
		{
			get => strandunbondingdata.FromStart;
			set { strandunbondingdata.FromStart = value; }
		}

		public System.Double MiddleToStart
		{
			get => strandunbondingdata.MiddleToStart;
			set { strandunbondingdata.MiddleToStart = value; }
		}

		public System.Double MiddleToEnd
		{
			get => strandunbondingdata.MiddleToEnd;
			set { strandunbondingdata.MiddleToEnd = value; }
		}

		public System.Double FromEnd
		{
			get => strandunbondingdata.FromEnd;
			set { strandunbondingdata.FromEnd = value; }
		}

        

        internal dynamic strandunbondingdata;
        
        public StrandUnbondingData()
        {
            this.strandunbondingdata =  TSActivator.CreateInstance("Tekla.Structures.Model.StrandUnbondingData");
        }

        internal StrandUnbondingData(dynamic tsObject)
        {
            this.strandunbondingdata = tsObject;
        }





    }

    internal static class StrandUnbondingData_
    {
        public static dynamic GetTSObject(StrandUnbondingData dynObject)
        {
            return dynObject.strandunbondingdata;
        }

        public static StrandUnbondingData FromTSObject(dynamic tsObject)
        {
            return new StrandUnbondingData(tsObject);
        }
    }


}
    
