﻿using Microsoft.Extensions.Logging;
using ModularPipelines.Context;
using ModularPipelines.Models;
using ModularPipelines.Modules;

namespace ModularPipelines.Examples;

public class SubmodulesModule : Module
{
    protected override async Task<ModuleResult<IDictionary<string, object>>?> ExecuteAsync(IModuleContext context, CancellationToken cancellationToken)
    {
        foreach (var c in Guid.NewGuid().ToString())
        {
            await SubModule(c.ToString(), async () =>
            {
                context.Logger.LogInformation("{Submodule}", c.ToString());
                await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken);
            });
        }

        return new Dictionary<string, object>();
    }
}