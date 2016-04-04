using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfCore.Web.Models
{
    public class Talk
    {
        public int  Id { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public Tracks Track { get; set; }
        public string Tags { get; set; }

        public TalkStatus Status { get; set; }
    }

    public enum Tracks
    {
        Developer,
        Database,
        PowerShell,
        ProfessionDevelopment
    }
    public enum TalkStatus
    {
        Pending,
        InReview,
        AttendeeReview,
        Approved,
        Declined    
    }
}
