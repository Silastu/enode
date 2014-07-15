﻿using System.Threading;
using ENode.EQueue;
using ENode.Eventing;

namespace DistributeSample.CommandProcessor.Providers
{
    public class EventTopicProvider : AbstractTopicProvider<EventStream>
    {
        static int _index;
        public override string GetTopic(EventStream eventStream)
        {
            if (Interlocked.Increment(ref _index) % 2 == 0)
            {
                return "NoteEventTopic2";
            }
            else
            {
                return "NoteEventTopic1";
            }
        }
    }
}
