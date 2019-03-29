using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Entities
{
    [Serializable]
    [XmlType]
    [DataContract]
    public class Questions:EntityBase
    {
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string Answer { get; set; }
        public string Explanation { get; set; }
    }
}

