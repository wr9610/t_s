using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSI.Common;
using T_S.BLL;
using T_S.MODEL.VModel;
using T_S.WIN_UI.MODEL;
using Menu = T_S.MODEL.DModel.Menu;

namespace T_S.WIN_UI
{
    public partial class MainIndex : Form
    {
        public MainIndex()
        {
            InitializeComponent();
            /*skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\Calmness.ssk";  //皮肤文件以 .ssk结尾
            skinEngine1.SkinDialogs = false;*/
        }
        MenuBLL menuBll=new MenuBLL();
        /*private void MainIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1=new Form1();
            form1.Close();
            Application.Exit();
        }*/

        private void MainIndex_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                InitMainInfo();
            }
            
           
        }

        List<View_StndentRole> Stulist = null;
        string Name = "";
        private bool IsAdmin = false;
        private void InitMainInfo()
        {
            LoginModel loginModel=this.Tag as LoginModel;
            if (loginModel != null)
            {
                Stulist = loginModel.StuList;
                Name = Stulist[0].Name;
                ChackIsadmin();
              List<T_S.MODEL.DModel.Menu> menulList=new List<Menu>();
                if (IsAdmin)//是否是管理员
                {
                    menulList = menuBll.GetMenuList("");
                }
                else
                {
                    string RoleId = string.Join(",", Stulist.Select(s => s.R_ID));
                    menulList = menuBll.GetMenuList(RoleId);

                }
                T_S_Ment.Items.Clear();
                //创建菜单项和工具菜单
              
                TxtName.Text = Name;
                Txt_Date.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //
                AddMenuItem(menulList,null,0);

            }
            
        }

        private void AddMenuItem( List<T_S.MODEL.DModel.Menu> mList,ToolStripMenuItem pMenu,int pID)
        {
            var childList = mList.Where(m => m.ParentId == pID);
            foreach (var c in childList)
            {
                ToolStripMenuItem tool=new ToolStripMenuItem();
                tool.Name = c.M_ID.ToString();
                tool.Text = c.Menu_Name;
                //判断是否有快捷键
                //设置alt快捷键
                string skey = c.MKey.ToString();
                if (string.IsNullOrEmpty(c.MKey))
                {
                    
                    if (skey.Length>1&&skey.Substring(0,3).ToLower()=="alt")
                    {
                        tool.Text += $"(&{skey.Substring(4)})";
                        Keys k;
                        Enum.TryParse<Keys>(skey.Substring(4), out k);
                        tool.ShortcutKeys = (Keys) (Keys.Alt | k);
                    }
                }
                else if (skey.Length > 1 && skey.Substring(0, 4).ToLower() == "ctrl")
                {
                    tool.Text += $"(&{skey.Substring(5)})";
                    Keys k;
                    Enum.TryParse<Keys>(skey.Substring(5), out k);
                    tool.ShortcutKeys = (Keys)(Keys.Control | k);
                }

                //菜单关联页面
                if (!string.IsNullOrEmpty(c.MUrl))
                {
                    tool.Tag = c;
                }
                //菜单响应注册事件（没有子菜单的）
                if (mList.Where(m=>m.ParentId==c.M_ID).ToList().Count==0)
                {
                    tool.Click += Tool_Click;
                }

                if (pMenu!=null)
                {
                    pMenu.DropDownItems.Add(tool);
                }
                else
                {
                    T_S_Ment.Items.Add(tool);

                }
                //为当前菜单项添加子菜单
                AddMenuItem(mList,tool,c.M_ID);
                
            }
        }
        //菜单项的响应
        private void Tool_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi=sender as ToolStripMenuItem;
            if (mi!=null)
            {
                T_S.MODEL.DModel.Menu menu = mi.Tag as Menu;
               
                
                if (menu.MUrl!= "无")
                {
                    //获取程序集名称
                    string assName = this.GetType().Assembly.GetName().Name;
                   
                   ObjectHandle t=  Activator.CreateInstance(assName, assName + "." + menu.MUrl);
                    Form f = (Form) t.Unwrap();
                    f.Tag = Name;
                    if (menu.IsTop!=0)
                    {
                        //不为顶层
                        tcPages.AddTabFormPage(f);
                    }
                    else
                    {
                        //顶层
                        f.Show();

                    }

                }
                else
                {
                    //特殊处理
                   
                    if (menu.TMDesp==ToolMenuDesp.ExitSystem.ToString())
                    {
                        //退出界面 
                        Application.Exit();

                    }
                    else if (menu.TMDesp==ToolMenuDesp.ChangeActor.ToString())
                    {
                        //更换用户
                    }
                    else if (menu.TMDesp==ToolMenuDesp.RefreshMenu.ToString())
                    {
                        //刷新界面
                       
                    }
                     
                    
                }
            }
        }

       

        /// <summary>
        /// 判断是是管理员 权限
        /// </summary>
        /// <returns></returns>
        private void ChackIsadmin()
        {
            foreach (var s in Stulist)
            {
                if (s.R_ID==2)
                {
                    IsAdmin = true;
                }
            }
        }

        private enum ToolMenuDesp
        {
            ExitSystem=1,
            ChangeActor=2,
            RefreshMenu=3
        }

        private void MainIndex_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MsgBoxHelper.MsgBoxConfirm("提示", "是否退出？")==DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }

           
           
        }
    }
}
