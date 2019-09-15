using System.Collections.Generic;
using PKP_API;
public static class DbHelper
{
    public static IEnumerable<Ticket> Tickets { get; set; }
    public static IEnumerable<Ticket> GetTickets()
    { 
        return Tickets;
     }
    static DbHelper()
    {
        Tickets = new List<Ticket>
        {
            new Ticket {
                Id=1,
                TicketId="IC 12345678",
                Route = new Route
                {
                    Id=1,
                    StacjaKoncowa = new Stacja
                    {
                        Id=1,
                        Nazwa="Gdansk Glowny"
                    },
                    StacjaPoczatkowa=new Stacja
                    {
                        Id=2,
                        Nazwa="Warszawa Centralna"
                    },
                    StacjePosrednie = new List<Stacja>
                    {
                       new Stacja{
                        Id=3,
                        Nazwa="Torun"
                    },
                    new Stacja{
                        Id=4,
                        Nazwa="Brzydgoszcz"
                    }
                    },
                    Dlugosc = 333
                },
                    Train = new Train {
                        Id=1,
                        NazwaPociagu="LemooryZysku",
                        Wagony=4
                }
            }
        };
    }
}