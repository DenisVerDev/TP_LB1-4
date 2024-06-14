using LB1_tprtbor;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class FileController : ControllerBase
{
    [HttpGet("{id}")]
    public ActionResult<string> GetFile(int id)
    {
        // Логика получения файла по id
        return Ok("File result");
    }

    [HttpPost]
    public ActionResult<string> UploadFile([FromBody] TestFile file)
    {
        // Логика загрузки нового файла
        return Ok("File uploaded");
    }
}
