using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IRoleLogic
    {
        void CreateOrUpdate(RoleBindingModel model);
        void Delete(RoleBindingModel model);
        List<RoleViewModel> Read(RoleBindingModel model);
    }
}
