using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace EspacoX_V3.Models
{
    public class Building
    {
             
            public int Id { get; set; }

            [Required, StringLength(100)]
            public string Name { get; set; }

            [Required, StringLength(200)]

            public string Address { get; set; }
            public ICollection<Room> Rooms { get; set; } = new List<Room>();

            public string AddRoom(Room room)
            {
            Rooms.Add(room);
            return "Sala adicionada ao prédio com sucesso!";
            }

    }


}