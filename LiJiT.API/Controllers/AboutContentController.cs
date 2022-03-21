using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LiJiT.Domain.DTO;
using LiJiT.Domain.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LiJiT.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class AboutContentController : ControllerBase
    {
        public readonly IAboutContentService _aboutContentService;
        public AboutContentController(IAboutContentService aboutContentService)
        {
            _aboutContentService = aboutContentService;
        }
        [HttpGet]
        [Route("About")]
        public async Task<AboutContentDto> GetAll()
        {
            var temp = await _aboutContentService.getAll();
            return temp[0];
        }
        [HttpPost]
        [Route("Create")]
        public async Task<ListDto<AboutContentDto>> CreateAboutContent(AboutContentDto  aboutContentDto)
        {
            return await _aboutContentService.CreateAboutContent(aboutContentDto);
        }
    }
}
