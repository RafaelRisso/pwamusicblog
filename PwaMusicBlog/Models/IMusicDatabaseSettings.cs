using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PwaMusicBlog.Models
{
    public interface IMusicDatabaseSettings
    {
       
        string MusicCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}

