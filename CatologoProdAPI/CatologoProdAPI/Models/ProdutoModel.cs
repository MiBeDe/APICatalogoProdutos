using Google.Cloud.Firestore;

namespace CatologoProdAPI.Models
{
    [FirestoreData]
    public class ProdutoModel
    {
        public string IdProd { get; set; }
        [FirestoreProperty]
        public string Categoria { get; set; }
        [FirestoreProperty]
        public string SubCategoria { get; set; }
        [FirestoreProperty]
        public string NomeProduto { get; set; }
        [FirestoreProperty]
        public string Descricao { get; set; }
        [FirestoreProperty]
        public string Tamanho { get; set; }
        [FirestoreProperty]
        public string Cor { get; set; }
        [FirestoreProperty]
        public double Preco { get; set; }
        [FirestoreProperty]
        public int Quantidade { get; set; }
        [FirestoreProperty]
        public string PathImages { get; set; }
        [FirestoreProperty]
        public string Image1 { get; set; }
        [FirestoreProperty]
        public string Image2 { get; set; }
        [FirestoreProperty]
        public string Image3 { get; set; }
    }
}
