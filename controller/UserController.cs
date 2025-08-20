using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using model;

namespace controller;

[Route("api/user")]
[ApiController]
class UserController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<UserModel>> GetUsers()
    {
        return Ok();
    }
}