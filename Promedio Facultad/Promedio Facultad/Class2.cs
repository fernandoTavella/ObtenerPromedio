using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WindowsFormsApplication1
{
    class Notas : Promedio
    {
        string NombreMateria;
        int NotaMateria;
        List<Notas> materias;

        public Notas()
        {
            List<Notas> col = new List<Notas>();
            materias = col;
        }

        public void agregarMateria(string unNombreMat, int unaNota)
        {
            Notas nuevaNota = new Notas();
            nuevaNota.NombreMateria = unNombreMat;
            nuevaNota.NotaMateria = unaNota;

            if (this.noEstaIncluida(unNombreMat))
            {
                this.materias.Add(nuevaNota);
            }
            else
            {
                throw new Exception("la materia ya esta registrada");
            }
        }
        public bool noEstaIncluida(string nombreDeMateria)
        {
            return !materias.Any(unaNota => unaNota.NombreMateria == nombreDeMateria);

        }

        public int calcularPromedio()
        {
            int cantidad = materias.Count();
            int sumatoria = materias.Sum(unaNota => unaNota.NotaMateria);
            return sumatoria / cantidad;
        }
    }
}
