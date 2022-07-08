using Google.Cloud.Firestore;

namespace CatologoProdAPI.Models
{
    [FirestoreData]
    public class PedidoModel
    {
        public string IdPedido { get; set; }
        [FirestoreProperty]
        public string Vendedor { get; set; }
        [FirestoreProperty]
        public string Cliente { get; set; }
        [FirestoreProperty]
        public string IdProduto { get; set; }
        [FirestoreProperty]
        public string Produto { get; set; }
        [FirestoreProperty]
        public string Tamanho { get; set; }
        [FirestoreProperty]
        public string Cor { get; set; }
        [FirestoreProperty]
        public double Preco { get; set; }
        [FirestoreProperty]
        public string Categoria { get; set; }
        [FirestoreProperty]
        public string SubCategoria { get; set; }
        [FirestoreProperty]
        public int Quantidade { get; set; }
        [FirestoreProperty]
        public string DataPedido { get; set; }
        [FirestoreProperty]
        public string DataEnvio { get; set; }
        [FirestoreProperty]
        public int StatusPagamento { get; set; }
        [FirestoreProperty]
        public int StatusPedido { get; set; }
    }
}
