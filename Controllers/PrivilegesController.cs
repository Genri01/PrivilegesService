using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualBasic;
using PrivilegesService.Models;
using PrivilegesService.Services;

namespace PrivilegesService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrivilegesController : ControllerBase
    {

        private readonly ILogger<PrivilegesController> _logger;
        private readonly IPrivilegesService _privilegesService;

        public PrivilegesController(IPrivilegesService privilegesService, ILogger<PrivilegesController> logger)
        {
            _privilegesService = privilegesService ?? throw new ArgumentNullException(nameof(privilegesService));
            _logger = logger;
        }

        [HttpGet("Permissions")]
        [ProducesResponseType(typeof(List<PermissionsEnum>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<ObjectResult> GetPermissionsPrivileges()
        {
            var permissions = await _privilegesService.GetPermissionsPrivileges();
            
            if (!permissions.Any())
            {
                return NotFound("Not found");
            }

            return Ok(permissions);
        }


        [HttpPost("CreateUser")]
        public async Task<ActionResult<Guid>> CreateUser([FromBody] UserModelDto userDto)
        {
            var result = await _privilegesService.CreateUser(userDto);
            return Ok(result.UserId);
        }
    }
}
