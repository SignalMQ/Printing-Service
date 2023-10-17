namespace BL.Objects
{
    /// <summary>
    /// Basic realization of requests from users
    /// </summary>
    [Serializable]
    public class Request
    {
        /// <summary>
        /// Identificator for SQL
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Identificator for owner
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Type of service
        /// </summary>
        public string? ServiceType { get; set; }
        /// <summary>
        /// Price of service
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Type of fees
        /// </summary>
        public string? FeesType { get; set; }
        /// <summary>
        /// Request status
        /// </summary>
        public string? Status { get; set; }
        /// <summary>
        /// For surcharged purposes (+30% of price)
        /// </summary>
        public bool? IsSurcharged { get; set; }
        /// <summary>
        /// Request created date and time
        /// </summary>
        public DateTime Created { get; set; } = DateTime.Now;
    }
}