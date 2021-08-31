using System.Windows.Forms;
using System.ComponentModel;
namespace Clase1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Arreglos";

            this.agregar_lista = new Button();
            this.agregar_lista.Name ="agregar_lista";
            this.agregar_lista.Text ="Agregar elemento";
            this.agregar_lista.Location = new System.Drawing.Point(20,60);
            this.agregar_lista.Size = new System.Drawing.Size(120,30);
            this.agregar_lista.TabIndex = 10;

            this.tam_definer = new Button();
            this.tam_definer.Name ="tam_definer";
            this.tam_definer.Text ="Definir tamaño";
            this.tam_definer.Location = new System.Drawing.Point(120,20);
            this.tam_definer.Size = new System.Drawing.Size(120,30);
            this.tam_definer.TabIndex = 10;

            this.col_definer= new TextBox();
            this.col_definer.Name ="col_definer";
            this.col_definer.Location = new System.Drawing.Point(20,20);
            this.col_definer.Size = new System.Drawing.Size(120,30);
            this.col_definer.TabIndex = 10;
            
            this.row_definer= new TextBox();
            this.row_definer.Name ="row_definer";
            this.row_definer.Location = new System.Drawing.Point(20,20);
            this.row_definer.Size = new System.Drawing.Size(120,30);
            this.row_definer.TabIndex = 10;

            this.Controls.Add(agregar_lista);
            this.Controls.Add(tam_definer);
            this.Controls.Add(col_definer);
        }
        private Button agregar_lista;
        private Button tam_definer;
        private TextBox col_definer;
        private TextBox row_definer;

        #endregion
    }
}

