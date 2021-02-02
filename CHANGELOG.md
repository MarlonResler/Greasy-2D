# Dokumentation Meetings

## Wie sind Meetings abgelaufen?

Wir haben versucht, jede Woche ein Meeting zu halten, indem wir das Sprint Review, Planning und Standup zusammenfassen wollen. Wir haben erst allgemein darüber gesprochen, wie unsere Entwicklung vorangeht, ob es Probleme gibt und dann z.B. git merges o.Ä. durchgeführt. Danach sind wir die einzelnen Stories im Sprint Backlog durchgegangen und haben geschaut, ob und wie sie funktionieren. Wir haben nicht fertige Stories zurück in den Product Backlog gelegt. Zuletzt haben wir das Sprint Planning für die nächste Woche durchgeführt, indem wir festgelegt haben welche Aufgaben wer bis zum nächsten Meeting erledigt. Die Sprint Retrospective haben wir am letzten Meeting gehalten.

## 20.11.20

- Was soll im nächsten Sprint gemacht werden:
  - Main Character -> Marlon
  - Level 1 -> Simon
  - Level 2 -> Daniel
- Sonstiges:
  - Spielgenre festgelegt auf Jump n Run
  - Unity als Spielengine nutzen und Projekt aufgesetzt (Unity + Git)

## 25.11.20

### Daily Standup

- Probleme mit Git und dem Unityprojekt
  - Gemeinsam Änderungen gemerged und Branches angelegt

### Sprint Review

- Was wurde in diesem Sprint gemacht:
  - Main Character
- Was wurde nicht geschafft:
  - Level 1
    - Texturen fehlen, nicht spielbar
  - Level 2
    - Texturen fehlen, nicht spielbar

### Sprint Planning

- Was soll im nächsten Sprint gemacht werden:
  - Level 1 -> Simon
  - Level 2 -> Daniel
  - Patrol Enemy -> Daniel
  - coin + UI -> Daniel

## 02.12.20

### Daily Standup

- Pull Request des MainCharacters und einfügen in die bestehenden Level

### Sprint Review

- Was wurde in diesem Sprint gemacht:
  - Level 2
  - Patrol Enemy
  - coin + UI
- Was wurde nicht geschafft:
  - Level 1

### Sprint Planning

- Was soll im nächsten Sprint gemacht werden:
  - Level 1 -> Simon
  - Main Menu -> Marlon
  - improve Main Character Movement -> Marlon

## 16.12.20

### Daily Standup

--

### Sprint Review

- Was wurde in diesem Sprint gemacht:
  - Level 1
  - Main Menu
- Was wurde nicht geschafft:
  - Main Character Movement verbessern

### Sprint Planning

> Wegen Weihnachten und Neujahr kein Sprint

## 03.01.20

### Daily Standup

--

### Sprint Review

> Wegen Weihnachten und Neujahr kein Sprint

### Sprint Planning

- Was soll im nächsten Sprint gemacht werden:
  - Grafiken, Hintergründe, Leveldesign
  - Movement der Gegner
  - Main Menu
  - Main Character Lightning

## 10.01.20

### Daily Standup

- Gemeinsam die Änderungen des Main Characters gemerged

### Sprint Review

- Was wurde in diesem Sprint gemacht:
  - Main Character Lightning
  - Superlinter hinzufügen
  - Grafiken, Hintergründe, Leveldesign
  - Movement der Gegner
  - Main Menu
- Was wurde nicht geschafft:
  - Im Main Menu fehlt der Exit Node in das nächste Level
  - Texturen fehlen

### Sprint Planning

- Was soll im nächsten Sprint gemacht werden:
  - Main Menu:
    - Texturen
    - Scene Manager, um ins nächste Level zu kommen
  - Design der Level überarbeiten und Texturen erstellen

## 13.01.20

### Daily Standup

- Alle Branches auf dev gemerged und synchronisiert

### Sprint Review

- Was wurde in diesem Sprint gemacht:
  - Main Menu:
    - Texturen
    - Scene Manager, um ins nächste Level zu kommen
  - Design der Level überarbeiten und Texturen erstellen
  - Zwischenstand wurde mittels Pull Requests auf dev gemerged, um alle Branches wieder zu synchronisieren
- Was wurde nicht geschafft:

### Sprint Planning

- Was soll im nächsten Sprint gemacht werden:
  - End Screen -> Marlon
  - Coin Saving -> Marlon
  - Skins -> Marlon
    - Buy Skin with coins
    - Save actual skin
    - Save buyed skins
  - Release v1.0
    - Alle Bugfixes und Improvements
    - Alle Branches Mergen
    - Release erstellen -> Marlon
      - Binary builden
      - Mittels Self Extractor "Installer" bauen

## 31.01.20 - Zusätzlich Retrospective

### Daily Standup

- Version Branch und Release Build

### Sprint Review

- Was wurde in diesem Sprint gemacht:
  - End Screen
  - Coin Saving
  - Skins
  - Release v1.0
- Was wurde nicht geschafft:
- Welche Stories aus dem Product Backlog sind verbleibend:
  - Endboss
  - Coins verlieren, wenn ein Gegner mich hittet (nicht nur die aus aktuellem Level)
  - Movement des Main Characters verbessern

### Protokoll Retrospective:

Was war gut:

- Gut geplant, Umsetzung mit regelmäßigen Meetings hat gut funktioniert
- Aufteilung eines Meetings in Standup, Review und Planning
- Durch die vielen Meetings konnten Fragen und Fehler schnell und gut geklärt werden und die Scrum Grundlagen wurden dadurch verinnerlicht

Was war schlecht:

- Projekt Kanban im github ist etwas unübersichtlich
  - Keine Änderungsansicht der letzten Sprints, sondern nur aktueller Sprint
  - Tools wie Jira
- User Storys aus Sicht des Spielers formulieren, wenn Product Owner selber Entwickler ist
