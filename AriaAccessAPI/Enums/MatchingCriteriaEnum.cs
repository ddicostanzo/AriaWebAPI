using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriaWebAPI.AriaAccessAPI.Enums
{
    /// <summary>
    /// Enum representing the matching criteria for patient records.
    /// </summary>
    public enum MatchingCriteria
    {
        ExactMatchOnAll,
        ExactMatchOnPatientID1, 
        LikeMatchOnAll
    }
}
