using ModularPipelines.Context;

namespace ModularPipelines.Requirements;

public interface IPipelineRequirement
{
    Task<bool> MustAsync(IModuleContext context);
}