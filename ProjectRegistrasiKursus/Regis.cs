using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRegistrasiKursus
{
    public partial class Regis : Form
    {
        String bahasaPemrograman;
        String hariKursus;
        List<String> skill = new List<string>();
        public Regis()
        {
            InitializeComponent();
            bahasaPemrograman = "";
            hariKursus = "";
        }

        private void comboBoxBahasaPemrograman_SelectedValueChanged(object sender, EventArgs e)
        {
            bahasaPemrograman = comboBoxBahasaPemrograman.SelectedItem.ToString();
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            //menampilkan hasil isian form ke richtextbox
            richTextBoxHasil.AppendText("Anda sudah melakukan registrasi dengan rincian sebagai berikut:\n");
            richTextBoxHasil.AppendText("Bahasa Pemrograman :" + bahasaPemrograman + "\n");
            richTextBoxHasil.AppendText("Hari Kursus :" + hariKursus+"\n");
            richTextBoxHasil.AppendText("Pilihan Skill:\n");
            foreach (String valSkill in skill)
            {
                richTextBoxHasil.AppendText(valSkill.ToString()+"\n");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonHari1_Click(object sender, EventArgs e)
        {
            hariKursus = radioButtonHari1.Text;
        }

        private void radioButtonHari2_CheckedChanged(object sender, EventArgs e)
        {
            hariKursus = radioButtonHari2.Text;
        }

        private void radioButtonHari3_CheckedChanged(object sender, EventArgs e)
        {
            hariKursus = radioButtonHari3.Text;
        }

        private void checkBoxWeb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWeb.Checked)
            {
                //tambahkan skill web pada list skill
                skill.Add(checkBoxWeb.Text);
            }
            else
            {
                //menghapus skill web pada list skill
                skill.Remove(checkBoxWeb.Text);
            }
        }

        private void checkBoxMobile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMobile.Checked)
            {
                skill.Add(checkBoxMobile.Text);
            }
            else
            {
                skill.Remove(checkBoxMobile.Text);
            }
        }

        private void checkBoxDesktop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDesktop.Checked)
            {
                skill.Add(checkBoxDesktop.Text);
            }
            else
            {
                skill.Remove(checkBoxDesktop.Text);
            }
        }
    }
}
