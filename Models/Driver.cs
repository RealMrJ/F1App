public class Driver
{
    public string driverId { get; set; }
    public string url { get; set; }
    public string givenName { get; set; }
    public string familyName { get; set; }
    public string dateOfBirth { get; set; }
    public string nationality { get; set; }
    public string permanentNumber { get; set; }
    public string code { get; set; }
}

public class DriverTable
{
    public string season { get; set; }
    public List<Driver> Drivers { get; set; }
}

public class DriverMRData
{
    public string xmlns { get; set; }
    public string series { get; set; }
    public string url { get; set; }
    public string limit { get; set; }
    public string offset { get; set; }
    public string total { get; set; }
    public DriverTable DriverTable { get; set; }
}

public class DriverRoot
{
    public DriverMRData MRData { get; set; }
}
