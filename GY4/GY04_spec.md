---

---

## Összefoglaló
___

Megkezdtük a programozási tételek elsajátítását. Elsajátítottuk és gyakoroltuk:

-  Összegzés
-  Feltételes összegzés
-  Megszámlálás
-  Maximum kiválasztás


## Elmélet
___

>A programozási tételek meghatározásának ismeretét a gyakorlaton adottnak vesszük, hiszen ez az előadás anyagát képezi. Röviden: **a programozási tételek általánosított eljárások bizonyos problématípusok megoldására.**


#### Programozási tételek leírása

Egy programozási tétel használata specifikációnkban kétféle módon adható meg:

- **Tisztán matematikailag-logikailag**
- **Rövidített módon** (gyakorlatban ezt fogjuk alkalmazni)

A rövidített leírás a következőképpen épül fel:

```
eredmények = TÉTEL_NEVE(paraméterek)
```

A programozási tételek alábbi három paraméterét különböztetjük meg (habár nem minden tétel él az összessel):

- **Bejárás (i=e..u vagy i>=e)**: egész számok azon tartománya, amelyek a tétel a futása során indexel/bejár.
	i=1..n

- **f(i) függvény**: a bejárt indexekhez elemeket rendel, ezeken fog végrehajtódni a tétel által megvalósított művelet *(például ezeket az elemeket adjuk össze összegzésnél)*.
	f(i) = tomb\[i\]

- T(i) függvény: a bejárt indexekhez logikai értéket rendel. Ennek két célja lehet. Egyes tételeknél ez dönti el, hogy az ugyanezen indexhez rendelt f(i) elem figyelembe legyen-e véve a tétel műveletvégzésében. Más tételeknél magát a megoldást adja meg.
	T(i) = (tomb\[i\] > 40)


#### Új tételek

A gyakorlaton újonnan bevezetett tételek.


##### Összegzés

Olyan elemeket összegez (vagy tetszőleges művelettel összesít), amelyeken értelmezve van az összegzést/összesítést megvalósító művelet.

Paraméterei:

- bejárás (i=e..u)
- f(i) függvény

```
osszeg = SZUM(i=e..u, f(i))
```

```C#
osszeg = 0;
for (int i = e; i <= u; i++)
{
	osszeg += f(i);
}
```


##### Feltételes összegzés

Az összegzés kibővítése egy feltétellel. Csak T(i) teljesülése esetén összegzi f(i)-t.

Paraméterei:

- bejárás (i=e..u)
- f(i) függvény
- T(i) függvény

```
osszeg = SZUM(i=e..u, f(i), T(i))
```

```C#
osszeg = 0;
for (int i = e; i <= u; i++)
{
	if (T(i))
	{
		osszeg += f(i);
	}
}
```


##### Megszámlálás

Megszámolja, hány i esetén teljesül T(i).

Paraméterei:

- bejárás (i=e..u)
- T(i) függvény

```
db = DARAB(i=e..u, T(i))
```

```C#
db = 0;
for (int i = e; i <= u; i++)
{
	if (T(i))
	{
		db++;
	}
}
```


##### Maximum kiválasztás

Bejárja az indexintervallumot, és megkeresi azt az i-t, amely esetében f(i) a legnagyobb. Fontos, hogy f olyan halmazba képezzen, amelyen lineáris rendezés értelmezve van. A tétel két értéket hoz létre: a legnagyobb f(i) indexe, és maga a legnagyobb f(i).

Paraméterei:

- bejárás (i=e..u)
- f(i) függvény

```
(maxIndex, maxErtek) = MAX(i=e..u, f(i))
```

```C#
maxIndex = e;
maxErtek = f(e);

for (int i = e+1; i <= u; i++)
{
	if (f(i) > maxErtek)
	{
		maxIndex = i;
		maxErtek = f(i);
	}
}
```


## Feladatok
___

#### 1. feladat: Beolvasás a későbbi feladatokhoz

**Leírás:** Egy király bekéri az országában lakó N darab emberhavi keresetét - *valószínűleg nem kifejezetten tiszta szándékkal.* Ismerjük továbbá az ország törvényi minimálbérét.

```C#
int N = int.Parse(Console.ReadLine());
double minimalBer = double.Parse(Console.ReadLine());

double[] berLista = new double[N];
for (int i = 0; i < N; i++)
{
    berLista[i] = double.Parse(Console.ReadLine()); 
}
```

