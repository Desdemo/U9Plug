

namespace UFIDA.U9.Cust.BLT.ShipPlan.AmountBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.Business;

    public partial class ShipPushDeliveryTaskBP
    {
        
        private void Do_BeforeDo(object bp)
        {
            #region 获取相关强类型数据                               
                                                                     
            UFIDA.U9.SM.Ship.ShipPushDeliveryTaskBP strongBP = bp as UFIDA.U9.SM.Ship.ShipPushDeliveryTaskBP;                    
            if (strongBP == null)                                    
                return;                                              
                                                                     
            #endregion                                               

        }
        
        private void Do_AfterDo(object bp, ref object result)
        {
            #region 获取相关强类型数据                               
                                                                     
            UFIDA.U9.SM.Ship.ShipPushDeliveryTaskBP strongBP = bp as UFIDA.U9.SM.Ship.ShipPushDeliveryTaskBP;                    
            if (strongBP == null)                                    
                return;


            #endregion

        }
    }
}
