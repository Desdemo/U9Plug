

namespace UFIDA.U9.Cust.BLT.ShipPlan.AmountBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    
    public partial class TransOutPushDeliveryTaskBP
    {
        
        private void Do_AfterDo(object bp, ref object result)
        {
            #region 获取相关强类型数据                               
                                                                     
            UFIDA.U9.InvDoc.TransferOut.TransOutPushDeliveryTaskBP strongBP = bp as UFIDA.U9.InvDoc.TransferOut.TransOutPushDeliveryTaskBP;                    
            if (strongBP == null)                                    
                return;                                              
                                                                     
            #endregion                                               

        }
        
        private void Do_BeforeDo(object bp)
        {
            #region 获取相关强类型数据                               
                                                                     
            UFIDA.U9.InvDoc.TransferOut.TransOutPushDeliveryTaskBP strongBP = bp as UFIDA.U9.InvDoc.TransferOut.TransOutPushDeliveryTaskBP;                    
            if (strongBP == null)                                    
                return;                                              
                                                                     
            #endregion                                               

        }
    }
}
