﻿namespace Jazani.Senace.Reuniones.Aplicacion.Aplicacion.Datos.Paginado
{
    public class PageResponse<T>
    {
        public IReadOnlyList<T> Data { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public int PerPage { get; set; }
        public int CurrentPage { get; set; }
        public int LastPage { get; set; }
        public int Total { get; set; }
    }
}