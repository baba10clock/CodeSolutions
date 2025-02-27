public class Codec {
    private Dictionary<string, string> encodeMap = new Dictionary<string, string>();
    private Dictionary<string, string> decodeMap = new Dictionary<string, string>();
    private string baseUrl = "https://AnyUrl.com";
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        if(!encodeMap.ContainsKey(longUrl))
        {
            string shortUrl = baseUrl + (encodeMap.Count + 1).ToString();
            encodeMap[longUrl] = shortUrl;
            decodeMap[shortUrl] = longUrl;
        }
        return encodeMap[longUrl];
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        return decodeMap[shortUrl];
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));