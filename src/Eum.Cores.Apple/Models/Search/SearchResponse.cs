﻿using System.ComponentModel.DataAnnotations;
using Eum.Cores.Apple.Models.Search;

namespace Eum.Connections.Apple.Models.Search;
/// <summary>
/// The response to a search request.
/// </summary>
public sealed class SearchResponse
{
    /// <summary>
    /// (Required) The results included in the response to a search request.
    /// </summary>
    [Required]
    public SearchResults Results
    {
        get;
        init;
    } = null!;
}
