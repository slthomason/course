using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_solid_principles
{

    //#region invalid implementation
    //public class GarageStation
    //{
    //    public void DoOpenGate()
    //    {
    //        //Open the gate functinality
    //    }

    //    public void PerformService(Vehicle vehicle)
    //    {
    //        //Check if garage is opened
    //        //finish the vehicle service
    //    }

    //    public void DoCloseGate()
    //    {
    //        //Close the gate functinality
    //    }
    //}

    //#endregion

    #region valid implmentatation

    public class GarageStation
    {
        IGarageUtility _garageUtil;

        public GarageStation(IGarageUtility garageUtil)
        {
            this._garageUtil = garageUtil;
        }
        public void OpenForService()
        {
            _garageUtil.OpenGate();
        }
        public void DoService()
        {
            //Check if service station is opened and then
            //finish the vehicle service
        }
        public void CloseGarage()
        {
            _garageUtil.CloseGate();
        }
    }
    public class GarageStationUtility : IGarageUtility
    {
        public void OpenGate()
        {
            //Open the Garage for service
        }

        public void CloseGate()
        {
            //Close the Garage functionlity
        }
    }

    public interface IGarageUtility
    {
        void OpenGate();
        void CloseGate();
    }

    #endregion

}
