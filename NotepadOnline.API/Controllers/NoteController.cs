using Microsoft.AspNetCore.Mvc;
using NotepadOnline.Application.Note;
using NotepadOnline.Models;

namespace NotepadOnline.API.Controllers;

[ApiController]
[Route("note")]
public class NoteController : ControllerBase
{
    private readonly INoteService _noteService;
    
    public NoteController(INoteService noteService)
    {
        _noteService = noteService;
    }
    
    [HttpGet("get")]
    public IActionResult Get()
    {
        return Ok("Hello from TestController!");
    }
    
    [HttpPost("add")]
    public async Task <ActionResult> Add()
    {
        var note = new Note();
        note.Data = "Test text";
        await _noteService.Add(note);
        return Ok();
    }
}