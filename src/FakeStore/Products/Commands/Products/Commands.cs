namespace FakeStore.Products.Commands.Products
{
    /// <summary>
    /// Representa el objeto para la creacion de un producto
    /// </summary>
    /// <param name="Title">Título del producto</param>
    /// <param name="Price">Precio del producto</param>
    /// <param name="Description">Descripción del producto</param>
    /// <param name="Image">URL de la imagen del producto</param>
    /// <param name="Category">Categoría del producto</param>
    public record CreateProduct(string Title, double Price, string Description, string Image, string Category);

    /// <summary>
    /// Representa el objeto para la actualizacion de un producto
    /// </summary>
    /// <param name="Title">Título del producto</param>
    /// <param name="Price">Precio del producto</param>
    /// <param name="Description">Descripción del producto</param>
    /// <param name="Image">URL de la imagen del producto</param>
    /// <param name="Category">Categoría del producto</param>
    public record UpdateProduct(string Title, double Price, string Description, string Image, string Category);
}
