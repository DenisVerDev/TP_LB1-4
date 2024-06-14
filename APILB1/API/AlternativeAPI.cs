using LB1_tprtbor;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AlternativeController : ControllerBase
{
    [HttpGet("{id}")]
    public ActionResult<string> GetAlternative(int id)
    {
        // Логика получения альтернативы по id
        return Ok("Alternative result");
    }

    [HttpPost]
    public ActionResult<string> CreateAlternative([FromBody] Alternative alternative)
    {
        // Логика создания новой альтернативы
        return Ok("Alternative created");
    }
}
