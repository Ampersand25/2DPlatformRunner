

Liceul Teoretic “Lucian Blaga” Cluj-Napoca

Lucrare pentru obținerea atestatului profesional la

INFORMATICĂ

**JUMPER**

*Profesor coordonator,*

*Chitiul Daniela*

*Realizator,*

*Stanciu Cristian*

*clasa a XII-a A*

2019





**Cuprins**

\1) Prezentarea generală a temei abordate/motivația

alegerii temei și utilitatea aplicației – pag. 1

\2) Resurse hardware și software necesare – pag. 7

\3) Realizare aplicație:

vprezentare succintă a limbajelor și tehnologiilor

utilizate (C#, Unity, Visual Studio) – pag. 11

vdescriere UI (scene, meniuri, opțiuni, butoane, etc.)

\+ gestionare setări (activare/dezactivare reclame,

reglare volum, resetare statistici, pornirea/oprirea

modului de vibrație, etc.) – pag. 15

\4) Modul de utilizare al aplicației/descriere parte de

gameplay (characters + animații specifice, nivele, sistem

de score și highscore, checkpoint-uri, obstacole,

obiective, etc.) + capturi de ecran – pag. 21

\5) Disponibilitate curentă + extinderi posibile ale

aplicației – pag. 26

\6) Referințe (asset-uri folosite în dezvoltarea aplicației,

tutoriale C#, Unity, etc.) + alte link-uri utile (inclusiv

website aplicație) – pag. 32





**1.Introducere**

***logo-ul aplicației (realizat în Paint 3D)***

Proiectul ales de mine pentru susținerea lucrării de

atestat la informatică reprezintă un joc creat în Unity

Engine utilizând limbajul de programare C# cu ajutorul

căruia am scris script-uri cu care controlez ceea ce se

întâmplă atât la nivel de gameplay cât și din punct de

vedere al UI-ului (de exemplu funcționalitatea butoanelor

din joc este dată de anumite evenimente definite la nivel

de cod prin anumite metode/funcții specifice).

Conceptul din spatele jocului este unul simplu,

acesta fiind un 2D Platformer << tip de joc în două

dimensiuni în care jucătorul controlează un caracter

care trebuie să sară de pe o platformă pe alta evitând

obstacolele existente la nivelul gameplay-ului, obiectivul

jucătorului fiind acela de a completa nivelul curent. >>

1





destinat inițial pentru Android dat fiind faptul că telefonul

meu personal folosește acest sistem de operare și prin

urmare am putut testa aplicația în momentul în care am

construit apk-ul (cu ajutorul programului Android Studio),

dar având posibilitatea extinderii pe viitor și pe alte

platforme cum ar fi iOS sau WebGL.

2





Titlul aplicației (“Jumper” sau “JUMPER”) este unul

sugestiv, acesta sugerând obiectivul primordial al

jocului, ci anume acela de a sări de pe o platformă

statică pe alta în timp ce caracterul se deplasează cu

viteză constantă pe direcție orizontală (sensul de

mișcare fiind de la stânga la dreapta). Mai multe

amănunte referitoare la modul de joc vor fi prezentate la

punctul 4 al documentației.

***ss din timpul rulării de pe mobil***

Motivele care au stat la baza alegerii acestei teme

de proiect sunt după cum urmează (nu neapărat în

ordinea importanței):

dorința de a crea ceva mai deosebit față de

majoritatea elevilor care optează pentru un site în

HTML și CSS

3





faptul că un program interactiv sau un joc în

consolă în C++ sau Python (limbajele cunoscute de

către mine la momentul începerii lucrării de atestat),

dar și în orice alt limbaj de programare, ar fi fost

teme mult prea simpliste și care nu mi-ar fi oferit

posibilitatea de a învăța atâtea tehnologii noi plus

că timpul de realizare al unui astfel de proiect ar fi

fost unul relativ scurt (de câteva zile, cel mult una

sau două săptămâni în funcție de complexitate)

inițierea unui prim contact cu industria jocurilor

video, o industrie care în ultimii ani se află într-o

continuă ascensiune la nivel de piață și în care nu

trebuie să dispui de bugete colosale precum

companiile AAA pentru a avea succes și a genera

venituri de pe urma vânzărilor produsului sau a

reclamelor

faptul că dacă aș fi ales să lucrez la un site aș fi

avut mai mult de scris text și cules informații decât

de scris cod efectiv

posibilitatea de a mă putea pune în pielea unui

