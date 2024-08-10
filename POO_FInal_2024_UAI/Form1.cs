using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_FInal_2024_UAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GestorAlimentacion gestorAlimentacion = new GestorAlimentacion();

        void MostrarListBox(ListBox lsb, Object pO) 
        { 
          lsb.DataSource = null;
          lsb.DataSource = pO;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbAnimales.SelectedItem = cbAnimales.Items[0];
            cbAnimalAlimento.SelectedItem = cbAnimalAlimento.Items[0];
            cbVegetacion.SelectedItem = cbVegetacion.Items[0];
        }

        private void btnAgregarAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                Animal pAnimal = null;

                

                if (cbAnimales.SelectedItem == cbAnimales.Items[0] )
                    pAnimal = new Carnivoro(cbAnimales.Items[0].ToString());
                if (cbAnimales.SelectedItem == cbAnimales.Items[1])
                    pAnimal = new Carnivoro(cbAnimales.Items[1].ToString());

                if (cbAnimales.SelectedItem == cbAnimales.Items[2])
                    pAnimal = new Herbivoro(cbAnimales.Items[2].ToString());
                if (cbAnimales.SelectedItem == cbAnimales.Items[3])
                    pAnimal = new Herbivoro(cbAnimales.Items[3].ToString());

                gestorAlimentacion.AddAnimales(pAnimal);

                MostrarListBox(lsbAnimales, gestorAlimentacion.getAnimales());

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregarAlimento_Click(object sender, EventArgs e)
        {
            try
            {
                SerVivo pSerVivo = null;

                if (rbAnimal.Checked)
                    pSerVivo = new Herbivoro(cbAnimalAlimento.SelectedItem.ToString());

                if (rbVegetacion.Checked)
                    pSerVivo = new Planta(cbVegetacion.SelectedItem.ToString());

                if (pSerVivo == null)
                    throw new Exception("Valor Incorrecto!");
                

                gestorAlimentacion.AddAlimentos(pSerVivo);

                MostrarListBox(lsbAlimentos, gestorAlimentacion.getAlimentos());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsbAlimentos.SelectedItems.Count == 0) 
                    throw new Exception("Seleccioné o Agregué un alimento!");
                if (lsbAnimales.SelectedItems.Count == 0)
                    throw new Exception("Seleccioné o Agregué un animal!");

                Animal pAnimal = lsbAnimales.SelectedItem as Animal;
                SerVivo pServivo = lsbAlimentos.SelectedItem as SerVivo;

                pAnimal.Comer(pServivo);


                if (pAnimal is Herbivoro)
                    MostrarListBox(lsbAnimalAlimentos, (pAnimal as Herbivoro).getAlimentos());
                if (pAnimal is Carnivoro)
                    MostrarListBox(lsbAnimalAlimentos, (pAnimal as Carnivoro).getAlimentos());
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lsbAnimales_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(lsbAlimentos.SelectedItems.Count > 0 && lsbAnimales.SelectedItems.Count > 0)
                {
                    Animal pAnimal = lsbAnimales.SelectedItem as Animal;

                    if (pAnimal is Herbivoro)
                        MostrarListBox(lsbAnimalAlimentos, (pAnimal as Herbivoro).getAlimentos());
                    if (pAnimal is Carnivoro)
                        MostrarListBox(lsbAnimalAlimentos, (pAnimal as Carnivoro).getAlimentos());


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
