using System;
using ProtoBuf;

namespace WinFormAppForTest
{
    [ProtoContract]
    public class Pilot
    {
        [ProtoMember(1)]
        public Guid Id { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }

        [ProtoMember(3)]
        public int Age { get; set; }
    }
}
