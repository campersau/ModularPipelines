using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;
using ModularPipelines.Models;

namespace ModularPipelines.Docker.Options;

[CommandPrecedingArguments("scout", "policy")]
[ExcludeFromCodeCoverage]
public record DockerScoutPolicyOptions : DockerOptions
{
    [CommandSwitch("--env")]
    public string? Env { get; set; }

    [CommandSwitch("--exit-code")]
    public string? ExitCode { get; set; }

    [CommandSwitch("--org")]
    public string? Org { get; set; }

    [CommandSwitch("--output")]
    public string? Output { get; set; }

    [CommandSwitch("--platform")]
    public string? Platform { get; set; }

    [CommandSwitch("--to-env")]
    public string? ToEnv { get; set; }

    [CommandSwitch("--to-latest")]
    public string? ToLatest { get; set; }
}
