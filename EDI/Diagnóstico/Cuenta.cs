using System;

namespace Diagnóstico
{
    class Cuenta
    {
        public String titular {get; set;}
        public double cantidad {get; set;}

        public Cuenta(){
            this.titular = "";
            this.cantidad = 0;
        }
        public Cuenta(String titular){
            this.titular = titular;
            this.cantidad = 0;
        }
        public Cuenta(String titular, double cantidad){
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public void ingresar(double cantidad){
            if(cantidad > 0)
                this.cantidad+=cantidad;
        }
        public void retirar(double cantidad){
            if(cantidad > 0){
                this.cantidad-=cantidad;
                if(this.cantidad <= 0)
                    {
                        this.cantidad = 0;
                    }
            }
        }
        public String toString(){
            return String.Format("Titular: {0}, Cantidad: ${1}", this.titular, this.cantidad);
        }
    }
}
