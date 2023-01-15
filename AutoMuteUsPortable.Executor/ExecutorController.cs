using System.Reactive.Subjects;
using AutoMuteUsPortable.Shared.Controller.Executor;
using AutoMuteUsPortable.Shared.Entity.ExecutorConfigurationBaseNS;
using AutoMuteUsPortable.Shared.Entity.ExecutorConfigurationNS;
using AutoMuteUsPortable.Shared.Entity.ProgressInfo;

namespace AutoMuteUsPortable.Executor;

public class ExecutorController : ExecutorControllerBase
{
    public new readonly ExecutorConfiguration ExecutorConfiguration;

    public ExecutorController(object executorConfiguration) : base(executorConfiguration)
    {
        throw new NotImplementedException();
    }

    public ExecutorController(object computedSimpleSettings,
        object executorConfigurationBase) : base(computedSimpleSettings, executorConfigurationBase)
    {
        throw new NotImplementedException();
    }

    public override async Task Run(ISubject<ProgressInfo>? progress = null)
    {
        throw new NotImplementedException();
    }

    public override async Task Stop(ISubject<ProgressInfo>? progress = null)
    {
        throw new NotImplementedException();
    }

    public override async Task Restart(ISubject<ProgressInfo>? progress = null)
    {
        throw new NotImplementedException();
    }

    public override async Task Install(
        Dictionary<ExecutorType, ExecutorControllerBase> executors, ISubject<ProgressInfo>? progress = null)
    {
        throw new NotImplementedException();
    }

    public override async Task Update(
        Dictionary<ExecutorType, ExecutorControllerBase> executors, object oldExecutorConfiguration,
        ISubject<ProgressInfo>? progress = null)
    {
        throw new NotImplementedException();
    }
}