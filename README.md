<!--

author:   Volker Göhler
email:    volker.goehler@informatik.tu-freiberg.de
version:  0.0.1
language: de
narrator: Deutsch Female

edit: true
date: 2026-04-09

icon: img/TUBAF_Logo_blau.svg
logo: 

attribute: title image Von Bundesarchiv, Bild 183-41030-0002 / Draum / CC-BY-SA 3.0, CC BY-SA 3.0 de, https://commons.wikimedia.org/w/index.php?curid=5428443


attribute: Sicherheitszeichen von [Berufsgenossenschaft Holz und Metall](https://www.bghm.de/arbeitsschuetzer/praxishilfen/sicherheitszeichen)

comment:  Arbeitssicherheit & Gesundheitsschutz

link:   https://raw.githubusercontent.com/vgoehler/LiaScript_CSS_Provider/refs/heads/main/dist/university.css

tags: [ Sommersemester2026, Softwareentwicklung, Übung00]

-->

# Softwareentwicklung SoSe2026 - Aufgabe 00

In dieser Übung sollen Sie sich die verschiedenen Möglichkeiten der Erstellung von C# Programmen erarbeiten und diese evaluieren. Dabei sollen Sie verschiedene Editorkonzepte ausprobieren und im Hinblick auf Ihre Anforderungen testen. Verwenden Sie die von Ihnen ausgewählte Toolchain zum Lösen der gestellten Aufgaben.

## Bearbeitungszeit

29. April - 3. Mai 2024


## 1. Wahl der Werkzeuge

Nehmen wir an, Sie sind der Technologie-Scout in einem Unternehmen. Nachdem Microsoft seine Strategie bezüglich der Lizenzen von .NET geändert hat, wollen Sie sich einen Überblick verschaffen und testen, welche Tool-Chain für die Anforderungen in Ihrem Unternehmen am geeignetsten ist.

Um Ihnen eine Richtschnur zu geben, haben wir etwas vorgearbeitet:

| Konzept                             | Beispiele                                      | Tutorials                                                                                                                                                                                  |
| ----------------------------------- | ---------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Texteditor und Commandozeile        | Notepad++ und .NET                       | [Link](https://www.youtube.com/@dotnet) |
| Leichtgewichtige integrierte Lösung | Microsoft Visual Studio Code, Atom, Sublime Text, ... | C# mit Visual Studio Code [Link](https://www.youtube.com/watch?v=uytNCXw9dME)                                                                                             |
| Schwergewichtige IDE                | Microsoft Visual Studio 2022, Eclipse, ...            |  Visual Studio Community Edition [Link](https://visualstudio.microsoft.com/de/vs/community/), [https://www.youtube.com/@visualstudio](https://www.youtube.com/@visualstudio)             |

> Kurze Installationsanleitungen zu Visual Studio Code inkl. C#-Extension finden auch im OPAL im Verzeichnis Toolchains.

**Obige Auflistung stellt kein Muss dar. Fühlen Sie sich frei eigene Editoren, Compiler und Ausführungsumgebungen zu verwenden!**

Testen Sie mindestens zwei Konzepte. Legen Sie dazu mit den gewählten Tools `Hello-World` Projekte an.

## 2. Datentypen, Ein- und Ausgabe, formatierte Ausgabe

Zum auf einem fernen Planeten lebenden Energie-Wesen sollen folgende Daten ein und ausgegeben werden:

+ Bezeichnung (Zeichenkette)
+ Registriernummer (eine 5-stellige ganze Zahl),
+ Kategorie (Buchstabe A, B oder C),
+ Leuchtkraft (reelle Zahl mit 2 Nachkommastellen)

Entwickeln Sie Ihr Programm schrittweise:

1. Initialisieren Sie die Variablen mit geeigneten Konstanten ...
2. Lesen Sie die Werte von der Kommandozeile ein ...
3. Geben Sie die Werte von Tastatur ein ...
... und geben Sie diese anschließend aus.

Verwenden Sie die Datentypen `string`, `int`, `char` und `double`, für die Ausgabe die Methode `Console.WriteLine()` und für die Eingabe die Methode `Console.ReadLine()`. Bei der Ausgabe ist, falls nötig, die `ToString`-Methode zu verwenden, z.B. im Falle einer Gleitkommazahl:
`value = zahl.ToString(CultureInfo.InvariantCulture);`

Die Methode `Console.ReadLine()` liefert eine Zeichenkette, die in einen entsprechenden Datentyp umgewandelt werden muss. Dazu stehen z.B. für double folgende Methoden zur Verfügung:

```csharp
double wert = Convert.ToDouble(string, culture_specification);
double wert = double.Parse(string, culture_specification);
bool bwert = double.TryParse(string, styles, culture_specification, out wert);
```

Verwenden Sie als `culture_specification` `CultureInfo.InvariantCulture`
und `NumberStyles.AllowDecimalPoint` oder `NumberStyles.Any` als `style`.

> Erfahrenere Programmierer können für die Kategorie gern `enum`-Typ verwenden und bei der Konvertierung mit `Convert` und `Parse` die Ausnahmen(Exception) behandeln!

## 3. Fehler

Im Repository finden Sie die Datei `Temperatur.cs` , die ein fehlerhaftes Programm zur Umrechnung der Temperatur von Grad Celsius in Fahrenheit unter Verwendung der Formel:

$5 \cdot (T_{Fahrenheit} - 32) = 9 \cdot T_{Celsius}$

beinhaltet. Korrigieren Sie das Programm und führen Sie es aus.


## 4. Ausdrücke

**a) Arithmetische Operatoren**


Definieren und initialisieren Sie folgende Variablen:

```csharp
int a = 1, b = 2, c = 3, r = 4;
double y = 4.0;
```

Definieren Sie des Weiteren noch fehlende Variablen, berechnen Sie die Ausdrücke und geben Sie die Ergebnisse aus.

$d=\frac{a}{b}$

$f=\frac{a+b}{c-y}-\frac{a}{b}$

$f=\frac{-b+\sqrt{b^2-4ac}}{2a}$

$A = \pi r^2$

**b) Boolsche und Vergleichsoperatoren**

Überprüfen Sie in einem Programm

+ ob der eingegebene Wert für x im Bereich x1...x2 liegt,
+ ob der durch x und y definierte Punkt in einem Rechteck mit den Eckpunkten x1, y1 und x2, y2 liegt,
+ ob zwei Punkte die gleichen Koordinaten haben,
+ ob mindestens eine der Bedingungen x1<=x<=x2 bzw. y1<=y<=y2 zutrifft.

Lesen Sie die Werte x1, y1, x2, y2, x und y ein. Formulieren Sie die logischen Ausdrücke, die auf die
Variable vom Typ `bool` zugewiesen werden, geben Sie den Wert der Variable aus.

**c) Bit- und Shift-Operatoren**
Variablen x und y sind wie folgt definiert:

```
int x = 0b0001_0001, y=0b1000_1000, z=0b1111;
```

Berechnen Sie folgende Ausdrücke und geben Sie die Ergebnisse als Hexadezimalzahlen aus. Überlegen Sie wie diese Ergebnisse zustande kommen:

+ `x & y & z`,
+ `(x | y) & z`,
+ `~(x ^ y)` und
+ `~(x ^ y) & byte.MaxValue`

Mit welchem Operator kann aus dem Wert x der Wert y berechnet werden? Überprüfen Sie Ihre Vermutung.
