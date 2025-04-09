namespace Nyakko.EduConnect.API
{
    public interface IHelloService
    {
        string SayHello(string name);

    }
    public class HelloService : IHelloService
    {
        public string SayHello(string name)
        {
            return "Xin chào " + name;
        }
    }
}
