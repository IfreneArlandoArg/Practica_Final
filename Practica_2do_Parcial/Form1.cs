using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2do_Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Guarderia guarderia = new Guarderia();

        
        void MostrarListBox(ListBox lsb, object pO) 
        {
          lsb.DataSource = null;
          lsb.DataSource = pO;

        }
        void SinDarsenasDisponibles_Handler(object sender, EventArgs e) 
        {
            MessageBox.Show("Sin darsenas disponibles por el momento","Darsenas",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                guarderia.SinDarsenasDisponibles += SinDarsenasDisponibles_Handler;

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }    
        }

        private void btnAltaDarsena_Click(object sender, EventArgs e)
        {
            try
            {
                bool ValorNumerico = Int32.TryParse(txtNumDarsena.Text, out int val);
                if (!ValorNumerico)
                    throw new Exception($"Numero darse \"{txtNumDarsena.Text}\" tiene qué ser un valor numerico.");

                guarderia.AgregarDarsena(new Darsena(val));

                MostrarListBox(lsbDarsenas, guarderia.ObtenerListaDarsenasDisponibles());

                txtNumDarsena.Text = string.Empty;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnOrdenarDarsenas_Click(object sender, EventArgs e)
        {
            try
            {
                if(guarderia.ObtenerListaDarsenasDisponibles().Count == 0)
                    throw new Exception("No hay Darsenas disponibles para Ordenar.");
                   
                    guarderia.ordenarPorNumero();
                    MostrarListBox(lsbDarsenas, guarderia.ObtenerListaDarsenasDisponibles());
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAltaEmbarcacion_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNombreEmbarc.Text == string.Empty || txtColorEmbarcacion.Text == string.Empty)
                    throw new Exception("¡Aségurese de llenar todos los campos necesarios!");

                bool PotenciaNumerico = double.TryParse(txtPotenciaMotorEmbarcacion.Text, out double PotenciaMotor);
                if (!PotenciaNumerico)
                    throw new Exception($"Potencia Motor : {txtPotenciaMotorEmbarcacion.Text}, tiene qué ser un valor númerico.");

                bool CostoNumerico = double.TryParse(txtCostoEmbarcacion.Text, out double Costo );
                if (!CostoNumerico)
                    throw new Exception($"Costo : {txtCostoEmbarcacion.Text}, tiene qué ser un valor númerico. ");

                Embarcacion tempEmbarcacion = new Lancha(txtNombreEmbarc.Text,txtColorEmbarcacion.Text, PotenciaMotor, Costo);

                if (rbVelero.Checked)
                {
                    tempEmbarcacion = new Velero(txtNombreEmbarc.Text, txtColorEmbarcacion.Text, PotenciaMotor, Costo);
                    tempEmbarcacion.CalcularCosto();
                }

                if (rbCrucero.Checked)
                {
                    tempEmbarcacion = new Crucero(txtNombreEmbarc.Text, txtColorEmbarcacion.Text, PotenciaMotor, Costo);
                    tempEmbarcacion.CalcularCosto();
                }

                guarderia.AgregarEmbarcacion(tempEmbarcacion);

                MostrarListBox(lsbEmbarcaciones, guarderia.ObtenerListaEmbarcaciones());

                txtNombreEmbarc.Text = string.Empty;
                txtColorEmbarcacion.Text = string.Empty;
                txtPotenciaMotorEmbarcacion.Text= string.Empty;
                txtCostoEmbarcacion.Text = string.Empty ;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnOrdenarEmbarcaciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (guarderia.ObtenerListaEmbarcaciones().Count == 0)
                    throw new Exception("No hay embarcaciones disponibles para Ordenar.");

                guarderia.ordenarPorNombre();
                MostrarListBox(lsbEmbarcaciones, guarderia.ObtenerListaEmbarcaciones());

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnInstrucciones_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccioné Embarcaión y asigné (Seleccioné) una darsena","¡Instrucciones!");
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            try
            {
                if(guarderia.ObtenerListaDarsenasDisponibles().Count == 0)
                    guarderia.OnSinDarsenasDisponibles();

                if (guarderia.ObtenerListaEmbarcaciones().Count == 0)
                    throw new Exception("¡Sín embarcaciones registrados!");

                if (lsbDarsenas.SelectedItems.Count == 0)
                    throw new Exception("Seleccioné una darsena...");

                if (lsbEmbarcaciones.SelectedItems.Count == 0)
                    throw new Exception("Seleccioné una embarcación...");


                Embarcacion tempEmbarcacion = lsbEmbarcaciones.SelectedItem as Embarcacion;
                Darsena tempDarsena = lsbDarsenas.SelectedItem as Darsena;

                guarderia.AgregarAlquiler(new Alquiler(tempDarsena, tempEmbarcacion));

                MostrarListBox(lsbAlquileres, guarderia.ObtenerListaAlquileres());
                MostrarListBox(lsbDarsenas, guarderia.ObtenerListaDarsenasDisponibles());
                MostrarListBox(lsbEmbarcaciones, guarderia.ObtenerListaEmbarcaciones());


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (guarderia.ObtenerListaEmbarcaciones().Count == 0)
                    throw new Exception("¡Sín embarcaciones registrados!");

                if (lsbEmbarcaciones.SelectedItems.Count == 0)
                    throw new Exception("Seleccioné una embarcación...");

                if (txtNombreEmbarc.Text == string.Empty || txtColorEmbarcacion.Text == string.Empty)
                    throw new Exception("¡Aségurese de llenar todos los campos necesarios!");

                bool PotenciaNumerico = double.TryParse(txtPotenciaMotorEmbarcacion.Text, out double PotenciaMotor);
                if (!PotenciaNumerico)
                    throw new Exception($"Potencia Motor : {txtPotenciaMotorEmbarcacion.Text}, tiene qué ser un valor númerico.");

                bool CostoNumerico = double.TryParse(txtCostoEmbarcacion.Text, out double Costo);
                if (!CostoNumerico)
                    throw new Exception($"Costo : {txtCostoEmbarcacion.Text}, tiene qué ser un valor númerico. ");

                Embarcacion tempEmbarcacion = lsbEmbarcaciones.SelectedItem as Embarcacion;

                guarderia.RemoveEmbarcacion(tempEmbarcacion);

                if (rbLancha.Checked)
                    tempEmbarcacion = new Lancha(txtNombreEmbarc.Text, txtColorEmbarcacion.Text, PotenciaMotor, Costo);

                if (rbVelero.Checked)
                {
                    tempEmbarcacion = new Velero(txtNombreEmbarc.Text, txtColorEmbarcacion.Text, PotenciaMotor, Costo);
                    tempEmbarcacion.CalcularCosto();
                }

                if (rbCrucero.Checked)
                {
                    tempEmbarcacion = new Crucero(txtNombreEmbarc.Text, txtColorEmbarcacion.Text, PotenciaMotor, Costo);
                    tempEmbarcacion.CalcularCosto();
                }

                guarderia.AgregarEmbarcacion(tempEmbarcacion);

                MostrarListBox(lsbEmbarcaciones, guarderia.ObtenerListaEmbarcaciones());

                txtNombreEmbarc.Text = string.Empty;
                txtColorEmbarcacion.Text = string.Empty;
                txtPotenciaMotorEmbarcacion.Text = string.Empty;
                txtCostoEmbarcacion.Text = string.Empty;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
