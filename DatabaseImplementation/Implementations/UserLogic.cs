using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using DatabaseImplementation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseImplementation.Implementations
{
    public class UserLogic : IUserLogic
    {
        public void CreateOrUpdate(UserBindingModel model)
        {
            using (var context = new DatabaseContext())
            {
                User user = context.Users.FirstOrDefault(rec =>
                rec.Login == model.Login && rec.ID != model.ID);
                if (user != null)
                {
                    throw new Exception("Поставщик уже зарегристрирован");
                }
                if (model.ID.HasValue)
                {
                    user = context.Users.FirstOrDefault(rec => rec.ID == model.ID);
                    if (user == null)
                    {
                        throw new Exception("Пользователь не найден");
                    }
                }
                else
                {
                    user = new User();
                    context.Users.Add(user);
                }
                user.FullName = model.FullName;
                user.RoleID = model.RoleID;
                user.Login = model.Login;
                user.Password = model.Password;
                user.CreationDate = model.CreationDate;
                context.SaveChanges();
            }
        }

        public void Delete(UserBindingModel model)
        {
            using (var context = new DatabaseContext())
            {
                User user = context.Users.FirstOrDefault(rec => rec.ID == model.ID);
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Пользователь не найден");
                }
            }
        }

        public List<UserViewModel> Read(UserBindingModel model)
        {
            using (var context = new DatabaseContext())
            {
                return context.Users
                .Include(rec => rec.Role)
                .Where(rec => model == null || rec.ID == model.ID
                || model.StartDate.HasValue && model.EndDate.HasValue
                && rec.Role.CreationDate >= model.StartDate.Value
                && rec.Role.CreationDate <= model.EndDate.Value)
                .Select(rec => new UserViewModel
                {
                    ID = rec.ID,
                    FullName = rec.FullName,
                    RoleID = rec.RoleID,
                    RoleName = rec.Role.Name,
                    Login = rec.Login,
                    Password = rec.Password,
                    CreationDate = rec.CreationDate,
                    RoleCreationDate = rec.Role.CreationDate
                })
                .ToList();
            }
        }
    }
}
