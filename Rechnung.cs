class Rechnung
{
    private int Rechnungs_ID;
    private string Datum;
    private double Betrag;
    private double MWST;
    private Kunde Kundenverweis;
    private Mitarbeiter Mitarbeiterverweiß;
    private List<Artikel> ListeArtikel;

    public Rechnung()
    {
        
    }
    public void AddKunde(Kunde k) { }
    public void AddArtikel(Artikel a) { }
    public void AddMitarbeiter(Mitarbeiter m) { }

}
