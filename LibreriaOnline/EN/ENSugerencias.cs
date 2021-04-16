using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibreriaOnline
{
    class ENSugerencias
    {
        private string titulo;
        private string texto;
        private int id;
        private string autor;
        

    }

    public string titulo_
    {
        get { return titulo; }
        set { titulo = value; }
    }

    public string texto_
    {
        get { return texto; }
        set { texto = value; }
    }

    public int id_
    {
        get { return id; }
        set { id = value; }
    }

    public string autor_
    {
        get { return autor}
        set { autor = value; }
    }

    public ENSugerencia()
    {
        Titulo = "";
        Texto = "";
        Autor = "";
        Id = 0;
    }

    public ENSugerencia(string titulo, string texto, string autor, int id)
    {
        Titulo = titulo;
        Texto = texto;
        Autor = autor;
        Id = id;
    }


    public bool createSugerencia()
    {
        CADSugerencia s = new CADSugerencia
            return s.createSugerencia(this);
    }

    public bool readSugerencia()
    {
        CADSugerencia s = new CADSugerencia
            return s.readSugerencia(this);
    }

    public bool updateSugerencia()
    {
        CADSugerencia s = new CADSugerencia
            return s.updateSugerencia(this);
    }

    public bool deleteSugerencia()
    {
        CADSugerencia s = new CADSugerencia
            return s.deleteSugerencia(this);
    }

}
