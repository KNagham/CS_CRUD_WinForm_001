# CRUD System 
![CRUD System](https://user-images.githubusercontent.com/97918228/161865457-5b612509-c6f4-4567-b1df-5b181f048503.png)
### Die angewendete Programmiersprache
  - C#
### Die angewendete Graphical User Interface "GUI"
  - WinForm
### Funktion des Systems
  - Das programm ist mit einem SQL Server verbunden ermöglicht:
    - Creat die Daten
    - Reading die Daten 
    - Ändern die Daten 
    - Löschen die Daten
  - Funktionalität des Programms
    - Das Button "Insert" ermöglicht neue Daten hinzufügen ohne den Primärschlussel bzw. den ID manuell zu geben, da er Auto Increment in dem SQL Server konfiguriert
    - Das Button "Update" ermöglicht Daten zu ändern, die in der Datenbank vorhanden sind 
    - Das Button "Delete" ermöglicht Daten zu löschen, die in der Datenbank vorhanden sind 
    - Das Button "Search" ermöglicht nach einem Daten zu suchen, durch den ID falls er nicht bekannt ist, könnte es durch den Vorname, Name, Note, Fach oder welche Benutzer haben die Fach abgeschlossen
    - in der GridView wird es gezeigt die gefragte Daten oder die ganze Daten, die in der Datenbank vorhanden sind  
 ### Fuktionen in der Code benutzt wurde
  - Db Connection():Public Funktion öffnet und schlißt die Verbindung zum Datenbank in SQL Server, in dem wurde Adresse des SQL Servers definiert
  - Clear(): Public Funktion nachdem hinzufügen, löschen oder ändern die Daten in der Datenbank ermöglicht die Feldern zu leeren
  - Update(): Publich Funktion ermöglicht die Daten zu ändern
  - btnInsert(): Private Funktion, in dem wurde die Daten hinzugefügt und difiniert welche Daten gehören welches Feld. Am Ende wurde die Funktion Clear() ausgeführt, um die Felder zu leeren und die Funktion Update(), um die Daten zu aktualisieren
  - btnDelete(): Private Funktion ermöglicht Daten zu löschen durch dem Suche nach dem ID, Am Ende wurde die Funktionen Clear() und Update() ausgeführt
  - btnSearch(): Private Funktion ermöglicht die Suche nach einem bestimmten Datensatz in der Datenbank anhand den ID falls er unbekannt ist, kann Man durch die andere Info, Am Ende wurde die Funktion Clear() ausgeführt
### Die Datentyp
  - ID: ist Integer, da in der GUI wurde immer die Daten als String gezeigt, beim bearbeiten bestimmte Datensatz sollte er den Parameter vom string to int 
  - Vorname: ist String
  - Name: ist string
  - Alter: ist integer
  - Fach: ist String
  - Note: ist double
  - Abgeschlossen: ist einen Boolean und wird in dem Microsoft SQL Server als Bit definiert Bei 0 ist gleich Falsch, Bei 1 ist gleich Richtig  
      


