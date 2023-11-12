using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TestRestClient.Abstraction;
using TestRestClient.Models;
using TestRestClient.Models.Dto;
using TestWebApi.Entity;
using TestWebApi.Models.Dto;

namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ObserverController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IWordRestClient _wordRestClient;

        public ObserverController(IWordRestClient wordRestClient, IMapper mapper)
        {
            _wordRestClient = wordRestClient;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<Observer> Get(int id)
        {
            var word = await _wordRestClient.Get(id);
            var observer = _mapper.Map<Observer>(word);

            return observer;
        }

        [HttpPost]
        public async Task<Word> Create([FromBody] ObserverDto observerDto)
        {
            var wordDto = _mapper.Map<WordDto>(observerDto);
            var res = await _wordRestClient.Create(wordDto);

            return res;
        }

        [HttpPut]
        public async Task<Word> Update([AsParameters] int id, [FromBody] ObserverDto observerDto)
        {
            var wordDto = _mapper.Map<WordDto>(observerDto);
            var res = await _wordRestClient.Update(id, wordDto);

            return res;
        }

        [HttpDelete]
        public async void Delete([AsParameters] int id)
        {
            await _wordRestClient.Delete(id);
        }
    }
}