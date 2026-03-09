using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_solid_principles
{
    #region invalid implementation

    //public interface IOrder
    //{
    //    void AddToCart();
    //    void CCProcess();
    //}

    //public class OnlineOrder : IOrder
    //{
    //    public void AddToCart()
    //    {
    //        //Do Add to Cart
    //    }

    //    public void CCProcess()
    //    {
    //        //process through credit card
    //    }
    //}

    //public class OfflineOrder : IOrder
    //{
    //    public void AddToCart()
    //    {
    //        //Do Add to Cart
    //    }

    //    public void CCProcess()
    //    {
    //        //Not required for Cash/ offline Order
    //        throw new NotImplementedException();
    //    }
    //}


    #endregion

    #region valid implementation

    public interface IOrder
    {
        void AddToCart();
    }

    public interface IOnlineOrder
    {
        void CCProcess();
    }

    public class OnlineOrder : IOrder, IOnlineOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }

        public void CCProcess()
        {
            //process through credit card
        }
    }

    public class OfflineOrder : IOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }
    }


    #endregion
}
