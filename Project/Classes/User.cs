using System;

namespace Project.Classes
{
    public class User
    {
        /// <summary>
        /// айди юзера
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// юзернейм
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// хешированный пароль
        /// </summary>
        public string Password_Hash { get; set; }
        /// <summary>
        /// имя пользователя (произвольное)
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// дата создания юзера
        /// </summary>
        public DateTime Created_At { get; set; }

    }
}
