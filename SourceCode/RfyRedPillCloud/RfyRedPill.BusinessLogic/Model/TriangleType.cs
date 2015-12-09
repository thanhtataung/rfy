
using System.Runtime.Serialization;


namespace RfyRedPill.BusinessLogic.Model
{
    [DataContract(Name = "TriangleType", Namespace = "http://KnockKnock.readify.net")]
    public enum TriangleType 
    {
        [EnumMember]
        Error,
        [EnumMember]
        Equilateral,
        [EnumMember]
        Isosceles,
        [EnumMember]
        Scalene
    }
}
