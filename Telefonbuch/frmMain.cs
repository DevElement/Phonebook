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
        string sNumberType1 = "";
        string sNumberType2 = "";
        string sNumberType3 = "";
        string sNumberType4 = "";
        string sMailType1 = "";
        string sMailType2 = "";
        string sShowAsType = "NV";

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
            this.label12.Visible = false;
            this.pbDev.Visible = false;
        }

        //ComboBox "ShowAs --> Auswahl geändert".
        private void cobShowAs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cobShowAs.SelectedIndex)
            {
                case 0:
                    this.labExample.Text = "Beispiel: " + this.tbNachname.Text + ", " + this.tbVorname.Text;
                    sShowAsType = "NV";
                    break;
                case 1:
                    this.labExample.Text = "Beispiel: " + this.tbVorname.Text + " " + this.tbNachname.Text;
                    sShowAsType = "VN";
                    break;
                case 2:
                    this.labExample.Text = "Beispiel: " + this.tbNachname.Text + ", " + this.tbVorname.Text+" ("+this.tbNickname.Text+")";
                    sShowAsType = "NVS";
                    break;
                case 3:
                    this.labExample.Text = "Beispiel: " + this.tbTitel.Text + " " + this.tbNachname.Text;
                    sShowAsType = "TVN";
                    break;
                default:
                    this.labExample.Text = "Beispiel: " + this.tbNachname.Text + ", " + this.tbVorname.Text;
                    sShowAsType = "NV";
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

        // Comboboxes auswerten
        private void cBoxesChanged(object sender, EventArgs e)
        {
            ComboBox cBox = new ComboBox();
            cBox = (ComboBox)sender;

            switch (cBox.Name)
            {
                case "cobNr1":
                    if (cBox.SelectedIndex == -1)
                    {
                        sNumberType1 = "";
                    }
                    else
                    {sNumberType1 = cBox.SelectedItem.ToString(); }
                    break;
                case "cobNr2":
                    if (cBox.SelectedIndex == -1)
                    {
                        sNumberType2 = "";
                    }
                    else
                    { sNumberType2 = cBox.SelectedItem.ToString(); }
                    break;
                case "cobNr3":
                    if (cBox.SelectedIndex == -1)
                    {
                        sNumberType3 = "";
                    }
                    else
                    { sNumberType3 = cBox.SelectedItem.ToString(); }
                    break;
                case "cobNr4":
                    if (cBox.SelectedIndex == -1)
                    {
                        sNumberType4 = "";
                    }
                    else
                    { sNumberType4 = cBox.SelectedItem.ToString(); }
                    break;
                case "cobMail1":
                    if (cBox.SelectedIndex == -1)
                    {
                        sMailType1 = "";
                    }
                    else
                    { sMailType1 = cBox.SelectedItem.ToString(); }
                    break;
                case "cobMail2":
                    if (cBox.SelectedIndex == -1)
                    {
                        sMailType2 = "";
                    }
                    else
                    { sMailType2 = cBox.SelectedItem.ToString(); }
                    break;
            }
        }

        //Zurücksetzen der Comboboxes und der entsprechenden Felder
        private void btnDeleteKlicked(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn = (Button)sender;

            switch (btn.Name)
            {
                case "btnDelete1":
                    this.cobNr1.SelectedIndex = -1;
                    this.tbAC1.Text = "";
                    this.tbCC1.Text = "49";
                    this.tbNumber1.Text = "";
                    break;
                case "btnDelete2":
                    this.cobNr2.SelectedIndex = -1;
                    this.tbAC2.Text = "";
                    this.tbCC2.Text = "49";
                    this.tbNumber2.Text = "";
                    break;
                case "btnDelete3":
                    this.cobNr3.SelectedIndex = -1;
                    this.tbAC3.Text = "";
                    this.tbCC3.Text = "49";
                    this.tbNumber3.Text = "";
                    break;
                case "btnDelete4":
                    this.cobNr4.SelectedIndex = -1;
                    this.tbAC4.Text = "";
                    this.tbCC4.Text = "49";
                    this.tbNumber4.Text = "";
                    break;
                case "btnDelete5":
                    this.cobMail1.SelectedIndex = -1;
                    this.tbMail1.Text = "";
                    break;
                case "btnDelete6":
                    this.cobMail2.SelectedIndex = -1;
                    this.tbMail2.Text = "";
                    break;
            }
        }

        private void pbDev_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.develement.de");
        }

        private void label12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.develement.de");
        }
    }
}