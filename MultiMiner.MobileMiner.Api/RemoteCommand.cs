﻿using System;

namespace MultiMiner.MobileMiner.Api
{
    public class RemoteCommand
    {
        public int Id { get; set; }
        public string CommandText { get; set; }
        public DateTime CommandDate { get; set; }
    }
}