game developer și să înțeleg astfel mai bine efortul

și dedicația care stau în spatele unui joc indiferent

de complexitatea acestuia, lucru pe care nu îl poți

conștientiza în momentul în care te joci un joc, ci

doar atunci când experimentezi cu adevărat

procesul de creație al unui joc. Acest proiect m-a

ajutat în primul rând să apreciez, mult mai mult

decât o făceam înainte, munca oamenilor care

lucrează în actul de producție al unui joc video

multitudinea de posibilități și diversitatea de care

dispune această piață a gaming-ului

flexibilitatea pe care o are Unity, care conferă nu

doar posibilitatea de a crea jocuri, ci și de a realiza

4





aplicații în alte scopuri decât cel al

entertainmentului, după cum au dovedit colegii mei

de clasă care au creat un simulator de trafic cu

ajutorul acestui program

popularitatea și competivitatea de care dispune

game development-ul (există foarte multe game

jam-uri destinate deopotrivă începătorilor cât și

persoanelor experimentate în această industrie,

majoritatea competițiilor fiind unele online care nu

necesită taxă de participare sau alte costuri

suplimentare). Aceste game jam-uri pe lângă faptul

că reprezintă o oportunitate de a lucra în echipă cu

alți pasionați de game development și de a obține o

experiență unică atât în ceea ce privește munca în

echipă cât și în ceea ce privește modul în care este

conceput și dezvoltat un joc sau o aplicație, vin de

regulă cu premii pe măsură (de la bani și până la

asset-uri cadou, în funcție și de amploarea

competiției).

5





Scopul aplicației este exclusiv acela de

agrement/distracție. De menționat faptul că jocul nu

necesită conexiune la internet, acesta fiind offline.

6





**2.Resurse hardware și software**

**necesare**

Resursele folosite pentru realizarea aplicației sunt

următoarele:

**Hardware:**

. *Model laptop:* ASUS ROG STRIX GL753

. *Procesor (CPU):* Intel® Core™ i7 7700HQ

CPU @ 2.80GHz, 3.80 GHz CPU Speed

. *Placă video/grafică (GPU):* NVIDIA GeForce

GTX 1050 cu 4 GB de VRAM (Video RAM)

. *Memorie (RAM):* 8.00 GB (7.88 GB usable)

. *Spațiu liber pe hard-disk:* minim 3.51 GB

(3,778,822,144 bytes) pentru folder-ul cu

proiectul

. *Rezoluție:* 1920 x 1080, 60Hz

**Software:**

. *Sistem de operare (OS):* Windows 10 Pro 64-

bit

. *Program:* Unity 2018.3.2f1 (64-bit) ca și game

engine folosit la realizarea aplicației

Telefonul de pe care am făcut testarea aplicației

este un smartphone Samsung Galaxy A5 din 2017 ce

dispune de următoarele specificații (acestea nu sunt

cerințele minime de sistem, jocul funcționând și pentru

telefoane mai puțin performante, dar pentru o experiență

optimă se recomandă un telefon cu specificații mai

7





avansate sau similare cu cele ce urmează a fi

prezentate):

\- *OS:* Android v8.0 Oreo

\- *Model procesor:* Octa Core cu frecvența de 1900

\- *Dimensiuni (W x H x D mm):* 71.4 x 146.1 x 7.9

\- *Memorie RAM:* 3 GB

\- *Rezoluție (pixeli):* 1920 x 1080

\- *Diagonală display (inch):* 5.2

8





Jocul poate fi suportat în momentul de față doar pe

dispozitive de tip smartphone ce au ca și sistem de

operare Android și care dispun de touchscreen

funcțional. De asemenea, aplicația poate fi rulată și

testată și folosind programe ce permit utilizarea

aplicațiilor mobile de pe PC cum ar fi BlueStacks (este

necesar, la fel ca și în cazul telefonului mobil, doar apk-

ul) sau chiar direct din Unity Engine în Game Window cu

ajutorul mouse-ului, doar că pentru acest lucru este

necesar accesul la întreg proiectul, nu doar la apk cum

este în cazul în care aplicația este rulată pe telefon.

***captură din timpul rulării de pe telefon***

9





***jocul în BlueStacks pe computer***

10





***jocul în fereastra Game din Unity***

**3.Realizare aplicației**

**Prezentare succintă a limbajelor și tehnologiilor**

**utilizate**

. *Unity:* Unity este un motor în timp real dezvoltat de

Unity Technologies, anunțat și lansat pentru prima

