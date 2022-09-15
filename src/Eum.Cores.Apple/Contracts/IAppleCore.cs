using Eum.Core.Contracts;
using Eum.Cores.Apple.Contracts.Clients;
using Eum.Cores.Apple.Models;

namespace Eum.Cores.Apple.Contracts;

/// <summary>
/// A object that can be used to communicate with Apple's music service. <br/>
/// There are 2 types of calls that can be made: <br/>
///     1) Calls that require a developer token only
///     2) Calls that require both a developer token, and a media access token.
/// </summary>
public interface IAppleCore : IMusicCore
{
    IStoreFrontProvider StoreFrontProvider { get; }
    IReadOnlyDictionary<TokenType, TokenData> Tokens { get; }
    IArtists ArtistsClient { get; }
    IStoreFronts StoreFrontClient { get; }
    ISearch SearchClient { get; }
}