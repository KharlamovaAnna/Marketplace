namespace Project.Classes
{
    public class Option
    {
        /// <summary>
        /// ну айди опции
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// айди вопроса
        /// </summary>
        public int Question_Id { get; set; }
        /// <summary>
        /// текст
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// вес ответа
        /// </summary>
        public int Weight { get; set; }

    }
}
