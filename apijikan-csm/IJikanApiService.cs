﻿using Refit;


namespace apijikan_csm
{
    internal interface IJikanApiService
    {
        [Get("/anime")]
        Task<ApiResponse> SearchAnime([AliasAs("q")] string busca, [AliasAs("limit")] int limit = 25);
    }
}
