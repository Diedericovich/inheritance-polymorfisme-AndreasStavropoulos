using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animals
{
    public partial class Form1 : Form
    {
        public Animal animal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (radBtnCat.Checked == true)
            {
                animal = new Cat(txtBoxName.Text);
            }
            else if (radBtnParrot.Checked == true)
            {
                animal = new Parrot(txtBoxName.Text);
            }
            else if (radBtnHuman.Checked == true)
            {
                animal = new Human(txtBoxName.Text);
            }

        }

        private void btnTalk_Click(object sender, EventArgs e)
        {
            string sentence = comboBox1.SelectedItem.ToString();
            MessageBox.Show(animal.Talk(sentence));
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(animal.Pet());
        }

        private void btnEat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(animal.Eat());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
              Application.Exit();
        }
    }
}
