using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestSalles
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panelUsers);
            listPanel.Add(panelSalles);
            listPanel.Add(panelMachines);
            listPanel.Add(panelLogiciels);
            listPanel.Add(panelReclamations);
            listPanel.Add(panelReseaux);
            listPanel[0].BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listPanel[0].BringToFront();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkSalles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listPanel[1].BringToFront();
        }

        private void linkMachines_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listPanel[2].BringToFront();
        }

        private void linkLogiciels_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listPanel[3].BringToFront();
        }

        private void linkReclamations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listPanel[4].BringToFront();
        }

        private void linkReseaux_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listPanel[5].BringToFront();
        }
    }
}
