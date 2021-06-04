using LibreriaOnline.CAD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace LibreriaOnline.EN
{
    public class ENSoporte
    {

        private int id;
        private string pregunta;
        private string respuesta;
        private string asunto;
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

        public string Asunto
        {
            get { return asunto; }
            set { asunto = value; }
        }

        public ENSoporte()
        {
            Pregunta = "";
            ID = -1;
            Respuesta = "";
            Asunto = "";
        }

        public ENSoporte(string pregunta, string respuesta, int id, string asunto)
        {
            Pregunta = pregunta;
            ID = id;
            Respuesta = respuesta;
            Asunto = asunto;
        }

        public bool readPregunta() //Metodo no necesario para nuestro programa
        {
            CADSoporte soporte = new CADSoporte();
            return soporte.readPregunta(this);
        }

        public bool createPregunta() //Crea una pregunta
        {
            CADSoporte soporte = new CADSoporte();
            return soporte.createPregunta(this);
        }

        public DataSet Lista() //Devuelve un DataSet compuesto de todas las preguntas contestadas por los administradores de la pagina
        {
            CADSoporte soporte = new CADSoporte();
            return soporte.Lista();
        }

        public bool readFirstPregunta()  //Metodo no necesario para nuestro programa
        {
            CADSoporte soporte = new CADSoporte();
            return soporte.readFirstPregunta(this);
        }
        public bool readNextPregunta()  //Metodo no necesario para nuestro programa
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
        public bool readPrevPregunta()  //Metodo no necesario para nuestro programa
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
        public bool editPregunta()  //Metodo no necesario para nuestro programa
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

        public bool deletePregunta()  //Metodo no necesario para nuestro programa
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


