namespace indice.Edi
{
    public interface ICustomGrammerProperties
    {
        char SegmentNameDelimiter {get; set;}
        char ComponentDataElementSeparator {get; set;}
        char DataElementSeparator {get; set;}
        char? DecimalMark {get; set;}
        char? ReleaseCharacter {get; set;}
        char[] Reserved {get; set;}
        char SegmentTerminator {get; set;}
        char[] Separators {get; set;}

        string ServiceStringAdviceTag {get; set;}
        string InterchangeHeaderTag {get; set;}
        string FunctionalGroupHeaderTag {get; set;}
        string MessageHeaderTag {get; set;}
        string MessageTrailerTag {get; set;}
        string FunctionalGroupTrailerTag {get; set;}
        string InterchangeTrailerTag { get; set; }
    }
}
