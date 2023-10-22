namespace BL.Objects
{
    /// <summary>
    /// Basic realization of all subjects
    /// 
    /// Users table scheme
    /// </summary>
    [Serializable] //for json futured
    public class User
    {
        /// <summary>
        /// Identificator of user
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Username for authorization in Login
        /// </summary>
        public string? Username { get; set; }
        /// <summary>
        /// User password for login
        /// </summary>
        public string? Password { get; set; }
        /// <summary>
        /// Role of user
        /// </summary>
        public string? Role { get; set; }
        /// <summary>
        /// Requests of user
        /// </summary>
        public List<Request>? Requests { get; set; } = new();
    }
}
