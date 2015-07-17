﻿using Newtonsoft.Json;

namespace Inklewriter.Runtime
{
    public class Error : Runtime.Object
    {
        [JsonProperty("error")]
        [UniqueJsonIdentifier]
        public string message;

        [JsonProperty("endLine")]
        public bool useEndLineNumber;

        public Error (string message)
        {
            this.message = message;
        }

        // Require default constructor for serialisation
        public Error() : this(null) {}

        public override string ToString ()
        {
            return string.Format("Error: '{0}'", this.message);
        }
    }
}

