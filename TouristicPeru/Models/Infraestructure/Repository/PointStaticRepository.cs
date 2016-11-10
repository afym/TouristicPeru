using System.Collections.Generic;
using TouristicPeru.Models.Domain.Repository;
using TouristicPeru.Models.Domain.Entity;

namespace TouristicPeru.Models.Infraestructure.Repository
{
    public class PointStaticRepository : IPointRepository
    {
        public IList<Point> FindAll()
        {
            return new List<Point> {
                new Point(){Id = 1, Name = "Restaurant Huaca Pucllama", Category = "Restaurante", Address = "Calle Sarrio Av. 152", Image = "http://resizer.otstatic.com/v1/fDzI465IL8%2B687zSupRS4Q/23679264.jpg", Latitude = -12.11093612, Longitude = -77.03328646},
                new Point(){Id = 2, Name = "Museo de los Vecinos", Category = "Museo", Address = "Calle Lizardo Montero", Image = "http://www.semahn.chiapas.gob.mx/portal/media/botanico/museo_01.jpg", Latitude = -12.11141866, Longitude = -77.0291344},
                new Point(){Id = 3, Name = "Plaza Vea Miraflores", Category = "Super mercado", Address = "Av Angamos este", Image = "http://www.vector-logo.net/logo_preview/eps/p/Plaza_Vea.png", Latitude = -12.1124257, Longitude = -77.02974594},
                new Point(){Id = 4, Name = "Mercados Indios", Category = "Mercado", Address = "Av. Petit Thouards", Image = "http://resizer.otstatic.com/v1/fDzI465IL8%2B687zSupRS4Q/23679264.jpg", Latitude = -12.11507966, Longitude = -77.02810443},
                new Point(){Id = 5, Name = "Clinica Delgado Medic Ser", Category = "Centro de salud", Address = "Calle General BorgoñoMiraflores 15074", Image = "http://www.nvbcom.fr/wp-content/uploads/2016/02/BQA-Ve%C2%A6u%CC%88zelay-Luc-Boegly_059-200x200.jpg", Latitude = -12.11301222, Longitude = -77.03313947}
            };
        }
    }
}