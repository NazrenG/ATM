
namespace Task_cs
{
    internal class Run
    {
        public void runFunc(Func func, string str)
        {
            func.Invoke(str);
        }
            
    }
}
