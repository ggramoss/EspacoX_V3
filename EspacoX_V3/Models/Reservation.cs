using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EspacoX_V3.Models
{
    public class Reservation
    {
               
            public int Id { get; set; }

            [Required]
            public DateTime Date { get; set; } 

            [Required]
            public int UserId { get; set; } 

            [ForeignKey("UserId")]
            public User User { get; set; }

            [Required]
            public int RoomId { get; set; } 

            [ForeignKey("RoomId")]
            public Room Room { get; set; }

            [Required]
            [StringLength(50)]
            public string Status { get; set; } = "Livre"; 

        // Métodos
        public string CreateReservation()
        {
           
            if (!Room.CheckAvailability(Date, Date.TimeOfDay))
                return "Sala não está disponível no horário solicitado.";

            Status = "Reservada";
            return "Reserva criada com sucesso!";
        }

        public string CancelReservation()
        {
            Status = "Livre";
            return "Reserva cancelada com sucesso!";
        }

        public string ModifyReservation(DateTime newDate, int newRoomId)
        {
            RoomId = newRoomId;
            Date = newDate;
            Status = "Reserva alterada";

            return "Reserva modificada com sucesso!";
        }
    }
    }
