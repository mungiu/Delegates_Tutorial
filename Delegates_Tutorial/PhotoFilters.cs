using System;

namespace Delegates_Tutorial
{
    internal class PhotoFilters
    {
        public PhotoFilters()
        {
        }

        internal void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Brithness");
        }

        internal void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Contrast");
        }

        internal void Resize(Photo photo)
        {
            Console.WriteLine("Resized");
        }
    }
}