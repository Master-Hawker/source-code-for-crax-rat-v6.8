// Decompiled with JetBrains decompiler
// Type: Craxs_Rat.AsyncLock
// Assembly: CraxsRat, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 518449F5-7012-4EDA-9924-A26EC676C6A1
// Assembly location: C:\Users\HP\Downloads\CraxsRat v6.8 by TG @Hackfilter - Copy\CraxsRat VIP\CraxsRat_protected.exe

using Craxs_Rat.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace Craxs_Rat
{
  public class AsyncLock
  {
    private AsyncLock m_lock;

    public void Release() => ((MySettings) this).m_semaphore.Release();

    public AsyncLock(AsyncLock @lock) => this.m_lock = @lock;

    public void Dispose()
    {
      if (this.m_lock == null)
        return;
      this.m_lock.Release();
      this.m_lock = (AsyncLock) null;
    }

    private class Releaser : IDisposable
    {
      public int \u0024State;

      [CompilerGenerated]
      internal void MoveNext()
      {
        int state = this.\u0024State;
        int num;
        IDisposable disposable;
        try
        {
          TaskAwaiter taskAwaiter;
          if (state != 0)
          {
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            taskAwaiter = ((MySettings) ((AsyncLock.VB\u0024StateMachine_2_LockAsync) this).\u0024VB\u0024Me).m_semaphore.WaitAsync().GetAwaiter();
            if (!taskAwaiter.IsCompleted)
            {
              num = 0;
              this.\u0024State = 0;
              // ISSUE: reference to a compiler-generated field
              ((AsyncLock.VB\u0024StateMachine_2_LockAsync) this).\u0024A0 = taskAwaiter;
              // ISSUE: reference to a compiler-generated field
              ref AsyncTaskMethodBuilder<IDisposable> local1 = ref ((AsyncLock.VB\u0024StateMachine_2_LockAsync) this).\u0024Builder;
              ref TaskAwaiter local2 = ref taskAwaiter;
              // ISSUE: variable of a compiler-generated type
              AsyncLock.VB\u0024StateMachine_2_LockAsync machine2LockAsync = (AsyncLock.VB\u0024StateMachine_2_LockAsync) this;
              ref AsyncLock.VB\u0024StateMachine_2_LockAsync local3 = ref machine2LockAsync;
              local1.AwaitUnsafeOnCompleted<TaskAwaiter, AsyncLock.VB\u0024StateMachine_2_LockAsync>(ref local2, ref local3);
              return;
            }
          }
          else
          {
            num = -1;
            this.\u0024State = -1;
            // ISSUE: reference to a compiler-generated field
            taskAwaiter = ((AsyncLock.VB\u0024StateMachine_2_LockAsync) this).\u0024A0;
            // ISSUE: reference to a compiler-generated field
            ((AsyncLock.VB\u0024StateMachine_2_LockAsync) this).\u0024A0 = new TaskAwaiter();
          }
          taskAwaiter.GetResult();
          taskAwaiter = new TaskAwaiter();
          // ISSUE: reference to a compiler-generated field
          disposable = (IDisposable) new AsyncLock(((AsyncLock.VB\u0024StateMachine_2_LockAsync) this).\u0024VB\u0024Me);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          Exception exception = ex;
          this.\u0024State = -2;
          // ISSUE: reference to a compiler-generated field
          ((AsyncLock.VB\u0024StateMachine_2_LockAsync) this).\u0024Builder.SetException(exception);
          ProjectData.ClearProjectError();
          return;
        }
        num = -2;
        this.\u0024State = -2;
        // ISSUE: reference to a compiler-generated field
        ((AsyncLock.VB\u0024StateMachine_2_LockAsync) this).\u0024Builder.SetResult(disposable);
      }
    }
  }
}
