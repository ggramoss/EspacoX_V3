using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EspacoX_V3.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int Capacity { get; set; }

        public bool Availability { get; set; } = true; 
        [StringLength(500)]
        public string Description { get; set; }

        
        [Required]
        public int BuildingId { get; set; } 

        [ForeignKey("BuildingId")]
        public Building Building { get; set; } 

        // Métodos
        public bool CheckAvailability(DateTime date, TimeSpan time)
        {
           
            if (!Availability)
                return false;
            return true;
        }

        public string UpdateRoomDetails(string name, int? capacity, string description)
        {
            if (!string.IsNullOrWhiteSpace(name))
                Name = name;

            if (capacity.HasValue && capacity > 0)
                Capacity = capacity.Value;

            if (!string.IsNullOrWhiteSpace(description))
                Description = description;

            return "Detalhes da sala atualizados com sucesso!";
        }
    }
}
