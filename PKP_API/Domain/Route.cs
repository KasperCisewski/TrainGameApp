using System.Collections.Generic;

namespace PKP_API
{
    public class Route
    {
        public int Id { get; set; }

        public Stacja  StacjaPoczatkowa { get; set; }

        public Stacja StacjaKoncowa { get; set; }

        public IEnumerable<Stacja> StacjePosrednie { get; set; }

        public int Dlugosc { get; set; }
    }
}