dată în iunie 2005 la Conferința Mondială a

Dezvoltatorilor de la Apple Inc., ca motor exclusiv

pentru jocul OS X. Începând cu anul 2018, motorul

a fost extins pentru a susține 27 de platforme.

Motorul poate fi folosit pentru a crea atât jocuri

tridimensionale cât și bidimensionale, precum și

simulări pentru numeroasele sale platforme. Câteva

versiuni majore ale Unity au fost lansate de la

lansare, ultima versiune stabilă fiind Unity 2019.1.0.

Unity oferă utilizatorilor capacitatea de a crea jocuri

și experiențe interactive atât în 2D cât și în 3D.

Motorul oferă un API primar de scripting în C#, atât

11





pentru editorul Unity sub formă de pluginuri, cât și

pentru jocurile în sine, precum și funcționalitatea

drag and drop. Înainte ca C# să fie limbajul de

programare primar utilizat pentru motor, el a

susținut anterior Boo, care a fost eliminat în

versiunea Unity 5 și o versiune de JavaScript

numită UnityScript, care a fost depreciată în august

2017 după lansarea Unity 2017.1 în favoarea C#.

(sursă Wikipedia)

. *Visual Studio (VS):* Visual Studio include un set

complet de instrumente de dezvoltare pentru

generarea de aplicații ASP.NET, Servicii Web XML,

aplicații desktop și aplicații mobile. Visual Basic,

Visual C++, Visual C# și Visual J# toate folosesc

același mediu de dezvoltare integrat (IDE) care le

permite partajarea instrumentelor și facilitează

crearea de soluții folosind mai multe limbaje de

programare. Aceste limbaje permit să beneficieze

de caracteristicile .NET Framework care oferă

acces la tehnologii cheie care simplifică dezvoltarea

12





de aplicații web ASP și XML Web Services cu

Visual Web Developer. (sursa Wikipedia)

. *GitHub (+ GitHub Desktop):* GitHub este un serviciu

de găzduire web pentru proiecte de dezvoltare a

software-ului care utilizează sistemul de control al

versiunilor Git. GitHub oferă planuri tarifare pentru

depozite private, și conturi gratuite pentru proiecte

open source. Site-ul a fost lansat în 2008 de către

Tom Preston-Werner, Chris Wanstrath, și PJ Hyett.

În 2018 Microsoft a cumpărat Github pentru 7.5

miliarde de dolari. (sursa Wikipedia)

13





. *C# (C sharp):* C# este un limbaj de programare

orientat-obiect conceput de Microsoft la sfârșitul

anilor 90. A fost conceput ca un concurent pentru

limbajul Java. Ca și acesta, C# este un derivat al

limbajului de programare C++. C# simplifică mult

scrierea de programe pentru sistemul de operare

Windows.

Exemplu de program simplu Windows scris în

Managed C++ ( C++/CLI) și C#:

Cod scris în Managed C++ ( C++/CLI):

Cod scris în C#:

Alte tehnologii și programe utilizate la realizarea

atestatului sunt: Android Studio, Paint 3D (pentru

design-ul logo-ului aplicației).

14





**Descriere UI**

Jocul este alcătuit la momentul actual din 6 scene

(Level 1, Level 2, Level 3, Level 4, Main Menu și

Credits), fiecare dintre aceste scene dispune de muzică

pe fundal, muzică care poate fi oprită sau căreia îi poate

fi schimbat volumul, acest lucru fiind posibil doar din

setări care se regăsesc în meniul de start (Main Menu).

În momentul în care un jucător intră în joc este

întâmpinat de logo-ul de la Unity dupa care este

redirecționat către meniul de start. Acesta conține 5

butoane (3 cu text și două doar cu icon-uri). Aceste

butoane sunt: butonul de oprit/pornit muzica (în

momentul în care jucătorul intră în joc, muzica este

pornită), butonul de credits care face trecerea de la

meniul principal la scena de credits, butonul de start

care în momentul în care este apăsat deschide fereastra

de selectare a nivelului de joc (există 4 levele dintre care

jucătorul poate să îl aleagă pe cel dorit sau poate opta

ca nivelul să fie ales aleator/random), butonul de ieșire

din aplicație precum și butonul de opțiuni. Setările ce pot

fi schimbate din opțiuni sunt volumul (există un slider

care indică intensitatea sunetului), modul de vibrație

