---

---

## Összefoglaló
___

Megismerkedtünk a kurzuson tanult specifikációs eljárás felépítésével és jelöléseivel. Egyszerű példákon keresztül gyakoroltuk ennek használatát.


## Elmélet
___
#### Mi az a specifikáció?

A tárgyon tanult specifikációs eszköz a megoldandó feladat formalizált "megragadását", absztrahálását teszi lehetővé. *Idézve az előadásból:*

> *„a feladat formális megragadása szerződés a megbízó és a fejlesztő között"*


#### A specifikáció részei

A specifikációnk négy részből fog állni, méghozzá az alábbiakra bomlik:

##### Bemenet

A bemenetnél jelölni kell minden olyan adatot, amelyet a feladatmegoldásunk felhasznál, vagyis, amiktől a kimeneteink függeni fognak (a feladatmegoldásunkra végsősoron függvényként is tekinthetünk).

##### Kimenet

A kimenetnél nyilatkozunk azokról az adatokról, amelyeket a megoldás eredményeképp szeretnénk kapni. A kimenet önmagában nem ad választ arra, hogy mi lesz az eredmény, csak arra, hogy milyen típusú az, valamint, hogy milyen azonosítóval hivatkozunk rá a specifikációban. Ahogy bementből, természetesen kimenetből is lehet több.

##### Előfeltétel

Előfordulhat, hogy a bementnek bizonyos megkötéseknek kell megfelelnie, hogy értelmes eredmény legyen számítható belőle. (Nem lehet például egy személy magassága negatív érték.) Máskor a számítás elvégezhető a kizárni kívánt értékekkel, de azokról tudjuk, hogy értelmetlenek (1000 méter magas ember).

##### Utófeltétel

Az utófeltétel talán a legfontosabb (de legalábbis legbeszédesebb) része a specifikációnak. Megmondja, hogy a megoldás bemente és kimenete között milyen kapcsolat áll fenn. Nagyon fontos kihangsúlyozni, hogy nem a megoldás módját vagy menetét adja meg, tehát az algoritmustól eltérő és sokszor teljesen független dologról beszélünk.


## Feladatok
___

#### 1. feladat: Összeadás

**Leírás:** Két természetes szám összeadása.

```
Be: a ∈ N, b ∈ N
Ki: c ∈ N
Ef: -
Uf: c = a + b
```

```C#
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int c = a + b;
```


#### 2. feladat: Páros a szám?

**Leírás:** Döntsük el egy számról, hogy páros-e.

```
Be: szam ∈ N
Ki: paros ∈ L
Ef: -
Uf: paros = (szam % 2 = 0)
```

```C#
int szam = int.Parse(Console.ReadLine());

bool paros = (szam % 2 == 0);
```


#### 3. feladat: Prím a szám?

**Leírás:** Döntsük el egy számról, hogy prím-e.

```
Be: szam ∈ N
Ki: prim ∈ L
Ef: szam > 1
Uf: szam ≠ 2 and
    prim = (∀i ∈ [2..(szam div 2)]: (szam % i ≠ 0))
```

```C#
int szam = int.Parse(Console.ReadLine());

bool prim = true;

if (szam == 2)
{
	prim = false;
}

int i = 2;
while (prim && i < szam2/2)
{
    prim = (szam2 % i != 0);
    i++;
}
```


#### 4. feladat: Melyik síknegyedbe esik?

**Leírás:** Döntsd el egy koordinátáról, hogy egy Descartes-féle derékszögű koordináta-rendszer melyik síknegyedébe tartozik.

```
Be: x ∈ R, y ∈ R
Ki: sikNegyed ∈ N
Ef: x ≠ 0 and y ≠ 0
Uf: ((x > 0 and y > 0) -> sikNegyed = 1) and
    ((x < 0 and y > 0) -> sikNegyed = 2) and
    ((x < 0 and y < 0) -> sikNegyed = 3) and
    ((x > 0 and y < 0) -> sikNegyed = 4)
```

```C#
double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());

int sikNegyed;

if (x > 0 && y > 0)
{
    sikNegyed = 1;
} else if (x < 0 && y > 0)
{
    sikNegyed = 2;
} else if (x < 0 && y < 0)
{
    sikNegyed = 3;
} else
{
    sikNegyed = 4;
}
```


## Gyakorlás
___
#### Ellenőrző kérdések

1. Mik a specifikáció részei, és mi a szerepük?
2. Mi az implikáció igazságtáblája?
3. Hogyan valósítom meg implikációval az esetszétválasztást? Miért működik?


#### Gyakorló feladatok

>**Az elkészített feladatokat Teams-en és az egyetemi levelezésemen is szívesen fogadom!**

1. Kérjünk be két természetes számot (a és b), majd döntsük el, milyen számjegy áll a-nak a b-edik helyiértékén.
2. Találjuk meg kettő szám legnagyobb közös osztóját.