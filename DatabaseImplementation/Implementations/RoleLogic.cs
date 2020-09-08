using BusinessLogic.BindingModels;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using DatabaseImplementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseImplementation.Implementations
{
    public class RoleLogic : IRoleLogic
    {
        public void CreateOrUpdate(RoleBindingModel model)
        {
            using (var context = new DatabaseContext())
            {
                Role role = context.Roles.FirstOrDefault(rec =>
                rec.Name == model.Name && rec.ID != model.ID);
                if (role != null)
                {
                    throw new Exception("Уже есть роль с таким названием");
                }
                if (model.ID.HasValue)
                {
                    role = context.Roles.FirstOrDefault(rec => rec.ID == model.ID);
                    if (role == null)
                    {
                        throw new Exception("Роль не найдена");
                    }
                }
                else
                {
                    role = new Role();
                    context.Roles.Add(role);
                }
                role.Name = model.Name;
                role.Type = model.Type;
                role.CreationDate = model.CreationDate;
                context.SaveChanges();
            }
        }

        public void Delete(RoleBindingModel model)
        {
            using (var context = new DatabaseContext())
            {
                Role role = context.Roles.FirstOrDefault(rec => rec.ID == model.ID);
                if (role != null)
                {
                    context.Roles.Remove(role);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Роль не найдена");
                }
            }
        }

        public List<RoleViewModel> Read(RoleBindingModel model)
        {
            using (var context = new DatabaseContext())
            {
                return context.Roles
                    .Where(rec => model == null || rec.ID == model.ID
                    || model.StartDate.HasValue && model.EndDate.HasValue
                    && rec.CreationDate >= model.StartDate.Value
                    && rec.CreationDate <= model.EndDate.Value)
                    .Select(rec => new RoleViewModel
                    {
                        ID = rec.ID,
                        Name = rec.Name,
                        Type = rec.Type,
                        CreationDate = rec.CreationDate
                    })
                    .ToList();
            }
        }
    }
}
