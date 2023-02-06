using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace LibraryUI.logic
{
    class clsLibrary
    {
        clsData data = new clsData();
        //Método para registrar una librería
        public int registerLibrary(int nit, string name)
        {
            int resultado;
            string consulta;
            consulta = "insert into biblioteca(nitBiblioteca, nomBiblioteca) values (" + nit + ",'" + name + "')";
            resultado = data.ejecutarDML(consulta);
            return resultado;
        }

        //Método que muestra los libros en una librería específica y en una fecha inicio registro específica
        public DataTable researchBookByLibraryAndDate(int nit, string fechaInicioRegistro) //consulta 1
        {
            DataTable miDS = new DataTable();
            string consulta;
            consulta = "select biblioteca.nomBiblioteca, libcodigo, libtitulo, libcategoria, fechafinregistro from libro inner join biblioteca on libro.nitbiblioteca = biblioteca.nitbiblioteca where biblioteca.nitbiblioteca = " + nit + " and fechainicioregistro between to_date('" + fechaInicioRegistro + " 00:00:00','mm-dd-yyyy HH24:MI:SS') and to_date('" + fechaInicioRegistro + " 23:59:59','mm-dd-yyyy HH24:MI:SS')";
            miDS = data.researchValidate(consulta);
            return miDS;
        }

        //Método que muestra todas las bibliotecas
        public DataTable showAllLibrary()
        {
            DataTable miDS = new DataTable();
            string consulta;
            consulta = "select nitbiblioteca, nombiblioteca from biblioteca order by nitbiblioteca";
            miDS = data.researchValidate(consulta);
            return miDS;
        }

        //Método para saber si existe o no el nit de la biblioteca
        public bool validateOfCodeLibrary(int nit)
        {
            DataTable miDS = new DataTable();
            string consulta;
            consulta = "select nitbiblioteca from biblioteca where nitbiblioteca = " + nit;
            miDS = data.researchValidate(consulta);
            if (miDS.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Método para validar el nombre de la biblioteca, existe o no
        public bool validateNameLibrary(string nomBiblioteca)
        {
            DataTable miDS = new DataTable();
            string consulta;
            consulta = "select nombiblioteca from biblioteca where UPPER(nombiblioteca) = UPPER('" + nomBiblioteca + "')";
            miDS = data.researchValidate(consulta);
            if (miDS.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Método para unir libro y biblioteca
        public int registerBookOnLibrary(int libcodigo, int nitBiblioteca, string fechaIni, string fechaFin)
        {
            int resultado;
            string consulta;
            consulta = "insert into registerlibrobiblioteca values (" + libcodigo+", "+nitBiblioteca+", to_date('"+fechaIni+"','mm-dd-yyyy HH:MI:SS AM'), to_date('"+fechaFin+"', 'mm-dd-yyyy HH:MI:SS PM'))";
            resultado = data.ejecutarDML(consulta);
            return resultado;
        }

        //Método mostrar registro de libros en biblioteca
        public DataTable showAllRegisterBookOnLibrary()
        {
            DataTable miDS = new DataTable();
            string consulta;
            consulta = "select libcodigo, nitbiblioteca, fechainicioregistro, fechafinregistro from registerlibrobiblioteca";
            miDS = data.researchValidate(consulta);
            return miDS;
        }

        //Método para validar ya existe registro de libro en biblioteca
        public bool validateCodeBookOnLibrary(int libcodigo, int nitbiblioteca)
        {
            DataTable miDS = new DataTable();
            string consulta;
            consulta = "select * from registerlibrobiblioteca where nitbiblioteca = "+nitbiblioteca+" and libcodigo = " + libcodigo;
            miDS = data.researchValidate(consulta);
            if (miDS.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
