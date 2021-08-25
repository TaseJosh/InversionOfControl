using Unity;

namespace InversionOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer objContainer = new UnityContainer();
            objContainer.RegisterType<Patient>();
            objContainer.RegisterType<IDataAccessLayer, SqlServerDB>();
            objContainer.RegisterType<IDataAccessLayer, MySqlDB>();

            Patient user = objContainer.Resolve<Patient>();
            user.Add();
        }
    }
}
