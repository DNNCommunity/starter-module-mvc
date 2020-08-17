using starter_module_mvc.Services.Interfaces;

namespace starter_module_mvc.Services
{
    public class MyService : IMyService
    {
        public string DnnHello()
        {
            return "Hello from DNN!";
        }
        public string DnnHelloPersonalize(string name)
        {
            return "Hello " + name + " from DNN!";
        }
    }
}