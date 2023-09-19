/*
Novelty Yazılım Bilişim Teknolojileri Ltd. Şti. - www.noveltybilisim.com.tr
- Coder by Muhammed POLAT - Copyright (c) 2021 -

05.07.2021 - 06.09.2021 Tarihleri arasında yazılmış staj projesidir.

İletişim için: kurumsal@noveltybilisim.com.tr
https://www.muhammedpolat.com.tr/
info@muhammedpolat.com.tr
*/
using System;
using System.Windows.Forms;

namespace restoran
{
    public partial class frmLock : Form
    {
        public frmLock()
        {
            InitializeComponent();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            frmGiris frm = new frmGiris();
            frm.Show();
            this.Close();
        }
    }
}