care poate fi ON sau OFF (în cazul în care modul de

vibrat este activat, telefonul vibrează în momentul în

care caracterul se lovește de un obstacol sau cade de

pe platformă) și butonul de reclame care la fel ca și

butonul de vibrație poate fi ON sau OFF (în cazul în care

reclamele sunt activate, acestea vor fi redate în timpul

gameplay-ului dupa ce player-ul repetă un nivel de un

numar de ori diferit de 0 și multiplu de 5). Scena de

Credits conține și ea 5 butoane, dintre care 3 sunt

butoane care redirecționează jucătorul către paginile

personale ale creatorului (pagina de GitHub, profilul de

15





LinkedIn și pagina de Itch.io) la care se adaugă butonul

de ieșit din joc dar și cel de revenire la meniul de start.

Fiecare nivel dispune de mai multe opțiuni cum ar fi: de

a reseta highscore-ul pentru acel nivel, de a opri sunetul

din joc, de a reseta level-ul și de a pune pauză.

16





***jocul conține 22 de script-uri de C# scrise în Visual Studio***

17





18





19





20





**4.Modul de utilizare al aplicației**

Mecanismul de joc din spatele aplicației este unul

foarte simplu: jucătorul trebuie doar să apese pe ecranul

telefonului mobil pentru a face caracterul să sară în timp

ce acesta se deplasează. Obiectivul jocului este acela

de a sări de pe o platformă pe alta, dar și de a sări

pentru a evita anumite obstacole aflate la nivelul solului

sau care levitează în aer pentru ca în final să ajungă la

linia de final (sfârșitul fiecărui nivel este marcat de o linie

de finish, iar în momentul în care caracterul ajunge în

dreptul ei este activat un meniu special). În momentul în

care caracterul interacționează cu un obstacol sau cade

de pe platforme sub o anumită înălțime, acesta este dat

de la început sau de la ultimul checkpoint de care a

trecut (checkpoint-urile se găsesc după o anumită

distanță ce diferă de la un nivel la altul la fel ca și

numărul lor de pe hartă. Acestea se identifică dupa un

icon specific.) Fiecare caracter poate sări de exact două

ori (double jump) astfel încât odata ce jucătorul a apăsat

pe ecranul telefonului, caracterul sare în aer, iar dacă

jucătorul mai apasă încă o dată pe ecran în timp ce

caracterul se află în aer, acesta sare încă o dată

ajungând și mai sus în aer (de menționat faptul că în

momentul în care caracterul se află în cădere, acesta

poate sări o singură dată). Jocul dispune de două

caractere: un câine (levelele 1 și 3) și o pisică (levelele 2

și 4). La momentul de față există doar patru nivele a

căror mape au fost construite manual de la 0 cu ajutorul

asset-urilor descărcate. Astfel, primele două nivele au

ca și tematică câmpia în vreme ce următoarele două au

ca și tematică aleasă jungla. Fiecare level este deblocat

21





astfel încât un jucător nou nu trebuie să completeze un

anumit nivel pentru a trece la următorul, având

posibilitatea să încerce orice nivel dorește. Fiecare

caracter dispune de animații specifice. Aceste animații

sunt: de cădere, de sărit, de fugit, de mers, cât și o

animație de început. Animațiile sunt controlate din

Animator (de unde poate fi stabilită tranziția de la o

anumită animație la alta, tranziție ce nu este bilaterală,

astfel că dacă se poate trece de la animația A la

animația B, asta nu înseamnă neapărat că se poate

trece în mod direct și de la animația B la animația A).

Fiecare nivel din joc are anumite statistici cum ar fi

distanța parcursă de player în timpul gameplay-ului

(distanță ce la începutul nivelului este 0), distanța

maximă pe care jucătorul a atins-o de-a lungul timpului

