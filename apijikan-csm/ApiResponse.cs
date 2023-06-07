using Newtonsoft.Json;

namespace apijikan_csm
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Aired
    {
        [JsonProperty("from")]
        public DateTime? From { get; set; }

        [JsonProperty("to")]
        public object To { get; set; }

        [JsonProperty("prop")]
        public Prop Prop { get; set; }

        [JsonProperty("string")]
        public string String { get; set; }
    }

    public class Broadcast
    {
        [JsonProperty("day")]
        public object Day { get; set; }

        [JsonProperty("time")]
        public object Time { get; set; }

        [JsonProperty("timezone")]
        public object Timezone { get; set; }

        [JsonProperty("string")]
        public object String { get; set; }
    }

    public class Anime
    {
        [JsonProperty("mal_id")]
        public int? MalId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("images")]
        public Images Images { get; set; }

        [JsonProperty("trailer")]
        public Trailer Trailer { get; set; }

        [JsonProperty("approved")]
        public bool? Approved { get; set; }

        [JsonProperty("titles")]
        public List<Title> Titles { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("title_english")]
        public object TitleEnglish { get; set; }

        [JsonProperty("title_japanese")]
        public string TitleJapanese { get; set; }

        [JsonProperty("title_synonyms")]
        public List<object> TitleSynonyms { get; set; }

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

        [JsonProperty("aired")]
        public Aired Aired { get; set; }

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

        [JsonProperty("broadcast")]
        public Broadcast Broadcast { get; set; }

        [JsonProperty("producers")]
        public List<Producer> Producers { get; set; }

        [JsonProperty("licensors")]
        public List<object> Licensors { get; set; }

        [JsonProperty("studios")]
        public List<object> Studios { get; set; }

        [JsonProperty("genres")]
        public List<Genre> Genres { get; set; }

        [JsonProperty("explicit_genres")]
        public List<object> ExplicitGenres { get; set; }

        [JsonProperty("themes")]
        public List<object> Themes { get; set; }

        [JsonProperty("demographics")]
        public List<Demographic> Demographics { get; set; }
    }

    public class Demographic
    {
        [JsonProperty("mal_id")]
        public int? MalId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class From
    {
        [JsonProperty("day")]
        public int? Day { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("year")]
        public int? Year { get; set; }
    }

    public class Genre
    {
        [JsonProperty("mal_id")]
        public int? MalId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Images
    {
        [JsonProperty("jpg")]
        public Jpg Jpg { get; set; }

        [JsonProperty("webp")]
        public Webp Webp { get; set; }

        [JsonProperty("image_url")]
        public object ImageUrl { get; set; }

        [JsonProperty("small_image_url")]
        public object SmallImageUrl { get; set; }

        [JsonProperty("medium_image_url")]
        public object MediumImageUrl { get; set; }

        [JsonProperty("large_image_url")]
        public object LargeImageUrl { get; set; }

        [JsonProperty("maximum_image_url")]
        public object MaximumImageUrl { get; set; }
    }

    public class Items
    {
        [JsonProperty("count")]
        public int? Count { get; set; }

        [JsonProperty("total")]
        public int? Total { get; set; }

        [JsonProperty("per_page")]
        public int? PerPage { get; set; }
    }

    public class Jpg
    {
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("small_image_url")]
        public string SmallImageUrl { get; set; }

        [JsonProperty("large_image_url")]
        public string LargeImageUrl { get; set; }
    }

    public class Pagination
    {
        [JsonProperty("last_visible_page")]
        public int? LastVisiblePage { get; set; }

        [JsonProperty("has_next_page")]
        public bool? HasNextPage { get; set; }

        [JsonProperty("current_page")]
        public int? CurrentPage { get; set; }

        [JsonProperty("items")]
        public Items Items { get; set; }
    }

    public class Producer
    {
        [JsonProperty("mal_id")]
        public int? MalId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Prop
    {
        [JsonProperty("from")]
        public From From { get; set; }

        [JsonProperty("to")]
        public To To { get; set; }
    }

    public class ApiResponse
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("data")]
        public List<Anime> Data { get; set; }
    }

    public class Title
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title_title { get; set; }
    }

    public class To
    {
        [JsonProperty("day")]
        public object Day { get; set; }

        [JsonProperty("month")]
        public object Month { get; set; }

        [JsonProperty("year")]
        public object Year { get; set; }
    }

    public class Trailer
    {
        [JsonProperty("youtube_id")]
        public object YoutubeId { get; set; }

        [JsonProperty("url")]
        public object Url { get; set; }

        [JsonProperty("embed_url")]
        public object EmbedUrl { get; set; }

        [JsonProperty("images")]
        public Images Images { get; set; }
    }

    public class Webp
    {
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("small_image_url")]
        public string SmallImageUrl { get; set; }

        [JsonProperty("large_image_url")]
        public string LargeImageUrl { get; set; }
    }

}
