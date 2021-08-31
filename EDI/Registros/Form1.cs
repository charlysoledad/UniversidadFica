using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DateTime date = DateTime.Now;

        private Dictionary<String, int> spaceAvailable = new Dictionary<String, int>();
        public Form1()
        {
            InitializeComponent();
            String a_date = date.ToString("MM-dd-yyyy");
            this.spaceAvailable.Add(a_date, 20);
            this.lblSpaces.Text = "Lugares disponibles: " + spaceAvailable[a_date];
            ShowFilteredRows();
            CalculateProfits();
        }

        List<Mascota> mascotas = new List<Mascota>();

        private void digitControl(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            String a_date = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            if (spaceAvailable[a_date] > 0)
            {
                int cmbSelected = this.cmbService.SelectedIndex;
                Service service = Service.None;
                switch (cmbSelected)
                {
                    case -1: service = Service.None; break;
                    case 0: service = Service.Bath; break;
                    case 1: service = Service.HairCut; break;
                    case 2: service = Service.Vaccine; break;
                    default: service = Service.None; break;
                }
                Mascota mascota = new Mascota(
                    this.txtName.Text, this.txtRace.Text, Convert.ToInt32(this.txtAge.Text), service);

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);
                row.Cells[0].Value = mascota.name;
                row.Cells[1].Value = mascota.race;
                row.Cells[2].Value = mascota.age;
                row.Cells[3].Value = this.cmbService.SelectedItem;
                row.Cells[4].Value = a_date;

                this.dataGridView1.Rows.Insert(0,row);
                spaceAvailable[a_date]--;
                this.lblSpaces.Text = "Lugares disponibles: " + spaceAvailable[a_date];
                CalculateProfits();
            }
            else
            {
                MessageBox.Show("Lo sentimos, ya alcanzó el máximo de registros posibles.");
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            date = this.dateTimePicker1.Value;
            String a_date = date.ToString("MM-dd-yyy");
            try
            {
                spaceAvailable.Add(a_date, 20);
            }
            catch (ArgumentException)
            {
                
            }
            ShowFilteredRows();
            this.lblSpaces.Text = "Lugares disponibles: " + spaceAvailable[a_date];
            CalculateProfits();
        }

        void ShowFilteredRows()
        {
            String date = this.dateTimePicker1.Value.ToString("MM-dd-yyyy");
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if(row.Cells[4].Value.ToString() == date)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach(DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                try
                {
                    spaceAvailable[row.Cells[4].Value.ToString()]++;
                    this.lblSpaces.Text = "Lugares disponibles: " + spaceAvailable[row.Cells[4].Value.ToString()];
                    this.dataGridView1.Rows.RemoveAt(row.Index);
                    CalculateProfits();
                }
                catch (ArgumentException)
                {

                }
            }
        }

        void CalculateProfits()
        {
            int profits = 0, baths = 0, hairs = 0, vacc = 0 ;
            String date = this.dateTimePicker1.Value.ToString("MM-dd-yyyy");
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if(row.Cells[4].Value.ToString() == date)
                {
                    switch (row.Cells[3].Value)
                    {
                        case "Baño": profits += 120; baths++; break;
                        case "Corte de pelo": profits += 100; hairs++; break;
                        case "Vacuna": profits += 200; vacc++; break;
                        default: break;
                    }
                }
            }
            this.lblBaths.Text = "Baños: " + baths;
            this.lblHair.Text = "Cortes de pelo: " + hairs;
            this.lblVac.Text = "Vacunas: " + vacc;
            this.lblProfits.Text = "Ganancias del día: $"+profits;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/charlysoledad/UniversidadFica/tree/main/EDI/Registros");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible acceder al enlace.");
            }
        }
    }
}
