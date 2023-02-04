# 01_SBaumgartner-MyExpWB

Developmentplatform: Unity 2020.3.18f1, Visual Studio 2019, Mac OS Monterey 12.5.1

Kurzbeschreibung: Schneebälle abblocken - Sobald der Spieler die Triggerbox im Bereich vor der Schneeballkanone betritt, beginnt die Kanone in regelmäßigen Abständen Schneebälle zu schießen. Die Geschwindigkeit und Richtung der Schneebälle varriert innerhalb eines vorgegebenen Bereichs und die Aufgabe des Spielers ist es, alle Schneebälle abzublocken (zu berühren). Der Spieler hat zu Beginn des Spiels einen Score von 0 Punkten und drei Leben. Sobald der Spieler einen Schneeball berührt, wird der Score um einen Punkt ergänzt. Erwischt der Spieler den Schneeball nicht, wird ihm ein Leben abgezogen, bis er keine Leben mehr hat - dann ist das Spiel vorbei und die Kanone hört auf zu schießen. Ähnlich wie bei Tetris oder Doodle Jump kann man das Spiel nicht gewinnen, sondern nur seinen Score maximieren. Sobald der Spieler verloren hat, wird ihm sein Score auf dem Scoreboard angezeigt.


3 Syntaxelemente:

- if-Statement
- array
- while-Schleife (konnte ich leider nicht einbauen)

Momentane Interaktion: Der Player ist im Moment noch eine Capsule mit dem Tag "Player". Der Player kann sich derzeit nicht aus eigener Kraft bewegen.


Limitations:

- Die vierte Kugel im Magazin der Kanone wird zwar gespawnt aber nicht abgeschossen. Das hat zur Folge, dass der Spieler diese Kugel nicht erwischen kann und daher automatisch ein Leben verliert.

- Das Abschussgeräusch der Kanone wird nur beim Abschuss der ersten Kugel abgespielt.

- Die Kanone schießt derzeit nur 5 Kugeln ab, weil nur 5 Kugeln im Array sind.

- Derzeit befindet sich noch keine Markierung für den Wirkungsbereich der Triggerbox am Boden.

- Die Skripte können noch nicht in den Weihnachtsmarkt implementiert werden, da sie noch nicht richtig benannt sind.
