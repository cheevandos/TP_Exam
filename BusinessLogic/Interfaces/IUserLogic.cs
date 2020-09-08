using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic.Interfaces
{
    public interface IUserLogic
    {
        void CreateOrUpdate(UserBindingModel model);
        void Delete(UserBindingModel model);
        List<UserViewModel> Read(UserBindingModel model);
    }
}
