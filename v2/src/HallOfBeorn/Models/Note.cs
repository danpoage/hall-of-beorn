namespace HallOfBeorn.Models
{
    public class Note
    {
        public Note(NoteType noteType, string version, string text)
        {
            NoteType = noteType;
            Version = version;
            Text = text;
        }

        public NoteType NoteType { get; }
        public string Version { get; }
        public string Text { get; }
    }
}
