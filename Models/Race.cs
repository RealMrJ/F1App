public class Circuit
{
    public string circuitId { get; set; }
    public string url { get; set; }
    public string circuitName { get; set; }
    public Location Location { get; set; }
}

public class Location
{
    public string lat { get; set; }
    public string @long { get; set; }
    public string locality { get; set; }
    public string country { get; set; }
}

public class RaceMRData
{
    public string xmlns { get; set; }
    public string series { get; set; }
    public string url { get; set; }
    public string limit { get; set; }
    public string offset { get; set; }
    public string total { get; set; }
    public RaceTable RaceTable { get; set; }
}

public class Race
{
    public string season { get; set; }
    public string round { get; set; }
    public string url { get; set; }
    public string raceName { get; set; }
    public Circuit Circuit { get; set; }
    public string date { get; set; }
}

public class RaceTable
{
    public string season { get; set; }
    public List<Race> Races { get; set; }
}

public class RaceRoot
{
    public RaceMRData MRData { get; set; }
}