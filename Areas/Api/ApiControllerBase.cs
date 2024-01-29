using Microsoft.AspNetCore.Mvc;

namespace webapitest.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class ApiControllerBase : ControllerBase
{

}