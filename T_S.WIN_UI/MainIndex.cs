using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_S.WIN_UI
{
    public partial class MainIndex : Form
    {
        public MainIndex()
        {
            InitializeComponent();
            skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\Calmness.ssk";  //皮肤文件以 .ssk结尾
        }

        private void MainIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1=new Form1();
            form1.Close();
        }
    }
}
