﻿using System;

namespace Excubo.Blazor.Diagrams
{
    public class LinkData
    {
        public NodeAnchor Source { get; set; }
        public NodeAnchor Target { get; set; }
        internal Action<LinkBase> OnCreate { get; set; }
    }
}
