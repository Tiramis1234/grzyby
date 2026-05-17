using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace grzyby.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grzyby",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    Rodzina = table.Column<string>(type: "TEXT", nullable: false),
                    Opis = table.Column<string>(type: "TEXT", nullable: false),
                    Jadalny = table.Column<bool>(type: "INTEGER", nullable: false),
                    ZdjecieUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grzyby", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TodoItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    IsDone = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wpisy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tytul = table.Column<string>(type: "TEXT", nullable: false),
                    Tresc = table.Column<string>(type: "TEXT", nullable: false),
                    DataDodania = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AuthorId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wpisy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wpisy_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Komentarze",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tresc = table.Column<string>(type: "TEXT", nullable: false),
                    DataDodania = table.Column<DateTime>(type: "TEXT", nullable: false),
                    WpisId = table.Column<int>(type: "INTEGER", nullable: false),
                    AuthorId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentarze", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Komentarze_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Komentarze_Wpisy_WpisId",
                        column: x => x.WpisId,
                        principalTable: "Wpisy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Grzyby",
                columns: new[] { "Id", "Jadalny", "Nazwa", "Opis", "Rodzina", "ZdjecieUrl" },
                values: new object[,]
                {
                    { 1, true, "Borowik szlachetny (Prawdziwek)", "Duży, mięsisty grzyb o przyjemnym zapachu. Jeden z najbardziej cenionych jadalnych borowików.", "Borowikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Boletus_edulis.jpg?width=800" },
                    { 2, false, "Muchomor czerwony", "Charakterystyczny, trujący grzyb z czerwonym kapeluszem i białymi plamkami.", "Muchomorowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_muscaria.jpg?width=800" },
                    { 3, true, "Czubajka kania", "Duży, parasolowaty grzyb o smacznym miąższu. Bardzo popularny, często smażony na wzór kotletów.", "Pieczarkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Macrolepiota-procera.jpg?width=800" },
                    { 4, true, "Pieprznik jadalny (Kurka)", "Żółty, falisty grzyb o owocowym zapachu. Rzadko robaczywieje, wyśmienity w śmietanie.", "Pieprznikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Cantharellus_cibarius.JPG?width=800" },
                    { 5, false, "Gąska zielonka", "Dawniej uważana za jadalną, dziś niezalecana ze względu na możliwe ciężkie zatrucia na długą metę.", "Gąskowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Tricholoma_equestre.jpg?width=800" },
                    { 6, true, "Podgrzybek brunatny", "Jeden z najczęściej zbieranych grzybów w Polsce. Miąższ po uciśnięciu lub przekrojeniu lekko sinieje.", "Borowikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Imleria_badia.jpg?width=800" },
                    { 7, false, "Muchomor sromotnikowy", "Śmiertelnie trujący! Często mylony z gąską zielonką lub młodą kanią. Uszkadza wątrobę.", "Muchomorowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_phalloides.jpg?width=800" },
                    { 8, true, "Mleczaj rydz", "Po uszkodzeniu wydziela pomarańczowe mleczko. Uważany za jednego z najsmaczniejszych grzybów.", "Gołąbkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Lactarius_Deliciosus.jpg?width=800" },
                    { 9, true, "Maślak zwyczajny", "Jego kapelusz pokryty jest śluzowatą, lepką skórką. Rośnie przeważnie pod sosnami.", "Maślakowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Suillus_luteus.jpg?width=800" },
                    { 10, false, "Goryczak żółciowy (Szatan)", "Niejadalny z powodu skrajnie gorzkiego smaku. Podobny do prawdziwka, ale ma różowe rurki.", "Borowikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Tylopilus_felleus.jpg?width=800" },
                    { 11, true, "Koźlarz babka", "Grzyb o łagodnym smaku z charakterystycznym trzonem pokrytym drobnymi, czarniawymi łuskami.", "Borowikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Leccinum_scabrum.jpg?width=800" },
                    { 12, true, "Opieńka miodowa", "Pasożyt drzew. Znakomity grzyb jadalny po dłuższej obróbce termicznej.", "Obrzękowcowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Armillaria_mellea.jpg?width=800" },
                    { 13, false, "Zasłonak rudy", "Śmiertelnie trujący grzyb z objawami zatrucia pojawiającymi się po ponad tygodniu.", "Zasłonakowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Cortinarius_rubellus.jpg?width=800" },
                    { 14, true, "Smardz jadalny", "Wiosenny grzyb o nietypowej, pofałdowanej główce przypominającej plaster miodu. Pod ochroną.", "Smardzowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Morchella_esculenta.jpg?width=800" },
                    { 15, true, "Purchawka chropowata", "Młode owocniki (gdy ich wnętrze jest całkowicie białe) są jadalne i bardzo smaczne.", "Pieczarkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Lycoperdon_perlatum.jpg?width=800" },
                    { 16, true, "Krasnoborowik ceglastopory", "Ciemnobrązowy kapelusz i czerwone pory. Mocno sinieje po przekrojeniu. Jadalny po ugotowaniu.", "Borowikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Neoboletus_luridiformis.jpg?width=800" },
                    { 17, true, "Podgrzybek zajączek", "Popularny grzyb o żółtawym trzonie i zamszowym kapeluszu. Rzadko robaczywieje.", "Borowikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Xerocomus_subtomentosus.jpg?width=800" },
                    { 18, true, "Siedzuń sosnowy (Szmaciak)", "Nietypowy, kalafiorowaty grzyb rosnący przy sosnach. Jadalny, wybitny w smaku.", "Siedzuniowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Sparassis_crispa.jpg?width=800" },
                    { 19, true, "Pieczarka polna", "Dziko rosnąca krewniaczka pieczarki ze sklepu. Występuje na łąkach i pastwiskach.", "Pieczarkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Agaricus_campestris.jpg?width=800" },
                    { 20, false, "Muchomor plamisty", "Silnie trujący! Ma gładki, prążkowany brzeg kapelusza i bulwę z wałeczkowatą pochwą.", "Muchomorowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_pantherina.jpg?width=800" },
                    { 21, false, "Muchomor jadowity", "Śmiertelnie trujący, całkowicie biały grzyb. Bardzo niebezpieczny, mylony z pieczarką.", "Muchomorowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_virosa.jpg?width=800" },
                    { 22, false, "Borowik szatański", "Bardzo rzadki, silnie trujący grzyb o bladoszarym kapeluszu i krwistoczerwonym trzonie.", "Borowikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Rubroboletus_satanas.jpg?width=800" },
                    { 23, true, "Gołąbek zielonawy", "Posiada charakterystyczny, popękany, grynszpanowozielony kapelusz. Bardzo smaczny.", "Gołąbkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Russula_virescens.jpg?width=800" },
                    { 24, false, "Gołąbek wymiotny", "Ma piękny, jaskrawoczerwony kapelusz, ale jest silnie piekący i trujący (zaburzenia żołądkowe).", "Gołąbkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Russula_emetica.jpg?width=800" },
                    { 25, true, "Płomiennica zimowa", "Cenny grzyb rosnący zimą pod śniegiem na pniach drzew liściastych.", "Kępkowcowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Flammulina_velutipes.jpg?width=800" },
                    { 26, true, "Boczniak ostrygowaty", "Popularny grzyb jadalny rosnący na martwym drewnie w kępach. Często uprawiany.", "Boczniakowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Pleurotus_ostreatus.jpg?width=800" },
                    { 27, true, "Piaskowiec modrzak", "Jego jasny miąższ po przekrojeniu błyskawicznie zmienia kolor na atramentowoniebieski.", "Piaskowcowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Gyroporus_cyanescens.jpg?width=800" },
                    { 28, true, "Czernidłak kołpakowaty", "Jadalny TYLKO młody, gdy blaszki są białe. Z czasem rozpływa się w czarną maź.", "Pieczarkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Coprinus_comatus.jpg?width=800" },
                    { 29, true, "Sarniak dachówkowaty", "Przypomina wyglądem sowę. Zamiast rurek posiada pod kapeluszem gęste kolce.", "Kolczakowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Sarcodon_imbricatus.jpg?width=800" },
                    { 30, true, "Lejkowiec dęty", "Wygląda jak zwinięty, czarny liść. Po wysuszeniu wybitny grzyb przyprawowy.", "Pieprznikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Craterellus_cornucopioides.jpg?width=800" },
                    { 31, true, "Kolczak obłączasty", "Rośnie w mchu, pod kapeluszem posiada gęste, białawe kolce zamiast blaszek.", "Kolczakowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Hydnum_repandum.jpg?width=800" },
                    { 32, false, "Maślanka wiązkowa", "Pospolity, zółto-zielony grzyb rosnący gęstymi kępami na pniach. Gorzki i trujący.", "Pierścieniakowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Hypholoma_fasciculare.jpg?width=800" },
                    { 33, false, "Piestrzenica kasztanowata", "Przypomina fałdy mózgu. Posiada toksyczną gyromitrynę, jest silnie trująca przed obróbką.", "Krążkownicowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Gyromitra_esculenta.jpg?width=800" },
                    { 34, false, "Krowiak podwinięty (Olszówka)", "Udowodniono, że po latach może wywoływać śmiertelną anemię. Zbieranie odradzane.", "Krowiakowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Paxillus_involutus.jpg?width=800" },
                    { 35, false, "Mleczaj wełnianka", "Różowawy grzyb z 'wełnistym' brzegiem. Wydziela piekące mleczko, silnie trujący surowy.", "Gołąbkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Lactarius_torminosus.jpg?width=800" },
                    { 36, true, "Maślak sitarz", "Kapelusz blado-żółtobrązowy, rurki szerokie, przypominające gąbkę lub sito. Jadalny, choć dość miękki.", "Maślakowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Suillus_bovinus.jpg?width=800" },
                    { 37, true, "Maślak ziarnisty", "W odróżnieniu od maślaka zwyczajnego nie ma pierścienia na trzonie. Pyszny grzyb jadalny, rośnie pod sosnami.", "Maślakowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Suillus_granulatus.jpg?width=800" },
                    { 38, true, "Maślak pstry", "Kapelusz zamszowy, ciemnożółty lub rdzawy. Miąższ twardszy niż u innych maślaków, lekko sinieje po przekrojeniu.", "Maślakowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Suillus_variegatus.jpg?width=800" },
                    { 39, true, "Podgrzybek złotawy", "Powierzchnia kapelusza często popękana, ukazująca czerwonawy miąższ pod spodem. Przeciętny w smaku.", "Borowikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Xerocomellus_chrysenteron.jpg?width=800" },
                    { 40, true, "Borowik ponury", "Posiada czerwonawą siateczkę na trzonie i ciemne pory. Surowy jest trujący, jadalny dopiero po długim gotowaniu.", "Borowikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Suillellus_luridus.jpg?width=800" },
                    { 41, true, "Borowik usiatkowany", "Kuzyn prawdziwka o jasnobrązowym, zamszowym kapeluszu i wyraźnej siateczce na niemal całym trzonie.", "Borowikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Boletus_reticulatus.jpg?width=800" },
                    { 42, true, "Borowik sosnowy", "Prawdziwek o charakterystycznym, bardzo ciemnym, czerwonobrązowym kapeluszu. Niezwykle ceniony grzybiarsko.", "Borowikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Boletus_pinophilus.jpg?width=800" },
                    { 43, true, "Koźlarz czerwony", "Wybitny grzyb o jaskrawym, ceglastoczerwonym kapeluszu, twardym miąższu i łuskowatym trzonie. Rośnie pod osikami.", "Borowikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Leccinum_aurantiacum.jpg?width=800" },
                    { 44, true, "Koźlarz grabowy", "Często spotykany pod grabami. Po uszkodzeniu jego biały miąższ szybko ciemnieje, stając się fioletowo-czarny.", "Borowikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Leccinum_pseudoscabrum.jpg?width=800" },
                    { 45, true, "Koźlarz pomarańczowożółty", "Grzyb podobny do koźlarza czerwonego, jednak jego łuski na trzonie od początku są czarne. Rośnie z brzozami.", "Borowikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Leccinum_versipelle.jpg?width=800" },
                    { 46, false, "Muchomor cytrynowy", "Kapelusz bladożółty z łatkami. Zapach przypomina surowe ziemniaki. Zwykle uważany za trujący lub niejadalny.", "Muchomorowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_citrina.jpg?width=800" },
                    { 47, false, "Muchomor porfirowy", "O fioletowoszarym odcieniu kapelusza, zapach również ziemniaczany. Zawiera toksyny i jest niejadalny.", "Muchomorowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_porphyria.jpg?width=800" },
                    { 48, true, "Muchomor rdzawobrązowy", "Nie posiada pierścienia na trzonie. Kapelusz gładki, pomarańczowobrązowy. Jadalny po obróbce termicznej.", "Muchomorowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_fulva.jpg?width=800" },
                    { 49, true, "Muchomor twardawy", "Jadalny muchomor (po gotowaniu). Miąższ po przełamaniu powoli przebarwia się na czerwonawy kolor.", "Muchomorowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Amanita_excelsa.jpg?width=800" },
                    { 50, true, "Pieczarka dwuzarodnikowa", "To najpopularniejszy grzyb uprawny (pieczarka biała i brązowa w sklepach), jednak występuje również dziko na kompoście.", "Pieczarkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Agaricus_bisporus.jpg?width=800" },
                    { 51, false, "Pieczarka żółtawa", "TRUJĄCA! Przy pocieraniu trzonu lub brzegu kapelusza silnie żółknie. Pachnie nieprzyjemnie apteką lub fenolem.", "Pieczarkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Agaricus_xanthodermus.jpg?width=800" },
                    { 52, true, "Pieczarka leśna", "Często rośnie w lasach iglastych. Ma kapelusz pokryty brązowymi łuskami. Po przekrojeniu miąższ czerwienieje.", "Pieczarkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Agaricus_silvaticus.jpg?width=800" },
                    { 53, true, "Gąska niekształtna", "Szara gąska rosnąca głównie późną jesienią w lasach sosnowych. Bardzo smaczna po ugotowaniu.", "Gąskowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Tricholoma_portentosum.jpg?width=800" },
                    { 54, false, "Gąska siarkowa", "Grzyb o jaskrawożółtym kolorze i bardzo silnym, nieprzyjemnym zapachu gazu świetlnego. Niejadalny/trujący.", "Gąskowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Tricholoma_sulphureum.jpg?width=800" },
                    { 55, true, "Gołąbek jadalny", "Posiada różowo-cielisty kapelusz, z którego skórka nie zdejmuje się do końca (zostawia obwódkę). Twardy i smaczny.", "Gołąbkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Russula_vesca.jpg?width=800" },
                    { 56, true, "Gołąbek winny", "Ciemnoczerwony kapelusz, wydziela zapach przypominający śledzie. Miąższ ciemnieje po uszkodzeniu. Jadalny.", "Gołąbkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Russula_xerampelina.jpg?width=800" },
                    { 57, false, "Gołąbek brudnożółty", "Bardzo pospolity w polskich lasach. Ma żółtawy kapelusz i dość ostry smak na surowo. Mało wartościowy kulinarnie.", "Gołąbkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Russula_ochroleuca.jpg?width=800" },
                    { 58, false, "Mleczaj rudy", "Ceglastoczerwony kapelusz ze szpicem. Wydziela białe mleczko, które ma ekstremalnie palący, ostry smak. Niejadalny.", "Gołąbkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Lactarius_rufus.jpg?width=800" },
                    { 59, true, "Mleczaj smaczny", "Kapelusz pomarańczowobrązowy, obficie wydziela łagodne, białe mleczko pachnące śledziami. Znakomity na surowo po usmażeniu.", "Gołąbkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Lactifluus_volemus.jpg?width=800" },
                    { 60, true, "Mleczaj kamforowy", "Mały, bordowy grzyb wydzielający zapach maggi, cykorii lub kamfory. Po wysuszeniu doskonały jako przyprawa.", "Gołąbkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Lactarius_camphoratus.jpg?width=800" },
                    { 61, true, "Rycerzyk czerwonozłoty", "Przepiękny grzyb o żółtym miąższu i fioletowoczerwonym kapeluszu rosnący na martwym drewnie. Jadalny, choć smakuje drzewem.", "Gąskowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Tricholomopsis_rutilans.jpg?width=800" },
                    { 62, true, "Pieniążek dębowy", "Drobny grzybek o cienkim trzonie z jasnobrązowym kapeluszem. Występuje masowo pod dębami. Uznawany za jadalny po obróbce.", "Omphalotaceae", "https://commons.wikimedia.org/wiki/Special:FilePath/Gymnopus_dryophilus.jpg?width=800" },
                    { 63, false, "Czernidłak pospolity", "TRUJĄCY w połączeniu z alkoholem (zawiera kopryną blokującą metabolizm alkoholu). Bez alkoholu teoretycznie jadalny (młody).", "Kruchaweczkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Coprinopsis_atramentaria.jpg?width=800" },
                    { 64, true, "Czernidłak błyszczący", "Rośnie kępami na pniach, a jego kapelusz pokryty jest błyszczącymi, mikowymi ziarenkami. Jadalne tylko białe formy młode.", "Kruchaweczkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Coprinellus_micaceus.jpg?width=800" },
                    { 65, false, "Lejkówka jadowita", "Mały, niepozorny biały grzyb rosnący na trawnikach i pastwiskach. Silnie trujący – zawiera muskarynę, prowokując ślinotok i zlewne poty.", "Gąskowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Clitocybe_dealbata.jpg?width=800" },
                    { 66, false, "Krowiak aksamitny", "Posiada masywny, brązowy, grubo zamszowy trzon boczny lub centralny. Rośnie na martwym drewnie. Kwaśny i ciężkostrawny.", "Tapinellaceae", "https://commons.wikimedia.org/wiki/Special:FilePath/Tapinella_atrotomentosa.jpg?width=800" },
                    { 67, false, "Lisówka pomarańczowa", "Nazywana potocznie 'fałszywą kurką'. Blaszki dużo drobniejsze, cienkie, kapelusz bywa jaskrawszy. Niejadalna, u niektórych wywołuje zatrucia.", "Lisówkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Hygrophoropsis_aurantiaca.jpg?width=800" },
                    { 68, true, "Twardzioszek przydrożny", "Rośnie w trawie tworząc słynne 'czarcie kręgi'. Ma mały kapelusz z garbem i bardzo twardy, elastyczny trzon. Ceniony grzyb do zup.", "Twardzioszkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Marasmius_oreades.jpg?width=800" },
                    { 69, true, "Twardzioszek czosnaczek", "Drobniutki grzyb na igiełkowatym trzonie o potężnym, intensywnym zapachu czosnku. Wspaniały naturalny aromat do potraw.", "Twardzioszkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Mycetinis_scorodonius.jpg?width=800" },
                    { 70, true, "Klejówka świerkowa", "Kapelusz szary i gruby obficie pokryty przezroczystym, grubym śluzem, który należy zerwać. Gotowany zmienia kolor na fioletowy. Smaczna.", "Klejówkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Gomphidius_glutinosus.jpg?width=800" },
                    { 71, true, "Zasłonak fioletowy", "Wygląda zjawiskowo: jest od stóp do głów atramentowofioletowy. Jadalny, choć w Polsce rzadki (często pod ochroną).", "Zasłonakowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Cortinarius_violaceus.jpg?width=800" },
                    { 72, true, "Purchawka gruszkowata", "Ma gładką skórkę i w przeciwieństwie do chropowatej – rośnie licznie na martwym drewnie, a nie w ziemi. Jadalna dopóki biała w środku.", "Pieczarkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Apioperdon_pyriforme.jpg?width=800" },
                    { 73, true, "Czasznica olbrzymia", "Biała, kulista purchawka osiągająca wielkość piłki lekarskiej (nawet kilkanaście kilogramów!). Wybitna na kotlety, gdy wnętrze jest idealnie białe.", "Pieczarkowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Calvatia_gigantea.jpg?width=800" },
                    { 74, true, "Sromotnik smrodliwy", "W dorosłej formie wydziela odór psującego się mięsa wabiąc muchy. Młoda forma ('czarcie jajo') jest jadalna i w wielu krajach stanowi rarytas.", "Sromotnikowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Phallus_impudicus.jpg?width=800" },
                    { 75, true, "Żagiew łuskowa", "Duża huba o zapachu świeżego ogórka lub arbuza. Pasożyt drzew liściastych. Bardzo młode owocniki są jadalne po ugotowaniu.", "Żagwiowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Cerioporus_squamosus.jpg?width=800" },
                    { 76, false, "Łuskwiak nastroszony", "Cały pokryty gęstymi, suchymi, sterczącymi łuskami. Występuje kępami u podnóży drzew. Jest twardy, gorzkawy i może wywołać niestrawność.", "Pierścieniakowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Pholiota_squarrosa.jpg?width=800" },
                    { 77, true, "Ucho bzowe", "Często nazywany 'grzybem Mun'. Elastyczny, żelatynowaty grzyb rosnący głównie zimą na gałęziach czarnego bzu. Idealny do dań kuchni azjatyckiej.", "Uszakowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Auricularia_auricula-judae.jpg?width=800" },
                    { 78, true, "Żółciak siarkowy", "Wydaje jaskrawożółte półki na drzewach liściastych. Potocznie zwany 'leśnym kurczakiem' bo smażony w panierce mocno go przypomina (jadalny tylko młody).", "Żagwiowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Laetiporus_sulphureus.jpg?width=800" },
                    { 79, true, "Maślanka łagodna", "W odróżnieniu od trującej maślanki wiązkowej ma rdzawy, gładki kapelusz i łagodny smak. Dobry grzyb jadalny używany na przetwory.", "Pierścieniakowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Hypholoma_capnoides.jpg?width=800" },
                    { 80, true, "Opieńka ciemna", "Równie popularna i smaczna jak miodowa, ale zazwyczaj posiada nieco ciemniejszy, mocniej pokryty łuseczkami kapelusz.", "Obrzękowcowate", "https://commons.wikimedia.org/wiki/Special:FilePath/Armillaria_ostoyae.jpg?width=800" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Komentarze_AuthorId",
                table: "Komentarze",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Komentarze_WpisId",
                table: "Komentarze",
                column: "WpisId");

            migrationBuilder.CreateIndex(
                name: "IX_Wpisy_AuthorId",
                table: "Wpisy",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Grzyby");

            migrationBuilder.DropTable(
                name: "Komentarze");

            migrationBuilder.DropTable(
                name: "TodoItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Wpisy");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
