
# ruderfahrtenbuch
todo:
-benutzerverwaltung(authentisierung, authentifizierung, autorisierung): 
 gruppen: benutzer erben von den gruppen

-bootmanagement: bootstabelle mit eigenschaften

-personenmanagement: person verweist auf user, person kann zu mehreren teams gehören, 

-fahrtmanagement: aktive Fahrten
                  -status(laufend, pausiert)
                  -mitfahrer
                  -bemerkung
                  -ort
                  abgeschlossene Fahrten

-reservierungsmanagement: mit kalender

-statistik über boote

API: 
    Boote: 
        wie Personen
    
    Fahrten
        Fahrt starten (Put)
        Fahrt stoppen (Post, Endezeit eintragen)
        Fahrten auflisten ( aktive, alle, )

    Reservierungen
        Schnittstelle( BootID, Start DateTime, Ende DateTime, Angemeldeter User)
        