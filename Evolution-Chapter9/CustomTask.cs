using System.Runtime.CompilerServices;

[AsyncMethodBuilder(typeof(CustomTaskMethodBuilder))]
public class CustomTask
{
    public CustomTaskAwaiter GetAwaiter() => new CustomTaskAwaiter();

    public class CustomTaskAwaiter : INotifyCompletion
    {
        public bool IsCompleted => true;

        public void GetResult() { }

        public void OnCompleted(Action continuation) => continuation();
    }
}