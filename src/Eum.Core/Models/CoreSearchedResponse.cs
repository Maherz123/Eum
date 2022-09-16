using Eum.Core.Contracts;
using Eum.Core.Contracts.Models;

namespace Eum.Core.Models;

public sealed class CoreSearchedResponse : ICoreResponse
{
    public PaginatedWrapper<IArtist>? Artists { get; init; }
    public bool IsError => false;
}