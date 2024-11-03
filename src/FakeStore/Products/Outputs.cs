namespace FakeStore.Products
{
    /// <summary>
    /// Representa el producto
    /// </summary>
    /// <param name="Id">Título del producto</param>
    /// <param name="Title">Título del producto</param>
    /// <param name="Price">Precio del producto</param>
    /// <param name="Description">Descripción del producto</param>
    /// <param name="Image">URL de la imagen del producto</param>
    /// <param name="Category">Categoría del producto</param>
    public record ProductOutput(int Id, string Title, double Price, string Description, string Image, string Category);
}
