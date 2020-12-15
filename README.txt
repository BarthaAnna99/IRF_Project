IRF Beadandó

Feladatok: adatbázis, kifejtett setter ág, fromázott Excel, enumeráció

A beadandó keretein belül egy drag and drop alapú Kanban táblázatot készítettem el, aminek segítségével nyomon lehet követni egy-egy projekt munkaterület feladatainak az előrehaladását.
A felhasználói felületet tekinte alapvetőn egyformos megoldásra törekedtem, ezért inkább paneleket és usercontrol-okat alkalmaztam. Természetesen mindennek az volt a célja, hogy a felhasználó könnyen megtalálja azt, amit szeretne.
A programom felépítése és a fő funkciói:
- az alkalmazás alapvetően egy adatbázisra épül, hiszen itt tárolódik el minden releváns adat. Maga az adatbázis felépítse elég egyszerű (csillagséma), összesen 3 táblát tartalmaz.
- a From1 alapvetően csak a UI felépítése van, az itt található gombokkal lehet megnyitni az UC-ket
- UCKanban: ez a programnak a fő felülete. Az adott időszakot kiválasztva láthatjük, hogy milyen feladatok/userstoryk vannak. Ezekre kattintva megnyílik egy új ablak, ahol részletesebb információkat is láthatunk, illetve szerkeszthetjük is az adott elemet (pl a fontosságán álltva változik a háttér színe). Az elemek húzógatásával pedig az egyik státuszból áthelyezhetjük a másikba. A jobb felső sarokban található + jellel új userstory-kat vehetünk fel, míg az excel icon az adott időszak elemeit nyitja meg Excel táblában.
- UCJelentés: ezen a felületen összesítve láthatjuk, hogy az egyes személyek hány feladatot vittek el, amit egy diagramon is ábrázoltam
- UserStoryField: ezt a származtatott osztály külön kiemelném, hiszen talán ez a fő építőelem a programomban. Ebben használtam kifejetet setter ágat, amikor az egyes elemek hátterének a színét állítom aszerint, hogy milyen fontosságú, illetve ugyanitt használuk enumerációt (csak az adott értékeket veszi fel: alacsony, közepes, magas)

