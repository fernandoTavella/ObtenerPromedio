using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;





class Notas {
    Dictionary<string, double> materias = new Dictionary<string,double>();
    double promedio;
    public Notas() {

    }

    public string agregarMateria(string unNombre, int unValorNota) {

        if (this.estaIncluida(unNombre))
       {
           return "La materia ya esta agregada";
       }
       else {
           materias.Add(unNombre, unValorNota);
           return "Materia agregada con exito";
       }

    }
    public double calcularPromedio() {
        double cantidad = materias.Count();
        double sumatoria = materias.Values.Sum(unValor => unValor);
        if (cantidad == 0)
        {
            return 0;
        }
        else {
            promedio = sumatoria / cantidad;
            return promedio;
        }
    }

    public bool estaIncluida(string unNombre) {
        return materias.ContainsKey(unNombre);   
    }

    public void guardar() {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(string.Format("Materia   Nota"));
        foreach (KeyValuePair<string, double> kvp in materias)
        {
            sb.AppendLine(string.Format("{0} :  {1}", kvp.Key, kvp.Value));
        }

        string filePath = @"C:\PromedioUTN.txt";
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            using (TextWriter tw = new StreamWriter(fs))
                tw.Write(sb.ToString());
        }
    }
    public void abrir(){/*MODIFICAR NOMBRES*/
        using (System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\PromedioUTN.txt")) {
            while (!sr.EndOfStream) {
                string cadena = sr.ReadLine();
                string[] separarCadena = cadena.Split(new char[] { ':' });
                if (separarCadena.Length < 2) // If we get less than 2 results, discard them
                    continue;
                else if (separarCadena.Length == 2) // Easy part. If there are 2 results, add them to the dictionary
                    if(!estaIncluida(separarCadena[0].Trim()))
                    materias.Add(separarCadena[0].Trim(), Convert.ToDouble(separarCadena[1].Trim()));
            }
        }
    }
    public string listarContenido() {
        string path = @"C:\PromedioUTN.txt";
        if (File.Exists(path))
            return System.IO.File.ReadAllText(path);
        else
            return "Archivo no creado";
    }
}