using PSI.Common;
using PSI.Common.Encrypt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T_S.BLL;
using T_S.MODEL.VModel;
using T_S.WIN_UI.MODEL;

namespace T_S.WIN_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Txt_Name.Clear();
            Txt_Psw.Clear();
            skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\MidsummerColor1.ssk";  //皮肤文件以 .ssk结尾
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            string Name = Txt_Name.Text.Trim();
            string Psw = Txt_Psw.Text.Trim();
            if (string.IsNullOrEmpty(Name))
            {
                MsgBoxHelper.MsgErrorShow("账号为空请确认后再试");
                Txt_Name.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Psw))
            {
                MsgBoxHelper.MsgErrorShow("密码为空请确认后再试");
                Txt_Psw.Focus();
                return;
            }
           string enPSW= MD5Encrypt.Encrypt(Psw);
            LoginBLL login=new LoginBLL();
            List<View_StndentRole> StuList = login.Login(Name, enPSW);
            if (StuList==null||StuList.Count==0)
            {
                MsgBoxHelper.MsgErrorShow("账号或密码错误");
                return;
            }
            else
            {
               
                MainIndex index=new MainIndex();
                index.Tag = new LoginModel()
                {
                    StuList = StuList,
                    LoginForm1 = this
                };
                index.Show();
                this.Hide();

            }
        }
    }
}
