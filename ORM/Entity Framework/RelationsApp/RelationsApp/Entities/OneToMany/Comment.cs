using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace RelationsApp.Entities.OneToMany
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }

        public Comment(string text) {
            this.Text = text;
        }
    }
}