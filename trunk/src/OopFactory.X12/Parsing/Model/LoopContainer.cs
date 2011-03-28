﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OopFactory.X12.Parsing.Specification;

namespace OopFactory.X12.Parsing.Model
{
    public abstract class LoopContainer : Container
    {
        private List<Loop> _loops;

        internal LoopContainer(Container parent, X12DelimiterSet delimiters, string startingSegment)
            : base(parent, delimiters, startingSegment)
        {
        }

        internal override void Initialize(string segment)
        {
            base.Initialize(segment);
            _loops = new List<Loop>();
        }

        internal abstract IList<LoopSpecification> AllowedChildLoops { get; }

        public IEnumerable<Loop> Loops { get { return _loops; } }

        public Loop AddLoop(string segmentString, LoopSpecification loopSpecification)
        {
            var loop = new Loop(this, _delimiters, segmentString, loopSpecification);
            _loops.Add(loop);
            return loop;
        }

        internal LoopSpecification GetLoopSpecification(string segmentString)
        {
            Segment segment = new Segment(this, _delimiters, segmentString);

            IList<LoopSpecification> matchingLoopSpecs = ((LoopContainer)this).AllowedChildLoops
                        .Where(cl => cl.StartingSegment.SegmentSpecification.SegmentId == segment.SegmentId).ToList();

            if (matchingLoopSpecs == null || matchingLoopSpecs.Count == 0)
            {
                return null;
            }
            else if (segment.SegmentId == "NM1" || segment.SegmentId == "N1")
            {
                return matchingLoopSpecs.Where(ls => ls.StartingSegment.EntityIdentifiers.Any(ei => ei.Code.ToString() == segment.DataElements[0] || ei.Code.ToString() == "Item" + segment.DataElements[0])).FirstOrDefault();
            }
            else
            {
                return matchingLoopSpecs.FirstOrDefault();
            }
        }
    }
}
