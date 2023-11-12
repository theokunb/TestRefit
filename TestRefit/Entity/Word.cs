using System.ComponentModel.DataAnnotations.Schema;

namespace TestRefit.Entity
{
    public class Word : TestRestClient.Models.Word
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get => base.Id; set => base.Id = value; }
    }
}
