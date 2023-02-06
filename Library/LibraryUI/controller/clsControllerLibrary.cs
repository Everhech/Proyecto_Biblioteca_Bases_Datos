using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryUI.logic;
using System.Data;

namespace LibraryUI.controller
{
    public class clsControllerLibrary
    {
        private clsLibrary library = new clsLibrary();
        public int ControllerRegisterLibrary(int nit, string name)
        {
            return library.registerLibrary(nit, name);
        }

        public int ControllerRegisterBookOnLibrary(int libcodigo, int nitBiblio, string fechaIni, string fechaFin)
        {
            return library.registerBookOnLibrary(libcodigo, nitBiblio, fechaIni, fechaFin);
        }

        public DataTable ControllerResearchLibrary(int nit, string fechaInicioRegistro)
        {
            return library.researchBookByLibraryAndDate(nit, fechaInicioRegistro);
        }

        public DataTable ControllerShowAllLibrary()
        {
            return library.showAllLibrary();
        }

        public bool ControllerValidateCodeLibrary(int nit)
        {
            return library.validateOfCodeLibrary(nit);
        }

        public bool ControllerValidateNameLibrary(string nomBiblioteca)
        {
            return library.validateNameLibrary(nomBiblioteca);
        }

        public DataTable ControllerShowAllBookOnLibrary()
        {
            return library.showAllRegisterBookOnLibrary();
        }

        public bool ControllerValidateBookOnLibrary(int libcodigo, int nitbiblioteca)
        {
            return library.validateCodeBookOnLibrary(libcodigo, nitbiblioteca);
        }
    }
}
