using BusinessLogic.BusinessLogic;
using BusinessLogic.Interfaces;
using DatabaseImplementation.Implementations;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace View
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var unityContainer = BuildUnityContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(unityContainer.Resolve<MainForm>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IRoleLogic, RoleLogic>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<IUserLogic, UserLogic>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<ReportLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<SerializationLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
