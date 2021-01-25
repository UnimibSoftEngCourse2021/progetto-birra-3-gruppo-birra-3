using System.Collections.Generic;

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
