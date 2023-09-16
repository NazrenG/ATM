using Task_cs;

Console.WriteLine("Enter string");
var str = Console.ReadLine();
MyClass cls = new MyClass(str);
Func funcDell = new (cls.Reverse); 	
funcDell += cls.Space;
Run run = new Run();
run.runFunc(funcDell, str); 