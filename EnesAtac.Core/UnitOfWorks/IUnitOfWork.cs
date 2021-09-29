using EnesAtac.Core.Repositeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnesAtac.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IArticleRepository articles { get; }
        ICategoryRepository categorys { get; }
        ICommentRepository comments { get; }
        IGalleryImageRepository galleryImages { get; }
        IGalleryRepository gallerys { get; }
        ILogRepository logs { get; }
        IMenuListRepository menuLists { get; }
        IMenuRepository menus { get; }
        IMenuTypeRepository menuTypes { get; }
        IUserRepository users { get; }
        IUserTypeRepository userTypes { get; }

        Task CommitAsync();
        void Commit();
    }
}
