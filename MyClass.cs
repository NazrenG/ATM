

namespace Task_cs
{
    delegate void Func(string str);

    internal class MyClass
    {
        public string str { get; set; }

        public MyClass(string str)
        {
            this.str = str;
        }
      
        public void Space(string str)
        {
            
            this.str=string.Join("_",str.ToCharArray());
            Console.WriteLine(this.str);
        }
        public void Reverse(string str)
        {
           char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            this.str=new string(chars);
            Console.WriteLine(this.str);
        }

    }
}
