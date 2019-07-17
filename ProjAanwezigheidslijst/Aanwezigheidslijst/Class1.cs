using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Aanwezigheidslijst
{
    public class Deelnemers
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Woonplaats { get; set; }
        public int BadgeNummer { get; set; }

        public override string ToString()
        {
            return Naam;
        }

    }

    public class DeelnemersOpleidingen
    {
        public int Id { get; set; }
        public Deelnemers Deelnemer { get; set; }
        public Opleidingsinformatie Opleiding { get; set; }

    }

    public class NietOpleidingsDagen
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public bool Voormiddag { get; set; }
        public bool Namiddag { get; set; }
        public Opleidingsinformatie Opleiding { get; set; }
    }

    public class Tijdsregistratie
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Opleidingsinformatie Opleiding { get; set; }
        public Deelnemers Deelnemer { get; set; }

    }

    public class Opleidingsinformatie
    {
        public int Id { get; set; }
        public string Opleidingsinstelling { get; set; }
        public string Opleiding { get; set; }
        public string Contactpersoon { get; set; }
        public string Opleidingsplaats { get; set; }
        public string ReferentieOpleidingsplaats { get; set; }
        public int OeNummer { get; set; }
        public int Opleidingscode { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime EindDatume { get; set; }
        public override string ToString()
        {
            return Opleiding;
        }
    }


    public class DocetenOpleidingen
    {
        public int Id { get; set; }
        public Docenten Docent { get; set; }
        public Opleidingsinformatie Opleiding { get; set; }

    }

    public class Docenten
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Bedrijf { get; set; }

        public override string ToString()
        {
            return Naam;
        }
    }

    public class AanwezigheidslijstContext : DbContext
    {
        public AanwezigheidslijstContext() : base("Aanwezigheidslijst")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<Deelnemers> Deelnemers { get; set; }
        public DbSet<DeelnemersOpleidingen> DeelnemersOpleidingens { get; set; }
        public DbSet<NietOpleidingsDagen> NietOpleidingsDagens { get; set; }
        public DbSet<Tijdsregistratie> Tijdsregistraties { get; set; }
        public DbSet<Opleidingsinformatie> Opleidingsinformaties { get; set; }
        public DbSet<DocetenOpleidingen> DocetenOpleidingens { get; set; }
        public DbSet<Docenten> Docentens { get; set; }

        
    }
}
