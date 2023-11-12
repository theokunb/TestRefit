using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestRestClient.Models.Dto;
using TestRefit.Request.Word.Create;
using TestRefit.Request.Word.Get;
using TestRestClient.Abstraction;
using TestRestClient.Models;
using Refit;
using TestRefit.Request.Word.Update;
using TestRefit.Request.Word.Delete;

namespace TestRefit.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WordController : ControllerBase, IWordRestClient
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public WordController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<Word> Create([Body] WordDto wordDto)
        {
            var request = _mapper.Map<CreateWord>(wordDto);
            var res = await _mediator.Send(request);

            return res;
        }

        [HttpDelete]
        public async Task Delete([AsParameters] int id)
        {
            var request = new DeleteWord()
            {
                Id = id
            };
            var res = await _mediator.Send(request);

            return;
        }

        [HttpGet]
        public async Task<Word> Get([AsParameters]int id)
        {
            var request = new GetWord
            {
                Id = id
            };
            var res = await _mediator.Send(request);

            return res;
        }

        [HttpPut]
        public async Task<Word> Update([AsParameters] int id, [Body] WordDto wordDto)
        {
            var request = new UpdateWord
            {
                Id = id,
                Value = wordDto.Value
            };
            var res = await _mediator.Send(request);

            return res;
        }
    }
}