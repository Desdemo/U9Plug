

namespace UFIDA.U9.Cust.BLT.ShipPlan.AmountBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    
    public partial class TransOutPushDeliveryTaskBP : UFSoft.UBF.Service.BPSVExtendBase
    {
        
        public override void AfterDo(object bp, ref object result)
        {
            this.Do_AfterDo(bp, ref result);
           

        }
        
        public override void BeforeDo(object bp)
        {
            this.Do_BeforeDo(bp);


        }
    }
}
