using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vreme
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class AGROMET
    {

        private AGROMETLocation locationField;

        private AGROMETDATA[] dATAField;

        /// <remarks/>
        public AGROMETLocation Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DATA")]
        public AGROMETDATA[] DATA
        {
            get
            {
                return this.dATAField;
            }
            set
            {
                this.dATAField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AGROMETLocation
    {

        private byte locationIDField;

        private string locationNameField;

        private byte locationAltitudeField;

        private string locationDescrField;

        private string timeFormatField;

        private string uRLField;

        /// <remarks/>
        public byte LocationID
        {
            get
            {
                return this.locationIDField;
            }
            set
            {
                this.locationIDField = value;
            }
        }

        /// <remarks/>
        public string LocationName
        {
            get
            {
                return this.locationNameField;
            }
            set
            {
                this.locationNameField = value;
            }
        }

        /// <remarks/>
        public byte LocationAltitude
        {
            get
            {
                return this.locationAltitudeField;
            }
            set
            {
                this.locationAltitudeField = value;
            }
        }

        /// <remarks/>
        public string LocationDescr
        {
            get
            {
                return this.locationDescrField;
            }
            set
            {
                this.locationDescrField = value;
            }
        }

        /// <remarks/>
        public string TimeFormat
        {
            get
            {
                return this.timeFormatField;
            }
            set
            {
                this.timeFormatField = value;
            }
        }

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class AGROMETDATA
    {

        private System.DateTime dateField;

        private byte measurementsField;

        private decimal temp2Field;

        private decimal temp2_MinField;

        private decimal temp2_MaxField;

        private byte humidity2Field;

        private byte humidity2_MinField;

        private byte humidity2_MaxField;

        private decimal precipitationField;

        private decimal precipitation_MinField;

        private decimal precipitation_MaxField;

        private byte leafwetness2Field;

        private byte leafwetness2_MinField;

        private byte leafwetness2_MaxField;

        /// <remarks/>
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public byte Measurements
        {
            get
            {
                return this.measurementsField;
            }
            set
            {
                this.measurementsField = value;
            }
        }

        /// <remarks/>
        public decimal Temp2
        {
            get
            {
                return this.temp2Field;
            }
            set
            {
                this.temp2Field = value;
            }
        }

        /// <remarks/>
        public decimal Temp2_Min
        {
            get
            {
                return this.temp2_MinField;
            }
            set
            {
                this.temp2_MinField = value;
            }
        }

        /// <remarks/>
        public decimal Temp2_Max
        {
            get
            {
                return this.temp2_MaxField;
            }
            set
            {
                this.temp2_MaxField = value;
            }
        }

        /// <remarks/>
        public byte Humidity2
        {
            get
            {
                return this.humidity2Field;
            }
            set
            {
                this.humidity2Field = value;
            }
        }

        /// <remarks/>
        public byte Humidity2_Min
        {
            get
            {
                return this.humidity2_MinField;
            }
            set
            {
                this.humidity2_MinField = value;
            }
        }

        /// <remarks/>
        public byte Humidity2_Max
        {
            get
            {
                return this.humidity2_MaxField;
            }
            set
            {
                this.humidity2_MaxField = value;
            }
        }

        /// <remarks/>
        public decimal Precipitation
        {
            get
            {
                return this.precipitationField;
            }
            set
            {
                this.precipitationField = value;
            }
        }

        /// <remarks/>
        public decimal Precipitation_Min
        {
            get
            {
                return this.precipitation_MinField;
            }
            set
            {
                this.precipitation_MinField = value;
            }
        }

        /// <remarks/>
        public decimal Precipitation_Max
        {
            get
            {
                return this.precipitation_MaxField;
            }
            set
            {
                this.precipitation_MaxField = value;
            }
        }

        /// <remarks/>
        public byte Leafwetness2
        {
            get
            {
                return this.leafwetness2Field;
            }
            set
            {
                this.leafwetness2Field = value;
            }
        }

        /// <remarks/>
        public byte Leafwetness2_Min
        {
            get
            {
                return this.leafwetness2_MinField;
            }
            set
            {
                this.leafwetness2_MinField = value;
            }
        }

        /// <remarks/>
        public byte Leafwetness2_Max
        {
            get
            {
                return this.leafwetness2_MaxField;
            }
            set
            {
                this.leafwetness2_MaxField = value;
            }
        }
    }


}
