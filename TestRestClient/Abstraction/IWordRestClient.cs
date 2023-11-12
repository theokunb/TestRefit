using Refit;
using TestRestClient.Models;
using TestRestClient.Models.Dto;

namespace TestRestClient.Abstraction
{
    public interface IWordRestClient
    {
        [Get("/Word")]
        Task<Word> Get([AsParameters]int id);

        [Post("/Word/")]
        Task<Word> Create([Body] WordDto wordDto);

        [Put("/Word/")]
        Task<Word> Update([AsParameters] int id, [Body] WordDto wordDto);

        [Delete("/Word/")]
        Task Delete([AsParameters] int id);
    }
}
