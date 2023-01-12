using System.ComponentModel.DataAnnotations;

namespace Exchange.Models
{
    public class UserTransaction
    {
        [Key]
        public int Id { get; set; }
    }
}
