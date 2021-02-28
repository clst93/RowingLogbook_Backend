using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RowingLookbook_backend.Models
{
    public class Tour
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TourID
        {
            get; set;
        }
        public int BoatID
        {
            get; set;
        }
        public string TourStartplace
        {
            get; set;
        }
        public string TourStopplace
        {
            get; set;
        }
        public int BoatDriverID
        {
            get; set;
        }
        public string MemberOne
        {
            get; set;
        }
        public string MemberTwo
        {
            get; set;
        }
        public string MemberThree
        {
            get; set;
        }
        public string MemberFour
        {
            get; set;
        }
        public string MemberFive
        {
            get; set;
        }
        public string MemberSix
        {
            get; set;
        }
        public string MemberSeven
        {
            get; set;
        }
        public string MemberEight
        {
            get; set;
        }
        public string MemberNine
        {
            get; set;
        }
    }
}
