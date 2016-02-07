using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Alumnos
{
    class Alumnosc
    {
        private ArrayList listaAlumnos = new ArrayList();

        public ArrayList ListaAlumnos
        {
            get { return listaAlumnos; }
        }

        public void agregarAlumno(Alumno Alum)
        {
            listaAlumnos.Add(Alum);
        }

        public double medianotas()
        {
            int acumulador = 0;
            double medialumnos = 0;

            foreach (Alumno alum in listaAlumnos)
            {
                acumulador += alum.Nota;
            }

            if (listaAlumnos.Count == 0)
            {
                medialumnos = 0;
            }
            else
            {
                medialumnos = medialumnos / listaAlumnos.Count;
            }

            return acumulador;
        }
    }
}
