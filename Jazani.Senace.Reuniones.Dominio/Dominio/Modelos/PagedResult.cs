namespace Jazani.Senace.Reuniones.Dominio.Dominio.Modelos
{
    public class PagedResult<T>
    {
        public IReadOnlyList<T> Data { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public int PerPage { get; set; }
        public int CurrentPage { get; set; }
        public int LastPage { get; set; }
        public int Total { get; set; }

        public PagedResult(IReadOnlyList<T> data, Paging paginado, int totalElementos)
        {
            Data = data;

            int total = totalElementos;
            int page = paginado.PageNumber;
            int perPage = paginado.PageSize;

            int lastPage = (int)Math.Ceiling((decimal)total / perPage);

            if (lastPage < 1) lastPage = 1;

            int currentPage = page;

            if (page > lastPage) page = lastPage;

            int to = page * perPage;
            if (to > total) to = total;

            int from = (page - 1) * perPage + 1;
            if (total <= 0) from = 0;

            From = from;
            To = to;
            PerPage = perPage;
            CurrentPage = currentPage;
            LastPage = lastPage;
            Total = total;
        }
    }
}
