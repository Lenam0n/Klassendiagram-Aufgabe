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
    public void AddKunde(Kunde K) { }
    public void AddArtikel(Artikel A) { }
    public void AddMitarbeiter(Mitarbeiter M) { }

}
