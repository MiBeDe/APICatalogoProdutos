using CatologoProdAPI.Models;
using CatologoProdAPI.Repositories.Interfaces;
using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace CatologoProdAPI.Repositories
{
    public class EstoqueRepository : IEstoqueRepository
    {

        private readonly string projetoId;
        private readonly IConfiguration configuration;
        FirestoreDb _firestoreDb;

        public EstoqueRepository(IConfiguration iConfig)
        {
            configuration = iConfig;
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", configuration.GetSection("DirectoryConfig").GetSection("Base").Value);
            projetoId = "catalogoprodutoswebmvc";
            _firestoreDb = FirestoreDb.Create(projetoId);
        }

        public async Task<List<ProdutoModel>> GetProdutosEstoque()
        {
            Query estoqueQuery = _firestoreDb.Collection("produtos");
            QuerySnapshot estoqueQuerySnapshot = await estoqueQuery.GetSnapshotAsync();
            List<ProdutoModel> listaProdutos = new List<ProdutoModel>();

            foreach (DocumentSnapshot documentSnapshot in estoqueQuerySnapshot.Documents)
            {
                if (documentSnapshot.Exists)
                {
                    Dictionary<string, object> produto = documentSnapshot.ToDictionary();
                    string json = JsonConvert.SerializeObject(produto);

                    ProdutoModel produtoModel = JsonConvert.DeserializeObject<ProdutoModel>(json);
                    produtoModel.IdProd = documentSnapshot.Id;
                    listaProdutos.Add(produtoModel);
                }
            }

            return listaProdutos.ToList();
        }

        public async Task AlterarQuantidade(ProdutoModel produto)
        {
            DocumentReference documentReference = _firestoreDb.Collection("produtos").Document(produto.IdProd);
            await documentReference.SetAsync(produto, SetOptions.MergeFields("Quantidade"));
        }

        public async Task DeleteProduto(string idProduto)
        {
            DocumentReference documentReference = _firestoreDb.Collection("produtos").Document(idProduto);
            await documentReference.DeleteAsync();
        }

       
    }
}
