using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating a PhotoProcessor
            var processor = new PhotoProcessor();
            //instantiating a PhotoFilters
            var filters = new PhotoFilters();

            //instantiating the delegate defined inside "PhotoProcessor"
            //and pointing it to "ApplyBrigthness()" from "filters"
            Action<Photo> filterHandler = filters.ApplyBrightness;
            //NOTE: HOW TO ADD MULTIPLE METHODS TO A DELEGATE
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            //passing params as per Method definition
            //this will apply all methods associated with the delegate
            processor.Process("photo.jpg", filterHandler);

        }

        //NOTE: we are using the same method signature as defined by the delegate
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Red eye filter");
        }
    }
}
