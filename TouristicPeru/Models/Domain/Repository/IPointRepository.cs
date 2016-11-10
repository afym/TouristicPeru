using System;
using System.Collections.Generic;
using TouristicPeru.Models.Domain.Entity;

namespace TouristicPeru.Models.Domain.Repository
{
    interface IPointRepository
    {
        IList<Point> FindAll();
    }
}
