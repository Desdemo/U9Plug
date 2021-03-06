

namespace UFIDA.U9.Cust.BLT.ShipPlan.JumpButton2Plug
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Collections.Specialized;
    using UFSoft.UBF.UI.ControlModel;
    using UFSoft.UBF.UI.WebControlAdapter;
    using UFSoft.UBF.UI.WebControls.ClientCallBack;
    using UFSoft.UBF.UI.WebControls.Association;
    using System.Web.UI.WebControls.WebParts;
    using UFSoft.UBF.UI.IView;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using UFSoft.UBF.UI.Controls;
    using UFSoft.UBF.UI.WebControls;
    using static UFIDA.U9.Cust.BLT.ShipPlan.JumpButton2Plug.TemplateClass;

    public partial class TransferOutUIMainFormWebPart
    {
        
            #region 字段与属性                                       
                                                                     
            private UFIDA.U9.SCM.INV.TransferOutUIModel.TransferOutUIMainFormWebPart _strongPart;                           
                                                                     
            #endregion                                               

        
        private void Do_BeforeLoad(UFSoft.UBF.UI.IView.IPart part, EventArgs args)
        {
            #region 获取相关强类型数据                               
                                                                     
            _strongPart = part as UFIDA.U9.SCM.INV.TransferOutUIModel.TransferOutUIMainFormWebPart;                         
            if (_strongPart == null)                                  
                return;

            #endregion

            #region 页面扩展-加按钮
            //Card里面增加按钮
            //设置按钮在容器中的位置
            IUFCard card = (IUFCard)_strongPart.GetUFControlByName(_strongPart.TopLevelContainer, "Card0");
            IUFButton btnPRToPM = new UFWebButtonAdapter();
            btnPRToPM.Text = "运费计算";
            btnPRToPM.ID = "ComplexLogistics";
            btnPRToPM.AutoPostBack = true;
            card.Controls.Add(btnPRToPM);
            CommonFunction.Layout(card, btnPRToPM, 18, 0);   //一般为从左往右按钮个数乘以2
            #endregion
            btnPRToPM.Click += new EventHandler(btnPRToPM_Click);
        }

        private void btnPRToPM_Click(object sender, EventArgs e)
        {
            SCM.INV.TransferOutUIModel.TransferOutRecord record = (SCM.INV.TransferOutUIModel.TransferOutRecord)_strongPart.Model.TransferOut.Records[0];
            // 出货日期
            this._strongPart.CurrentSessionState["date"] = record.BusinessDate;
            if (_strongPart.Model.TransferOut_TransOutLines_TransOutSubLines.Records.Count > 0)
            {
                SCM.INV.TransferOutUIModel.TransferOut_TransOutLines_TransOutSubLinesRecord recordLine = (SCM.INV.TransferOutUIModel.TransferOut_TransOutLines_TransOutSubLinesRecord)_strongPart.Model.TransferOut_TransOutLines_TransOutSubLines.Records[0];
                // 物流商
                this._strongPart.CurrentSessionState["sup"] = recordLine.Carrier;
                this._strongPart.CurrentSessionState["sup_name"] = recordLine.Carrier_Name;
                this._strongPart.CurrentSessionState["sup_code"] = recordLine.Carrier_Code;
                // 存储地点
                this._strongPart.CurrentSessionState["wh"] = recordLine.TransInWh;  
            }
            this._strongPart.Action.CurrentPart.NavigatePage("Cust_Shipplan_ComplexListURI", null);

        }
    }
}
