using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityQueryable
{
    class Program
    {
        static void Main(string[] args)
        {

            var terraPlaces = new QueryableTerraServerData<Place>();

            var query = from place in terraPlaces
                        where place.Name == "place1"
                        select place.PlaceType;

            foreach (PlaceType placeType in query)
                Console.WriteLine(placeType);

        }
    }


    
}
