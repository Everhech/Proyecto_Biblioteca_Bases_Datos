using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryUI.logic;
using System.Data;

namespace LibraryUI.controller
{
    public class clsControllerBook
    {
        clsBook book = new clsBook();
        public int ControllerRegisterBook(int libCodigo, string libTitulo, int numPaginas, string libCategoria, string fechaInicioRegistro, string fechaFinRegistro, int nitBiblioteca)
        {
            return book.registerBook(libCodigo, libTitulo, numPaginas, libCategoria, fechaInicioRegistro, fechaFinRegistro, nitBiblioteca);
        }

        public DataTable ControllerResearchCountBook(string libCategoria) //Va junto con ShowControllerBook: consulta 2
        {
            return book.researchCountBookByCategory(libCategoria);
        }

        public DataTable ControllerShowBookByCategory(string libCategoria) //consulta 2
        {
            return book.showBooksByCategory(libCategoria);
        }

        public DataTable ControllerShowAllBooks() //Muestra todos los libros
        {
            return book.showAllBooks();
        }

        public bool ControllerValidateCodeBook(int libcodigo)
        {
            return book.validateOfCodeBook(libcodigo);
        }

        public bool ControllerValidateTitleBook(string libtitulo)
        {
            return book.validateTitleOfBook(libtitulo);
        }

        

    }
}
