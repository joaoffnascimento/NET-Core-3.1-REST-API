using System.Collections.Generic;
using piloto.Models;

namespace piloto.Data
{
    public class MockPilotoRepository : IPilotoRepository
    {
        public IEnumerable<Piloto> getAllPilotos()
        {
            var pilotos = new List<Piloto>{
                new Piloto { Id = 1, Nome = "Michael Schumacher", Idade = 52, Equipe = "Ferrari" },
                new Piloto { Id = 2, Nome = "Lewis Hamilton", Idade = 36, Equipe = "Mercedes" },
                new Piloto { Id = 3, Nome = "Daniel Ricardo", Idade = 31, Equipe = "Renault" },
                new Piloto { Id = 4, Nome = "Lando Norris", Idade = 21, Equipe = "McLaren" },
            };

            return pilotos;
        }

        public Piloto getPilotoById(int id)
        {
            return new Piloto { Id = 1, Nome = "Michael Schumacher", Idade = 52, Equipe = "Ferrari" };
        }
    }
}