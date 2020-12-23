using ConferencePlanner.GraphQL.Common;
using ConferencePlanner.GraphQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferencePlanner.GraphQL.Speakers
{
    public class AddSpeakerPayload : SpeakerPayloadBase
    {
        public AddSpeakerPayload(Speaker speaker)
            : base(speaker)
        {
        }

        public AddSpeakerPayload(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }
    }
}
