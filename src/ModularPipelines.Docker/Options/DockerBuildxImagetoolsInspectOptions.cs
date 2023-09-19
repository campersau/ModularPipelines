using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Docker.Options;

[CommandPrecedingArguments("buildx imagetools inspect")]
[ExcludeFromCodeCoverage]
public record DockerBuildxImagetoolsInspectOptions([property: PositionalArgument(Position = Position.AfterSwitches)] string Name) : DockerOptions
{
    [CommandSwitch("--format")]
    public string? Format { get; set; }

    [BooleanCommandSwitch("--raw")]
    public bool? Raw { get; set; }

    [CommandSwitch("--builder")]
    public string? Builder { get; set; }
}
