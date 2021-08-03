﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class OperadoresDeConversao : IAulaItem
    {
        public void Executar()
        {

            AnguloEmGraus anguloEmGraus = 45;//Aqui está rolando um Cast implicito que eu defini através do 'static implicit operator' vide no exemplo da classe 'AnguloEmGraus'
            Console.WriteLine(anguloEmGraus);

            AnguloEmRadianos anguloEmRadianos = 15;
            Console.WriteLine(anguloEmRadianos);

            double graus = anguloEmGraus;

            anguloEmRadianos = anguloEmGraus;
            anguloEmGraus = (AnguloEmGraus) anguloEmRadianos;//Aqui está rolando um Cast explicito que eu defini através do 'static explicit operator' vide no exemplo da classe 'AnguloEmGraus'
            System.Console.WriteLine($"anguloEmGraus: {anguloEmGraus}");
            System.Console.WriteLine($"anguloEmRadianos: {anguloEmRadianos}");
        }
    }

    public struct AnguloEmRadianos
    {
        public double Radianos { get; }

        public AnguloEmRadianos(double radianos)
        {
            this.Radianos = radianos;
        }

        public static implicit operator AnguloEmRadianos(AnguloEmGraus graus)
        {
            return new AnguloEmRadianos(graus.Graus * System.Math.PI / 180);
        }

        public static implicit operator AnguloEmRadianos (double radianos)
        {
            return new AnguloEmRadianos(radianos);
        }

        public static double Converte(AnguloEmRadianos radianos)
        {
            return radianos.Radianos;
        }

        public override string ToString()
        {
            return String.Format("{0} radianos", this.Radianos);
        }
    }

    public struct AnguloEmGraus
    {
        public double Graus { get; }

        public AnguloEmGraus(double graus) { this.Graus = graus; }

        public static explicit operator AnguloEmGraus(AnguloEmRadianos radianos)
        {
            return new AnguloEmGraus(radianos.Radianos * 180 / System.Math.PI);
        }

        public static implicit operator AnguloEmGraus(double graus)
        {
            return new AnguloEmGraus(graus);
        }

        public static implicit operator double(AnguloEmGraus graus)
        {
            return graus.Graus;
        }

        public override string ToString()
        {
            return String.Format("{0} graus", this.Graus);
        }
    }

}
