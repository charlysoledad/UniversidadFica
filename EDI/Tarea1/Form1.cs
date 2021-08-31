using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            arr_element.Enabled = false;
            addElementBtn.Enabled = false;
        }

        private Arreglo arreglo;
        private int cols = 0, ac_cols = 0;

        private void unidimBtn_Click(object sender, EventArgs e)
        {
            this.cols = Convert.ToInt32(arr_unidimensional.Text);
            arreglo = new Arreglo(this.cols);
            arr_element.Enabled = true;
            addElementBtn.Enabled = true;
            this.array_data.ColumnCount = this.cols;
            for (int i = 0; i < this.cols; i++)
            {
                this.array_data.Columns[i].Name = i.ToString();
            }
        }

        private void addElementBtn_Click(object sender, EventArgs e)
        {
            int value = 0;
            bool next = false;
            if (arr_element.Text != "")
            {
                if(this.ac_cols < this.cols)
                {
                    value = Convert.ToInt32(arr_element.Text);
                    next = arreglo.AgregarElemento(value);
                    addElementBtn.Enabled = arr_element.Enabled = next;
                    this.array_data.Rows[0].Cells[this.ac_cols].Value = value;

                    this.ac_cols++;
                    arr_element.Text = "";
                    lessNumberLbl.Text = "Numero menor: "+arreglo.getLessValue();
                    highNumberLbl.Text = "Numero mayor: " + arreglo.getHighValue();
                }
                if (!next)
                {
                    arreglo.generateOcurrences();
                    this.occurrencesLow.Text = "Ocurrencias: " + arreglo.getLessOccurrences() + " veces.";
                    this.occurrencesHigh.Text = "Ocurrencias: " + arreglo.getHighOccurrences() + " veces.";
                }
            }
        }

        private int mat_rows = 0; int mat_cols = 0;
        private Arreglo mat1, mat2, matRes;

        private int mat1_act_row = 0, mat1_act_col = 0;
        private int mat2_act_row = 0, mat2_act_col = 0;

        private void restarBtn_Click(object sender, EventArgs e)
        {
            matRes.ResetArray();
            for (int i = 0; i < this.mat_rows; i++)
            {
                for (int j = 0; j < this.mat_cols; j++)
                {
                    bool next = matRes.AgregarElemento(mat1.ObtenerElemento(i, j) - mat2.ObtenerElemento(i, j));
                    this.matResult.Rows[i].Cells[j].Value = matRes.ObtenerElemento(i, j);
                }
            }
        }

        private void sumarBtn_Click(object sender, EventArgs e)
        {
            matRes.ResetArray();
            for (int i = 0; i < this.mat_rows; i++)
            {
                for (int j = 0; j < this.mat_cols; j++)
                {
                    bool next = matRes.AgregarElemento(mat1.ObtenerElemento(i, j) + mat2.ObtenerElemento(i, j));
                    this.matResult.Rows[i].Cells[j].Value = matRes.ObtenerElemento(i,j);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = false;
            this.panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = false;
            this.panel2.Visible = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = this.panel2.Visible = false;
            this.panel3.Visible = true;
        }

        private void addMb_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(this.valueB.Text);
            bool next = mat2.AgregarElemento(value);

            this.matriz2.Rows[this.mat2_act_row].Cells[this.mat2_act_col].Value = value;
            this.mat2_act_col++;
            if (this.mat2_act_col == this.mat_cols)
            {
                this.mat2_act_row++;
                this.mat2_act_col = 0;
            }
            this.valueB.Text = "";
            if (!next)
            {
                this.addMb.Enabled = false;
                this.valueB.Enabled = false;
            }
        }

        private void addMa_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(this.valueA.Text);
            bool next = mat1.AgregarElemento(value);
            
            this.matriz1.Rows[this.mat1_act_row].Cells[this.mat1_act_col].Value = value;
            this.mat1_act_col++;
            if (this.mat1_act_col == this.mat_cols)
            {
                this.mat1_act_row++;
                this.mat1_act_col = 0;
            }
            this.valueA.Text = "";
            if(!next)
            {
                this.addMa.Enabled = false;
                this.valueA.Enabled = false;
            }

        }

        private void defineDims_Click(object sender, EventArgs e)
        {
            this.mat_rows = this.mat_cols = Convert.ToInt32(matDims.Text);
            
            this.mat1 = new Arreglo(this.mat_rows, this.mat_cols);
            this.mat2 = new Arreglo(this.mat_rows, this.mat_cols);
            this.matRes = new Arreglo(this.mat_rows, this.mat_cols);

            this.mat1_act_row = this.mat1_act_col = this.mat2_act_row = this.mat2_act_col = 0;

            this.matriz1.RowCount = this.matriz2.RowCount =
              this.matriz1.ColumnCount = this.matriz2.ColumnCount =
                this.matResult.RowCount = this.matResult.ColumnCount = this.mat_rows;

            this.matriz1.ColumnHeadersVisible = 
              this.matriz2.ColumnHeadersVisible = 
                this.matResult.ColumnHeadersVisible = false;

            for(int i = 0; i < this.mat_rows; i++)
            {
                this.matriz1.Columns[i].Width = this.matriz2.Columns[i].Width = this.matResult.Columns[i].Width = 20;
                for (int j = 0; j < this.mat_cols; j++)
                {
                    this.matriz1.Rows[i].Cells[j].Value =
                      this.matriz2.Rows[i].Cells[j].Value =
                        this.matResult.Rows[i].Cells[j].Value = 0;
                }
            }
            this.valueA.Enabled = this.valueB.Enabled =
                this.addMa.Enabled = this.addMb.Enabled = true;
        }

        private void text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

    }
}
