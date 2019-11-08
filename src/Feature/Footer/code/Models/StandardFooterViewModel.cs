using System;
using Glass.Mapper.Sc.Web.Mvc;

namespace Books.Feature.Footer.Models
{
    public class StandardFooterViewModel
    {
        private readonly IMvcContext _context;

        public StandardFooterViewModel(IMvcContext context)
        {
            _context = context;
            GetFooter(_context);
        }

        private void GetFooter(IMvcContext context)
        {
            
        }
    }
}