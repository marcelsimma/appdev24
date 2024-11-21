using System;

namespace BarbaraMarte.Week07.TicketSystem;

class SellingTickets
{
    List<Concert> _concerts = new List<Concert>();
    Dictionary<string, string> _tickets = new Dictionary<string, string>();

    public SellingTickets()
    {

    }
    public void plusConzert(Concert concert)
    {
        _concerts.Add(concert);
    }

    public void WaitingCue()
    {
        foreach (Concert concert in _concerts)
        {

        }
    }
}