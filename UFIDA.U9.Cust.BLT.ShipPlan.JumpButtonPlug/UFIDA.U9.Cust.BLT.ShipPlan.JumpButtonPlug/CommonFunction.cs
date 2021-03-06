

namespace UFIDA.U9.Cust.BLT.ShipPlan.JumpButtonPlug
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
    
    
    public partial class TemplateClass
    {
        
	    public class CommonFunction 
	    {                                                                                                              
	        public static void Layout(IContainer container, IUFControl ctrl, uint x, uint y)                           
	        {                                                                                                          
	            Layout(container, ctrl, x, y, 1, 1, Unit.Pixel(0), Unit.Pixel(0), true);                               
	        }                                                                                                          
	                                                                                                                   
	        public static void Layout(IContainer container, IUFControl ctrl, uint x, uint y, int width, int height)    
	        {                                                                                                          
	            Layout(container, ctrl, x, y, 1, 1, Unit.Pixel(width), Unit.Pixel(height), false);                     
	        }                                                                                                          
	                                                                                                                   
	                                                                                                                   
	        public static void Layout(IContainer container, IUFControl ctrl, uint x, uint y, int xspan, int yspan,     
	            Unit width, Unit height, bool isAutoSize)                                                              
	        {                                                                                                          
	            IGridLayout gl = container.Layout as IGridLayout;                                                      
	            if (gl == null) return;                                                                                
	            GridLayoutInfo glInfo = new GridLayoutInfo((uint)x, (uint)y, (uint)xspan, (uint)yspan, width, height); 
	            glInfo.AutoSize = isAutoSize;                                                                          
	            gl.Controls.Add((Control)ctrl, glInfo);                                                                
	                                                                                                                   
	        }                                                                                                          
	                                                                                                                   
	        public static IUFControl FindControl(IPart part,string parentControl, string control)                      
	        {                                                                                                          
	            IUFCard card = (IUFCard)part.GetUFControlByName(part.TopLevelContainer, parentControl);                
	            if (card == null)                                                                                      
	                return null;                                                                                       
	                                                                                                                   
	            foreach (IUFControl ctrl in card.Controls)                                                             
	            {                                                                                                      
	                if (ctrl.ID.Equals(control, StringComparison.OrdinalIgnoreCase))                                   
	                {                                                                                                  
	                    return ctrl;                                                                                   
	                }                                                                                                  
	            }                                                                                                      
	            return null;                                                                                           
	        }                                                                                                          
	    }                                                                                                              

    }
}
