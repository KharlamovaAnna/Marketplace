namespace Project.Classes
{
    public class Question
    {
        /// <summary>
        /// айди вопроса
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// айди опросника
        /// </summary>
        public int Survey_ID { get; set; }
        /// <summary>
        /// текст
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// тип вопроса
        /// </summary>
        public string Question_Type { get; set; }
    }
}
