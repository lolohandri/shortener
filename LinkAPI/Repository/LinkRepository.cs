using LinkAPI.Context;
using LinkAPI.Models;
using LinkAPI.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.CompilerServices;

namespace LinkAPI.Repository
{
    public class LinkRepository : GenericRepository<Link>
    {
        private readonly DataContext _context;
        public LinkRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public bool IsUrlExists(string url)
        {
            var linkCheck = _context.Links.FirstOrDefault(link => link.OriginLink == url);
            return linkCheck != null ? true : false; 
        }

        public override IEnumerable<Link> GetAll()
        {
            return base.GetAll();
        }
        public override Link Get(long id)
        {
            return base.Get(id);
        }
        public override void Create(Link link)
        {
            base.Create(link);
        }
        public override bool Delete(long id)
        {
            return base.Delete(id);
        }
    }
}
