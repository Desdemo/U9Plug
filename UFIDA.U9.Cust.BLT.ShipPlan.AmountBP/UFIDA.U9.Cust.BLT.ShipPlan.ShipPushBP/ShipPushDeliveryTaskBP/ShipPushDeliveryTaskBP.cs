

namespace UFIDA.U9.Cust.BLT.ShipPlan.AmountBP
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UFSoft.UBF.Business;

    public partial class ShipPushDeliveryTaskBP : UFSoft.UBF.Service.BPSVExtendBase
    {
        
        public override void BeforeDo(object bp)
        {
            this.Do_BeforeDo(bp);
        }
        
        public override void AfterDo(object bp, ref object result)
        {
            this.Do_AfterDo(bp, ref result);
        }
    }
}
