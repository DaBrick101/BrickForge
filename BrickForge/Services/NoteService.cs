namespace BrickForge.Services
{
    using BrickForge.Data;
    using BrickForge.Models;
    using Microsoft.EntityFrameworkCore;

    public class NoteService
    {
        private readonly AppDbContext _context;

        public NoteService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Note>> GetNotesAsync()
        {
            return await _context.Notes.ToListAsync();
        }

        public async Task<Note?> GetNoteByIdAsync(int id)
        {
            return await _context.Notes.FindAsync(id);
        }



        public async Task<Note> CreateNoteAsync(Note note)
        {
            _context.Notes.Add(note);
            await _context.SaveChangesAsync();
            return note;
        }

        public async Task<Note> UpdateNoteAsync(Note note)
        {
            _context.Notes.Update(note);
            await _context.SaveChangesAsync();
            return note;
        }

        public async Task DeleteNoteAsync(int id)
        {
            var note = await _context.Notes.FindAsync(id);
            _context.Notes.Remove(note);
            await _context.SaveChangesAsync();
        }



    }
}
