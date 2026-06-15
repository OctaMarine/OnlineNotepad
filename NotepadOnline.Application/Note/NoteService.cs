using NotepadOnline.Repository;

namespace NotepadOnline.Application.Note;

public class NoteService : INoteService
{
    private readonly INoteRepository _noteRepository;
    
    public NoteService(INoteRepository noteRepository)
    {
        _noteRepository = noteRepository;
    }
    
    public void Get()
    {
        
    }
    
    public async Task Add(Models.Note note)
    {
        await _noteRepository.Add(note);
    }
    
    public void Update()
    {
        
    }
}