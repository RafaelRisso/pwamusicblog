using PwaMusicBlog.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PwaMusicBlog.Services
{
  public  interface IMusicService
    {
        //List<BlogPost> GetLatestPosts();
        string GetPostText(string link);

        //List<BlogPost> GetOlderPosts(int oldestPostId);

        //void Create(BlogPost post);
        Task Create(BlogPost post);

        List<BlogPost> GetLatestPosts();
        List<BlogPost> GetOlderPosts(int oldestPostId);
    }
}
