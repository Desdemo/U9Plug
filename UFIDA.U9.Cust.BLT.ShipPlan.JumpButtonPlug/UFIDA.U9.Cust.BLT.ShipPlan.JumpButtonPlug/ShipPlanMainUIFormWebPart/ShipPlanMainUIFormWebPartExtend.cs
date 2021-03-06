

namespace UFIDA.U9.Cust.BLT.ShipPlan.JumpButtonPlug
{
    using System;
    using UFSoft.UBF.UI.ControlModel;
    using UFSoft.UBF.UI.WebControlAdapter;
    using UFSoft.UBF.UI.IView;
    using UFSoft.UBF.UI.ActionProcess;
    using static UFIDA.U9.Cust.BLT.ShipPlan.JumpButtonPlug.TemplateClass;
    using System.Web.UI.WebControls.WebParts;
    using UFSoft.UBF.UI.State;
    using UFSoft.UBF.UI.MD.Runtime;
    using UFIDA.U9.SCM.SM.ShipPlanBListUIModel;

    public partial class ShipPlanMainUIFormWebPart
    {

        #region 字段与属性                                       

        private UFIDA.U9.SCM.SM.ShipPlanUIModel.ShipPlanMainUIFormWebPart _strongPart;

        #endregion


        private void Do_BeforeLoad(IPart part, EventArgs args)
        {
            _strongPart = part as UFIDA.U9.SCM.SM.ShipPlanUIModel.ShipPlanMainUIFormWebPart;
            if (_strongPart == null)
                return;

            #region 页面扩展-加按钮
            //Card里面增加按钮
            //设置按钮在容器中的位置
            IUFCard card = (IUFCard)_strongPart.GetUFControlByName(_strongPart.TopLevelContainer, "Card0");
            IUFButton btnPRToPM = new UFWebButtonAdapter();
            btnPRToPM.Text = "运费计算";
            btnPRToPM.ID = "ComplexLogistics";
            btnPRToPM.AutoPostBack = true;
            card.Controls.Add(btnPRToPM);
            CommonFunction.Layout(card, btnPRToPM, 16, 0);   //一般为从左往右按钮个数乘以2
            #endregion
            btnPRToPM.Click += new EventHandler(btnPRToPM_Click);
        }
        private void btnPRToPM_Click(object sender, EventArgs e)
        {
            //this._strongPart.Action.CurrentPart.NavigatePage("Cust_Shipplan_ComplexListURI", null);

            SCM.SM.ShipPlanUIModel.ShipPlanRecord record = (SCM.SM.ShipPlanUIModel.ShipPlanRecord)_strongPart.Model.ShipPlan.Records[0];
            SCM.SM.ShipPlanUIModel.ShipPlan_ShipPlanLinesRecord recordLine = (SCM.SM.ShipPlanUIModel.ShipPlan_ShipPlanLinesRecord)_strongPart.Model.ShipPlan_ShipPlanLines.Records[0];
            // 出货日期
            this._strongPart.CurrentSessionState["date"] = record.BusinessDate;
            // 物流商
            this._strongPart.CurrentSessionState["sup"] = recordLine.Supplier_Supplier;
            this._strongPart.CurrentSessionState["sup_name"] = recordLine.Supplier_Name;
            this._strongPart.CurrentSessionState["sup_code"] = recordLine.Supplier_Code;

            // 客户位置
            this._strongPart.CurrentSessionState["location"] = recordLine.ShipToSite_CustomerSite;
            this._strongPart.Action.CurrentPart.NavigatePage("Cust_Shipplan_ComplexListURI", null) ;
            
        }

    }

}
