using RoyalBureauShipping.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoyalBureauShipping.ViewModels
{
    public class ShipViewModel
    {
        public int Id { get; set; }
        public string VesselName { get; set; }
        public string ShipAddress { get; set; }
        public string IMO_NO { get; set; }
        public string Class_Id { get; set; }
        public string GRT { get; set; }
        public string Port_Of_Register { get; set; } 
        public int Depth { get; set; }
        public int Leangh { get; set; }
        public int Breadth { get; set; }
        public string Propulsion { get; set; }
		public int? CargoShipId { get; set; }

        //      [ForeignKey("CargoShipId")]
        //Date
        public DateTime DateBuildingContract { get; set; }
        public DateTime CasualHistory { get; set; }
        public DateTime DateDelivery { get; set; }
        public DateTime ExemptionCertificate { get; set; }
        public DateTime CertificateValid { get; set; }
        public DateTime CompletionDateSurvey { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime FirstPostOutInspection { get; set; }
        public DateTime SecondPostOutInspection { get; set; }
        public DateTime ValidUntil { get; set; }
        public DateTime DateofIssue { get; set; }
        public DateTime RevisionDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime LastPropeller { get; set; }
        //End 


        //data 
        public string? PortSurvey { get; set; }
        public string? ClassificationCharacters { get; set; }
        public int? Year { get; set; }
        public string? IssuedAt { get; set; }
        public string? TypeShipstrign { get; set; }
        public int? DeadweightShip { get; set; }
        public string? DistinctiveNumber { get; set; }
        public int? GrossTonnage { get; set; }
        public string? PermissibleMarineAreas { get; set; }
        public string? ShipOwner { get; set; }
        public string? Machinery { get; set; }

    }
}
