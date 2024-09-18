using Singleton;

SingletonBase singleton1 = ClassicSingletonLogger.GetInstance();
SingletonBase singleton2 = ClassicSingletonLogger.GetInstance();

if(singleton1 == singleton2)
{
    Console.WriteLine("Same instance, Classic Singleton implemented");
}

singleton1.Log("This message logged using singleton logging message");

SingletonBase singleton3 = ThreadSafeSingletonLogger.GetInstance();
SingletonBase singleton4 = ThreadSafeSingletonLogger.GetInstance();

if (singleton3 == singleton4)
{
    Console.WriteLine("\nSame instance, Thread Safe Singleton implemented");
}

singleton3.Log("This message logged using singleton logging message");

SingletonBase singleton5 = LazySingletonLogger.GetInstance();
SingletonBase singleton6 = LazySingletonLogger.GetInstance();

if (singleton5 == singleton6)
{
    Console.WriteLine("\nSame instance, Lazy Singleton implemented");
}

singleton5.Log("This message logged using singleton logging message");

SingletonBase singleton7 = StaticSingletonLogger.GetInstance();
SingletonBase singleton8 = StaticSingletonLogger.GetInstance();

if (singleton7 == singleton8)
{
    Console.WriteLine("\nSame instance, Static Singleton implemented");
}

singleton7.Log("This message logged using singleton logging message");
