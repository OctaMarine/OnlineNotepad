using NotepadOnline.Repository;

namespace NotepadOnline.Infrastructure.Note.Repositories;

public class NoteRepository : INoteRepository
{
    private readonly AppDbContext _context;
    
    public NoteRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task Add(Models.Note note)
    {
        await _context.Notes.AddAsync(note);
        await _context.SaveChangesAsync();
    }
}