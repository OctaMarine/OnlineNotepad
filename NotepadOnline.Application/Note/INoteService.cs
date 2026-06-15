namespace NotepadOnline.Application.Note;

public interface INoteService
{
    public Task Add(Models.Note note);
}