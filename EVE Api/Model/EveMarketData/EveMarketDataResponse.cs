﻿using System.Xml.Serialization;

namespace eZet.Eve.EveLib.Model.EveMarketData {
    [XmlRoot("emd", Namespace = "", IsNullable = false)]
    public class EveMarketDataResponse<T> {
        [XmlElement("currentTime")]
        public string CurrentTime { get; set; }

        [XmlAttribute("version")]
        public int Version { get; set; }

        [XmlElement("result")]
        public T Result { get; set; }
    }
}