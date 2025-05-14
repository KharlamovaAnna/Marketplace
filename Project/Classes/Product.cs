namespace Project.Classes
{
    public class Product
    {
        /// <summary>
        /// айди
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// название продукта
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// описание продукта
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// категория
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// ссылка на изображение товара
        /// </summary>
        public string Image_url { get; set; }
    }
}
