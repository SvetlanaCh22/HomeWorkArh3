public interface Worker
{
    void work();
    void eat();
}

public interface Robot
{
    void work();
}

public class HumanWorker : Worker
{
    public void work()
    {
        Console.WriteLine("Человек работает");
    }

    public void eat()
    {
        Console.WriteLine("Человек ест");
    }
}

public class RobotWorker : Robot
{
    public void work()
    {
        Console.WriteLine("Робот работает");
    }

}

public class Work
{
    public static void Main(String[] args)
    {
        Robot worker = new RobotWorker();
        worker.work();
    }
}