using System.Windows.Forms;

namespace Tarea1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.highNumberLbl = new System.Windows.Forms.Label();
            this.lessNumberLbl = new System.Windows.Forms.Label();
            this.addElementBtn = new System.Windows.Forms.Button();
            this.arr_element = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.array_data = new System.Windows.Forms.DataGridView();
            this.unidimBtn = new System.Windows.Forms.Button();
            this.arr_unidimensional = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.matResult = new System.Windows.Forms.DataGridView();
            this.restarBtn = new System.Windows.Forms.Button();
            this.sumarBtn = new System.Windows.Forms.Button();
            this.addMb = new System.Windows.Forms.Button();
            this.valueB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addMa = new System.Windows.Forms.Button();
            this.valueA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.matriz2 = new System.Windows.Forms.DataGridView();
            this.matriz1 = new System.Windows.Forms.DataGridView();
            this.defineDims = new System.Windows.Forms.Button();
            this.matDims = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.occurrencesLow = new System.Windows.Forms.Label();
            this.occurrencesHigh = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.array_data)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriz1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.occurrencesHigh);
            this.panel1.Controls.Add(this.occurrencesLow);
            this.panel1.Controls.Add(this.highNumberLbl);
            this.panel1.Controls.Add(this.lessNumberLbl);
            this.panel1.Controls.Add(this.addElementBtn);
            this.panel1.Controls.Add(this.arr_element);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.array_data);
            this.panel1.Controls.Add(this.unidimBtn);
            this.panel1.Controls.Add(this.arr_unidimensional);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 450);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // highNumberLbl
            // 
            this.highNumberLbl.AutoSize = true;
            this.highNumberLbl.Location = new System.Drawing.Point(274, 353);
            this.highNumberLbl.Name = "highNumberLbl";
            this.highNumberLbl.Size = new System.Drawing.Size(100, 15);
            this.highNumberLbl.TabIndex = 10;
            this.highNumberLbl.Text = "Numero mayor: 0";
            // 
            // lessNumberLbl
            // 
            this.lessNumberLbl.AutoSize = true;
            this.lessNumberLbl.Location = new System.Drawing.Point(274, 291);
            this.lessNumberLbl.Name = "lessNumberLbl";
            this.lessNumberLbl.Size = new System.Drawing.Size(101, 15);
            this.lessNumberLbl.TabIndex = 9;
            this.lessNumberLbl.Text = "Numero menor: 0";
            // 
            // addElementBtn
            // 
            this.addElementBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addElementBtn.FlatAppearance.BorderSize = 0;
            this.addElementBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addElementBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addElementBtn.Location = new System.Drawing.Point(398, 90);
            this.addElementBtn.Name = "addElementBtn";
            this.addElementBtn.Size = new System.Drawing.Size(75, 23);
            this.addElementBtn.TabIndex = 8;
            this.addElementBtn.Text = "Agregar";
            this.addElementBtn.UseVisualStyleBackColor = false;
            this.addElementBtn.Click += new System.EventHandler(this.addElementBtn_Click);
            // 
            // arr_element
            // 
            this.arr_element.Location = new System.Drawing.Point(275, 90);
            this.arr_element.Name = "arr_element";
            this.arr_element.Size = new System.Drawing.Size(100, 23);
            this.arr_element.TabIndex = 7;
            this.arr_element.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Elemento";
            // 
            // array_data
            // 
            this.array_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.array_data.Location = new System.Drawing.Point(12, 169);
            this.array_data.Name = "array_data";
            this.array_data.RowTemplate.Height = 25;
            this.array_data.Size = new System.Drawing.Size(616, 90);
            this.array_data.TabIndex = 5;
            // 
            // unidimBtn
            // 
            this.unidimBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.unidimBtn.FlatAppearance.BorderSize = 0;
            this.unidimBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unidimBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.unidimBtn.Location = new System.Drawing.Point(398, 54);
            this.unidimBtn.Name = "unidimBtn";
            this.unidimBtn.Size = new System.Drawing.Size(75, 23);
            this.unidimBtn.TabIndex = 4;
            this.unidimBtn.Text = "Definir";
            this.unidimBtn.UseVisualStyleBackColor = false;
            this.unidimBtn.Click += new System.EventHandler(this.unidimBtn_Click);
            // 
            // arr_unidimensional
            // 
            this.arr_unidimensional.Location = new System.Drawing.Point(275, 54);
            this.arr_unidimensional.Name = "arr_unidimensional";
            this.arr_unidimensional.Size = new System.Drawing.Size(100, 23);
            this.arr_unidimensional.TabIndex = 3;
            this.arr_unidimensional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dimension";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(233, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arreglo Unidimensional";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.matResult);
            this.panel2.Controls.Add(this.restarBtn);
            this.panel2.Controls.Add(this.sumarBtn);
            this.panel2.Controls.Add(this.addMb);
            this.panel2.Controls.Add(this.valueB);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addMa);
            this.panel2.Controls.Add(this.valueA);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.matriz2);
            this.panel2.Controls.Add(this.matriz1);
            this.panel2.Controls.Add(this.defineDims);
            this.panel2.Controls.Add(this.matDims);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 450);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(220, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Resultado";
            // 
            // matResult
            // 
            this.matResult.AllowUserToAddRows = false;
            this.matResult.AllowUserToDeleteRows = false;
            this.matResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matResult.Location = new System.Drawing.Point(220, 288);
            this.matResult.Name = "matResult";
            this.matResult.RowTemplate.Height = 25;
            this.matResult.Size = new System.Drawing.Size(223, 150);
            this.matResult.TabIndex = 17;
            // 
            // restarBtn
            // 
            this.restarBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.restarBtn.FlatAppearance.BorderSize = 0;
            this.restarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.restarBtn.Location = new System.Drawing.Point(279, 190);
            this.restarBtn.Name = "restarBtn";
            this.restarBtn.Size = new System.Drawing.Size(75, 23);
            this.restarBtn.TabIndex = 16;
            this.restarBtn.Text = "Restar";
            this.restarBtn.UseVisualStyleBackColor = false;
            this.restarBtn.Click += new System.EventHandler(this.restarBtn_Click);
            // 
            // sumarBtn
            // 
            this.sumarBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sumarBtn.FlatAppearance.BorderSize = 0;
            this.sumarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumarBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sumarBtn.Location = new System.Drawing.Point(279, 150);
            this.sumarBtn.Name = "sumarBtn";
            this.sumarBtn.Size = new System.Drawing.Size(75, 23);
            this.sumarBtn.TabIndex = 15;
            this.sumarBtn.Text = "Sumar";
            this.sumarBtn.UseVisualStyleBackColor = false;
            this.sumarBtn.Click += new System.EventHandler(this.sumarBtn_Click);
            // 
            // addMb
            // 
            this.addMb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addMb.Enabled = false;
            this.addMb.FlatAppearance.BorderSize = 0;
            this.addMb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addMb.Location = new System.Drawing.Point(529, 83);
            this.addMb.Name = "addMb";
            this.addMb.Size = new System.Drawing.Size(75, 23);
            this.addMb.TabIndex = 14;
            this.addMb.Text = "Agregar";
            this.addMb.UseVisualStyleBackColor = false;
            this.addMb.Click += new System.EventHandler(this.addMb_Click);
            // 
            // valueB
            // 
            this.valueB.Enabled = false;
            this.valueB.Location = new System.Drawing.Point(440, 83);
            this.valueB.Name = "valueB";
            this.valueB.Size = new System.Drawing.Size(66, 23);
            this.valueB.TabIndex = 13;
            this.valueB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor";
            // 
            // addMa
            // 
            this.addMa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addMa.Enabled = false;
            this.addMa.FlatAppearance.BorderSize = 0;
            this.addMa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addMa.Location = new System.Drawing.Point(176, 82);
            this.addMa.Name = "addMa";
            this.addMa.Size = new System.Drawing.Size(75, 23);
            this.addMa.TabIndex = 11;
            this.addMa.Text = "Agregar";
            this.addMa.UseVisualStyleBackColor = false;
            this.addMa.Click += new System.EventHandler(this.addMa_Click);
            // 
            // valueA
            // 
            this.valueA.Enabled = false;
            this.valueA.Location = new System.Drawing.Point(87, 82);
            this.valueA.Name = "valueA";
            this.valueA.Size = new System.Drawing.Size(66, 23);
            this.valueA.TabIndex = 10;
            this.valueA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor";
            // 
            // matriz2
            // 
            this.matriz2.AllowUserToAddRows = false;
            this.matriz2.AllowUserToDeleteRows = false;
            this.matriz2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matriz2.Location = new System.Drawing.Point(381, 112);
            this.matriz2.Name = "matriz2";
            this.matriz2.RowTemplate.Height = 25;
            this.matriz2.Size = new System.Drawing.Size(223, 150);
            this.matriz2.TabIndex = 8;
            // 
            // matriz1
            // 
            this.matriz1.AllowUserToAddRows = false;
            this.matriz1.AllowUserToDeleteRows = false;
            this.matriz1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matriz1.Location = new System.Drawing.Point(28, 112);
            this.matriz1.Name = "matriz1";
            this.matriz1.RowTemplate.Height = 25;
            this.matriz1.Size = new System.Drawing.Size(223, 150);
            this.matriz1.TabIndex = 7;
            // 
            // defineDims
            // 
            this.defineDims.BackColor = System.Drawing.SystemColors.ControlDark;
            this.defineDims.FlatAppearance.BorderSize = 0;
            this.defineDims.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defineDims.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.defineDims.Location = new System.Drawing.Point(381, 50);
            this.defineDims.Name = "defineDims";
            this.defineDims.Size = new System.Drawing.Size(75, 23);
            this.defineDims.TabIndex = 6;
            this.defineDims.Text = "Establecer";
            this.defineDims.UseVisualStyleBackColor = false;
            this.defineDims.Click += new System.EventHandler(this.defineDims_Click);
            // 
            // matDims
            // 
            this.matDims.Location = new System.Drawing.Point(264, 50);
            this.matDims.Name = "matDims";
            this.matDims.Size = new System.Drawing.Size(100, 23);
            this.matDims.TabIndex = 5;
            this.matDims.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dimensiones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(220, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Operaciones con matrices";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(12, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.back_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 450);
            this.panel3.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(220, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 34);
            this.button4.TabIndex = 2;
            this.button4.Text = "Suma y Resta";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(233, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 47);
            this.label9.TabIndex = 1;
            this.label9.Text = "Vectores";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(220, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "Ocurrencia del valor minimo";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // occurrencesLow
            // 
            this.occurrencesLow.AutoSize = true;
            this.occurrencesLow.Location = new System.Drawing.Point(282, 315);
            this.occurrencesLow.Name = "occurrencesLow";
            this.occurrencesLow.Size = new System.Drawing.Size(82, 15);
            this.occurrencesLow.TabIndex = 11;
            this.occurrencesLow.Text = "Ocurrencias: 0";
            // 
            // occurrencesHigh
            // 
            this.occurrencesHigh.AutoSize = true;
            this.occurrencesHigh.Location = new System.Drawing.Point(282, 378);
            this.occurrencesHigh.Name = "occurrencesHigh";
            this.occurrencesHigh.Size = new System.Drawing.Size(82, 15);
            this.occurrencesHigh.TabIndex = 12;
            this.occurrencesHigh.Text = "Ocurrencias: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Uso de vectores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.array_data)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriz1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button1;
        private Label label1;
        private Button addElementBtn;
        private TextBox arr_element;
        private Label label3;
        private DataGridView array_data;
        private Button unidimBtn;
        private TextBox arr_unidimensional;
        private Label lessNumberLbl;
        private Label highNumberLbl;
        private Panel panel2;
        private Label label8;
        private DataGridView matResult;
        private Button restarBtn;
        private Button sumarBtn;
        private Button addMb;
        private TextBox valueB;
        private Label label7;
        private Button addMa;
        private TextBox valueA;
        private Label label6;
        private DataGridView matriz2;
        private DataGridView matriz1;
        private Button defineDims;
        private TextBox matDims;
        private Label label5;
        private Label label4;
        private Button button2;
        private Panel panel3;
        private Button button4;
        private Label label9;
        private Button button3;
        private Label occurrencesLow;
        private Label occurrencesHigh;
    }
}

