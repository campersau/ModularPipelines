using System.Diagnostics.CodeAnalysis;
using ModularPipelines.Attributes;

namespace ModularPipelines.Docker.Options;

[CommandPrecedingArguments("image save")]
[ExcludeFromCodeCoverage]
public record DockerImageSaveOptions([property: PositionalArgument(Position = Position.AfterArguments)] IEnumerable<string> Images) : DockerOptions;
