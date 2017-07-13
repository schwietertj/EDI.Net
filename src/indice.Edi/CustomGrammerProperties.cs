using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indice.Edi
{
    public class CustomGrammerProperties : ICustomGrammerProperties
    {
        public CustomGrammerProperties() {
            SegmentNameDelimiter = '*';
            ComponentDataElementSeparator = '>';
            DataElementSeparator = '*';
            DecimalMark = '.';
            ReleaseCharacter = null;
            Reserved = new char[0];
            SegmentTerminator = '~';
            ServiceStringAdviceTag = null;
            InterchangeHeaderTag = "ISA";
            FunctionalGroupHeaderTag = "GS";
            MessageHeaderTag = "ST";
            MessageTrailerTag = "SE";
            FunctionalGroupTrailerTag = "GE";
            InterchangeTrailerTag = "IEA";
        }

        public char SegmentNameDelimiter { get; set; }
        public char ComponentDataElementSeparator { get; set; }
        public char DataElementSeparator { get; set; }
        public char? DecimalMark { get; set; }
        public char? ReleaseCharacter { get; set; }
        public char[] Reserved { get; set; }
        public char SegmentTerminator { get; set; }
        public char[] Separators { get; set; }
        public string ServiceStringAdviceTag { get; set; }
        public string InterchangeHeaderTag { get; set; }
        public string FunctionalGroupHeaderTag { get; set; }
        public string MessageHeaderTag { get; set; }
        public string MessageTrailerTag { get; set; }
        public string FunctionalGroupTrailerTag { get; set; }
        public string InterchangeTrailerTag { get; set; }
    }
}
