using LB1_tprtbor;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CombinationController : ControllerBase
{
    [HttpGet("{id}")]
    public ActionResult<string> GetCombination(int id)
    {
        // Логика получения комбинации по id
        return Ok("Combination result");
    }

    [HttpPost]
    public ActionResult<string> CreateCombination([FromBody] Combination combination)
    {
        // Логика создания новой комбинации
        return Ok("Combination created");
    }
}
