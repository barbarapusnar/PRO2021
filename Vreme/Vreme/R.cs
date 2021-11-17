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
    public partial class IzdaniRacunEnostavni
    {

        private IzdaniRacunEnostavniRacun racunField;

        private Signature signatureField;

        /// <remarks/>
        public IzdaniRacunEnostavniRacun Racun
        {
            get
            {
                return this.racunField;
            }
            set
            {
                this.racunField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public Signature Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacun
    {

        private IzdaniRacunEnostavniRacunGlavaRacuna glavaRacunaField;

        private IzdaniRacunEnostavniRacunPlacilniPogoji placilniPogojiField;

        private IzdaniRacunEnostavniRacunDatumiRacuna[] datumiRacunaField;

        private IzdaniRacunEnostavniRacunLokacije lokacijeField;

        private IzdaniRacunEnostavniRacunPoljubnoBesedilo[] poljubnoBesediloField;

        private IzdaniRacunEnostavniRacunReferencniDokumenti referencniDokumentiField;

        private IzdaniRacunEnostavniRacunPodatkiPodjetja[] podatkiPodjetjaField;

        private IzdaniRacunEnostavniRacunValuta valutaField;

        private IzdaniRacunEnostavniRacunPostavkeRacuna[] postavkeRacunaField;

        private IzdaniRacunEnostavniRacunPovzetekDavkovRacuna[] povzetekDavkovRacunaField;

        private IzdaniRacunEnostavniRacunPovzetekZneskovRacuna[] povzetekZneskovRacunaField;

        private string idField;

        /// <remarks/>
        public IzdaniRacunEnostavniRacunGlavaRacuna GlavaRacuna
        {
            get
            {
                return this.glavaRacunaField;
            }
            set
            {
                this.glavaRacunaField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPlacilniPogoji PlacilniPogoji
        {
            get
            {
                return this.placilniPogojiField;
            }
            set
            {
                this.placilniPogojiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DatumiRacuna")]
        public IzdaniRacunEnostavniRacunDatumiRacuna[] DatumiRacuna
        {
            get
            {
                return this.datumiRacunaField;
            }
            set
            {
                this.datumiRacunaField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunLokacije Lokacije
        {
            get
            {
                return this.lokacijeField;
            }
            set
            {
                this.lokacijeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PoljubnoBesedilo")]
        public IzdaniRacunEnostavniRacunPoljubnoBesedilo[] PoljubnoBesedilo
        {
            get
            {
                return this.poljubnoBesediloField;
            }
            set
            {
                this.poljubnoBesediloField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunReferencniDokumenti ReferencniDokumenti
        {
            get
            {
                return this.referencniDokumentiField;
            }
            set
            {
                this.referencniDokumentiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PodatkiPodjetja")]
        public IzdaniRacunEnostavniRacunPodatkiPodjetja[] PodatkiPodjetja
        {
            get
            {
                return this.podatkiPodjetjaField;
            }
            set
            {
                this.podatkiPodjetjaField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunValuta Valuta
        {
            get
            {
                return this.valutaField;
            }
            set
            {
                this.valutaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PostavkeRacuna")]
        public IzdaniRacunEnostavniRacunPostavkeRacuna[] PostavkeRacuna
        {
            get
            {
                return this.postavkeRacunaField;
            }
            set
            {
                this.postavkeRacunaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PovzetekDavkovRacuna")]
        public IzdaniRacunEnostavniRacunPovzetekDavkovRacuna[] PovzetekDavkovRacuna
        {
            get
            {
                return this.povzetekDavkovRacunaField;
            }
            set
            {
                this.povzetekDavkovRacunaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PovzetekZneskovRacuna")]
        public IzdaniRacunEnostavniRacunPovzetekZneskovRacuna[] PovzetekZneskovRacuna
        {
            get
            {
                return this.povzetekZneskovRacunaField;
            }
            set
            {
                this.povzetekZneskovRacunaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunGlavaRacuna
    {

        private ushort vrstaRacunaField;

        private uint stevilkaRacunaField;

        private byte funkcijaRacunaField;

        private string kodaNamenaField;

        /// <remarks/>
        public ushort VrstaRacuna
        {
            get
            {
                return this.vrstaRacunaField;
            }
            set
            {
                this.vrstaRacunaField = value;
            }
        }

        /// <remarks/>
        public uint StevilkaRacuna
        {
            get
            {
                return this.stevilkaRacunaField;
            }
            set
            {
                this.stevilkaRacunaField = value;
            }
        }

        /// <remarks/>
        public byte FunkcijaRacuna
        {
            get
            {
                return this.funkcijaRacunaField;
            }
            set
            {
                this.funkcijaRacunaField = value;
            }
        }

        /// <remarks/>
        public string KodaNamena
        {
            get
            {
                return this.kodaNamenaField;
            }
            set
            {
                this.kodaNamenaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPlacilniPogoji
    {

        private IzdaniRacunEnostavniRacunPlacilniPogojiPodatkiORokih podatkiORokihField;

        private IzdaniRacunEnostavniRacunPlacilniPogojiPlacilniRoki placilniRokiField;

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPlacilniPogojiPodatkiORokih PodatkiORokih
        {
            get
            {
                return this.podatkiORokihField;
            }
            set
            {
                this.podatkiORokihField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPlacilniPogojiPlacilniRoki PlacilniRoki
        {
            get
            {
                return this.placilniRokiField;
            }
            set
            {
                this.placilniRokiField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPlacilniPogojiPodatkiORokih
    {

        private byte vrstaPogojaField;

        /// <remarks/>
        public byte VrstaPogoja
        {
            get
            {
                return this.vrstaPogojaField;
            }
            set
            {
                this.vrstaPogojaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPlacilniPogojiPlacilniRoki
    {

        private byte vrstaDatumaPlacilnegaRokaField;

        private System.DateTime datumField;

        /// <remarks/>
        public byte VrstaDatumaPlacilnegaRoka
        {
            get
            {
                return this.vrstaDatumaPlacilnegaRokaField;
            }
            set
            {
                this.vrstaDatumaPlacilnegaRokaField = value;
            }
        }

        /// <remarks/>
        public System.DateTime Datum
        {
            get
            {
                return this.datumField;
            }
            set
            {
                this.datumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunDatumiRacuna
    {

        private ushort vrstaDatumaField;

        private System.DateTime datumRacunaField;

        /// <remarks/>
        public ushort VrstaDatuma
        {
            get
            {
                return this.vrstaDatumaField;
            }
            set
            {
                this.vrstaDatumaField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DatumRacuna
        {
            get
            {
                return this.datumRacunaField;
            }
            set
            {
                this.datumRacunaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunLokacije
    {

        private byte vrstaLokacijeField;

        private string nazivLokacijeField;

        /// <remarks/>
        public byte VrstaLokacije
        {
            get
            {
                return this.vrstaLokacijeField;
            }
            set
            {
                this.vrstaLokacijeField = value;
            }
        }

        /// <remarks/>
        public string NazivLokacije
        {
            get
            {
                return this.nazivLokacijeField;
            }
            set
            {
                this.nazivLokacijeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPoljubnoBesedilo
    {

        private string vrstaBesedilaField;

        private IzdaniRacunEnostavniRacunPoljubnoBesediloBesedilo besediloField;

        /// <remarks/>
        public string VrstaBesedila
        {
            get
            {
                return this.vrstaBesedilaField;
            }
            set
            {
                this.vrstaBesedilaField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPoljubnoBesediloBesedilo Besedilo
        {
            get
            {
                return this.besediloField;
            }
            set
            {
                this.besediloField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPoljubnoBesediloBesedilo
    {

        private string tekst1Field;

        private string tekst2Field;

        /// <remarks/>
        public string Tekst1
        {
            get
            {
                return this.tekst1Field;
            }
            set
            {
                this.tekst1Field = value;
            }
        }

        /// <remarks/>
        public string Tekst2
        {
            get
            {
                return this.tekst2Field;
            }
            set
            {
                this.tekst2Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunReferencniDokumenti
    {

        private uint stevilkaDokumentaField;

        private string vrstaDokumentaField;

        /// <remarks/>
        public uint StevilkaDokumenta
        {
            get
            {
                return this.stevilkaDokumentaField;
            }
            set
            {
                this.stevilkaDokumentaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VrstaDokumenta
        {
            get
            {
                return this.vrstaDokumentaField;
            }
            set
            {
                this.vrstaDokumentaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPodatkiPodjetja
    {

        private IzdaniRacunEnostavniRacunPodatkiPodjetjaNazivNaslovPodjetja nazivNaslovPodjetjaField;

        private IzdaniRacunEnostavniRacunPodatkiPodjetjaFinancniPodatkiPodjetja financniPodatkiPodjetjaField;

        private IzdaniRacunEnostavniRacunPodatkiPodjetjaReferencniPodatkiPodjetja[] referencniPodatkiPodjetjaField;

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPodatkiPodjetjaNazivNaslovPodjetja NazivNaslovPodjetja
        {
            get
            {
                return this.nazivNaslovPodjetjaField;
            }
            set
            {
                this.nazivNaslovPodjetjaField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPodatkiPodjetjaFinancniPodatkiPodjetja FinancniPodatkiPodjetja
        {
            get
            {
                return this.financniPodatkiPodjetjaField;
            }
            set
            {
                this.financniPodatkiPodjetjaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferencniPodatkiPodjetja")]
        public IzdaniRacunEnostavniRacunPodatkiPodjetjaReferencniPodatkiPodjetja[] ReferencniPodatkiPodjetja
        {
            get
            {
                return this.referencniPodatkiPodjetjaField;
            }
            set
            {
                this.referencniPodatkiPodjetjaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPodatkiPodjetjaNazivNaslovPodjetja
    {

        private string vrstaPartnerjaField;

        private IzdaniRacunEnostavniRacunPodatkiPodjetjaNazivNaslovPodjetjaIdentifikacijaPartnerja identifikacijaPartnerjaField;

        private IzdaniRacunEnostavniRacunPodatkiPodjetjaNazivNaslovPodjetjaNazivPartnerja nazivPartnerjaField;

        private IzdaniRacunEnostavniRacunPodatkiPodjetjaNazivNaslovPodjetjaUlica ulicaField;

        private string krajField;

        private string nazivDrzaveField;

        private ushort postnaStevilkaField;

        private string kodaDrzaveField;

        /// <remarks/>
        public string VrstaPartnerja
        {
            get
            {
                return this.vrstaPartnerjaField;
            }
            set
            {
                this.vrstaPartnerjaField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPodatkiPodjetjaNazivNaslovPodjetjaIdentifikacijaPartnerja IdentifikacijaPartnerja
        {
            get
            {
                return this.identifikacijaPartnerjaField;
            }
            set
            {
                this.identifikacijaPartnerjaField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPodatkiPodjetjaNazivNaslovPodjetjaNazivPartnerja NazivPartnerja
        {
            get
            {
                return this.nazivPartnerjaField;
            }
            set
            {
                this.nazivPartnerjaField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPodatkiPodjetjaNazivNaslovPodjetjaUlica Ulica
        {
            get
            {
                return this.ulicaField;
            }
            set
            {
                this.ulicaField = value;
            }
        }

        /// <remarks/>
        public string Kraj
        {
            get
            {
                return this.krajField;
            }
            set
            {
                this.krajField = value;
            }
        }

        /// <remarks/>
        public string NazivDrzave
        {
            get
            {
                return this.nazivDrzaveField;
            }
            set
            {
                this.nazivDrzaveField = value;
            }
        }

        /// <remarks/>
        public ushort PostnaStevilka
        {
            get
            {
                return this.postnaStevilkaField;
            }
            set
            {
                this.postnaStevilkaField = value;
            }
        }

        /// <remarks/>
        public string KodaDrzave
        {
            get
            {
                return this.kodaDrzaveField;
            }
            set
            {
                this.kodaDrzaveField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPodatkiPodjetjaNazivNaslovPodjetjaIdentifikacijaPartnerja
    {

        private uint stevilkaPartnerjaField;

        private byte agencijaField;

        /// <remarks/>
        public uint StevilkaPartnerja
        {
            get
            {
                return this.stevilkaPartnerjaField;
            }
            set
            {
                this.stevilkaPartnerjaField = value;
            }
        }

        /// <remarks/>
        public byte Agencija
        {
            get
            {
                return this.agencijaField;
            }
            set
            {
                this.agencijaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPodatkiPodjetjaNazivNaslovPodjetjaNazivPartnerja
    {

        private string nazivPartnerja1Field;

        private string nazivPartnerja2Field;

        /// <remarks/>
        public string NazivPartnerja1
        {
            get
            {
                return this.nazivPartnerja1Field;
            }
            set
            {
                this.nazivPartnerja1Field = value;
            }
        }

        /// <remarks/>
        public string NazivPartnerja2
        {
            get
            {
                return this.nazivPartnerja2Field;
            }
            set
            {
                this.nazivPartnerja2Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPodatkiPodjetjaNazivNaslovPodjetjaUlica
    {

        private string ulica1Field;

        /// <remarks/>
        public string Ulica1
        {
            get
            {
                return this.ulica1Field;
            }
            set
            {
                this.ulica1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPodatkiPodjetjaFinancniPodatkiPodjetja
    {

        private IzdaniRacunEnostavniRacunPodatkiPodjetjaFinancniPodatkiPodjetjaBancniRacun bancniRacunField;

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPodatkiPodjetjaFinancniPodatkiPodjetjaBancniRacun BancniRacun
        {
            get
            {
                return this.bancniRacunField;
            }
            set
            {
                this.bancniRacunField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPodatkiPodjetjaFinancniPodatkiPodjetjaBancniRacun
    {

        private string stevilkaBancnegaRacunaField;

        private string nazivBanke1Field;

        private string bICField;

        /// <remarks/>
        public string StevilkaBancnegaRacuna
        {
            get
            {
                return this.stevilkaBancnegaRacunaField;
            }
            set
            {
                this.stevilkaBancnegaRacunaField = value;
            }
        }

        /// <remarks/>
        public string NazivBanke1
        {
            get
            {
                return this.nazivBanke1Field;
            }
            set
            {
                this.nazivBanke1Field = value;
            }
        }

        /// <remarks/>
        public string BIC
        {
            get
            {
                return this.bICField;
            }
            set
            {
                this.bICField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPodatkiPodjetjaReferencniPodatkiPodjetja
    {

        private string vrstaPodatkaPodjetjaField;

        private string podatekPodjetjaField;

        /// <remarks/>
        public string VrstaPodatkaPodjetja
        {
            get
            {
                return this.vrstaPodatkaPodjetjaField;
            }
            set
            {
                this.vrstaPodatkaPodjetjaField = value;
            }
        }

        /// <remarks/>
        public string PodatekPodjetja
        {
            get
            {
                return this.podatekPodjetjaField;
            }
            set
            {
                this.podatekPodjetjaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunValuta
    {

        private byte vrstaValuteRacunaField;

        private string kodaValuteField;

        /// <remarks/>
        public byte VrstaValuteRacuna
        {
            get
            {
                return this.vrstaValuteRacunaField;
            }
            set
            {
                this.vrstaValuteRacunaField = value;
            }
        }

        /// <remarks/>
        public string KodaValute
        {
            get
            {
                return this.kodaValuteField;
            }
            set
            {
                this.kodaValuteField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPostavkeRacuna
    {

        private IzdaniRacunEnostavniRacunPostavkeRacunaPostavka postavkaField;

        private IzdaniRacunEnostavniRacunPostavkeRacunaOpisiArtiklov opisiArtiklovField;

        private IzdaniRacunEnostavniRacunPostavkeRacunaKolicinaArtikla kolicinaArtiklaField;

        private IzdaniRacunEnostavniRacunPostavkeRacunaZneskiPostavke zneskiPostavkeField;

        private IzdaniRacunEnostavniRacunPostavkeRacunaCenaPostavke[] cenaPostavkeField;

        private IzdaniRacunEnostavniRacunPostavkeRacunaDavkiPostavke davkiPostavkeField;

        private uint stroskovnoMestoField;

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPostavkeRacunaPostavka Postavka
        {
            get
            {
                return this.postavkaField;
            }
            set
            {
                this.postavkaField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPostavkeRacunaOpisiArtiklov OpisiArtiklov
        {
            get
            {
                return this.opisiArtiklovField;
            }
            set
            {
                this.opisiArtiklovField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPostavkeRacunaKolicinaArtikla KolicinaArtikla
        {
            get
            {
                return this.kolicinaArtiklaField;
            }
            set
            {
                this.kolicinaArtiklaField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPostavkeRacunaZneskiPostavke ZneskiPostavke
        {
            get
            {
                return this.zneskiPostavkeField;
            }
            set
            {
                this.zneskiPostavkeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CenaPostavke")]
        public IzdaniRacunEnostavniRacunPostavkeRacunaCenaPostavke[] CenaPostavke
        {
            get
            {
                return this.cenaPostavkeField;
            }
            set
            {
                this.cenaPostavkeField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPostavkeRacunaDavkiPostavke DavkiPostavke
        {
            get
            {
                return this.davkiPostavkeField;
            }
            set
            {
                this.davkiPostavkeField = value;
            }
        }

        /// <remarks/>
        public uint StroskovnoMesto
        {
            get
            {
                return this.stroskovnoMestoField;
            }
            set
            {
                this.stroskovnoMestoField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPostavkeRacunaPostavka
    {

        private byte stevilkaVrsticeField;

        /// <remarks/>
        public byte StevilkaVrstice
        {
            get
            {
                return this.stevilkaVrsticeField;
            }
            set
            {
                this.stevilkaVrsticeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPostavkeRacunaOpisiArtiklov
    {

        private string kodaOpisaArtiklaField;

        private IzdaniRacunEnostavniRacunPostavkeRacunaOpisiArtiklovOpisArtikla opisArtiklaField;

        /// <remarks/>
        public string KodaOpisaArtikla
        {
            get
            {
                return this.kodaOpisaArtiklaField;
            }
            set
            {
                this.kodaOpisaArtiklaField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPostavkeRacunaOpisiArtiklovOpisArtikla OpisArtikla
        {
            get
            {
                return this.opisArtiklaField;
            }
            set
            {
                this.opisArtiklaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPostavkeRacunaOpisiArtiklovOpisArtikla
    {

        private string opisArtikla1Field;

        private string opisArtikla2Field;

        /// <remarks/>
        public string OpisArtikla1
        {
            get
            {
                return this.opisArtikla1Field;
            }
            set
            {
                this.opisArtikla1Field = value;
            }
        }

        /// <remarks/>
        public string OpisArtikla2
        {
            get
            {
                return this.opisArtikla2Field;
            }
            set
            {
                this.opisArtikla2Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPostavkeRacunaKolicinaArtikla
    {

        private byte vrstaKolicineField;

        private decimal kolicinaField;

        private string enotaMereField;

        /// <remarks/>
        public byte VrstaKolicine
        {
            get
            {
                return this.vrstaKolicineField;
            }
            set
            {
                this.vrstaKolicineField = value;
            }
        }

        /// <remarks/>
        public decimal Kolicina
        {
            get
            {
                return this.kolicinaField;
            }
            set
            {
                this.kolicinaField = value;
            }
        }

        /// <remarks/>
        public string EnotaMere
        {
            get
            {
                return this.enotaMereField;
            }
            set
            {
                this.enotaMereField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPostavkeRacunaZneskiPostavke
    {

        private byte vrstaZneskaPostavkeField;

        private decimal znesekPostavkeField;

        /// <remarks/>
        public byte VrstaZneskaPostavke
        {
            get
            {
                return this.vrstaZneskaPostavkeField;
            }
            set
            {
                this.vrstaZneskaPostavkeField = value;
            }
        }

        /// <remarks/>
        public decimal ZnesekPostavke
        {
            get
            {
                return this.znesekPostavkeField;
            }
            set
            {
                this.znesekPostavkeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPostavkeRacunaCenaPostavke
    {

        private string vrstaCeneField;

        private decimal cenaField;

        /// <remarks/>
        public string VrstaCene
        {
            get
            {
                return this.vrstaCeneField;
            }
            set
            {
                this.vrstaCeneField = value;
            }
        }

        /// <remarks/>
        public decimal Cena
        {
            get
            {
                return this.cenaField;
            }
            set
            {
                this.cenaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPostavkeRacunaDavkiPostavke
    {

        private IzdaniRacunEnostavniRacunPostavkeRacunaDavkiPostavkeDavkiNaPostavki davkiNaPostavkiField;

        private IzdaniRacunEnostavniRacunPostavkeRacunaDavkiPostavkeZneskiDavkovPostavke[] zneskiDavkovPostavkeField;

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPostavkeRacunaDavkiPostavkeDavkiNaPostavki DavkiNaPostavki
        {
            get
            {
                return this.davkiNaPostavkiField;
            }
            set
            {
                this.davkiNaPostavkiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ZneskiDavkovPostavke")]
        public IzdaniRacunEnostavniRacunPostavkeRacunaDavkiPostavkeZneskiDavkovPostavke[] ZneskiDavkovPostavke
        {
            get
            {
                return this.zneskiDavkovPostavkeField;
            }
            set
            {
                this.zneskiDavkovPostavkeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPostavkeRacunaDavkiPostavkeDavkiNaPostavki
    {

        private string vrstaDavkaPostavkeField;

        private decimal odstotekDavkaPostavkeField;

        /// <remarks/>
        public string VrstaDavkaPostavke
        {
            get
            {
                return this.vrstaDavkaPostavkeField;
            }
            set
            {
                this.vrstaDavkaPostavkeField = value;
            }
        }

        /// <remarks/>
        public decimal OdstotekDavkaPostavke
        {
            get
            {
                return this.odstotekDavkaPostavkeField;
            }
            set
            {
                this.odstotekDavkaPostavkeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPostavkeRacunaDavkiPostavkeZneskiDavkovPostavke
    {

        private byte vrstaZneskaDavkaPostavkeField;

        private decimal znesekField;

        /// <remarks/>
        public byte VrstaZneskaDavkaPostavke
        {
            get
            {
                return this.vrstaZneskaDavkaPostavkeField;
            }
            set
            {
                this.vrstaZneskaDavkaPostavkeField = value;
            }
        }

        /// <remarks/>
        public decimal Znesek
        {
            get
            {
                return this.znesekField;
            }
            set
            {
                this.znesekField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPovzetekDavkovRacuna
    {

        private IzdaniRacunEnostavniRacunPovzetekDavkovRacunaDavkiRacuna davkiRacunaField;

        private IzdaniRacunEnostavniRacunPovzetekDavkovRacunaZneskiDavkov[] zneskiDavkovField;

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPovzetekDavkovRacunaDavkiRacuna DavkiRacuna
        {
            get
            {
                return this.davkiRacunaField;
            }
            set
            {
                this.davkiRacunaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ZneskiDavkov")]
        public IzdaniRacunEnostavniRacunPovzetekDavkovRacunaZneskiDavkov[] ZneskiDavkov
        {
            get
            {
                return this.zneskiDavkovField;
            }
            set
            {
                this.zneskiDavkovField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPovzetekDavkovRacunaDavkiRacuna
    {

        private string vrstaDavkaField;

        private decimal odstotekDavkaField;

        /// <remarks/>
        public string VrstaDavka
        {
            get
            {
                return this.vrstaDavkaField;
            }
            set
            {
                this.vrstaDavkaField = value;
            }
        }

        /// <remarks/>
        public decimal OdstotekDavka
        {
            get
            {
                return this.odstotekDavkaField;
            }
            set
            {
                this.odstotekDavkaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPovzetekDavkovRacunaZneskiDavkov
    {

        private byte vrstaZneskaDavkaField;

        private decimal znesekDavkaField;

        /// <remarks/>
        public byte VrstaZneskaDavka
        {
            get
            {
                return this.vrstaZneskaDavkaField;
            }
            set
            {
                this.vrstaZneskaDavkaField = value;
            }
        }

        /// <remarks/>
        public decimal ZnesekDavka
        {
            get
            {
                return this.znesekDavkaField;
            }
            set
            {
                this.znesekDavkaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPovzetekZneskovRacuna
    {

        private IzdaniRacunEnostavniRacunPovzetekZneskovRacunaZneskiRacuna zneskiRacunaField;

        private IzdaniRacunEnostavniRacunPovzetekZneskovRacunaSklicZaPlacilo sklicZaPlaciloField;

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPovzetekZneskovRacunaZneskiRacuna ZneskiRacuna
        {
            get
            {
                return this.zneskiRacunaField;
            }
            set
            {
                this.zneskiRacunaField = value;
            }
        }

        /// <remarks/>
        public IzdaniRacunEnostavniRacunPovzetekZneskovRacunaSklicZaPlacilo SklicZaPlacilo
        {
            get
            {
                return this.sklicZaPlaciloField;
            }
            set
            {
                this.sklicZaPlaciloField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPovzetekZneskovRacunaZneskiRacuna
    {

        private ushort vrstaZneskaField;

        private decimal znesekRacunaField;

        /// <remarks/>
        public ushort VrstaZneska
        {
            get
            {
                return this.vrstaZneskaField;
            }
            set
            {
                this.vrstaZneskaField = value;
            }
        }

        /// <remarks/>
        public decimal ZnesekRacuna
        {
            get
            {
                return this.znesekRacunaField;
            }
            set
            {
                this.znesekRacunaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IzdaniRacunEnostavniRacunPovzetekZneskovRacunaSklicZaPlacilo
    {

        private string sklicPlacilaField;

        private string stevilkaSklicaField;

        /// <remarks/>
        public string SklicPlacila
        {
            get
            {
                return this.sklicPlacilaField;
            }
            set
            {
                this.sklicPlacilaField = value;
            }
        }

        /// <remarks/>
        public string StevilkaSklica
        {
            get
            {
                return this.stevilkaSklicaField;
            }
            set
            {
                this.stevilkaSklicaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class Signature
    {

        private SignatureSignedInfo signedInfoField;

        private string signatureValueField;

        private SignatureKeyInfo keyInfoField;

        private SignatureObject objectField;

        private string idField;

        /// <remarks/>
        public SignatureSignedInfo SignedInfo
        {
            get
            {
                return this.signedInfoField;
            }
            set
            {
                this.signedInfoField = value;
            }
        }

        /// <remarks/>
        public string SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        /// <remarks/>
        public SignatureKeyInfo KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
            }
        }

        /// <remarks/>
        public SignatureObject Object
        {
            get
            {
                return this.objectField;
            }
            set
            {
                this.objectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfo
    {

        private SignatureSignedInfoCanonicalizationMethod canonicalizationMethodField;

        private SignatureSignedInfoSignatureMethod signatureMethodField;

        private SignatureSignedInfoReference[] referenceField;

        /// <remarks/>
        public SignatureSignedInfoCanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        public SignatureSignedInfoSignatureMethod SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public SignatureSignedInfoReference[] Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoCanonicalizationMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoSignatureMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReference
    {

        private SignatureSignedInfoReferenceDigestMethod digestMethodField;

        private string digestValueField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        public SignatureSignedInfoReferenceDigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        public string DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureSignedInfoReferenceDigestMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureKeyInfo
    {

        private SignatureKeyInfoX509Data x509DataField;

        /// <remarks/>
        public SignatureKeyInfoX509Data X509Data
        {
            get
            {
                return this.x509DataField;
            }
            set
            {
                this.x509DataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureKeyInfoX509Data
    {

        private string x509CertificateField;

        /// <remarks/>
        public string X509Certificate
        {
            get
            {
                return this.x509CertificateField;
            }
            set
            {
                this.x509CertificateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureObject
    {

        private QualifyingProperties qualifyingPropertiesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://uri.etsi.org/01903/v1.1.1#")]
        public QualifyingProperties QualifyingProperties
        {
            get
            {
                return this.qualifyingPropertiesField;
            }
            set
            {
                this.qualifyingPropertiesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.1.1#")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.1.1#", IsNullable = false)]
    public partial class QualifyingProperties
    {

        private QualifyingPropertiesSignedProperties signedPropertiesField;

        private string targetField;

        /// <remarks/>
        public QualifyingPropertiesSignedProperties SignedProperties
        {
            get
            {
                return this.signedPropertiesField;
            }
            set
            {
                this.signedPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.1.1#")]
    public partial class QualifyingPropertiesSignedProperties
    {

        private QualifyingPropertiesSignedPropertiesSignedSignatureProperties signedSignaturePropertiesField;

        private string idField;

        /// <remarks/>
        public QualifyingPropertiesSignedPropertiesSignedSignatureProperties SignedSignatureProperties
        {
            get
            {
                return this.signedSignaturePropertiesField;
            }
            set
            {
                this.signedSignaturePropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.1.1#")]
    public partial class QualifyingPropertiesSignedPropertiesSignedSignatureProperties
    {

        private System.DateTime signingTimeField;

        private QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificate signingCertificateField;

        private QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSignaturePolicyIdentifier signaturePolicyIdentifierField;

        /// <remarks/>
        public System.DateTime SigningTime
        {
            get
            {
                return this.signingTimeField;
            }
            set
            {
                this.signingTimeField = value;
            }
        }

        /// <remarks/>
        public QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificate SigningCertificate
        {
            get
            {
                return this.signingCertificateField;
            }
            set
            {
                this.signingCertificateField = value;
            }
        }

        /// <remarks/>
        public QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSignaturePolicyIdentifier SignaturePolicyIdentifier
        {
            get
            {
                return this.signaturePolicyIdentifierField;
            }
            set
            {
                this.signaturePolicyIdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.1.1#")]
    public partial class QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificate
    {

        private QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCert certField;

        /// <remarks/>
        public QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCert Cert
        {
            get
            {
                return this.certField;
            }
            set
            {
                this.certField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.1.1#")]
    public partial class QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCert
    {

        private QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertCertDigest certDigestField;

        private QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertIssuerSerial issuerSerialField;

        /// <remarks/>
        public QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertCertDigest CertDigest
        {
            get
            {
                return this.certDigestField;
            }
            set
            {
                this.certDigestField = value;
            }
        }

        /// <remarks/>
        public QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertIssuerSerial IssuerSerial
        {
            get
            {
                return this.issuerSerialField;
            }
            set
            {
                this.issuerSerialField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.1.1#")]
    public partial class QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertCertDigest
    {

        private QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertCertDigestDigestMethod digestMethodField;

        private string digestValueField;

        /// <remarks/>
        public QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertCertDigestDigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        public string DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.1.1#")]
    public partial class QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertCertDigestDigestMethod
    {

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.1.1#")]
    public partial class QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSigningCertificateCertIssuerSerial
    {

        private string x509IssuerNameField;

        private uint x509SerialNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public string X509IssuerName
        {
            get
            {
                return this.x509IssuerNameField;
            }
            set
            {
                this.x509IssuerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public uint X509SerialNumber
        {
            get
            {
                return this.x509SerialNumberField;
            }
            set
            {
                this.x509SerialNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://uri.etsi.org/01903/v1.1.1#")]
    public partial class QualifyingPropertiesSignedPropertiesSignedSignaturePropertiesSignaturePolicyIdentifier
    {

        private object signaturePolicyImpliedField;

        /// <remarks/>
        public object SignaturePolicyImplied
        {
            get
            {
                return this.signaturePolicyImpliedField;
            }
            set
            {
                this.signaturePolicyImpliedField = value;
            }
        }
    }


}
