using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHub
{
    public class SceneLibrary
    {
        public List<Book> ModernLiterature { get; set; }
        public List<Book> Classics { get; set; }
        public List<Book> Drama { get; set; }
        public List<Book> CrimeThriller { get; set; }
        public List<Book> AdventureAction { get; set; }
        public List<Book> Romance { get; set; }
        public List<Book> Horror { get; set; }
        public List<Book> Comedy { get; set; }
        public List<Book> ScienceFictionFantasy { get; set; }
        public List<Book> HistoricFiction { get; set; }
        public List<Book> MacedonianPoetry { get; set; }
        public List<Book> ForeignPoetry { get; set; }
        public List<Book> Travel { get; set; }
        public List<Book> SportFitness { get; set; }
        public List<Book> Cookbooks { get; set; }
        public List<Book> Economy { get; set; }
        public List<Book> SocialOther { get; set; }
        public List<Book> Medicine { get; set; }
        public List<Book> ScienceOther { get; set; }
        public List<Book> Music { get; set; }
        public List<Book> FilmStagecraft { get; set; }
        public List<Book> Architecture { get; set; }
        public List<Book> EncyclopediaLexicon { get; set; }
        public List<Book> JournalMagazine { get; set; }

        //иницијализација на листите со соодветните книги
        public SceneLibrary()
        {
            ModernLiterature = new List<Book>
            {
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/064046_1200_1200px_w_0_0px.jpg", "Невидливиот живот на Еуридиси Гузмау", "Марта Батаља", "Современа литература", 1200.00, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/064039_350_350px.jpg", "Авел Санчез: Приказна за една страст", "Мигел Де Унамуно", "Современа литература", 1210.00, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096315_350_350px.jpg", "Јама", "Александар Куприн", "Современа литература", 1220.00, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/063980_350_350px.jpg", "Ситни души", "Луис Коуперус", "Современа литература", 1230.00, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/063943_350_350px.jpg", "Книга", "Жозе Луиш Пејшото", "Современа литература", 1240.00, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/063929_350_350px.jpg", "Книга на празниците", "Марко Погачар", "Современа литература", 1250.00, 5),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/063918_350_350px.jpg", "Црвените очи", "Миријам Леруа", "Современа литература", 1260.00, 4),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/063870_350_350px.jpg", "Сиви пчели", "Андреј Курков", "Современа литература", 1270.00, 3),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/063867_350_350px.jpg", "Шега", "Доменико Старноне", "Современа литература", 1280.00, 2),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/210380_350_350px.jpg", "Солунска 28 - трет дел", "Неле Карајлиќ", "Современа литература", 1290.00, 1),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/094261_350_350px.jpg", "Неранцула", "Панаит Истрати", "Современа литература", 1300.00, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/094260_350_350px.jpg", "Мелита", "Јосип Еуген Томиќ", "Современа литература", 1310.00, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/094248_350_350px.jpg", "Чувај се од сењската река", "Аугуст Шеноа", "Современа литература", 1320.00, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/094247_350_350px.jpg", "Марта", "Елиза Ожешкова", "Современа литература", 1330.00, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/094245_350_350px.jpg", "Мртви капитали", "Јосип Козарац", "Современа литература", 1340.00, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/094234_350_350px.jpg", "Пред светлото", "Вјенцеслав Новак", "Современа литература", 1350.00, 5),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/094223_350_350px.jpg", "Бунтот на ангелите", "Анатол Франс", "Современа литература", 1360.00, 4),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096001_350_350px.jpg", "Татарска пустина", "Дино Буцати", "Современа литература", 1370.00, 3),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/094164_350_350px.jpg", "Скала", "Евгенија Кузњецова", "Современа литература", 1380.00, 2),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/094162_350_350px.jpg", "Градина", "Петра Дворжакова", "Современа литература", 1390.00, 1)
            };

            Classics = new List<Book>
            {
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/064044_1200_1200px_w_0_0px.jpg", "Травничка хроника", "Иво Андриќ", "Класична литература", 1200.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096313_1200_1200px_w_0_0px.jpg", "Сонувачот", "Владислав Рејмонт", "Класична литература", 1210.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096308_1200_1200px_w_0_0px.jpg", "Бедни луѓе", "Фјодор Достоевски", "Класична литература", 1220.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063982_1200_1200px_w_0_0px.jpg", "Мизерна", "Халит Зија Ушаклигил", "Класична литература", 1230.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063944_1200_1200px_w_0_0px.jpg", "Избрани раскази", "Антон П. Чехов", "Класична литература", 1240.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063932_1200_1200px_w_0_0px.jpg", "Магла и месечевина", "Меша Селимовиќ", "Класична литература", 1250.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096113_1200_1200px_w_0_0px.jpg", "The Gift", "Vladimir Nabokov", "Класична литература", 1260.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096110_1200_1200px_w_0_0px.jpg", "Growing Up in the South", "Jones Suzanne", "Класична литература", 1270.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063927_1200_1200px_w_0_0px.jpg", "Дневникот на Сатаната", "Леонид Андрееев", "Класична литература", 1280.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096054_1200_1200px_w_0_0px.jpg", "Pride and Prejudice", "Jane Austen", "Класична литература", 1290.00, 1),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096009_1200_1200px_w_0_0px.jpg", "Среќен е тој што умее да сака", "Херман Хесе", "Класична литература", 1300.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096030_1200_1200px_w_0_0px.jpg", "Паѓаат старици", "Данил Хармс", "Класична литература", 1310.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094262_1200_1200px_w_0_0px.jpg", "Во регистратурата", "Анте Ковачевиќ", "Класична литература", 1320.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094259_1200_1200px_w_0_0px.jpg", "Бегство во Будим", "Владислав Ванчура", "Класична литература", 1330.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094222_1200_1200px_w_0_0px.jpg", "Женското царство", "Антон Павлович Чехов", "Класична литература", 1340.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094210_1200_1200px_w_0_0px.jpg", "Среќното момче", "Бјернстјерне Бјернсон", "Класична литература", 1350.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094209_1200_1200px_w_0_0px.jpg", "Двобој", "Антон Павлович Чехов", "Класична литература", 1360.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094178_1200_1200px_w_0_0px.jpg", "Убави и проклети", "Скот Фицџералд", "Класична литература", 1370.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094203_1200_1200px_w_0_0px.jpg", "Години на невиност", "Идит Вортон", "Класична литература", 1380.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094186_1200_1200px_w_0_0px.jpg", "Љубовта на последниот магнат", "Скот Фицџералд", "Класична литература", 1390.00, 1)
            };

            Drama = new List<Book>
            {
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/059484_1200_1200px_w_0_0px.jpg", "Four Plays", "Copi", "Драма", 1400.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/055881_1200_1200px_w_0_0px.jpg", "Раски и маски", "Александар Кујунџиски", "Драма", 1410.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/048887_1200_1200px_w_0_0px.jpg", "Животот на Прача Рузвелт ; Невиност", "Деа Лоер", "Драма", 1420.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/046932_1200_1200px_w_0_0px.jpg", "Медеја", "Лукиј Анај Сенека", "Драма", 1430.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/046931_1200_1200px_w_0_0px.jpg", "Трилогија за непослушноста", "Ивана Сајко", "Драма", 1440.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/046924_1200_1200px_w_0_0px.jpg", "Избрани драми - том 2", "Горан Стефановски", "Драма", 1450.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/046236_1200_1200px_w_0_0px.jpg", "Нова античка драма", "Сашо Димовски", "Драма", 1460.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/045232_1200_1200px_w_0_0px.jpg", "Жак и неговиот господар", "Милан Кундера", "Драма", 1470.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/042823_1200_1200px_w_0_0px.jpg", "Слана и Јазол", "Душко Трифуновски", "Драма", 1480.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/042395_1200_1200px_w_0_0px.jpg", "Невидливите", "Тена Штивичиќ", "Драма", 1490.00, 1),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/014832_1200_1200px_w_0_0px.jpg", "Henry IV, Part 2", "William Shakespeare", "Драма", 1500.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/041735_1200_1200px_w_0_0px.jpg", "Мир-Божица-Ејрене", "Аристофан", "Драма", 1510.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/013950_1200_1200px_w_0_0px.jpg", "Избрани драми", "Горан Стефановски", "Драма", 1520.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/012385_1200_1200px_w_0_0px.jpg", "Plays : The Cherry Orchard, Three Sisters, The Seagull and Uncle Vanya", "Anton Chekhov", "Драма", 1530.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/012373_1200_1200px_w_0_0px.jpg", "Henry IV, Part I", "William Shakespeare", "Драма", 1540.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/012372_1200_1200px_w_0_0px.jpg", "Love's Labour's Lost", "William Shakespeare", "Драма", 1550.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/012371_1200_1200px_w_0_0px.jpg", "Coriolanus", "William Shakespeare", "Драма", 1560.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/012369_1200_1200px_w_0_0px.jpg", "The Merry Wives Of Windsor", "William Shakespeare", "Драма", 1570.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/010853_1200_1200px_w_0_0px.jpg", "Richard II (Signet Classics)", "William Shakespeare", "Драма", 1580.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/010852_1200_1200px_w_0_0px.jpg", "Julius Caesar", "William Shakespeare", "Драма", 1590.00, 1)
            };

            CrimeThriller = new List<Book>
            {
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/064043_1200_1200px_w_0_0px.jpg", "Ехо на споделеното лудило", "Благоја Стојков", "Криминале", 1200.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063936_1200_1200px_w_0_0px.jpg", "Верувај ми", "Андерс Рослунд", "Криминале", 1210.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063933_1200_1200px_w_0_0px.jpg", "Само таа остана", "Рајли Сејгер", "Криминале", 1220.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063931_1200_1200px_w_0_0px.jpg", "Плен", "Ирса Сигурдадотир", "Криминале", 1230.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096121_1200_1200px_w_0_0px.jpg", "Жените", "Кристин Хана", "Криминале", 1240.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096120_1200_1200px_w_0_0px.jpg", "Плејлиста", "Себастија Фитцек", "Криминале", 1250.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096118_1200_1200px_w_0_0px.jpg", "Добра и лоша", "Алиса Фини", "Криминале", 1260.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094149_1200_1200px_w_0_0px.jpg", "Сестра смрт", "Даниел Петр", "Криминале", 1270.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096114_1200_1200px_w_0_0px.jpg", "Suspects", "Lesley Pearse", "Криминале", 1280.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094217_1200_1200px_w_0_0px.jpg", "X.Y.Z.", "Ана Кетрин Грин", "Криминале", 1290.00, 1),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063871_1200_1200px_w_0_0px.jpg", "Елена знае", "Клаудија Пињеиро", "Криминале", 1300.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063924_1200_1200px_w_0_0px.jpg", "Играта на господин Филип", "Санта Аргирова", "Криминале", 1310.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094146_1200_1200px_w_0_0px.jpg", "Оддел Д", "Фрида Мекфаден", "Криминале", 1320.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094127_1200_1200px_w_0_0px.jpg", "Семејни тајни", "Лијан Моријарти", "Криминале", 1330.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094117_1200_1200px_w_0_0px.jpg", "Local Woman Missing", "Mary Kubica", "Криминале", 1340.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094116_1200_1200px_w_0_0px.jpg", "Camino Island", "John Grisham", "Криминале", 1350.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094115_1200_1200px_w_0_0px.jpg", "Rogue Lawyer", "John Grisham", "Криминале", 1360.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094114_1200_1200px_w_0_0px.jpg", "The Lost Symbol", "Dan Brown", "Криминале", 1370.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094113_1200_1200px_w_0_0px.jpg", "Dead Letters", "Caite Dolan-Leach", "Криминале", 1380.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094112_1200_1200px_w_0_0px.jpg", "The Associate", "John Grisham", "Криминале", 1390.00, 1)
            };

            AdventureAction = new List<Book>
            {
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094163_1200_1200px_w_0_0px.jpg", "Карбид", "Андриј Љубка", "Авантура", 1400.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/059833_1200_1200px_w_0_0px.jpg", "Остров на тишината", "Весела Богданович", "Авантура", 1410.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/059487_1200_1200px_w_0_0px.jpg", "Tarzan of the Apes", "Edgar Rice Burroughs", "Авантура", 1420.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/057269_1200_1200px_w_0_0px.jpg", "Мировна машина", "Озгур Мумџу", "Авантура", 1430.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/049779_1200_1200px_w_0_0px.jpg", "Нулорог", "Петр Станчик", "Авантура", 1440.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/049827_1200_1200px_w_0_0px.jpg", "Сосед од пеколот 2: Совршенство", "Р.Л. Метјусон", "Авантура", 1450.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/054148_1200_1200px_w_0_0px.jpg", "The Afghan", "Frederick Forsyth", "Авантура", 1460.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/013953_1200_1200px_w_0_0px.jpg", "Пловејќи на Еџ", "Лесли Страт", "Авантура", 1470.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/013294_1200_1200px_w_0_0px.jpg", "Merde Happens", "Stephen Clarke", "Авантура", 1480.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/005245_1200_1200px_w_0_0px.jpg", "A Sparrow Falls", "Wilbur Smith", "Авантура", 1490.00, 1),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/012145_1200_1200px_w_0_0px.jpg", "Dangerous Minds", "Janet Evanovich", "Авантура", 1500.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/039853_1200_1200px_w_0_0px.jpg", "Dragon Teeth", "Michael Crichton", "Авантура", 1510.00, 9)
            };

            Romance = new List<Book>
            {
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/064051_1200_1200px_w_0_0px.jpg", "Безобразни писма", "Вај Киленд и Пенелопи Вард", "Романса", 1200.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096553_1200_1200px_w_0_0px.jpg", "Heart Bones", "Colleen Hoover", "Романса", 1210.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096552_1200_1200px_w_0_0px.jpg", "Point of Retreat", "Colleen Hoover", "Романса", 1220.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096551_1200_1200px_w_0_0px.jpg", "Hopeless", "Colleen Hoover", "Романса", 1230.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096550_1200_1200px_w_0_0px.jpg", "This Girl", "Colleen Hoover", "Романса", 1240.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096549_1200_1200px_w_0_0px.jpg", "Without Merit", "Colleen Hoover", "Романса", 1250.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063981_1200_1200px_w_0_0px.jpg", "Украдената убавина", "Кејт Мичел", "Романса", 1260.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063979_1200_1200px_w_0_0px.jpg", "Погрешно време за љубов", "Ина Мур", "Романса", 1270.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063949_1200_1200px_w_0_0px.jpg", "Забранети задоволства", "Елизабет Хојт", "Романса", 1280.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096122_1200_1200px_w_0_0px.jpg", "Кралицата Шарлота", "Џулија Квин", "Романса", 1290.00, 1),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096119_1200_1200px_w_0_0px.jpg", "Скрши го мразот", "Хана Грејс", "Романса", 1300.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096109_1200_1200px_w_0_0px.jpg", "Девојката од прозорецот", "Ѓулсерен Будајџоглу", "Романса", 1310.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096107_1200_1200px_w_0_0px.jpg", "Опасни намери", "Елизабет Хојт", "Романса", 1320.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063925_1200_1200px_w_0_0px.jpg", "Шепотот на дневникот", "Ангела Пенова", "Романса", 1330.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063878_1200_1200px_w_0_0px.jpg", "Последиците од љубовта", "Сулејман Адонија", "Романса", 1340.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096055_1200_1200px_w_0_0px.jpg", "The Paris Apartment", "Lucy Foley", "Романса", 1350.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094187_1200_1200px_w_0_0px.jpg", "Сицилијанска романса", "Ен Редклиф", "Романса", 1360.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063776_1200_1200px_w_0_0px.jpg", "Горчливиот вкус на успехот", "Милијана Павловска", "Романса", 1370.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093925_1200_1200px_w_0_0px.jpg", "Сите недовршени нешта", "Ребека Јарос", "Романса", 1380.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093927_1200_1200px_w_0_0px.jpg", "Плејбој", "Вај Киленд", "Романса", 1390.00, 1)

            };

            Horror = new List<Book>
            {
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/064035_1200_1200px_w_0_0px.jpg", "На планините на лудилото", "Х. Ф. Лавкрафт", "Хорор", 1400.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093748_1200_1200px_w_0_0px.jpg", "Се што правиме во мракот", "Џенифер Хилер", "Хорор", 1410.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093591_1200_1200px_w_0_0px.jpg", "Endymion (Hyperion)", "Dan Simmons", "Хорор", 1420.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093590_1200_1200px_w_0_0px.jpg", "The Rise of Endymion", "Dan Simmons", "Хорор", 1430.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093579_1200_1200px_w_0_0px.jpg", "Black House", "Stephen King", "Хорор", 1440.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093569_1200_1200px_w_0_0px.jpg", "The Girl Who Loved Tom Gordon", "Stephen King", "Хорор", 1450.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093491_1200_1200px_w_0_0px.jpg", "The Final Girl Support Group", "Grady Hendrix", "Хорор", 1460.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093489_1200_1200px_w_0_0px.jpg", "Things Have Gotten Worse Since We Last Spoke And Other Misfortunes", "Eric LaRocca", "Хорор", 1470.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/978144_1200_1200px_w_0_0px.jpg", "Dolores Claiborne", "Stephen King", "Хорор", 1480.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/062445_1200_1200px_w_0_0px.jpg", "Escaping From Houdini", "Kerri Maniscalco", "Хорор", 1490.00, 1),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/054402_1200_1200px_w_0_0px.jpg", "Dracula, A Mystery Story", "Bram Stoker", "Хорор", 1500.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/054279_1200_1200px_w_0_0px.jpg", "Подоцна", "Стивен Кинг", "Хорор", 1510.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/052282_1200_1200px_w_0_0px.jpg", "The Hunted", "Gabriel Bergmoser", "Хорор", 1520.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/050899_1200_1200px_w_0_0px.jpg", "A Head Full of Ghosts", "Paul Tremblay", "Хорор", 1530.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/044847_1200_1200px_w_0_0px.jpg", "Колку покрваво", "Стивен Кинг", "Хорор", 1540.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/040428_1200_1200px_w_0_0px.jpg", "Flight or Fright : 17 Turbulent Tales", "Stephen King, Bev Vincent", "Хорор", 1550.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/038835_1200_1200px_w_0_0px.jpg", "The Bazaar of Bad Dreams", "Stephen King", "Хорор", 1560.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/014039_1200_1200px_w_0_0px.jpg", "Skeleton Crew", "Stephen King", "Хорор", 1570.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/014083_1200_1200px_w_0_0px.jpg", "The Drawing Of The Three (The Dark Tower II)", "Stephen King", "Хорор", 1580.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/013993_1200_1200px_w_0_0px.jpg", "Hearts in Atlantis", "Stephen King", "Хорор", 1590.00, 1)
            };

            Comedy = new List<Book>
            {
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096608_1200_1200px_w_0_0px.jpg", "I, Maybot: The Rise and Fall", "John Crace", "Комедија", 1200.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063659_1200_1200px_w_0_0px.jpg", "Најдобрите вицови на Окно 5", "", "Комедија", 1220.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063658_1200_1200px_w_0_0px.jpg", "Најдобрите вицови на Окно 4", "", "Комедија", 1230.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063657_1200_1200px_w_0_0px.jpg", "Најдобрите вицови на Окно 3", "", "Комедија", 1240.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063656_1200_1200px_w_0_0px.jpg", "Најдобрите вицови на Окно 2", "", "Комедија", 1250.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063655_1200_1200px_w_0_0px.jpg", "Најдобрите вицови на Окно 1", "", "Комедија", 1260.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/060906_1200_1200px_w_0_0px.jpg", "Цепај сине: пошто џабе живиш у Македонија", "Зоран Спасов - Ѕоф", "Комедија", 1270.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/053033_1200_1200px_w_0_0px.jpg", "Џабе живиш у Скопје", "Зоран Спасов - Ѕоф", "Комедија", 1280.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/041980_1200_1200px_w_0_0px.jpg", "Hark", "Sam Lipsyte", "Комедија", 1290.00, 1),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/040640_1200_1200px_w_0_0px.jpg", "Cold War Steve Presents... A Prat's Progress", "Cold War Steve", "Комедија", 1300.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/039033_1200_1200px_w_0_0px.jpg", "Теодосиј Малиот", "Разван Радулеску", "Комедија", 1310.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/013451_1200_1200px_w_0_0px.jpg", "Тошо Малерот - монологија", "Васко Тодоров", "Комедија", 1320.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011129_1200_1200px_w_0_0px.jpg", "Мрачни скршнувања", "Џон Ралстон Сол", "Комедија", 1330.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/056201_1200_1200px_w_0_0px.jpg", "Confessions of a Forty-Something F**k Up", "Alexandra Potter", "Комедија", 1340.00, 6)
            };

            ScienceFictionFantasy = new List<Book>
            {
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096052_1200_1200px_w_0_0px.jpg", "Among Thieves", "M. J. Kuhn", "Научна фантастика и фантазија", 1400.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096051_1200_1200px_w_0_0px.jpg", "The Sentinel", "Lee Child", "Научна фантастика и фантазија", 1410.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096049_1200_1200px_w_0_0px.jpg", "The Desert Prince", "Peter V. Brett", "Научна фантастика и фантазија", 1420.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063767_1200_1200px_w_0_0px.jpg", "Harry Potter and the Deathly Hallows", "J.K. Rowling", "Научна фантастика и фантазија", 1430.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063697_1200_1200px_w_0_0px.jpg", "Anthem", "Ayn Rand", "Научна фантастика и фантазија", 1440.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063695_1200_1200px_w_0_0px.jpg", "Atlas Shrugged", "Ayn Rand", "Научна фантастика и фантазија", 1450.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063690_1200_1200px_w_0_0px.jpg", "The Lord Of The Rings", "J.R.R. Tolkien", "Научна фантастика и фантазија", 1460.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093914_1200_1200px_w_0_0px.jpg", "Detective Thrillers Short Stories (Gothic Fantasy)", "Lee Horsley", "Научна фантастика и фантазија", 1470.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093913_1200_1200px_w_0_0px.jpg", "Black Sci-Fi Short Stories (Gothic Fantasy)", "Tia Ross", "Научна фантастика и фантазија", 1480.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093827_1200_1200px_w_0_0px.jpg", "Fourth Wing", "Rebecca Yarros", "Научна фантастика и фантазија", 1490.00, 1),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093746_1200_1200px_w_0_0px.jpg", "Witches, Wizards, Seers & Healers Myths & Tales: Epic Tales", "Diane Purkiss", "Научна фантастика и фантазија", 1500.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093711_1200_1200px_w_0_0px.jpg", "Силмарилион", "Џон Р. Р. Толкин", "Научна фантастика и фантазија", 1510.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093643_1200_1200px_w_0_0px.jpg", "The Return of the King", "J.R.R. Tolkien", "Научна фантастика и фантазија", 1520.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093634_1200_1200px_w_0_0px.jpg", "Time's Eye (A Time Odyssey)", "Arthur C. Clarke", "Научна фантастика и фантазија", 1530.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093633_1200_1200px_w_0_0px.jpg", "The Imperial Handbook - A Commander's Guide", "Daniel Wallace", "Научна фантастика и фантазија", 1540.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093608_1200_1200px_w_0_0px.jpg", "The Bounty Hunter Wars", "K W Jeter", "Научна фантастика и фантазија", 1550.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093583_1200_1200px_w_0_0px.jpg", "Inhibitor Phase", "Alastair Reynolds", "Научна фантастика и фантазија", 1560.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093581_1200_1200px_w_0_0px.jpg", "The Female Man", "Joanna Russ", "Научна фантастика и фантазија", 1570.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093580_1200_1200px_w_0_0px.jpg", "Grass (SF Masterworks)", "Sheri S. Tepper", "Научна фантастика и фантазија", 1580.00, 2)

            };

            HistoricFiction = new List<Book>
            {
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063945_1200_1200px_w_0_0px.jpg", "Залудно бегство", "Сигрун Паулсдотир", "Историска фикција", 1600.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063938_1200_1200px_w_0_0px.jpg", "Куќа на духови", "Изабел Аљенде", "Историска фикција", 1610.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096123_1200_1200px_w_0_0px.jpg", "A Long Petal of the Sea", "Isabel Allende", "Историска фикција", 1620.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096115_1200_1200px_w_0_0px.jpg", "Hamnet", "Maggie O Farrell", "Историска фикција", 1630.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063919_1200_1200px_w_0_0px.jpg", "Одмаздата на Тудорите", "К. В. Гортнер", "Историска фикција", 1640.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096085_1200_1200px_w_0_0px.jpg", "Фау-2", "Роберт Херис", "Историска фикција", 1650.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094249_1200_1200px_w_0_0px.jpg", "Олга и Лина", "Еуген Кумичиќ", "Историска фикција", 1660.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094168_1200_1200px_w_0_0px.jpg", "Империјата на сонцето", "Џ. Г. Балард", "Историска фикција", 1670.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094123_1200_1200px_w_0_0px.jpg", "Девојчински спомени", "Ани Ерно", "Историска фикција", 1680.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093788_1200_1200px_w_0_0px.jpg", "Пристанишна зона: приказна за духови", "Демјан Валфорд Дејвис", "Историска фикција", 1690.00, 1),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093725_1200_1200px_w_0_0px.jpg", "Раскажувачот", "Мирана Ликар", "Историска фикција", 1700.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093649_1200_1200px_w_0_0px.jpg", "Зимската роза", "Мелани Добсон", "Историска фикција", 1710.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093607_1200_1200px_w_0_0px.jpg", "Shrines of Gaiety", "Kate Atkinson", "Историска фикција", 1720.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093588_1200_1200px_w_0_0px.jpg", "The Kingdoms", "Natasha Pulley", "Историска фикција", 1730.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093498_1200_1200px_w_0_0px.jpg", "The Marriage Portrait", "Maggie O'Farrell", "Историска фикција", 1740.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/062458_1200_1200px_w_0_0px.jpg", "Lord John and the Hand of Devils", "Diana Gabaldon", "Историска фикција", 1750.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/062850_1200_1200px_w_0_0px.jpg", "The Fortune Of War", "Patrick O'Brian", "Историска фикција", 1760.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/062848_1200_1200px_w_0_0px.jpg", "The Library of the Dead", "T. L. Huchu", "Историска фикција", 1770.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/062845_1200_1200px_w_0_0px.jpg", "The Wine-Dark Sea", "Patrick O'Brian", "Историска фикција", 1780.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/062837_1200_1200px_w_0_0px.jpg", "The Surgeon's Mate", "Patrick O'Brian", "Историска фикција", 1790.00, 1)
            };

            MacedonianPoetry = new List<Book>
            {
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/064037_1200_1200px_w_0_0px.jpg", "Јазикот што само ние го разбираме", "Зоран Јакимоски", "Македонска поезија", 1800.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/064036_1200_1200px_w_0_0px.jpg", "Грозје од кукавица", "Славе Ѓорѓо Димоски", "Македонска поезија", 1810.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096529_1200_1200px_w_0_0px.jpg", "Шестарот на времето", "Никола Маџиров", "Македонска поезија", 1820.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/064009_1200_1200px_w_0_0px.jpg", "Додека спиеш", "Биљана Стојановска", "Македонска поезија", 1830.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094165_1200_1200px_w_0_0px.jpg", "Меѓу копнежот и сонот", "Соња Карбева", "Македонска поезија", 1840.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094167_1200_1200px_w_0_0px.jpg", "Во твоите зеници", "Анита Димитриевска", "Македонска поезија", 1850.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063942_1200_1200px_w_0_0px.jpg", "Небо од стихови", "Софија Добревска", "Македонска поезија", 1860.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/064008_1200_1200px_w_0_0px.jpg", "Една ноќ", "Кристина Краличин", "Македонска поезија", 1870.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/063661_1200_1200px_w_0_0px.jpg", "Нејзина песна - Пет современи македонски поетеси", "", "Македонска поезија", 1880.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/094118_1200_1200px_w_0_0px.jpg", "Подоцна", "Маријан Бошевски", "Македонска поезија", 1890.00, 1),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093904_1200_1200px_w_0_0px.jpg", "Утре е секогаш сега", "Весна Алексова Стојковска", "Македонска поезија", 1900.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093700_1200_1200px_w_0_0px.jpg", "Дождови во мај: сублимирани емоции со две лажички мед", "Даница И. Лепојевиќ", "Македонска поезија", 1910.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/062166_1200_1200px_w_0_0px.jpg", "Стражари на ноќта", "Марија Митева", "Македонска поезија", 1920.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/060482_1200_1200px_w_0_0px.jpg", "Капки", "Ристо Маџунков", "Македонска поезија", 1930.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/060224_1200_1200px_w_0_0px.jpg", "Ветар и магла", "Вера Лиличиќ", "Македонска поезија", 1940.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/059835_1200_1200px_w_0_0px.jpg", "Љубовно аздисано хаику", "Стефчо Стефанов", "Македонска поезија", 1950.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/057510_1200_1200px_w_0_0px.jpg", "Две мориња", "Јосип Коцев", "Македонска поезија", 1960.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/057250_1200_1200px_w_0_0px.jpg", "Бесконечно: анатомија на страста", "Десанка Николова", "Македонска поезија", 1970.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/057247_1200_1200px_w_0_0px.jpg", "Боја во сето сиво", "Александра Андреева", "Македонска поезија", 1980.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/054252_1200_1200px_w_0_0px.jpg", "Филмски песни", "Дејан Трајкоски", "Македонска поезија", 1990.00, 1)
            };

            ForeignPoetry = new List<Book>
            {
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/093744_1200_1200px_w_0_0px.jpg", "Selected Poetical Works: Blake", "William Blake", "Foreign Poetry", 1800.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/062869_1200_1200px_w_0_0px.jpg", "Poems", "Charles Dickens", "Foreign Poetry", 1810.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/059614_1200_1200px_w_0_0px.jpg", "Sonnets", "Cecco Angiolieri", "Foreign Poetry", 1820.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/049143_1200_1200px_w_0_0px.jpg", "Poems from the high Prairie", "Alice Louise Wagoner , Anna Applegarth", "Foreign Poetry", 1830.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/048016_1200_1200px_w_0_0px.jpg", "Spoon River Anthology: 100th Anniversary Edition", "Edgar Lee Masters", "Foreign Poetry", 1840.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/042561_1200_1200px_w_0_0px.jpg", "Home Body", "Rupi Kaur", "Foreign Poetry", 1850.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/042342_1200_1200px_w_0_0px.jpg", "RENDANG", "Will Harris", "Foreign Poetry", 1860.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/041498_1200_1200px_w_0_0px.jpg", "Phenomenal Woman : Four Poems Celebrating Women", "Maya Angelou", "Foreign Poetry", 1870.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/014704_1200_1200px_w_0_0px.jpg", "The Complete Poems of John Keats", "John Keats", "Foreign Poetry", 1880.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/014609_1200_1200px_w_0_0px.jpg", "Mother : A Cradle to Hold Me", "Maya Angelou", "Foreign Poetry", 1890.00, 1),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/014499_1200_1200px_w_0_0px.jpg", "And Still I Rise : A Book of Poems", "Maya Angelou", "Foreign Poetry", 1900.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/014498_1200_1200px_w_0_0px.jpg", "I Shall Not Be Moved : Poems", "Maya Angelou", "Foreign Poetry", 1910.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/014483_1200_1200px_w_0_0px.jpg", "I Shall Not Be Moved", "Maya Angelou", "Foreign Poetry", 1920.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/013882_1200_1200px_w_0_0px.jpg", "A Little Larger Than the Entire Universe : Selected Poems", "Fernando Pessoa", "Foreign Poetry", 1930.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/013724_1200_1200px_w_0_0px.jpg", "The Song of Roland", "Guy Gavriel Kay", "Foreign Poetry", 1940.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/013332_1200_1200px_w_0_0px.jpg", "The Colossus and Other Poems", "Sylvia Plath", "Foreign Poetry", 1950.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/002809_1200_1200px_w_0_0px.jpg", "Betting on the Muse", "Charles Bukowski", "Foreign Poetry", 1960.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/003092_1200_1200px_w_0_0px.jpg", "Rumi: Bridge to the Soul : Journeys into the Music and Silence of the Heart", "Rumi", "Foreign Poetry", 1970.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/002789_1200_1200px_w_0_0px.jpg", "On Love", "Charles Bukowski", "Foreign Poetry", 1980.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/002787_1200_1200px_w_0_0px.jpg", "Dangling in the Tournefortia", "Charles Bukowski", "Foreign Poetry", 1990.00, 1)
            };

            Travel = new List<Book>
            {
                 new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/062893_1200_1200px_w_0_0px.jpg", "Pretty Little London", "Sara Santini, Andrea Di Filipo", "Travel", 2020.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/059454_1200_1200px_w_0_0px.jpg", "Birnbaum's 2020 Disneyland Resort: The Official Vacation Guide", "Birnbaum Guides", "Travel", 2021.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/978075_1200_1200px_w_0_0px.jpg", "501 great places to stay", "Fid Backhouse, Arthur Findlay, Kieran Fogarty", "Travel", 2022.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/044488_1200_1200px_w_0_0px.jpg", "Churches & monasteries : guide book", "Goce Drtkovski, Natali Nikolovska", "Travel", 2023.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011556_1200_1200px_w_0_0px.jpg", "Phuket (Marco Polo Guide)", "Академска Книга", "Travel", 2024.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011552_1200_1200px_w_0_0px.jpg", "Dubrovnik & Dalmatian Coast (Marco Polo Pocket Guide)", "Академска Книга", "Travel", 2025.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011428_1200_1200px_w_0_0px.jpg", "Prague (Marco Polo Travel Handbook)", "Академска Книга", "Travel", 2026.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011550_1200_1200px_w_0_0px.jpg", "Dubai (Marco Polo Pocket Guide)", "Академска Книга", "Travel", 2027.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011427_1200_1200px_w_0_0px.jpg", "Berlin (Marco Polo Travel Handbook)", "Академска Книга", "Travel", 2028.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011424_1200_1200px_w_0_0px.jpg", "Lisbon (Marco Polo Guide)", "Академска Книга", "Travel", 2029.00, 1),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011421_1200_1200px_w_0_0px.jpg", "Venice (Marco Polo Pocket Guide)", "Академска Книга", "Travel", 2030.00, 10),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011420_1200_1200px_w_0_0px.jpg", "Tenerife (Marco Polo Pocket Guide)", "Академска Книга", "Travel", 2031.00, 9),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011419_1200_1200px_w_0_0px.jpg", "Cuba (Marco Polo Pocket Guide)", "Академска Книга", "Travel", 2032.00, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011414_1200_1200px_w_0_0px.jpg", "Ireland (Marco Polo Travel Handbook)", "Академска Книга", "Travel", 2033.00, 7),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011413_1200_1200px_w_0_0px.jpg", "Rome (Marco Polo Travel Handbook)", "Академска Книга", "Travel", 2034.00, 6),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011406_1200_1200px_w_0_0px.jpg", "Florence (Marco Polo Travel Handbook)", "Академска Книга", "Travel", 2035.00, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011404_1200_1200px_w_0_0px.jpg", "Dresden (Marco Polo Travel Handbook)", "Академска Книга", "Travel", 2036.00, 4),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011395_1200_1200px_w_0_0px.jpg", "Insight Guides: Italian Lakes", "Академска Книга", "Travel", 2037.00, 3),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/011392_1200_1200px_w_0_0px.jpg", "Insight Guides: Brazil", "Академска Книга", "Travel", 2038.00, 2),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/007526_1200_1200px_w_0_0px.jpg", "Скопје: водич на улици", "Љубе Ристовски", "Travel", 2039.00, 1)
            };

            SportFitness = new List<Book>
            {
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/093394_350_350px.jpg", "Science of HIIT: Understand the Anatomy and Physiology to Transform Your Body", "Ingrid S. Clay", "Sport/Fitness", 2020.00, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/053783_350_350px.jpg", "Foam Roller Exercises : Relieve Pain, Prevent Injury, Improve Mobility", "Sam Woodworth", "Sport/Fitness", 2021.00, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/051679_350_350px.jpg", "15-Minute Gentle Yoga : Four 15-Minute Workouts for Energy, Balance, and Calm", "Louise Grime", "Sport/Fitness", 2022.00, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/051679_350_350px.jpg", "15-Minute Pilates : Four 15-Minute Workouts for Strength, Stretch, and Control", "Alycea Ungaro", "Sport/Fitness", 2023.00, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/043104_350_350px.jpg", "Основен тренинг за живот", "Марино Башиќ", "Sport/Fitness", 2024.00, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/015011_350_350px.jpg", "Football Leaks : Uncovering the Dirty Deals Behind the Beautiful Game", "Rafael Buschmann", "Sport/Fitness", 2025.00, 5),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/013271_350_350px.jpg", "The Qigong Bible", "Katherine Allen", "Sport/Fitness", 2026.00, 4),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/012324_350_350px.jpg", "15 Minute Fitness: 100 quick and easy exercises", "Suzanne Martin", "Sport/Fitness", 2027.00, 3),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/010729_350_350px.jpg", "The Accumulator : The Revolutionary 30-Day Fitness Plan", "Paul Mumford", "Sport/Fitness", 2028.00, 2),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/008437_350_350px.jpg", "Тренирање со руско ѕвоно", "Стив Котер", "Sport/Fitness", 2029.00, 1),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/007918_350_350px.jpg", "Pilates for Living : Get stronger, fitter and healthier for an active later life", "Harri Angell", "Sport/Fitness", 2030.00, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/007234_350_350px.jpg", "A Little Course in Pilates : Simply Everything You Need to Succeed", "DK", "Sport/Fitness", 2031.00, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/002474_350_350px.png", "Издржи, кралице : реални приказни за растежот, падовите и успесите на еден брат и една сестра во свет во кој трчањето е помалку од ништо но повеќе од сè", "Весна Кираџиева, Александар Кираџиев", "Sport/Fitness", 2032.00, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/008127_350_350px.jpg", "Девијантност и социјална контрола во спортот", "Мајкл Еткинсон", "Sport/Fitness", 2033.00, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/004861_350_350px.jpg", "Менаџмент на човечки ресурси во спортот и рекреацијата", "Пакианатан Челадурај", "Sport/Fitness", 2034.00, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/004826_350_350px.jpg", "Психологија на физичката активност : детерминанти, добросостојба и интервенции", "Стјуарт Џ.Х. Бидл, Нанет Матри", "Sport/Fitness", 2035.00, 5),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/004822_350_350px.jpg", "Напреден бокс : обука, вештини и техники", "Ракеш Сонди, Томи Томпсон", "Sport/Fitness", 2036.00, 4),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/001988_350_350px.jpg", "Квалитативно истражување во физичката активност и во здравствените професии", "Вилијам Питни", "Sport/Fitness", 2037.00, 3),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/000010_350_350px.jpg", "Како успешно да се игра ракомет: техника, тактика, тренинг", "Кристоф Колоџеј", "Sport/Fitness", 2038.00, 2),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/004199_350_350px.jpg", "Основи на спортскиот менаџмент", "Роберт Бејкер, Крег Ешерик", "Sport/Fitness", 2039.00, 1)
            };

            Cookbooks = new List<Book>()
            {
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096143_350_350px.jpg", "Enjoying Bourbon", "Frank Flannery", "Книги за готвење", 1590, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096125_350_350px.jpg", "Tea at the Palace", "Carolyn Robb", "Книги за готвење", 1290, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096124_350_350px.jpg", "Party Drinks", "Rebecca Hubbell", "Книги за готвење", 1390, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/062865_350_350px.jpg", "The Mix", "Liora Bels", "Книги за готвење", 1490, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/062237_350_350px.jpg", "The Great American Recipe Cookbook", "Академска Книга", "Книги за готвење", 1790, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/059734_350_350px.jpg", "200 Family Slow Cooker Recipes", "Sara Lewis", "Книги за готвење", 1690, 5),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/058514_350_350px.jpg", "Australian Women's Weekly Healthy Eating : Balanced, Nourishing Everyday Recipes", "Академска Книга", "Книги за готвење", 1890, 4),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/058416_350_350px.jpg", "Вегански готвач : со радост во кујната и љубов кон животните", "Срце за животните", "Книги за готвење", 1490, 3),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/056902_350_350px.jpg", "Готвењето како наука и уметноста на убавото јадење", "Пелегрино Артузи", "Книги за готвење", 1590, 2),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/053786_350_350px.jpg", "Modern Flexitarian : Veg-based Recipes you can Flex to add Fish, Meat, or Dairy", "DK", "Книги за готвење", 1690, 1),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/051663_350_350px.jpg", "Australian Women's Weekly: Vegetarian - Flavoursome, Nutritious Everyday Recipes", "Australian Women'S Weekly", "Книги за готвење", 1790, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/050984_350_350px.jpg", "The Korean Vegan Cookbook : Reflections and Recipes from Omma's Kitchen", "Joanna Lee Molinaro", "Книги за готвење", 1990, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/047775_350_350px.jpg", "Plenty more : живописни зеленчукови рецепти за изобилство од вкусови", "Јотам Отоленги", "Книги за готвење", 1890, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/035623_350_350px.jpg", "Од длабочините на морето", "Дејан Карапеев", "Книги за готвење", 1690, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/035588_350_350px.jpg", "Dave's kitchen: Гответе насмеани", "Давор Панчевски", "Книги за готвење", 1590, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/014670_350_350px.jpg", "Mowgli Street Food : Stories and recipes from the Mowgli Street Food restaurants", "Nisha Katona", "Книги за готвење", 1790, 5),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/009469_350_350px.jpg", "Голем готвач за бебиња и мали децa", "Dagmar Fon Kram", "Книги за готвење", 1490, 4),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/008485_350_350px.png", "Моите најдобри рецепти", "Билјана Вучкова", "Книги за готвење", 1690, 3),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/008292_350_350px.jpg", "The Frankies Spuntino Kitchen Companion & Cooking Manual", "The Frankies", "Книги за готвење", 1990, 2),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/007922_350_350px.jpg", "The Slow Cooker Baby Food Cookbook", "Maggie Meade", "Книги за готвење", 1790, 1)
            };

            Economy = new List<Book>
            {
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096528_350_350px.jpg", "Дигитална економија", "Зоран Јаневски", "Economy", 1200.00, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096527_350_350px.jpg", "Вештини на вработените за конкурентност на мали и средни претпријатија", "д-р Ирина Пиперкова, д-р Александра Лозановска", "Economy", 930.00, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096526_350_350px.jpg", "Можности за примена на концептот на зелена економија во мсп во РСМ", "Неда Петроска-Ангеловска, Катерина Хаџи Наумова-Михајловска", "Economy", 1390.00, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096525_350_350px.jpg", "Квалитетот на живот на населението во РСМ во време на COVID-19 пандемијата", "д-р Владимир Петковски, д-р Исидора Станчева", "Economy", 995.00, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096524_350_350px.jpg", "Демографско терминолошки речник", "Економски институт - Скопје", "Economy", 785.00, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096523_350_350px.jpg", "Особености на активното и неактивното помладо население во Р. Македонија", "Верица Јаневска, Александра Лозаноска", "Economy", 650.00, 5),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096522_350_350px.jpg", "Финансирање на мали и средни претпријатија", "Биљана Ангелова, Климентина Попоска", "Economy", 1075.00, 4),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096521_350_350px.jpg", "Меѓународен маркетинг: концепциски, стратегиски и акциони аспекти", "Татјана Петковска Мирчевска", "Economy", 1245.00, 3),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096520_350_350px.jpg", "Научната дијаспора од Република Македонија", "Верица Јанеска (редактор)", "Economy", 840.00, 2),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096519_350_350px.jpg", "Претприемачка лабораторија", "Татјана П. Мирчевска, Зоран Јаневски", "Economy", 1495.00, 1),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096518_350_350px.jpg", "Акциите - инструмент на портфолио менаџментот", "Диана Бошковска", "Economy", 1100.00, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096517_350_350px.jpg", "Претприемништво и електронска трговија", "Зоран Јаневски", "Economy", 875.00, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096516_350_350px.jpg", "Готовинскиот тек и ликвидноста на претпријатијата", "Неда Петровска-Ангеловска", "Economy", 1300.00, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/005459_350_350px.jpg", "Примена на повеќекритериумски методи во банкарството : случајот на Комерцијална банка АД Скопје", "Виолета Цветковска", "Economy", 1020.00, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096515_350_350px.jpg", "Туризмот и економскиот развој на Република Македонија", "Марија Ацковска", "Economy", 750.00, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/005344_350_350px.jpg", "Историја на економската мисла", "Агнард Сандму", "Economy", 1275.00, 5),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/002622_350_350px.jpg", "Маркетинг-менаџмент : знаења и вештини", "Џ. Пол Питер, Џејмс Донели", "Economy", 945.00, 4),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/002363_350_350px.jpg", "Претприемачки мал бизнис", "Џером Кац, Ричард Грин", "Economy", 1512.00, 3),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/001611_350_350px.jpg", "Претприемаштво", "Robert Hisrih, Mihael Peters", "Economy", 975.00, 2),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/001521_350_350px.jpg", "Стратегиски бренд-менаџмент : градење, мерење и управување со капиталот на брендот", "Кевин Лејн Келер", "Economy", 1400.00, 1)
            };

            SocialOther = new List<Book>()
            {
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/053665_350_350px.jpg", "Злоупотреба на процесните овластувања во парничната постапка", "Милка Ракочевиќ", "Правни науки", 1250, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/048924_350_350px.jpg", "Loyalty towards the constitution : dissenting opinions of judge Darko Kostadinovski, ph.d.", "Darko Kostadinovski Ph.D", "Правни науки", 1750, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/047107_350_350px.jpg", "Лојалност кон уставот", "Дарко Костадиновски", "Правни науки", 1450, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/044966_350_350px.png", "Македонско енергетско право", "Серјожа Марков, Јован Андоновски", "Правни науки", 1980, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/042862_350_350px.jpg", "Уставно право", "Светомир Шкариќ", "Правни науки", 1320, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/011483_350_350px.jpg", "Криминолошки профил на сторителите на кривичното дело силување", "Крсте Маљановски", "Правни науки", 1670, 5),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/006874_350_350px.jpg", "Човекови права и психоанализа", "Љубомир Д. Фрчковски", "Правни науки", 1540, 4),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/004985_350_350px.jpg", "Воспоставување на единствен државен протокол на ниво на Република Македонија", "Санде Симијанов", "Правни науки", 1790, 3),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/004771_350_350px.jpg", "Реторика", "Јован Андоновски", "Правни науки", 1360, 2),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/062289_350_350px.jpg", "Ники", "Тибор Дери", "Правни науки", 1420, 1),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096184_350_350px.jpg", "Судска психологија со психопатологија", "Д-р Крсте Маљановски", "Правни науки", 1630, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/055828_350_350px.jpg", "Шизофренија или аскетизам", "Јован Корнаракис", "Правни науки", 1550, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/049724_350_350px.jpg", "Децата и разводот", "Драгана Батиќ", "Правни науки", 1480, 8)
            };

            Medicine = new List<Book>()
            {
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/063742_350_350px.jpg", "Unnatural Causes", "Richard Shepherd", "Medicine", 2890, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/053809_350_350px.jpg", "Инспиративна вистина", "Орде Ѓорѓиоски", "Medicine", 2190, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/052630_350_350px.jpg", "Јуридизација на медицината – реален ст(р)ав за лекарска грешка", "Габриела Гајдова", "Medicine", 2490, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/050233_350_350px.jpg", "Микрохируршка ендодонција", "Арналдо Кастелучи", "Medicine", 3190, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/048937_350_350px.jpg", "Педијатриски прирачник : за првите шест години", "Ангелчо Андоновски, Татјана Јаќовска", "Medicine", 2690, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/042406_350_350px.jpg", "Некои аспекти на новоформираното коскено ткиво", "Ненад Атанасов, Виктор Камнар", "Medicine", 1990, 5),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/009067_350_350px.jpg", "Акушерство : учебник", "Весна Антовска", "Medicine", 2990, 4),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/007950_350_350px.jpg", "Невролошки терапевтски прирачник", "Методи Чепреганов, Милчо Демерџиев", "Medicine", 3490, 3),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/005953_350_350px.jpg", "Атлас на човечката анатомија", "Френк Х. Нетер", "Medicine", 4190, 2),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/004123_350_350px.jpg", "Медицински основи на инвалидноста", "Владимир Трајковски", "Medicine", 2590, 1),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/003445_350_350px.jpg", "Одбрани поглавја од трансфузиона хематологија и интерна медицина", "Трајан Стрезоски", "Medicine", 2990, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/002287_350_350px.jpg", "Генетски предиспозиции за заразни заболувања", "Ричард Кезлоу", "Medicine", 2890, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/001652_350_350px.jpg", "Харперова илустрирана биохемија", "Роберт Мареј", "Medicine", 3290, 8)
            };

            ScienceOther = new List<Book>()
            {
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/063766_350_350px.jpg", "Special & General Relativity Concise Edition", "Алберт Ајнштајн", "Природни науки", 2890, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/003553_350_350px.jpg", "Габите во Македонија", "Санде Стојчевски", "Природни науки", 2190, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/063983_350_350px.jpg", "Анализа со конечни елементи", "Виктор Христовски", "Природни науки", 2490, 8),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/096186_1200_1200px_w_0_0px.jpg", "Изведба на објекти од високоградба", "Мадан Мета, Волтер Скарбороу, Дајен Армприст", "Природни науки", 3190, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/063765_350_350px.jpg", "The Road to Conscious Machines: The Story of AI", "Мајкл Вулдриџ", "Природни науки", 2690, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/002295_350_350px.jpg", "Модерна имплементација на компајлери во Java", "Ендрју Апел", "Природни науки", 1990, 5),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/001546_350_350px.jpg", "Комплексност на пресметувањата : современ пристап", "Санџив Арора", "Природни науки", 2990, 4),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/093938_350_350px.jpg", "Карти - Погоди ја земјата", "Топер", "Природни науки", 2490, 3),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/052597_350_350px.jpg", "Matematika : doracak për parashkollorë : 4-5 vjet", "Билјана Стојоска-Златков", "Природни науки", 2190, 2),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/036036_350_350px.jpg", "Kujtesa matematikore : doracak për moshën parashkollore : (5 - 6 vjeç)", "Ели Маказлиева", "Природни науки", 1890, 1),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/036035_350_350px.jpg", "Kujtesa matematikore : doracak për moshën parashkollore : (4 - 5 vjeç)", "Ели Маказлиева", "Природни науки", 1990, 10)
            };

            Music = new List<Book>()
            {
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/056900_350_350px.jpg", "Партитури за оркестар на шест антологиски кореографии", "Коловски Марко, Илиевски Дарко", "Музика", 1490, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/048905_350_350px.jpg", "Пиеси за пијано 1: Барок и класика", "Снежана Атанасова Чадиковска", "Музика", 1290, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/008878_350_350px.png", "ПИЕСИ за пијано 3, Романтизам и импресионизам Кн.1", "Снежана Атанасова Чадиковска, Стојанчо Баковски", "Музика", 1390, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/008877_350_350px.png", "ПИЕСИ за пијано 2, Романтизам и импресионизам Кн.1", "Снежана Атанасова Чадиковска, Стојанчо Баковски", "Музика", 1340, 7)
            };

            FilmStagecraft = new List<Book>()
            {
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/052316_350_350px.jpg", "The Film Book: A Complete Guide", "Ronald Bergan", "Филмска уметност и сценографија", 1890, 10)
            };

            Architecture = new List<Book>()
            {
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/002405_350_350px.jpg", "Паметни материјали во архитектурата, внатрешната архитектура и дизајнот", "Аксел Ритер", "Архитектура", 2890, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/001935_350_350px.jpg", "Нов архитектонски атлас", "Франциско Асенсио", "Архитектура", 3190, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/001906_350_350px.jpg", "Конструирање архитектура : материјали, процеси, структури : прирачник", "Андреа Деплацес", "Архитектура", 2790, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/001902_350_350px.jpg", "Ентериери : вовед", "Карла Нилсон, Дејвид Тејлор", "Архитектура", 2490, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/001312_350_350px.jpg", "Историја на архитектурата : основи и ритуали", "Спиро Костоф", "Архитектура", 2990, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/001180_350_350px.jpg", "Земјена архитектура : од античка до модерна", "Вилијам Морган", "Архитектура", 2690, 5),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/000086_350_350px.jpg", "Нојферт: Архитектонско проектирање", "Ернст Нојферт", "Архитектура", 2890, 4)
            };

            EncyclopediaLexicon = new List<Book>()
            {
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096598_350_350px.jpg", "Plant Magick", "Jessica Hundley", "Енциклопедии и лексикони", 2390, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/096595_350_350px.jpg", "Cabinet of Natural Curiosities", "Taschen", "Енциклопедии и лексикони", 2990, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/093370_350_350px.jpg", "The Chemistry Book: Big Ideas Simply Explained", "DK", "Енциклопедии и лексикони", 2790, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/093349_350_350px.jpg", "Great Novels", "D.K. Publishing", "Енциклопедии и лексикони", 2590, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/062826_350_350px.jpg", "Politics Philosophy & Economics", "", "Енциклопедии и лексикони", 2190, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/060494_350_350px.jpg", "The Book of Palms", "Carl Friedrich Philipp von Martius", "Енциклопедии и лексикони", 2690, 5),
                new Book("https://www.literatura.mk/files/watermark/files/thumbs/files/images/slike_proizvoda/thumbs_1200/thumbs_w/059874_1200_1200px_w_0_0px.jpg", "Disney A to Z : The Official Encyclopedia", "Dave Smith", "Енциклопедии и лексикони", 2490, 4),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/054128_350_350px.jpg", "The Science of Pregnancy : The Complete Illustrated Guide from Conception to Birth", "DK", "Енциклопедии и лексикони", 2890, 3),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/054127_350_350px.jpg", "Star Wars Ultimate Factivity Collection", "DK", "Енциклопедии и лексикони", 1990, 2),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/054122_350_350px.jpg", "Norse Myths", "Matt Ralphs", "Енциклопедии и лексикони", 2290, 1),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/054120_350_350px.jpg", "Dinosaurs and Other Prehistoric Life", "Prof Anusuya Chinsamy-Turan", "Енциклопедии и лексикони", 2390, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/054118_350_350px.jpg", "Greek Myths : Meet the heroes, gods, and monsters of ancient Greece", "DK", "Енциклопедии и лексикони", 2190, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/053277_350_350px.jpg", "The Sherlock Holmes Book Big Ideas Simply Explained", "DK", "Енциклопедии и лексикони", 2590, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/051773_350_350px.jpg", "Star Wars: The Complete Visual Dictionary", "Pablo Hidalgo, DR David Reynolds", "Енциклопедии и лексикони", 2990, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/006687_350_350px.jpg", "The Art Book : Big Ideas Simply Explained", "DK", "Енциклопедии и лексикони", 2690, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/038876_350_350px.jpg", "Earth : The Definitive Visual Guide", "DK", "Енциклопедии и лексикони", 2790, 5),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/013613_350_350px.jpg", "1001 Books You Must Read Before You Die", "Peter Boxall", "Енциклопедии и лексикони", 2490, 4),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/013402_350_350px.jpg", "Преглед на класични автомобили", "Мајкл Горман", "Енциклопедии и лексикони", 2590, 3),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/011541_350_350px.jpg", "The Science of Animals : Inside their Secret World", "DK", "Енциклопедии и лексикони", 2890, 2),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/011124_350_350px.jpg", "Тие имаат збор за тоа : ненаметлив лексикон на непреводливи зборови и фрази", "Хауард Реинголд", "Енциклопедии и лексикони", 2990, 1)
            };

            JournalMagazine = new List<Book>()
            {
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/062292_350_350px.jpg", "Современост бр. 4, 2023 год.", "Современост", "Часописи и магазини", 1290, 10),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/055697_350_350px.jpg", "Современост бр. 1, 2023 год.", "Современост", "Часописи и магазини", 1190, 9),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/050553_350_350px.jpg", "Современост бр. 2, 2022 год.", "Стеван Марковски, Снежана Стојчевска", "Часописи и магазини", 1090, 8),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/049793_350_350px.jpg", "Современост бр. 4, 2021 год.", "Стеван Марковски, Снежана Стојчевска", "Часописи и магазини", 990, 7),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/049791_350_350px.jpg", "Современост бр. 1, 2022 год.", "Стеван Марковски, Снежана Стојчевска", "Часописи и магазини", 1090, 6),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/049185_350_350px.jpg", "Современост бр. 4, 2022 год.", "Современост", "Часописи и магазини", 1190, 5),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/046364_350_350px.jpg", "Деветка бр. 4", "Тони Атанасовски, Игор Јовчевски", "Часописи и магазини", 1490, 4),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/046363_350_350px.jpg", "Деветка бр. 3", "Игор Јовчевски, Никола Темков, Димано", "Часописи и магазини", 1390, 3),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/046362_350_350px.jpg", "Деветка бр. 2", "Игор Јовчевски, Никола Темков, Димано", "Часописи и магазини", 1290, 2),
                new Book("https://www.literatura.mk/files/thumbs/files/images/slike_proizvoda/thumbs_350/005774_350_350px.jpg", "Јавач на комета", "Славко Јаневски", "Часописи и магазини", 990, 1)
            };
        }

        //метод кој ја враќа листата на книги за соодветниот жанр
        public List<Book> returnList(string genre)
        {
            switch (genre)
            {
                case "ModernLiterature":
                    return ModernLiterature.ToList();
                case "Classics":
                    return Classics.ToList();
                case "Drama":
                    return Drama.ToList();
                case "CrimeThriller":
                    return CrimeThriller.ToList();
                case "AdventureAction":
                    return AdventureAction.ToList();
                case "Romance":
                    return Romance.ToList();
                case "Horror":
                    return Horror.ToList();
                case "Comedy":
                    return Comedy.ToList();
                case "ScienceFictionFantasy":
                    return ScienceFictionFantasy.ToList();
                case "HistoricFiction":
                    return HistoricFiction.ToList();
                case "MacedonianPoetry":
                    return MacedonianPoetry.ToList();
                case "ForeignPoetry":
                    return ForeignPoetry.ToList();
                case "Travel":
                    return Travel.ToList();
                case "SportFitness":
                    return SportFitness.ToList();
                case "Cookbooks":
                    return Cookbooks.ToList();
                case "Economy":
                    return Economy.ToList();
                case "SocialOther":
                    return SocialOther.ToList();
                case "Medicine":
                    return Medicine.ToList();
                case "ScienceOther":
                    return ScienceOther.ToList();
                case "Music":
                    return Music.ToList();
                case "FilmStagecraft":
                    return FilmStagecraft.ToList();
                case "Architecture":
                    return Architecture.ToList();
                case "EncyclopediaLexicon":
                    return EncyclopediaLexicon.ToList();
                case "JournalMagazine":
                    return JournalMagazine.ToList();
                default:
                    return new List<Book>();
            }
        }
    }
}
