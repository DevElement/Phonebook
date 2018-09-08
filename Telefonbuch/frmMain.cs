using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefonbuch
{
    public partial class frmMain : Form
    {
        Image iContactImg;

        public frmMain()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }       
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        //Button "Neu" wurde gedrückt.
        private void btnNew_Click(object sender, EventArgs e)
        {
            this.tabContactInfos.Visible = true;
            this.btnPreview.Visible = true;
            this.btnSave.Visible = true;
            this.labChoise.Visible = false;
        }

        //ComboBox "ShowAs --> Auswahl geändert".
        private void cobShowAs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cobShowAs.SelectedIndex)
            {
                case 0:
                    this.labExample.Text = "Beispiel: " + this.tbNachname.Text + ", " + this.tbVorname.Text;
                    break;
                case 1:
                    this.labExample.Text = "Beispiel: " + this.tbVorname.Text + " " + this.tbNachname.Text;
                    break;
                case 2:
                    this.labExample.Text = "Beispiel: " + this.tbNachname.Text + ", " + this.tbVorname.Text+" ("+this.tbNickname.Text+")";
                    break;
                case 3:
                    this.labExample.Text = "Beispiel: " + this.tbTitel.Text + " " + this.tbNachname.Text;
                    break;
                default:
                    this.labExample.Text = "Beispiel: " + this.tbNachname.Text + ", " + this.tbVorname.Text;
                    break;
            }
        }

        //Bild in PictureBox laden
        private void btnOpenPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog OF = new OpenFileDialog();
            OF.Title = "Bitte Bild auswählen...";
            OF.Multiselect = false;
            OF.Filter = "Bilder|*.png;*.bmp;*.jpg;*.gif|PNG-Bilder|*.png|BMP-Bilder|*.bmp|JPG-Bilder|*,jpg";
            OF.FilterIndex = 0;
            DialogResult DR = OF.ShowDialog();

            if(DR == DialogResult.OK)
            {
                iContactImg = Image.FromFile(OF.FileName);
                this.pbContact.Image = iContactImg;
            }
            else
            {
                this.pbContact.Image = Telefonbuch.Properties.Resources.g12_photos2_97346;
            }
        }
    }
}