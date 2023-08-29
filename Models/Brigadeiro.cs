namespace brigadeiros.Models 
{
    public class Brigadeiro
    {
        public int BrigadeiroId {get; set;}
        public string Nome {get; set;}
        public string DescricaoCurta {get; set;}
        public string DescricaoDetalhada {get; set;}
        public decimal Preco {get; set;}
        public string ImagemUrl {get; set;}
        public string ImagemThumbnailUrl {get; set;}
        public bool IsBrigadeiroPreferido {get; set;}
        public bool EmEstoque {get; set;}

        public int CategoriaId {get; set;}
        public virtual Categoria Categoria {get; set;}
    }
}