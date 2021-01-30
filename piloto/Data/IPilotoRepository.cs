using System.Collections.Generic;
using piloto.Models;

namespace piloto.Data
{
    public interface IPilotoRepository {

        IEnumerable<Piloto> getAllPiloto();
        Piloto getPilotoById(int id);
    }
}