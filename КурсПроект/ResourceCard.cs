using System.ComponentModel;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace КурсПроект {
    public partial class ResourceCard : Form {
        public int time = 0; //Время с начала
        private int ghostOffset = 0; //Шатание карты
        private Point origin = Point.Empty; //Положение карты
        private Main main; //Глава

        private String cardType; //Тип карты

        //Время восстановления
        public int cardDelay;
        public int cardDelayStart;

        private int health = 4; //Здоровье

        //Сеттеры
        public void setOrigin(Point point) {
            origin = point;
        }
        public void setMain(Main main) {
            this.main = main;
        }
        public void setType(String type) {
            this.cardType = type;
        }
        public String getType() {
            return this.cardType;
        }
        public void setDelay(int delay) {
            this.cardDelay = delay;
        }

        //Начало
        public ResourceCard() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Location = origin;

            switch (cardType) { //Инфа о карте взависимости от типа
                case "Ore": {
                        button1.BackColor = Color.White;
                        cardDelay = 380;
                        button1.Text = ore;
                        break;
                    }
                case "Wood": {
                        button1.BackColor = Color.Tan;
                        cardDelay = 180;
                        button1.Text = tree;
                        break;
                    }
                case "Stone": {
                        button1.BackColor = Color.Gray;
                        cardDelay = 260;
                        button1.Text = rock;
                        break;
                    }
            }
        }

        //Время
        private void timer1_Tick(object sender, EventArgs e) {
            time++;

            //Восстановление
            progressBar1.Value = Math.Max(0,Math.Min(100, (int)Single.Lerp(0, 100, (float)(time - cardDelayStart) / cardDelay)));
            progressBar1.Value = Math.Max(0, progressBar1.Value - 1);
            progressBar1.Value = Math.Min(100, progressBar1.Value + 1);


            //Анимация
            ghostOffset = (int)(Math.Cos(time / 30.0) * 5);
            this.Location = new Point(origin.X,
                origin.Y + ghostOffset);
        }

        //Кнопка
        private void button1_Click(object sender, EventArgs e) {
            if (time - cardDelayStart < cardDelay - 5) //Идёт восстановление
                return;

            int efficiency = get_efficiency();
            if (efficiency == 0)
                return;
            health -= efficiency;

            if (health <= 0) { //Смерть
                main.resourceMined(cardType, this);
                Close();
                return;
            }
            cardDelayStart = time;
        }

        private int get_efficiency() {
            if (!main.toolFunctional())
                return Convert.ToInt32(cardType != "Ore");

            switch (main.getToolIndex()) {
                case 0: {
                        if (cardType == "Wood") {
                            main.toolUsed();
                            return 3;
                        }
                        if (cardType == "Ore")
                            return 0;
                        return 1;
                    }
                case 1: {
                        if (cardType == "Stone") {
                            main.toolUsed();
                            return 3;
                        }
                        if (cardType == "Ore") {
                            main.toolUsed();
                            return 2;
                        }
                        return 1;
                    }
                default: {
                        if (cardType == "Ore")
                            return 0;
                        return 1;
                    }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e) {

        }
        public override bool Equals(object? obj) {
            if (!(obj is String))
                return false;
            return (String) obj == cardType;
        }




        private String ore = "\r\n\r\n                                                        \r\n                                                        \r\n                       xx                               \r\n                     xx  $;                             \r\n                    xx    xx                            \r\n                   xx  Xx  x+                           \r\n                  xx   $;    ;+                         \r\n                 $X    &        ;+                      \r\n                &$     xx:         .;                   \r\n               $$    x      +;:       ;                 \r\n              XX   +x x         :;.    X                \r\n             xx   x   x              ; &&X              \r\n          xx $   $    x+                &  :;:          \r\n        $&X $&  X      x               x&       ;;;     \r\n    xx++x    $ &       ++              xx           ;   \r\n    $x       xxXx       ;             +x            xx  \r\n   x$                      ;          x              x  \r\n   X                xx;X+     :;;+   Xx              x  \r\n   x                  $&$          &&                xx \r\n   +                  $&$x:;;;;;;xx xX             ;+;  \r\n       ::   :;;;;;;;;;xX               +;;;;;;;;;;;     \r\n                                                        \r\n\r\n";
        private String rock = "\r\n\r\n                         --=-:                          \r\n                      --       :-                       \r\n                   :=-           --                     \r\n                  =+     . -       -=                   \r\n                ==     - + +=   :    --                 \r\n              -=+      +#* +     -.    ==               \r\n            :-     .: -= ++  -=          +-- :-         \r\n     ==         -:            +=-    .          ++      \r\n    + #       ==        -              .     -  *#+=    \r\n  == =+=-   ===   -    ==               ==--+-  :  ==   \r\n+##      - :    . :    =              :.             =  \r\n=+**=                  +  -=  =-  .      = ++ ++   -  -:\r\n   ++ : ++  +=  =      -==  ##  *  #+ += -+=++++=-=     \r\n      =+++==+: -==+++-     -++=====++++=                \r\n\r\n";
        private String tree = "\r\n\r\n                ’’„)’ ìhƒìƒhó’                          \r\n             )2  ’                    ’„„ì)’„           \r\n            )„    ’„„))’’            ’’)      ))’       \r\n          ’)’     ’                     ’„ì„’    )ó     \r\n          „      ’  ’                       ì      ’’   \r\n       )’           ’„ ’„’       ’) )„             ’ )  \r\n      „)„’’’ ì’                          ’„’        )„  \r\n   ì)         ’                             ’ ’’     ’)’\r\n   ’Ö’’ì )’’’  ’           )„„’’’’                    ’’\r\n      ƒÖÖ¶ÖÖh)ì’„ ’                      ’’  ’  ’’ ’’)O \r\n                ’ƒ„  ) ’’ ’ ’ƒ      ’„      )„  )  ì    \r\n                    )’ ’ó’’   „„’„    ’ó’               \r\n                   ƒ„ƒ „   ))))    )                    \r\n                    óƒ ’)     „))’                      \r\n                   ƒO’   ’   ’ ƒ  ì                     \r\n                ’ ƒ          „ ì )                      \r\n               ì)     „„       ì„                       \r\n             )         )’       ’’  ’                   \r\n            ì ’                   „’ ’                  \r\n         )ƒ’ ’          ’’„  ’     ’„ ’„)ƒ„             \r\n    ’)ì) ’’                 ’)„’’)  ’’   ’’ƒ            \r\n                 ’’’’’’             ’’)) ’’             \r\n";
    }
}