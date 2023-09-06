using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Docker.Options;

[CommandPrecedingArguments("swarm join-token")]
[ExcludeFromCodeCoverage]
public record DockerSwarmJoinTokenOptions : DockerOptions
{
    [BooleanCommandSwitch("--quiet")]
    public bool? Quiet { get; set; }

    [CommandSwitch("--rotate")]
    public string? Rotate { get; set; }
}
