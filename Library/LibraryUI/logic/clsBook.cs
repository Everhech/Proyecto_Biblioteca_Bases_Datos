using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace LibraryUI.logic
{
    class clsBook
    {
        clsData data = new clsData();
        //Método para registrar un libro
        public int registerBook(int libCodigo, string libTitulo, int numPaginas, string libCategoria, string fechaInicioRegistro, string fechaFinRegistro, int nitBiblioteca)
        {
            int resultado;
            string consulta;
            consulta = "insert into libro(libcodigo,libtitulo,numpaginas,libcategoria,fechainicioregistro,fechafinregistro,nitbiblioteca) values(" + libCodigo + ",'" + libTitulo + "'," + numPaginas + ",'" + libCategoria + "',to_date('" + fechaInicioRegistro + "','mm-dd-yyyy HH:MI:SS AM'),to_date('" + fechaFinRegistro + "','mm-dd-yyyy HH:MI:SS PM')," + nitBiblioteca + ")";
            resultado = data.ejecutarDML(consulta);
            return resultado;
        }

        //Método para mostrar la cantidad de libros que hay, por categoria buscada  --> Resultado un valor
        public DataTable researchCountBookByCategory(string libCategoria)
        {
            DataTable miDS = new DataTable();
            string consulta;
            consulta = "select count(libcategoria) Cantidad from libro where libcategoria = '" + libCategoria + "'";
            miDS = data.researchValidate(consulta);
            return miDS;
        }

        //Método para mostrar los libros de la categoria buscada anteriormente  --> Resultado una tabla
        public DataTable showBooksByCategory(string libCategoria)
        {
            DataTable miDS = new DataTable();
            string consulta;
            consulta = "select libtitulo,libcategoria from libro where libcategoria = '" + libCategoria + "'";
            miDS = data.researchValidate(consulta);
            return miDS;
        }

        //Método para mostrar todos los libros
        public DataTable showAllBooks()
        {
            DataTable miDS = new DataTable();
            string consulta;
            consulta = "select libcodigo, libtitulo, nitbiblioteca from libro order by libcodigo";
            miDS = data.researchValidate(consulta);
            return miDS;
        }

        //Método para validar el libcodigo, saber si existe o no
        public bool validateOfCodeBook(int libcodigo)
        {
            DataTable miDS = new DataTable();
            string consulta;
            consulta = "select libcodigo from libro where libcodigo = " + libcodigo;
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

        //Método para validar el nombre del libro, existe o no
        public bool validateTitleOfBook(string libtitulo)
        {
            DataTable miDS = new DataTable();
            string consulta;
            consulta = "select libtitulo from libro where UPPER(libtitulo) = UPPER('" + libtitulo + "')";
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
