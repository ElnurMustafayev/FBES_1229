using BlogApp.Entities;
using System.Collections.Generic;

namespace BlogApp.Repositories.Base;

public interface IBlogsRepository<TEntity> {
    IEnumerable<Blog> Get(int authorId);
}