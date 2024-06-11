using System.Runtime.CompilerServices;

public class CustomTaskMethodBuilder
{
    private TaskCompletionSource<object?> _tcs = new TaskCompletionSource<object?>();

    public static CustomTaskMethodBuilder Create() => new CustomTaskMethodBuilder();

    public CustomTask Task => new CustomTask();

    public void SetResult() => _tcs.SetResult(null);

    public void SetException(Exception exception) => _tcs.SetException(exception);

    public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
        where TAwaiter : INotifyCompletion
        where TStateMachine : IAsyncStateMachine
    {
        awaiter.OnCompleted(stateMachine.MoveNext);
    }

    public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
        where TAwaiter : ICriticalNotifyCompletion
        where TStateMachine : IAsyncStateMachine
    {
        awaiter.OnCompleted(stateMachine.MoveNext);
    }

    public void Start<TStateMachine>(ref TStateMachine stateMachine)
        where TStateMachine : IAsyncStateMachine
    {
        stateMachine.MoveNext();
    }

    public void SetStateMachine(IAsyncStateMachine stateMachine) { }
}