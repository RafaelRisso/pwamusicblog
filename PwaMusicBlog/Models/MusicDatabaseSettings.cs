using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PwaMusicBlog.Models
{
    public class MusicDatabaseSettings:IMusicDatabaseSettings
    {
        public string MusicCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
