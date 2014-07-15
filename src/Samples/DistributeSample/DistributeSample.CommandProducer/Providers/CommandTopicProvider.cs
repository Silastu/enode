﻿using System.Threading;
using ENode.Commanding;
using ENode.EQueue;

namespace DistributeSample.CommandProducer.Providers
{
    public class CommandTopicProvider : AbstractTopicProvider<ICommand>
    {
        static int _index;
        public override string GetTopic(ICommand command)
        {
            if (Interlocked.Increment(ref _index) % 2 == 0)
            {
                return "NoteCommandTopic2";
            }
            else
            {
                return "NoteCommandTopic1";
            }
        }
    }
}
