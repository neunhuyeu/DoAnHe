using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms.Layout;
using DevExpress.XtraEditors;
using System.Drawing;
namespace AddTab
{
    public class TabAdd
    {   
        // Sử dụng 4 đối số truyền vào cho hàm này gồm có:
        //1> DevExpress.XtraTab.XtraTabControl XtraTabCha : Tạm gọi là Tab Cha vì XtraTabControl này để mình quăng tabcon vào
        //2> string icon : Khi add Tab con vào Tab cha thì đối số này để quy định icon hình cho tabCon(XtraTabpage)
        //3> string TabNameAdd : Khi add tab con vào thì đối số này quy định tên của Tabcon vừa Add vào đó.
        //4> System.Windows.Forms.UserControl UserControl: Cái này dùng để Add cái UserControl do ta tạo vào Tabcon
        public void AddTab(DevExpress.XtraTab.XtraTabControl XtraTabCha, string icon, string TabNameAdd, System.Windows.Forms.UserControl UserControl)
        {
            // Khởi tạo 1 Tab Con (XtraTabPage) 
            DevExpress.XtraTab.XtraTabPage TAbAdd = new DevExpress.XtraTab.XtraTabPage();
            // Đặt đại cái tên cho nó là TestTab 
            TAbAdd.Name = "TestTab";
            // Tên của nó là đối số như đã nói ở trên
            TAbAdd.Text = TabNameAdd;
            // Add đối số UserControl vào Tab con vừa khởi tạo ở trên
            TAbAdd.Controls.Add(UserControl);
            // Dock cho nó tràn hết TAb con đó
            UserControl.Dock = DockStyle.Fill;
            try
            {
                // Icon của Tab con khi add vào Tab cha sẽ được quy định ở đây(^^Ở đây là k sử dụng Icon^^)
                TAbAdd.Image = System.Drawing.Bitmap.FromFile(System.Windows.Forms.Application.StartupPath.ToString() + @"\Icons\" + icon);

            }
            catch (Exception ex)
            {
            }
            // Quăng nó lên TAb Cha 
            XtraTabCha.TabPages.Add(TAbAdd);
        }
    }
}