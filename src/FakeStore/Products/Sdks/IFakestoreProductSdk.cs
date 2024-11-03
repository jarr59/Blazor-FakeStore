using FakeStore.Products.Commands.Products;
using Refit;

namespace FakeStore.Products.Sdks
{
    public interface IFakestoreProductSdk
    {
        /// <summary>
        /// Url base de los endpoints de productos
        /// </summary>
        const string URL = "/products";

        /// <summary>
        /// Devuelve todos los productos
        /// </summary>
        /// <param name="limit">Limite de productos</param>
        /// <param name="sort">Ordernamiento</param>
        /// <returns></returns>
        [Get(URL)]
        Task<List<ProductOutput>> GetProducts([Query] int? limit,
                                              [Query] string sort);

        /// <summary>
        /// Devuelve un producto por Id
        /// </summary>
        /// <returns></returns>
        [Get(URL + "/{id}")]
        Task<ProductOutput> GetProductById(int Id);

        /// <summary>
        /// Crea un producto
        /// </summary>
        /// <returns></returns>
        [Post(URL)]
        Task<ProductOutput> CreateProduct(CreateProduct createProduct);

        /// <summary>
        /// Actualiza un producto
        /// </summary>
        /// <returns></returns>
        [Post(URL + "/{id}")]
        Task<ProductOutput> UpdateProduct(int Id, UpdateProduct createProduct);


        /// <summary>
        /// Devuelve todas las categorias
        /// </summary>
        /// <returns></returns>
        [Get(URL + "/categories")]
        Task<List<string>> GetCategories();
    }
}
