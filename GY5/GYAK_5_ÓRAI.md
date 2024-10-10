---

---
## Összefoglaló
___

Újabb programozási tételekkel folytatjuk:

-  Feltételes maximumkeresés
-  Eldöntés
-  Kiválasztás
-  Keresés


## Elmélet
___
#### Rekordtípus

A rekordtípus más típusok szemantikus és szintaktikus összekapcsolását teszi lehetővé.

```
peldany ∈ RekordTipus
RekordTipus = (adattag1:Halmaz x adattag2:Halmaz)
```

```C#
struct RekordTipus
{
	public int adattag1;
	public string adattag2;
	
	public RekordTipus(int a1, string a2)
	{
		adattag1 = a1;
		adattag2 = a2;
	}
}

RekordTípus peldany = new RekordTípus(érték, érték);
```


#### Új tételek

A gyakorlaton újonnan bevezetett tételek.


##### Feltételes maximumkeresés

A maximumkiválasztáshoz hasonló, ám feltétel mentén szűri a figyelembe vett indexeket. Fontos, hogy semmi nem garantálja a feltételnek eleget tevő index meglétét, így elképzelhető, hogy egyáltalán nem lesz miből maximumot kiválasztanunk. Ez a tétel, ennek okán, három visszatérési értékkel is rendelkezik, amelyből egy a találat létezését jelző logikai érték.

Paraméterei:

- bejárás (i=e..u)
- f(i) függvény
- T(i) függvény

```
(van, maxIndex, maxErtek) = MAX(i=e..u, f(i), T(i))
```

```C#
van = false;

maxIndex;
maxErtek;

for (int i = e; i <= u; i++)
{
	if (van && T(i))
	{
		if (f(i) > maxErtek)
		{
			maxIndex = i;
			maxErtek = f(i);
		}
	}
	else if (!van && T(i))
	{
		van = true;
		maxIndex = i;
		maxErtek = f(i);
	}
}
```


##### Eldöntés

Eldönti (és ennek alapján logikai értéket ad vissza), hogy van-e olyan i index a tartományban, amelyre T(i) igaz.

Paraméterei:

- bejárás (i=e..u)
- T(i) függvény

```
van = VAN(i=e..u, T(i))
```

```C#
van = false;
i = e;

while (i <= u && !T(i))
{
	i++;
}

van = (i <= u);
```


##### Kiválasztás

Ha tudjuk, hogy biztosan lesz olyan i, amelyre T(i) igaz, akkor a kiválasztás tételét érdemes használni ezen i megtalálására.

Paraméterei:

- bejárás (i>=e)
- T(i) függvény

```
index = KIVÁLASZT(i>=e, T(i))
```

```C#
index = e;

while (!T(index))
{
	index++;
}
```


##### Keresés

A keresés lényegében az eldöntés és kiválasztás tételének ötvözése.

Paraméterei:

- bejárás (i=e..u)
- T(i) függvény

```
(van, index) = KERES(i=e..u, T(i))
```

```C#
index = e;

while (index <= u && !T(index)) {
	index++;
}

van = (index <= u);
```


## Feladatok
___

#### 1. feladat: 180-nál magasabb

**Leírás:** Feljegyeztük diákok neveit és magasságait (centiméterben). Döntsük el, hogy van-e köztük olyan, aki 180 centinél magasabb.

```
Be: n ∈ N,
    diakLista ∈ Diak[1..n],
    Diak = (nev:S x magassag:N)
Ki: van ∈ L
Ef: -
Uf: van = VAN(i=1..n, diakLista[i].magassag > 180)
```

> [!faq] A beolvasás megtörténtét a lenti példában adottnak vesszük.

```C#
i = 0;

while (i < n && diakLista[i].magassag <= 180)
{
	i++;
}

van = (i < n)
```


#### 2. feladat: Magasság szerinti sorrend

**Leírás:** Nézzük meg, magasság szerinti sorrendben lettek-e feljegyezve a diákok.

```
Be: n ∈ N,
    diakLista ∈ Diak[1..n],
    Diak = (nev:S x magassag:N)
Ki: sorban ∈ L
Ef: -
Uf: sorban =
nem(VAN(i=1..n-1, (diakLista[i].magassag > diakLista[i+1].magassag)))
```

```C#
int i = 0;

while (i < n-1 && (diakLista[i].magassag <= diakLista[i+1].magassag))
{
	i++;
}

sorban = !(i < n-1);
```

>[!tip] A feladat ezzel ekvivalens módon a MIND (optimista eldöntés) tételének használatával is felírható:

```
Be: n ∈ N,
    diakLista ∈ Diak[1..n],
    Diak = (nev:S x magassag:N)
Ki: sorban ∈ L
Ef: -
Uf: sorban =
MIND(i=1..n-1, (diakLista[i].magassag <= diakLista[i+1].magassag))
```


#### 3. feladat: q centis átfogó

**Leírás:** Ismerjük derékszögű háromszögek befogóinak hosszait (centiméterben). Meg van adva továbbá egy q szám. Keressünk egy olyan háromszögeket (ha van), amely átfogója pontosan q centiméter. 

```
Be: n ∈ N,
    q ∈ R,
    befogoLista ∈ Befogo[1..n],
    Befogo = (a:R x b:R)
Ki: van ∈ L,
    index ∈ N
Ef: ∀i ∈ [1..n]: (befogoLista[i].a > 0 and befogoLista[i].b > 0)
Uf: (van, index) = KERES(i=1..n, sqrt((befogoLista[i].a)*(befogoLista[i].a) + (befogoLista[i].b)*(befogoLista[i].b)) = q)
```

```C#
index = 0;

while (index < n && sqrt((befogoLista[i].a)*(befogoLista[i].a) + (befogoLista[i].b)*(befogoLista[i].b)) /= q) {
	index++;
}

van = (index < n);
```


## Gyakorlás
___
#### Ellenőrző kérdések

1. Miért fontos a rekordtípus használata?
2. Fogalmazd meg, mit valósítanak meg a fönt tanult tételek. Nézd meg a matematikai definíciójukat, és ennek fényében ellenőrizd válaszod.


#### Gyakorló feladatok

1. Ismerjük középkori városok nevét, lakóinak számát, illetve az éves bevételét aranyban.
	a) Van-e olyan város, ahol az egy főre jutó éves bevétel nagyobb, mint 50 arany?
	b) Melyik a legmagasabb éves bevételű, 1000 főnél kisebb lélekszámú város?
	c) Mekkora a különbség a két legnagyobb város lélekszáma között?

