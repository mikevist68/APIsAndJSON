using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) 
            {
                RonVSKanyeAPI.Kanye();
                RonVSKanyeAPI.Ron();

                
            }
            OpenWeatherMapAPI.Weather();
        }

    
    }
}
