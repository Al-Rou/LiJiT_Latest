using System;
using LiJiT.Domain.IRepository;
using LiJiT.Model;
using LiJiT.EntityFramework;

namespace LiJiT.Persistance.Repository
{
    public class AboutContentRepository : GenericRepository<AboutContent, LiJiTDbContext>, IAboutContentRepository
    {
        public AboutContentRepository(LiJiTDbContext context) : base(context)
        {
        }
    }
}
