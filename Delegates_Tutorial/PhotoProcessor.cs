using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Tutorial
{
    class PhotoProcessor
    {
        //// CUSTOMER delegate to functions with this signature: 
        //// Type: void  + Take param of type: Photo
        //public delegate void PhotoFilterHandler(Photo photo);


        //passing a delagate to the method
        public void Process(string path, Action<Photo> filterHandler)
        {
            //System.Action<> AKA void
            //System.Func<>   AKA return

            var photo = Photo.Load(path);

            /*passing the photo object to the delegate
              this code does not know which method to apply
              the client(developer) using this code should define the method
              which makes it extensible*/
            filterHandler(photo);

            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);

            photo.Save();
        }
    }
}
