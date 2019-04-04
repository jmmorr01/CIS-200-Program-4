// Grading ID C2937
// Program 4
// Section 200-01
// Due 11/27/12
// Description: This class is used to compare parcels and put them in descending order based on zip code.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1
{
    class ZipOrder : IComparer<Parcel>
    {
        public int Compare(Parcel parcelOne, Parcel parcelTwo)
        {
            if (parcelOne == null && parcelTwo == null)
                return 0;
            if (parcelOne == null)
                return -1;

            return parcelTwo.DestinationAddress.Zip.CompareTo(parcelOne.DestinationAddress.Zip);
        }
    }
}
