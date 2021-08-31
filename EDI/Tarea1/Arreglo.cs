using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Arreglo
    {
        private int[,] elementos;
        private int rows, cols;
        private int a_row = 0, a_col = 0;
        private bool can_add = true;
        private int less_number;
        private int high_number;
        private bool first_entered = true;
        private Dictionary<int,int> occurrences;
        public Arreglo(int cols)
        {
            elementos = new int[1, cols];
            this.rows = 1;
            this.cols = cols;
            this.less_number = 0;
            this.high_number = 0;
            this.a_row = this.a_col = 0;
            this.first_entered = true;
            occurrences = new Dictionary<int, int>();
    }

        public Arreglo(int rows, int cols)
        {
            elementos = new int[rows, cols];
            this.rows = rows;
            this.cols = cols;
            this.a_row = this.a_col = 0;
            occurrences = new Dictionary<int, int>();
        }

        public bool AgregarElemento(int value)
        {
            if(this.a_row < this.rows)
            {
                if(this.a_col < this.cols)
                {
                    elementos[this.a_row, this.a_col] = value;
                    if (first_entered)
                    {
                        high_number = less_number = value;
                        first_entered = false;
                    }
                    if (value < this.less_number)
                    {
                        less_number = value;
                    }
                    if(value > high_number)
                    {
                        high_number = value;
                    }
                    this.a_col++;
                }
                if(a_col == this.cols)
                {
                    this.a_row++;
                    this.a_col = 0;
                }
                this.can_add = true;
            }
            if (this.a_row == this.rows)
            {
                this.can_add = false;
            }
            return this.can_add;
        }
        public void ObtenerElementos()
        {
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    Console.Write(this.elementos[i,j] + ", ");
                }
            }
        }

        public int ObtenerElemento(int row, int col)
        {
            return elementos[row, col];
        }

        public void ResetArray()
        {
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    elementos[i, j] = 0;
                }
            }
            this.a_row = this.a_col = 0;
        }

        public void generateOcurrences()
        {
            foreach(var value in elementos)
            {
                occurrences.TryGetValue(value, out int times);
                occurrences[value] = times + 1;
            }
        }

        public int getRow()
        {
            return this.a_row;
        }

        public int getLessOccurrences()
        {
            return occurrences[this.less_number];
        }

        public int getLessValue()
        {
            return this.less_number;
        }

        public int getHighValue()
        {
            return this.high_number;
        }

        public int getHighOccurrences()
        {
            return occurrences[this.high_number];
        }
        public string getDimension()
        {
            return "Rows: " + this.rows + ", Cols: " + this.cols;
        }

    }
}
