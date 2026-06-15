namespace NotepadOnline.Repository;

public interface INoteRepository
{
    public Task Add(Models.Note note);
}