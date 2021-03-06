﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.SharedSource.CognitiveServices.Models.Vision.Video
{
    public class MotionDetectionEvent
    {
        public int Type { get; set; }
        public string TypeName { get; set; }
        public List<FragmentLocation> Locations { get; set; }
        public int RegionId { get; set; }
    }
}