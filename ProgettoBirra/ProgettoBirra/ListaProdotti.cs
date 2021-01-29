using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoBirra
{
    class ListaProdotti
    {
        private List<ProdottoMapper> listaProdotti = new List<ProdottoMapper>();

        public ListaProdotti()
        {}

        public ListaProdotti(List<ProdottoMapper> listaProdotti)
        {
            this.listaProdotti = listaProdotti;
        }
    }
}
