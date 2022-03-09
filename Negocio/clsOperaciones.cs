using System; //Libreria principal

namespace Negocio
{
    public class clsOperaciones
    {
        private double dblNumero1;
        private double dblNumero2;
        private double dblResultado;
        private String strMensaje;

        public clsOperaciones()
        {
            this.dblNumero1 = 0;
            this.dblNumero2 = 0;
            this.dblResultado = 0;
            this.strMensaje = "";

        }
        public void setCalcularOperaciones(int op)
        {
            if(this.dblNumero1 == 0 || this.dblNumero2 == 0)
            {
                this.strMensaje = "Debe actualizar las variables de instancia ";
            }
            else
            {
                this.strMensaje = "";
                if(op == 0)
                {
                    this.dblResultado = this.dblNumero1 + this.dblNumero2;
                }
                if(op == 1)
                {
                    this.dblResultado = this.dblNumero1 - this.dblNumero2;
                }
                if(op == 2)
                {
                    this.dblResultado = this.dblNumero1 * this.dblNumero2;
                }
                if(op == 3)
                {
                    if(this.dblNumero2 == 0)
                    {
                        this.strMensaje = "MATH ERROR, DIV ";
                    }
                    else
                    {
                        this.strMensaje = "";
                        this.dblResultado = this.dblNumero1 / this.dblNumero2;
                    }
                }
            }
        }

        public void setNumero1(double n1) { this.dblNumero1 = n1; }
        public double getNumero1() { return this.dblNumero1; }

        public void setNumero2(double n2) { this.dblNumero2 = n2; }
        public double getNumero2() { return this.dblNumero2; }

        public double getResultado() { return this.dblResultado; }
        public String getMensaje() { return this.strMensaje; }

    }
}
