using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PwaMusicBlog.Extensions;

namespace PwaMusicBlog.Models
{
    public class BlogPost
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int PostId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Link
        {
            get
            {
                return $"{ShortDescription.UrlFriendly(50)}{PostId}" ;
            }
            set { }
        }
        public string Image { get; set; }
        public string Tracks { get; set; }
        public string YtLink { get; set; }
        public bool SendNotification { get; set; }
    }
}
