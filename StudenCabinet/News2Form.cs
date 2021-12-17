using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace StudenCabinet
{
    public partial class News2Form : MaterialForm
    {
        public News2Form()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue600, Primary.Blue400, Accent.LightBlue200, TextShade.WHITE);
        }

        private void News2Form_Load(object sender, EventArgs e)
        {

        }
    }
}