>**Megjegyzés:** hogy az adatok beolvasását ne kelljen minden részfeladatnál ismételten megejteni, a fönti kódsor lefutását minden ilyen részfeladat előtt adottnak tekintjük. Lesznek olyan feladatok, amelyek nem használják az összes beolvasott adatot.


#### 2. feladat: Az ország összkeresete

**Leírás:** A király kíváncsi az országának összkeresetére, így számolásba kezd.

```
Be: n ∈ N,
    berLista ∈ R[1..n]
Ki: mindenBerOsszege ∈ R
Ef: ∀i ∈ [1..n]: (berLista[i] > 0)
Uf: mindenBerOsszege = SZUM(i=1..n, berLista[i])
```

```C#
double mindenBerOsszege = 0;

for (int i = 0; i < N; i++)
{
    mindenBerOsszege += berLista[i];
}
```


#### 3. feladat: Kizsákmányolhatók száma

**Leírás:** A király túlzottan empatizál a gazdagokkal ahhoz, hogy megadóztassa őket, így a kevésbé tehetősek bevételére vet szemet. A király először is megszámolja azon polgárainak számát, akiknek keresete nem haladja meg a minimálbér 120%-át.

```
Be: n ∈ N,
    berLista ∈ R[1..n],
    minimalBer ∈ R
Ki: kizsakmanyolhatokSzama ∈ N
Ef: ∀i ∈ [1..n]: (berLista[i] > minimalBer)
Uf: kizsakmanyolhatokSzama =
    DARAB(i=1..n, (berLista[i] <= minimalBer * 1.2))
```

```C#
int kizsakmanyolhatokSzama = 0;
            
for (int i = 0; i < N; i++)
{
    if (berLista[i] <= minimalBer*1.2)
    {
        kizsakmanyolhatokSzama++;
    }
}
```


#### 4. feladat: Zsebre tett adó

**Leírás:** A király egy csekély 70%-os adót vet ki a minimálbér legfeljebb 120%-át megkereső lakosok havi bérére. Mennyi pénzre tesz így szert?

```
Be: n ∈ N,
    berLista ∈ R[1..n],
    minimalBer ∈ R
Ki: osszAdo ∈ R
Ef: ∀i ∈ [1..n]: (berLista[i] > minimalBer)
Uf: osszAdo =
    SZUM(i=1..n, (berLista[i] * 0.7), (berLista[i] <= minimalBer * 1.2))
```

```C#
double osszAdo = 0;

for (int i = 0; i < N; i++)
{
    if (berLista[i] <= minimalBer * 1.2)
    {
        osszAdo += berLista[i] * 0.7;
    }
}
```


#### 5. feladat: Új király

**Leírás:** A királyt váratlan "baleset" éri, így a nép új uralkodót választ magának. Kényelmi okokból a legmagasabb keresetűt szeretnék megválasztani. Hányadik lakos ez a listában, és mennyit keres?

```
Be: n ∈ N,
    berLista ∈ R[1..n]
Ki: ujKiralyIndex ∈ N,
    ujKiralyKeresete ∈ R
Ef: ∀i ∈ [1..n]: (berLista[i] > 0)
Uf: (ujKiralyIndex, ujKiralyKeresete) =
    MAX(i=1..n, berLista[i])
```

```C#
int ujKiralyIndex = 0;
double ujKiralyKeresete = berLista[0];

for (int i = 1; i < N; i++)
{
    if (berLista[i] > ujKiralyKeresete)
    {
        ujKiralyIndex = i;
        ujKiralyKeresete = berLista[i];
    }
}
```



## Gyakorlás
___
#### Ellenőrző kérdések

1. Fogalmazd meg, mit valósítanak meg a fönt tanult tételek. Nézd meg a matematikai definíciójukat, és ennek fényében ellenőrizd válaszod.
2. Mi a három nevezetes paraméter szerepe?


#### Gyakorló feladatok

>**Az elkészített feladatokat Teams-en és az egyetemi levelezésemen is szívesen fogadom!**

1. Valósíts meg egy megszámlálást, azonban csak a feltételes összegzés tételét használd hozzá.
2. Alakítsd át a maximum kiválasztás tételét olyan módon, hogy a legkisebb elemet adja meg.