în nivelul respectiv (această distanță maximă poate fi

resetată prin intermediul unui buton, dar și numărul de

dăți de câte ori a “murit” (a căzut de pe platformă sau s-

a lovit de un obstacol) caracterul (nu se numără dacă

jucătorul resetează din buton nivelul respectiv).

Câteva informații importante despre fiecare nivel în

parte:

22





ü Nivelul 1: are tematică specifică de câmpie (cu

soare, nori, iarbă, etc.) nu conține obstacole, doar

platforme situate mai jos sau mai sus la nivelul

hărții, singurul caracter disponibil este câinele,

viteza caracterului este de 4 unități (această viteză

nu se poate modifica pe parcursul nivelului),

caracterul poate sări cu 7 unități, coordonatele

caracterului sunt de -4.366 pe axa Ox și 4.28 pe

Oy, distanța de finish a nivelului este la 386.7724

pe axa Ox, dacă jucătorul cade sub -8 pe axa Oy

acesta este dat de la ultimul checkpoint activat (sau

de la început dacă nu a fost activat nici măcar un

checkpoint). La nivelul mapei există 5 checkpoint-

uri.

23





ü Nivelul 2: are aceeași tematică ca și primul nivel, nu

conține obstacole asemeni primului nivel, este

disponibil doar caracterul pisică, coordonatele

spațiale sunt aceleași ca și cele ale caracterului de

la primul nivel al jocului, viteza caracterului este de

4 unități, caracterul poate sări cu 7 unități, distanța

de finish a nivelului este la 611.07 pe axa Ox, dacă

jucătorul cade sub -14.5 pe axa Oy acesta este dat

de la ultimul checkpoint activat (sau de la început

dacă nu a fost activat nici măcar un checkpoint).

Harta conține 9 checkpoint-uri.

ü Nivelul 3: are tematică de junglă (liane, șerpi,

copaci înalți, etc.) conține doar inamici/obstacole

statice care nu se mișcă, singurul caracter

disponibil este câinele la fel ca și la primul nivel,

coordonatele spațiale sunt aceleași ca și cele ale

caracterelor de la nivelele precedente, viteza

caracterului este de 5 unități, caracterul poate sări

cu 7 unități, distanța de finish a nivelului este la 575

pe axa Ox, dacă jucătorul cade sub -8 pe axa Oy

acesta este dat de la ultimul checkpoint activat (sau

24





de la început dacă nu a fost activat nici măcar un

checkpoint). Harta conține 7 checkpoint-uri.

ü Nivelul 4: tematica este aceeași cu cea de la nivelul

precedent (nivelul 3), conține pe lângă obstacole

statice cum sunt cele de la nivelul 3 și obstacole

dinamice care se deplasează pe o anumită direcție

și pe o anumită distanță, singurul caracter disponibil

este pisica la fel ca și la al doilea nivel,

coordonatele spațiale sunt aceleași ca și cele ale

caracterelor de la nivelele precedente, viteza

caracterului este de 5 unități, caracterul poate sări

cu 7 unități, distanța de finish a nivelului este la

850.25 pe axa Ox, dacă jucătorul cade sub -8 pe

axa Oy acesta este dat de la ultimul checkpoint

activat (sau de la început dacă nu a fost activat nici

măcar un checkpoint). Harta conține 9 checkpoint-

uri.

25





**5.Disponibilitate curentă**

În momentul de față aplicația creată este disponibilă

pentru o singură platformă ci anume pentru telefon, iar

singurul sistem de operare pentru care a fost testată și

pentru care există la momentul de față apk disponibil

este Android. Cu toate acestea, aplicația poate fi jucată

și pe PC, folosind anumite programe specifice care

permit rularea jocurilor de mobil pe computer (printre

acestea se numără: MobileGo, BlueStacks, YouWave,

Droid4X, MirrorGo pentru a juca jocuri Android pe

Windows precum și programe precum VirtualBox, Andy

Android Emulator pentru Mac; mai multe detalii se

găsesc la adresa[:](http://ro.wondershare.com/mirror-emulator/play-android-games-on-windows-mac-pc.html)[ ](http://ro.wondershare.com/mirror-emulator/play-android-games-on-windows-mac-pc.html)[http://ro.wondershare.com/mirror-](http://ro.wondershare.com/mirror-emulator/play-android-games-on-windows-mac-pc.html)

[emulator/play-android-games-on-windows-mac-pc.html](http://ro.wondershare.com/mirror-emulator/play-android-games-on-windows-mac-pc.html)[),](http://ro.wondershare.com/mirror-emulator/play-android-games-on-windows-mac-pc.html)

dar experiența de joc nu este aceeași, una dintre

diferențele majore fiind că pe PC în loc de atingeri tactile

pe ecran cu degetul, cum este cazul smartphone-ului ce

26





dispune de touchscreen, pe calculator trebuie folosit

mouse-ul pentru a juca jocul (excepție fac laptopurile 2

în 1 care sunt și tablete și prin urmare dispun de

touchscreen).

27





Extinderile posibile ale aplicației pe viitor la care m-

am gândid sunt următoarele:

· crearea de tranziții între scene (fading between

scenes) + animație de început când se deschide

jocul și de sfârșit pentru momentul în care se iese

din joc

· extinderea jocului pe alte platforme (PC, Mac &

Linux Standalone; iOS; WebGL)

· publicarea jocului pe Google Play sau App Store (în

eventualitatea în care creez o versiune și pentru

iOS a jocului)

· monetizarea aplicației prin intermediul reclamelor

(în momentul de față reclamele existente în joc sunt

doar de la Unity Analytics și nu constituie nici un fel

de beneficiu financiar pentru aplicație, doar simple

prototipuri de reclame)

· adăugarea de 4 noi nivele standard (două cu

tematică de iarnă și celelalte două cu tematică de

deșert) + un mod de tip Endless Runner în care

mapa să fie generată, ci nu creată manual ca și la

celelalte level-uri; dar și crearea unui tutorial

· fixarea unor posibile bug-uri minore la nivelul

gameplay-ului în cazul în care acestea vor fi

descoperite la viitoarele testări ale aplicației pe alte

platforme decât Android

28





29





***singura reclamă existentă în joc***

30





***asset-urile pregătite pentru viitoarele 4 nivele ale jocului***

31





**6.Referințe**

. <https://www.flaticon.com/>[ ](https://www.flaticon.com/)- pentru icon-uri la diverse

butoane din joc și nu numai

. <https://github.com/>[ ](https://github.com/)- pentru a-mi putea depozita în

siguranță proiectul, pentru a-mi putea monitoriza

activitatea, pentru a avea backup la fiecare update

. <https://desktop.github.com/>[ ](https://desktop.github.com/)- pagina de pe care

poate fi descărcată aplicația de Desktop de la

GitHub, aplicație ce facilitează crearea de commit-

uri sau foldere, dar și adăugarea de repository-uri

pe site

. <https://github.com/Ampersand25/2DPlatformRunner>

\- pagina de GitHub cu repository-ul în care am

salvat proiectul (acesta este public, astfel că oricine

poate avea acces la el, dar nu poate descărca

direct apk-ul din cauza restricțiilor de la GitHub care

nu permit încărcarea pe site a unor file-uri cu

dimensiunea peste o anumită limită stabilită)

. <https://unity3d.com/get-unity/download>[ ](https://unity3d.com/get-unity/download)- site-ul de

unde poate fi descărcat atât Unity Engine cât și

Unity Hub

. <https://unity3d.com/learn/tutorials>[ ](https://unity3d.com/learn/tutorials)- tutoriale

interactive în Unity

. <https://docs.unity3d.com/Manual/index.html>[ ](https://docs.unity3d.com/Manual/index.html)-

documentația din Unity

[.](https://assetstore.unity.com/?gclid=CjwKCAjwza_mBRBTEiwASDWVvlyQZw1j9jiYH0OGpnTilmraxniuUkh2GyYU5V1ZtiaiOacS4YU98RoCrvcQAvD_BwE)[ ](https://assetstore.unity.com/?gclid=CjwKCAjwza_mBRBTEiwASDWVvlyQZw1j9jiYH0OGpnTilmraxniuUkh2GyYU5V1ZtiaiOacS4YU98RoCrvcQAvD_BwE)[https://assetstore.unity.com/?gclid=CjwKCAjwza_m](https://assetstore.unity.com/?gclid=CjwKCAjwza_mBRBTEiwASDWVvlyQZw1j9jiYH0OGpnTilmraxniuUkh2GyYU5V1ZtiaiOacS4YU98RoCrvcQAvD_BwE)

[BRBTEiwASDWVvlyQZw1j9jiYH0OGpnTilmraxniuU](https://assetstore.unity.com/?gclid=CjwKCAjwza_mBRBTEiwASDWVvlyQZw1j9jiYH0OGpnTilmraxniuUkh2GyYU5V1ZtiaiOacS4YU98RoCrvcQAvD_BwE)

[kh2GyYU5V1ZtiaiOacS4YU98RoCrvcQAvD_BwE](https://assetstore.unity.com/?gclid=CjwKCAjwza_mBRBTEiwASDWVvlyQZw1j9jiYH0OGpnTilmraxniuUkh2GyYU5V1ZtiaiOacS4YU98RoCrvcQAvD_BwE)[ ](https://assetstore.unity.com/?gclid=CjwKCAjwza_mBRBTEiwASDWVvlyQZw1j9jiYH0OGpnTilmraxniuUkh2GyYU5V1ZtiaiOacS4YU98RoCrvcQAvD_BwE)–

site-ul de pe care am descărcat majoritatea asset-

urilor folosite în joc (restul asset-urilor sunt simple

imagini PNG luate de pe Google)

32





[.](https://www.gameart2d.com/cat-and-dog-free-sprites.html)[ ](https://www.gameart2d.com/cat-and-dog-free-sprites.html)[https://www.gameart2d.com/cat-and-dog-free-](https://www.gameart2d.com/cat-and-dog-free-sprites.html)

[sprites.html](https://www.gameart2d.com/cat-and-dog-free-sprites.html)[ ](https://www.gameart2d.com/cat-and-dog-free-sprites.html)- site-ul de unde am luat animațiile și

imaginile PNG cu cele două caractere din joc

. <https://developer.android.com/studio>[ ](https://developer.android.com/studio)- site-ul de

unde am descărcat Android Studio

. <https://filehippo.com/download_android_sdk/>[ ](https://filehippo.com/download_android_sdk/)- site-

ul de unde mi-am descărcat Android SDK

. <https://visualstudio.microsoft.com/>[ ](https://visualstudio.microsoft.com/)- pagina oficială

de unde poate fi descărcat VS

***repository-ul pe care am salvat proiectul pe GitHub (proiectul***

***conține 53.7% Shader Lab ce se găsețe în TextMesh Pro, un***

***asset deținut de Unity și folosit la realizarea proiectului, care***

***oferă mai multe proprietăți textului, 34.4% C# și 8.3% HLSL,***

***regăsit tot în TextMesh Pro). La acest repository am 12***

***commit-uri la activ, plus alte 79 de commit-uri de la un***

***repository mai vechi pe care găzduiam aplicația inițial până în***

***momentul în care au intervenit anumite probleme și nu mai***

***puteam da push la modificări din aplicație, lucru ce m-a***

***obligat să creez repository-ul actual și să îl fac privat pe cel***

***vechi.***

33





***sprite-urile folosite la joc pentru cele două caractere***

***aplicația de Desktop de la GitHub***

34





Următoarele sunt câteva canale de YouTube ce m-

au ajutat prin anumite videoclipuri cu tutoriale și sfaturi

atât în ceea ce privește Unity cât și C#, dar și câteva

canale utile pentru un începător în industria game

development-ului:

[·](https://www.youtube.com/channel/UC9Z1XWw1kmnvOOFsj6Bzy2g)[ ](https://www.youtube.com/channel/UC9Z1XWw1kmnvOOFsj6Bzy2g)[https://www.youtube.com/channel/UC9Z1XWw1km](https://www.youtube.com/channel/UC9Z1XWw1kmnvOOFsj6Bzy2g)

[nvOOFsj6Bzy2g](https://www.youtube.com/channel/UC9Z1XWw1kmnvOOFsj6Bzy2g)

[·](https://www.youtube.com/channel/UCYbK_tjZ2OrIZFBvU6CCMiA)[ ](https://www.youtube.com/channel/UCYbK_tjZ2OrIZFBvU6CCMiA)[https://www.youtube.com/channel/UCYbK_tjZ2OrIZ](https://www.youtube.com/channel/UCYbK_tjZ2OrIZFBvU6CCMiA)

[FBvU6CCMiA](https://www.youtube.com/channel/UCYbK_tjZ2OrIZFBvU6CCMiA)

[·](https://www.youtube.com/channel/UCgyqtNWZmIxTx3b6OxTSALw)[ ](https://www.youtube.com/channel/UCgyqtNWZmIxTx3b6OxTSALw)[https://www.youtube.com/channel/UCgyqtNWZmIxT](https://www.youtube.com/channel/UCgyqtNWZmIxTx3b6OxTSALw)

[x3b6OxTSALw](https://www.youtube.com/channel/UCgyqtNWZmIxTx3b6OxTSALw)

[·](https://www.youtube.com/channel/UCG08EqOAXJk_YXPDsAvReSg)[ ](https://www.youtube.com/channel/UCG08EqOAXJk_YXPDsAvReSg)[https://www.youtube.com/channel/UCG08EqOAXJk](https://www.youtube.com/channel/UCG08EqOAXJk_YXPDsAvReSg)

[_YXPDsAvReSg](https://www.youtube.com/channel/UCG08EqOAXJk_YXPDsAvReSg)

[·](https://www.youtube.com/channel/UCUkRj4qoT1bsWpE_C8lZYoQ)[ ](https://www.youtube.com/channel/UCUkRj4qoT1bsWpE_C8lZYoQ)[https://www.youtube.com/channel/UCUkRj4qoT1bs](https://www.youtube.com/channel/UCUkRj4qoT1bsWpE_C8lZYoQ)

[WpE_C8lZYoQ](https://www.youtube.com/channel/UCUkRj4qoT1bsWpE_C8lZYoQ)

[·](https://www.youtube.com/channel/UC16wQrBg9UVlWa6aGBd9q-w)[ ](https://www.youtube.com/channel/UC16wQrBg9UVlWa6aGBd9q-w)[https://www.youtube.com/channel/UC16wQrBg9UVl](https://www.youtube.com/channel/UC16wQrBg9UVlWa6aGBd9q-w)

[Wa6aGBd9q-w](https://www.youtube.com/channel/UC16wQrBg9UVlWa6aGBd9q-w)

[·](https://www.youtube.com/channel/UCNJvwJ6daLmw4_gUKTw4cSg)[ ](https://www.youtube.com/channel/UCNJvwJ6daLmw4_gUKTw4cSg)[https://www.youtube.com/channel/UCNJvwJ6daLm](https://www.youtube.com/channel/UCNJvwJ6daLmw4_gUKTw4cSg)

[w4_gUKTw4cSg](https://www.youtube.com/channel/UCNJvwJ6daLmw4_gUKTw4cSg)

[·](https://www.youtube.com/channel/UCmtyQOKKmrMVaKuRXz02jbQ)[ ](https://www.youtube.com/channel/UCmtyQOKKmrMVaKuRXz02jbQ)[https://www.youtube.com/channel/UCmtyQOKKmr](https://www.youtube.com/channel/UCmtyQOKKmrMVaKuRXz02jbQ)

[MVaKuRXz02jbQ](https://www.youtube.com/channel/UCmtyQOKKmrMVaKuRXz02jbQ)

[·](https://www.youtube.com/channel/UCTY3kks3U4RDvpMX87fvo1A)[ ](https://www.youtube.com/channel/UCTY3kks3U4RDvpMX87fvo1A)[https://www.youtube.com/channel/UCTY3kks3U4R](https://www.youtube.com/channel/UCTY3kks3U4RDvpMX87fvo1A)

[DvpMX87fvo1A](https://www.youtube.com/channel/UCTY3kks3U4RDvpMX87fvo1A)

[·](https://www.youtube.com/channel/UCp5WDvPDLCkSZWp9hP5xIvQ)[ ](https://www.youtube.com/channel/UCp5WDvPDLCkSZWp9hP5xIvQ)[https://www.youtube.com/channel/UCp5WDvPDLC](https://www.youtube.com/channel/UCp5WDvPDLCkSZWp9hP5xIvQ)

[kSZWp9hP5xIvQ](https://www.youtube.com/channel/UCp5WDvPDLCkSZWp9hP5xIvQ)

[·](https://www.youtube.com/channel/UCd_lJ4zSp9wZDNyeKCWUstg)[ ](https://www.youtube.com/channel/UCd_lJ4zSp9wZDNyeKCWUstg)[https://www.youtube.com/channel/UCd_lJ4zSp9wZ](https://www.youtube.com/channel/UCd_lJ4zSp9wZDNyeKCWUstg)

[DNyeKCWUstg](https://www.youtube.com/channel/UCd_lJ4zSp9wZDNyeKCWUstg)

[·](https://www.youtube.com/channel/UCX4mqbvv5lGqLpI4FYlJt4w/videos)[ ](https://www.youtube.com/channel/UCX4mqbvv5lGqLpI4FYlJt4w/videos)[https://www.youtube.com/channel/UCX4mqbvv5lGq](https://www.youtube.com/channel/UCX4mqbvv5lGqLpI4FYlJt4w/videos)

[LpI4FYlJt4w/videos](https://www.youtube.com/channel/UCX4mqbvv5lGqLpI4FYlJt4w/videos)

[·](https://www.youtube.com/channel/UCC4zJALvEYbZ5C-G912Zyig)[ ](https://www.youtube.com/channel/UCC4zJALvEYbZ5C-G912Zyig)[https://www.youtube.com/channel/UCC4zJALvEYb](https://www.youtube.com/channel/UCC4zJALvEYbZ5C-G912Zyig)

[Z5C-G912Zyig](https://www.youtube.com/channel/UCC4zJALvEYbZ5C-G912Zyig)

35

