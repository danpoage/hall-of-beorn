using System;

namespace HallOfBeorn.Models.LotR.Community.FlyingSolo
{
    public class FlyingSoloChannel
        : Creator
    {
        public FlyingSoloChannel()
            : base("Flying Solo", "https://www.youtube.com/watch?v=S3rWajCjCdI", "https://www.youtube.com/watch?v=S3rWajCjCdI", LinkType.YouTube)
        {
            AddYear(2022);
            AddLink("LOTR Progression 19: Into Ithilien", "https://www.youtube.com/watch?v=S3rWajCjCdI", "2022-09-19")
                .WithLabels("Progression", "Into Ithilien");
        }
    }
}