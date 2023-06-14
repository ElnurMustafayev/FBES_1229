namespace BlogApp.Repositories;

using BlogApp.Data.EfCore;
using BlogApp.Entities;
using BlogApp.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;

public class BlogsEfRepository : IBlogsRepository<Blog> {
	private readonly MyDbContext context;

	public BlogsEfRepository() {
		this.context = new MyDbContext();
	}

	public IEnumerable<Blog> Get(int authorId) {
		return this.context.Blogs
			.Where(b => b.AuthorId == authorId)
			.ToList();
    }
}