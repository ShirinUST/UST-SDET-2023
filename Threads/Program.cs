/*
class ThreadExample
{
    static void Main()
{
    // Create two threads
    Thread thread1 = new Thread(T1);
    Thread thread2 = new Thread(T1);

    // Start the threads
    thread1.Start();
    thread2.Start();

    // Wait for the threads to finish
    thread1.Join();
    thread2.Join();

    Console.WriteLine("Both threads have completed their work.");
}

static void T1()
{
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId + " is working: " + i);
        Thread.Sleep(1000); // Simulate some work
    }
}
}
*/

using Threads;

/*
class Program
{
    static void Main()
    {
        WareHouse warehouse = new WareHouse();

        Thread worker1 = new Thread(() => warehouse.AddBox(1));
        Thread worker2 = new Thread(() => warehouse.AddBox(2));

        worker1.Start();
        worker2.Start();

        worker1.Join();
        worker2.Join();

        Console.WriteLine("Work completed. Total boxes in the warehouse: " + warehouse.GetTotalBoxes());
    }
}
*/
class Program
{
    static void Main()
    {
        CourseRegistration course = new CourseRegistration();
        int numberOfStudents = 5;

        List<Thread> studentThreads = new List<Thread>();

        for (int i = 1; i <= numberOfStudents; i++)
        {
            string studentName = $"Student {i}";
            Thread studentThread = new Thread(() => course.RegisterStudent(studentName));
            studentThreads.Add(studentThread);
            studentThread.Start();
        }

        foreach (Thread studentThread in studentThreads)
        {
            studentThread.Join();
        }

        Console.WriteLine($"Course registration completed. Total registered students: {course.GetRegisteredStudentCount()}");
    }
}