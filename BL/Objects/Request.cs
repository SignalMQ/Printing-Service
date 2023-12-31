﻿namespace BL.Objects
{
    /// <summary>
    /// Basic realization of requests from users
    /// 
    /// Other it's Requests table scheme
    /// </summary>
    [Serializable] //for json futured
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
        /// Identifier for request for worker
        /// </summary>
        public int LinkedUserId { get; set; }
        /// <summary>
        /// Type of service
        /// </summary>
        public string? Service { get; set; }
        /// <summary>
        /// Price of service
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Type of fees
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