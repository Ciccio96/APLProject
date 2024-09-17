namespace APL_ServerDef.Classi
{
    public class ProductConnection
    {
        public class RootObject
        {
            public string status { get; set; }
            public Prodotto[] data { get; set; }
            public string message { get; set; }
        }
        //public class Prodotto
        //{
        //    public Guid Id { get; set; }
        //    public string Articolo { get; set; }
        //    public double Prezzo { get; set; }
        //    public int Disponibilita { get; set; }
        //    public string Reparto { get; set; }
        //    public string Categoria { get; set; }

        //}

        public class Prodotto
        {
            public int id { get; set; }
            public string employee_name { get; set; }
            public int employee_salary { get; set; }
            public int employee_age { get; set; }
            public string profile_image { get; set; }
        }

        
    }
    
}
