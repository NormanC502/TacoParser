namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                logger.LogInfo("Array length is less than 3.");         // Log that and return null
                                                                        // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }
            double longitude;

            double latitude;

            string name;
            // grab the longitude from your array at index 1
            double.TryParse(cells[1], out longitude);

            // grab the latitude from your array at index 0
            double.TryParse(cells[0], out latitude);

            // grab the name from your array at index 2
            name = cells[2];

            // Then, you'll need an instance of the TacoBell class
            var taco = new TacoBell();

            // With the name and point set correctly
            taco.Name = name;
            // With the name and point set correctly
            var point = new Point();
            // With the name and point set correctly
            point.Longitude = longitude;
            // With the name and point set correctly
            point.Latitude = latitude;
            // With the name and point set correctly
            taco.Location = point;



            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

            // You'll need to create a TacoBell class                  CREATED TacoBell1.cs
            // that conforms to ITrackable                             Inherited for Itrackable and refactored



            // Then, return the instance of your TacoBell class
            return taco;
            // Since it conforms to ITrackable
        }
    }
}