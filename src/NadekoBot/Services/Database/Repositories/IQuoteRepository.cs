﻿using NadekoBot.Services.Database.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NadekoBot.Services.Database.Repositories
{
    public interface IQuoteRepository : IRepository<Quote>
    {
        IEnumerable<Quote> GetAllQuotesByKeyword(ulong guildId, string keyword);
        Task<Quote> GetRandomQuoteByKeywordAsync(ulong guildId, string keyword);
        Task<Quote> SearchQuoteKeywordTextAsync(ulong guildId, string keyword, string text);
        IEnumerable<Quote> GetGroup(ulong guildId, int skip, int take);
    }
}
