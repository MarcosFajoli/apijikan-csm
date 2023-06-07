using Newtonsoft.Json;

namespace apijikan_csm
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

    public class Anime
    {
        [JsonProperty("mal_id")]
        public int? MalId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("approved")]
        public bool? Approved { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("title_english")]
        public string? TitleEnglish { get; set; }

        [JsonProperty("title_japanese")]
        public string TitleJapanese { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("episodes")]
        public int? Episodes { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("airing")]
        public bool? Airing { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("score")]
        public double? Score { get; set; }

        [JsonProperty("scored_by")]
        public int? ScoredBy { get; set; }

        [JsonProperty("rank")]
        public int? Rank { get; set; }

        [JsonProperty("popularity")]
        public int? Popularity { get; set; }

        [JsonProperty("members")]
        public int? Members { get; set; }

        [JsonProperty("favorites")]
        public int? Favorites { get; set; }

        [JsonProperty("synopsis")]
        public string Synopsis { get; set; }

        [JsonProperty("background")]
        public object Background { get; set; }

        [JsonProperty("season")]
        public object Season { get; set; }

        [JsonProperty("year")]
        public object Year { get; set; }
    }


    public class Pagination
    {
        [JsonProperty("last_visible_page")]
        public int? LastVisiblePage { get; set; }

        [JsonProperty("has_next_page")]
        public bool? HasNextPage { get; set; }

        [JsonProperty("current_page")]
        public int? CurrentPage { get; set; }
    }

    public class ApiResponse
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("data")]
        public List<Anime> Data { get; set; }
    }

}
