﻿using ModularPipelines.Attributes;

namespace ModularPipelines.Build.Settings;

public record GitHubSettings
{
    [SecretValue]
    public string? TokenWithTriggerBuild { get; init; }
    
    [SecretValue]
    public string? TokenWithoutTriggerBuild { get; init; }
    public GitHubPullRequest? PullRequest { get; init; }
    public GitHubRepository? Repository { get; init; }
}

public record GitHubRepository
{
    public long? Id { get; init; }
}

public record GitHubPullRequest
{
    public int? Number { get; init; }
    public string? Branch { get; init; }
    public string? Author { get; init; }
}