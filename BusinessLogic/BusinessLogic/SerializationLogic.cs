using BusinessLogic.Interfaces;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace BusinessLogic.BusinessLogic
{
    public class SerializationLogic
    {
        private readonly IUserLogic userLogic;
        private readonly IRoleLogic roleLogic;

        public SerializationLogic(IUserLogic userLogic, IRoleLogic roleLogic)
        {
            this.userLogic = userLogic;
            this.roleLogic = roleLogic;
        }

        public void Serialize()
        {
            SerializeRoles();
            SerializeUsers();
        }

        private async void SerializeUsers()
        {
            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "users_" + DateTime.Now.ToLongDateString() + ".json");
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var users = userLogic.Read(null);
                await JsonSerializer.SerializeAsync(fs, users);
            }
        }

        private async void SerializeRoles()
        {
            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "roles_" + DateTime.Now.ToLongDateString() + ".json");
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var roles = roleLogic.Read(null);
                await JsonSerializer.SerializeAsync(fs, roles);
            }
        }
    }
}
