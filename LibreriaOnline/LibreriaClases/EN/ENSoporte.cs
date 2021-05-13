using LibreriaOnline.CAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaOnline.EN
{
    public class ENSoporte
    {

        private int id;
        private string pregunta;
        private string respuesta;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Pregunta
        {
            get { return pregunta; }
            set { pregunta = value; }
        }

        public string Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }

        public ENSoporte()
        {
            Pregunta = "";
            ID = -1;
            Respuesta = "";
        }

        public ENSoporte(string pregunta, string respuesta, int id)
        {
            Pregunta = pregunta;
            ID = id;
            Respuesta = respuesta;
        }

        public bool readPregunta()
        {
            CADSoporte soporte = new CADSoporte();
            return soporte.readPregunta(this);
        }

        public bool createPregunta()
        {
            CADSoporte soporte = new CADSoporte();

            if (!soporte.readPregunta(this))
            {
                return soporte.createPregunta(this);
            }
            else
            {
                return false;
            }
        }

        public bool readFirstPregunta()
        {
            CADSoporte soporte = new CADSoporte();
            return soporte.readFirstPregunta(this);
        }
        public bool readNextPregunta()
        {
            CADSoporte soporte = new CADSoporte();
            if (soporte.readPregunta(this))
            {
                return soporte.readNextPregunta(this);
            }
            else
            {
                return false;
            }
        }
        public bool readPrevPregunta()
        {
            CADSoporte soporte = new CADSoporte();
            if (soporte.readPregunta(this))
            {
                return soporte.readPrevPregunta(this);
            }
            else
            {
                return false;
            }
        }
        public bool editPregunta()
        {
            CADSoporte soporte = new CADSoporte();
            ENSoporte copia = new ENSoporte();
            copia.ID = ID;
            copia.Pregunta = Pregunta;
            copia.Respuesta = Respuesta;
            if (soporte.readPregunta(this))
            {
                ID = copia.ID;
                Pregunta = copia.Pregunta;
                Respuesta = copia.Respuesta;
                return soporte.editPregunta(this);
            }
            else
            {
                return false;
            }
        }

        public bool deletePregunta()
        {
            CADSoporte soporte = new CADSoporte();
            if (soporte.readPregunta(this))
            {
                return soporte.deletePregunta(this);
            }
            else
            {
                return false;
            }
        }


    }
}


