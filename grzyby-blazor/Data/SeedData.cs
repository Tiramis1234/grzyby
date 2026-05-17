using grzyby.Models;

namespace grzyby.Data;

public static class SeedData
{
    public static readonly Grzyb[] Grzyby =
    {
            // --- PIERWSZE 35 GRZYBÓW ---
            new Grzyb { Id = 1, Nazwa = "Borowik szlachetny (Prawdziwek)", Rodzina = "Borowikowate", Opis = "Duży, mięsisty grzyb o przyjemnym zapachu. Jeden z najbardziej cenionych jadalnych borowików.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Boletus_edulis.jpg?width=800" },
            new Grzyb { Id = 2, Nazwa = "Muchomor czerwony", Rodzina = "Muchomorowate", Opis = "Charakterystyczny, trujący grzyb z czerwonym kapeluszem i białymi plamkami.", Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_muscaria.jpg?width=800" },
            new Grzyb { Id = 3, Nazwa = "Czubajka kania", Rodzina = "Pieczarkowate", Opis = "Duży, parasolowaty grzyb o smacznym miąższu. Bardzo popularny, często smażony na wzór kotletów.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Macrolepiota-procera.jpg?width=800" },
            new Grzyb { Id = 4, Nazwa = "Pieprznik jadalny (Kurka)", Rodzina = "Pieprznikowate", Opis = "Żółty, falisty grzyb o owocowym zapachu. Rzadko robaczywieje, wyśmienity w śmietanie.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Cantharellus_cibarius.JPG?width=800" },
            new Grzyb { Id = 5, Nazwa = "Gąska zielonka", Rodzina = "Gąskowate", Opis = "Dawniej uważana za jadalną, dziś niezalecana ze względu na możliwe ciężkie zatrucia na długą metę.", Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Tricholoma_equestre.jpg?width=800" },
            new Grzyb { Id = 6, Nazwa = "Podgrzybek brunatny", Rodzina = "Borowikowate", Opis = "Jeden z najczęściej zbieranych grzybów w Polsce. Miąższ po uciśnięciu lub przekrojeniu lekko sinieje.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Imleria_badia.jpg?width=800" },
            new Grzyb { Id = 7, Nazwa = "Muchomor sromotnikowy", Rodzina = "Muchomorowate", Opis = "Śmiertelnie trujący! Często mylony z gąską zielonką lub młodą kanią. Uszkadza wątrobę.", Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_phalloides.jpg?width=800" },
            new Grzyb { Id = 8, Nazwa = "Mleczaj rydz", Rodzina = "Gołąbkowate", Opis = "Po uszkodzeniu wydziela pomarańczowe mleczko. Uważany za jednego z najsmaczniejszych grzybów.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Lactarius_Deliciosus.jpg?width=800" },
            new Grzyb { Id = 9, Nazwa = "Maślak zwyczajny", Rodzina = "Maślakowate", Opis = "Jego kapelusz pokryty jest śluzowatą, lepką skórką. Rośnie przeważnie pod sosnami.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Suillus_luteus.jpg?width=800" },
            new Grzyb { Id = 10, Nazwa = "Goryczak żółciowy (Szatan)", Rodzina = "Borowikowate", Opis = "Niejadalny z powodu skrajnie gorzkiego smaku. Podobny do prawdziwka, ale ma różowe rurki.", Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Tylopilus_felleus.jpg?width=800" },
            new Grzyb { Id = 11, Nazwa = "Koźlarz babka", Rodzina = "Borowikowate", Opis = "Grzyb o łagodnym smaku z charakterystycznym trzonem pokrytym drobnymi, czarniawymi łuskami.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Leccinum_scabrum.jpg?width=800" },
            new Grzyb { Id = 12, Nazwa = "Opieńka miodowa", Rodzina = "Obrzękowcowate", Opis = "Pasożyt drzew. Znakomity grzyb jadalny po dłuższej obróbce termicznej.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Armillaria_mellea.jpg?width=800" },
            new Grzyb { Id = 13, Nazwa = "Zasłonak rudy", Rodzina = "Zasłonakowate", Opis = "Śmiertelnie trujący grzyb z objawami zatrucia pojawiającymi się po ponad tygodniu.", Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Cortinarius_rubellus.jpg?width=800" },
            new Grzyb { Id = 14, Nazwa = "Smardz jadalny", Rodzina = "Smardzowate", Opis = "Wiosenny grzyb o nietypowej, pofałdowanej główce przypominającej plaster miodu. Pod ochroną.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Morchella_esculenta.jpg?width=800" },
            new Grzyb { Id = 15, Nazwa = "Purchawka chropowata", Rodzina = "Pieczarkowate", Opis = "Młode owocniki (gdy ich wnętrze jest całkowicie białe) są jadalne i bardzo smaczne.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Lycoperdon_perlatum.jpg?width=800" },
            new Grzyb { Id = 16, Nazwa = "Krasnoborowik ceglastopory", Rodzina = "Borowikowate", Opis = "Ciemnobrązowy kapelusz i czerwone pory. Mocno sinieje po przekrojeniu. Jadalny po ugotowaniu.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Neoboletus_luridiformis.jpg?width=800" },
            new Grzyb { Id = 17, Nazwa = "Podgrzybek zajączek", Rodzina = "Borowikowate", Opis = "Popularny grzyb o żółtawym trzonie i zamszowym kapeluszu. Rzadko robaczywieje.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Xerocomus_subtomentosus.jpg?width=800" },
            new Grzyb { Id = 18, Nazwa = "Siedzuń sosnowy (Szmaciak)", Rodzina = "Siedzuniowate", Opis = "Nietypowy, kalafiorowaty grzyb rosnący przy sosnach. Jadalny, wybitny w smaku.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Sparassis_crispa.jpg?width=800" },
            new Grzyb { Id = 19, Nazwa = "Pieczarka polna", Rodzina = "Pieczarkowate", Opis = "Dziko rosnąca krewniaczka pieczarki ze sklepu. Występuje na łąkach i pastwiskach.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Agaricus_campestris.jpg?width=800" },
            new Grzyb { Id = 20, Nazwa = "Muchomor plamisty", Rodzina = "Muchomorowate", Opis = "Silnie trujący! Ma gładki, prążkowany brzeg kapelusza i bulwę z wałeczkowatą pochwą.", Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_pantherina.jpg?width=800" },
            new Grzyb { Id = 21, Nazwa = "Muchomor jadowity", Rodzina = "Muchomorowate", Opis = "Śmiertelnie trujący, całkowicie biały grzyb. Bardzo niebezpieczny, mylony z pieczarką.", Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_virosa.jpg?width=800" },
            new Grzyb { Id = 22, Nazwa = "Borowik szatański", Rodzina = "Borowikowate", Opis = "Bardzo rzadki, silnie trujący grzyb o bladoszarym kapeluszu i krwistoczerwonym trzonie.", Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Rubroboletus_satanas.jpg?width=800" },
            new Grzyb { Id = 23, Nazwa = "Gołąbek zielonawy", Rodzina = "Gołąbkowate", Opis = "Posiada charakterystyczny, popękany, grynszpanowozielony kapelusz. Bardzo smaczny.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Russula_virescens.jpg?width=800" },
            new Grzyb { Id = 24, Nazwa = "Gołąbek wymiotny", Rodzina = "Gołąbkowate", Opis = "Ma piękny, jaskrawoczerwony kapelusz, ale jest silnie piekący i trujący (zaburzenia żołądkowe).", Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Russula_emetica.jpg?width=800" },
            new Grzyb { Id = 25, Nazwa = "Płomiennica zimowa", Rodzina = "Kępkowcowate", Opis = "Cenny grzyb rosnący zimą pod śniegiem na pniach drzew liściastych.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Flammulina_velutipes.jpg?width=800" },
            new Grzyb { Id = 26, Nazwa = "Boczniak ostrygowaty", Rodzina = "Boczniakowate", Opis = "Popularny grzyb jadalny rosnący na martwym drewnie w kępach. Często uprawiany.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Pleurotus_ostreatus.jpg?width=800" },
            new Grzyb { Id = 27, Nazwa = "Piaskowiec modrzak", Rodzina = "Piaskowcowate", Opis = "Jego jasny miąższ po przekrojeniu błyskawicznie zmienia kolor na atramentowoniebieski.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Gyroporus_cyanescens.jpg?width=800" },
            new Grzyb { Id = 28, Nazwa = "Czernidłak kołpakowaty", Rodzina = "Pieczarkowate", Opis = "Jadalny TYLKO młody, gdy blaszki są białe. Z czasem rozpływa się w czarną maź.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Coprinus_comatus.jpg?width=800" },
            new Grzyb { Id = 29, Nazwa = "Sarniak dachówkowaty", Rodzina = "Kolczakowate", Opis = "Przypomina wyglądem sowę. Zamiast rurek posiada pod kapeluszem gęste kolce.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Sarcodon_imbricatus.jpg?width=800" },
            new Grzyb { Id = 30, Nazwa = "Lejkowiec dęty", Rodzina = "Pieprznikowate", Opis = "Wygląda jak zwinięty, czarny liść. Po wysuszeniu wybitny grzyb przyprawowy.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Craterellus_cornucopioides.jpg?width=800" },
            new Grzyb { Id = 31, Nazwa = "Kolczak obłączasty", Rodzina = "Kolczakowate", Opis = "Rośnie w mchu, pod kapeluszem posiada gęste, białawe kolce zamiast blaszek.", Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Hydnum_repandum.jpg?width=800" },
            new Grzyb { Id = 32, Nazwa = "Maślanka wiązkowa", Rodzina = "Pierścieniakowate", Opis = "Pospolity, zółto-zielony grzyb rosnący gęstymi kępami na pniach. Gorzki i trujący.", Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Hypholoma_fasciculare.jpg?width=800" },
            new Grzyb { Id = 33, Nazwa = "Piestrzenica kasztanowata", Rodzina = "Krążkownicowate", Opis = "Przypomina fałdy mózgu. Posiada toksyczną gyromitrynę, jest silnie trująca przed obróbką.", Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Gyromitra_esculenta.jpg?width=800" },
            new Grzyb { Id = 34, Nazwa = "Krowiak podwinięty (Olszówka)", Rodzina = "Krowiakowate", Opis = "Udowodniono, że po latach może wywoływać śmiertelną anemię. Zbieranie odradzane.", Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Paxillus_involutus.jpg?width=800" },
            new Grzyb { Id = 35, Nazwa = "Mleczaj wełnianka", Rodzina = "Gołąbkowate", Opis = "Różowawy grzyb z 'wełnistym' brzegiem. Wydziela piekące mleczko, silnie trujący surowy.", Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Lactarius_torminosus.jpg?width=800" },

            // --- KOLEJNE 45 GRZYBÓW (Od 36 do 80) ---
            new Grzyb
            {
                Id = 36, Nazwa = "Maślak sitarz", Rodzina = "Maślakowate",
                Opis = "Kapelusz blado-żółtobrązowy, rurki szerokie, przypominające gąbkę lub sito. Jadalny, choć dość miękki.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Suillus_bovinus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 37, Nazwa = "Maślak ziarnisty", Rodzina = "Maślakowate",
                Opis = "W odróżnieniu od maślaka zwyczajnego nie ma pierścienia na trzonie. Pyszny grzyb jadalny, rośnie pod sosnami.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Suillus_granulatus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 38, Nazwa = "Maślak pstry", Rodzina = "Maślakowate",
                Opis = "Kapelusz zamszowy, ciemnożółty lub rdzawy. Miąższ twardszy niż u innych maślaków, lekko sinieje po przekrojeniu.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Suillus_variegatus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 39, Nazwa = "Podgrzybek złotawy", Rodzina = "Borowikowate",
                Opis = "Powierzchnia kapelusza często popękana, ukazująca czerwonawy miąższ pod spodem. Przeciętny w smaku.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Xerocomellus_chrysenteron.jpg?width=800"
            },
            new Grzyb
            {
                Id = 40, Nazwa = "Borowik ponury", Rodzina = "Borowikowate",
                Opis = "Posiada czerwonawą siateczkę na trzonie i ciemne pory. Surowy jest trujący, jadalny dopiero po długim gotowaniu.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Suillellus_luridus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 41, Nazwa = "Borowik usiatkowany", Rodzina = "Borowikowate",
                Opis = "Kuzyn prawdziwka o jasnobrązowym, zamszowym kapeluszu i wyraźnej siateczce na niemal całym trzonie.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Boletus_reticulatus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 42, Nazwa = "Borowik sosnowy", Rodzina = "Borowikowate",
                Opis = "Prawdziwek o charakterystycznym, bardzo ciemnym, czerwonobrązowym kapeluszu. Niezwykle ceniony grzybiarsko.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Boletus_pinophilus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 43, Nazwa = "Koźlarz czerwony", Rodzina = "Borowikowate",
                Opis = "Wybitny grzyb o jaskrawym, ceglastoczerwonym kapeluszu, twardym miąższu i łuskowatym trzonie. Rośnie pod osikami.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Leccinum_aurantiacum.jpg?width=800"
            },
            new Grzyb
            {
                Id = 44, Nazwa = "Koźlarz grabowy", Rodzina = "Borowikowate",
                Opis = "Często spotykany pod grabami. Po uszkodzeniu jego biały miąższ szybko ciemnieje, stając się fioletowo-czarny.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Leccinum_pseudoscabrum.jpg?width=800"
            },
            new Grzyb
            {
                Id = 45, Nazwa = "Koźlarz pomarańczowożółty", Rodzina = "Borowikowate",
                Opis = "Grzyb podobny do koźlarza czerwonego, jednak jego łuski na trzonie od początku są czarne. Rośnie z brzozami.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Leccinum_versipelle.jpg?width=800"
            },
            new Grzyb
            {
                Id = 46, Nazwa = "Muchomor cytrynowy", Rodzina = "Muchomorowate",
                Opis = "Kapelusz bladożółty z łatkami. Zapach przypomina surowe ziemniaki. Zwykle uważany za trujący lub niejadalny.",
                Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_citrina.jpg?width=800"
            },
            new Grzyb
            {
                Id = 47, Nazwa = "Muchomor porfirowy", Rodzina = "Muchomorowate",
                Opis = "O fioletowoszarym odcieniu kapelusza, zapach również ziemniaczany. Zawiera toksyny i jest niejadalny.",
                Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_porphyria.jpg?width=800"
            },
            new Grzyb
            {
                Id = 48, Nazwa = "Muchomor rdzawobrązowy", Rodzina = "Muchomorowate",
                Opis = "Nie posiada pierścienia na trzonie. Kapelusz gładki, pomarańczowobrązowy. Jadalny po obróbce termicznej.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_fulva.jpg?width=800"
            },
            new Grzyb
            {
                Id = 49, Nazwa = "Muchomor twardawy", Rodzina = "Muchomorowate",
                Opis = "Jadalny muchomor (po gotowaniu). Miąższ po przełamaniu powoli przebarwia się na czerwonawy kolor.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_excelsa.jpg?width=800"
            },
            new Grzyb
            {
                Id = 50, Nazwa = "Pieczarka dwuzarodnikowa", Rodzina = "Pieczarkowate",
                Opis = "To najpopularniejszy grzyb uprawny (pieczarka biała i brązowa w sklepach), jednak występuje również dziko na kompoście.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Agaricus_bisporus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 51, Nazwa = "Pieczarka żółtawa", Rodzina = "Pieczarkowate",
                Opis = "TRUJĄCA! Przy pocieraniu trzonu lub brzegu kapelusza silnie żółknie. Pachnie nieprzyjemnie apteką lub fenolem.",
                Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Agaricus_xanthodermus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 52, Nazwa = "Pieczarka leśna", Rodzina = "Pieczarkowate",
                Opis = "Często rośnie w lasach iglastych. Ma kapelusz pokryty brązowymi łuskami. Po przekrojeniu miąższ czerwienieje.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Agaricus_silvaticus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 53, Nazwa = "Gąska niekształtna", Rodzina = "Gąskowate",
                Opis = "Szara gąska rosnąca głównie późną jesienią w lasach sosnowych. Bardzo smaczna po ugotowaniu.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Tricholoma_portentosum.jpg?width=800"
            },
            new Grzyb
            {
                Id = 54, Nazwa = "Gąska siarkowa", Rodzina = "Gąskowate",
                Opis = "Grzyb o jaskrawożółtym kolorze i bardzo silnym, nieprzyjemnym zapachu gazu świetlnego. Niejadalny/trujący.",
                Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Tricholoma_sulphureum.jpg?width=800"
            },
            new Grzyb
            {
                Id = 55, Nazwa = "Gołąbek jadalny", Rodzina = "Gołąbkowate",
                Opis = "Posiada różowo-cielisty kapelusz, z którego skórka nie zdejmuje się do końca (zostawia obwódkę). Twardy i smaczny.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Russula_vesca.jpg?width=800"
            },
            new Grzyb
            {
                Id = 56, Nazwa = "Gołąbek winny", Rodzina = "Gołąbkowate",
                Opis = "Ciemnoczerwony kapelusz, wydziela zapach przypominający śledzie. Miąższ ciemnieje po uszkodzeniu. Jadalny.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Russula_xerampelina.jpg?width=800"
            },
            new Grzyb
            {
                Id = 57, Nazwa = "Gołąbek brudnożółty", Rodzina = "Gołąbkowate",
                Opis = "Bardzo pospolity w polskich lasach. Ma żółtawy kapelusz i dość ostry smak na surowo. Mało wartościowy kulinarnie.",
                Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Russula_ochroleuca.jpg?width=800"
            },
            new Grzyb
            {
                Id = 58, Nazwa = "Mleczaj rudy", Rodzina = "Gołąbkowate",
                Opis = "Ceglastoczerwony kapelusz ze szpicem. Wydziela białe mleczko, które ma ekstremalnie palący, ostry smak. Niejadalny.",
                Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Lactarius_rufus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 59, Nazwa = "Mleczaj smaczny", Rodzina = "Gołąbkowate",
                Opis = "Kapelusz pomarańczowobrązowy, obficie wydziela łagodne, białe mleczko pachnące śledziami. Znakomity na surowo po usmażeniu.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Lactifluus_volemus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 60, Nazwa = "Mleczaj kamforowy", Rodzina = "Gołąbkowate",
                Opis = "Mały, bordowy grzyb wydzielający zapach maggi, cykorii lub kamfory. Po wysuszeniu doskonały jako przyprawa.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Lactarius_camphoratus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 61, Nazwa = "Rycerzyk czerwonozłoty", Rodzina = "Gąskowate",
                Opis = "Przepiękny grzyb o żółtym miąższu i fioletowoczerwonym kapeluszu rosnący na martwym drewnie. Jadalny, choć smakuje drzewem.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Tricholomopsis_rutilans.jpg?width=800"
            },
            new Grzyb
            {
                Id = 62, Nazwa = "Pieniążek dębowy", Rodzina = "Omphalotaceae",
                Opis = "Drobny grzybek o cienkim trzonie z jasnobrązowym kapeluszem. Występuje masowo pod dębami. Uznawany za jadalny po obróbce.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Gymnopus_dryophilus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 63, Nazwa = "Czernidłak pospolity", Rodzina = "Kruchaweczkowate",
                Opis = "TRUJĄCY w połączeniu z alkoholem (zawiera kopryną blokującą metabolizm alkoholu). Bez alkoholu teoretycznie jadalny (młody).",
                Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Coprinopsis_atramentaria.jpg?width=800"
            },
            new Grzyb
            {
                Id = 64, Nazwa = "Czernidłak błyszczący", Rodzina = "Kruchaweczkowate",
                Opis = "Rośnie kępami na pniach, a jego kapelusz pokryty jest błyszczącymi, mikowymi ziarenkami. Jadalne tylko białe formy młode.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Coprinellus_micaceus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 65, Nazwa = "Lejkówka jadowita", Rodzina = "Gąskowate",
                Opis = "Mały, niepozorny biały grzyb rosnący na trawnikach i pastwiskach. Silnie trujący – zawiera muskarynę, prowokując ślinotok i zlewne poty.",
                Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Clitocybe_dealbata.jpg?width=800"
            },
            new Grzyb
            {
                Id = 66, Nazwa = "Krowiak aksamitny", Rodzina = "Tapinellaceae",
                Opis = "Posiada masywny, brązowy, grubo zamszowy trzon boczny lub centralny. Rośnie na martwym drewnie. Kwaśny i ciężkostrawny.",
                Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Tapinella_atrotomentosa.jpg?width=800"
            },
            new Grzyb
            {
                Id = 67, Nazwa = "Lisówka pomarańczowa", Rodzina = "Lisówkowate",
                Opis = "Nazywana potocznie 'fałszywą kurką'. Blaszki dużo drobniejsze, cienkie, kapelusz bywa jaskrawszy. Niejadalna, u niektórych wywołuje zatrucia.",
                Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Hygrophoropsis_aurantiaca.jpg?width=800"
            },
            new Grzyb
            {
                Id = 68, Nazwa = "Twardzioszek przydrożny", Rodzina = "Twardzioszkowate",
                Opis = "Rośnie w trawie tworząc słynne 'czarcie kręgi'. Ma mały kapelusz z garbem i bardzo twardy, elastyczny trzon. Ceniony grzyb do zup.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Marasmius_oreades.jpg?width=800"
            },
            new Grzyb
            {
                Id = 69, Nazwa = "Twardzioszek czosnaczek", Rodzina = "Twardzioszkowate",
                Opis = "Drobniutki grzyb na igiełkowatym trzonie o potężnym, intensywnym zapachu czosnku. Wspaniały naturalny aromat do potraw.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Mycetinis_scorodonius.jpg?width=800"
            },
            new Grzyb
            {
                Id = 70, Nazwa = "Klejówka świerkowa", Rodzina = "Klejówkowate",
                Opis = "Kapelusz szary i gruby obficie pokryty przezroczystym, grubym śluzem, który należy zerwać. Gotowany zmienia kolor na fioletowy. Smaczna.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Gomphidius_glutinosus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 71, Nazwa = "Zasłonak fioletowy", Rodzina = "Zasłonakowate",
                Opis = "Wygląda zjawiskowo: jest od stóp do głów atramentowofioletowy. Jadalny, choć w Polsce rzadki (często pod ochroną).",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Cortinarius_violaceus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 72, Nazwa = "Purchawka gruszkowata", Rodzina = "Pieczarkowate",
                Opis = "Ma gładką skórkę i w przeciwieństwie do chropowatej – rośnie licznie na martwym drewnie, a nie w ziemi. Jadalna dopóki biała w środku.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Apioperdon_pyriforme.jpg?width=800"
            },
            new Grzyb
            {
                Id = 73, Nazwa = "Czasznica olbrzymia", Rodzina = "Pieczarkowate",
                Opis = "Biała, kulista purchawka osiągająca wielkość piłki lekarskiej (nawet kilkanaście kilogramów!). Wybitna na kotlety, gdy wnętrze jest idealnie białe.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Calvatia_gigantea.jpg?width=800"
            },
            new Grzyb
            {
                Id = 74, Nazwa = "Sromotnik smrodliwy", Rodzina = "Sromotnikowate",
                Opis = "W dorosłej formie wydziela odór psującego się mięsa wabiąc muchy. Młoda forma ('czarcie jajo') jest jadalna i w wielu krajach stanowi rarytas.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Phallus_impudicus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 75, Nazwa = "Żagiew łuskowa", Rodzina = "Żagwiowate",
                Opis = "Duża huba o zapachu świeżego ogórka lub arbuza. Pasożyt drzew liściastych. Bardzo młode owocniki są jadalne po ugotowaniu.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Cerioporus_squamosus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 76, Nazwa = "Łuskwiak nastroszony", Rodzina = "Pierścieniakowate",
                Opis = "Cały pokryty gęstymi, suchymi, sterczącymi łuskami. Występuje kępami u podnóży drzew. Jest twardy, gorzkawy i może wywołać niestrawność.",
                Jadalny = false, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Pholiota_squarrosa.jpg?width=800"
            },
            new Grzyb
            {
                Id = 77, Nazwa = "Ucho bzowe", Rodzina = "Uszakowate",
                Opis = "Często nazywany 'grzybem Mun'. Elastyczny, żelatynowaty grzyb rosnący głównie zimą na gałęziach czarnego bzu. Idealny do dań kuchni azjatyckiej.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Auricularia_auricula-judae.jpg?width=800"
            },
            new Grzyb
            {
                Id = 78, Nazwa = "Żółciak siarkowy", Rodzina = "Żagwiowate",
                Opis = "Wydaje jaskrawożółte półki na drzewach liściastych. Potocznie zwany 'leśnym kurczakiem' bo smażony w panierce mocno go przypomina (jadalny tylko młody).",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Laetiporus_sulphureus.jpg?width=800"
            },
            new Grzyb
            {
                Id = 79, Nazwa = "Maślanka łagodna", Rodzina = "Pierścieniakowate",
                Opis = "W odróżnieniu od trującej maślanki wiązkowej ma rdzawy, gładki kapelusz i łagodny smak. Dobry grzyb jadalny używany na przetwory.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Hypholoma_capnoides.jpg?width=800"
            },
            new Grzyb
            {
                Id = 80, Nazwa = "Opieńka ciemna", Rodzina = "Obrzękowcowate",
                Opis = "Równie popularna i smaczna jak miodowa, ale zazwyczaj posiada nieco ciemniejszy, mocniej pokryty łuseczkami kapelusz.",
                Jadalny = true, ZdjecieUrl = "https://commons.wikimedia.org/wiki/Special:FilePath/Armillaria_ostoyae.jpg?width=800"
            }
            
        };
}