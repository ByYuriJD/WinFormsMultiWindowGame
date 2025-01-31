using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
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
		public int currentCardDelay;

		private int health = 4; //Здоровье
		private bool toolUsed = false; //Использован ли инструмент (дает дополнительные ресурсы)

		//Тряска
		Random rnd = new Random();
		int shakeAmount;

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
						button1.BackColor = Color.White; //Цвет фона
						cardDelay = 380; //Восстановление
						button1.Text = ore; //Текст на кнопке
						pickNeeded.Visible = true; //Изображение - нужна кирка
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

		//Процесс
		private void timer1_Tick(object sender, EventArgs e) {
			time++;

			//Восстановление
			progressBar1.Value = Math.Max(0, Math.Min(100, (int)Single.Lerp(0, 100, 1 - (float)currentCardDelay / cardDelay)));
			progressBar1.Value = Math.Max(0, progressBar1.Value - 1);
			progressBar1.Value = Math.Min(100, progressBar1.Value + 1);


			//Анимация
			ghostOffset = (int)(Math.Cos(time / 15.0) * 5);
			Point ghostOrigin = new Point(origin.X,
				origin.Y + ghostOffset);
			//Тряска
			if (shakeAmount != 0) {
				int shakeAmplitude = shakeAmount / 4;
				Location = new Point(ghostOrigin.X + rnd.Next(-shakeAmplitude, shakeAmplitude), ghostOrigin.Y + 
					rnd.Next(-shakeAmplitude, shakeAmplitude));
				shakeAmount--;
				return;
			}
			Location = ghostOrigin;
		}

		//Кнопка
		private void button1_Click(object sender, EventArgs e) {
			if (currentCardDelay > 5) //Идёт восстановление
				return;

			int efficiency = get_efficiency(); //Эффективность текущего инструмента
			if (efficiency == 0)
				return;
			health -= efficiency;

			if (efficiency > 1) toolUsed = true;

			if (health <= 0) { //Ресурс добыт
				main.resourceMined(cardType, this, toolUsed);
				Close();
				return;
			}


			//Восстановлене
			cooldownTimer.Enabled = true;

			if (currentCardDelay == 0)
				currentCardDelay = cardDelay;
			else currentCardDelay = cardDelay - 20;

			//Визуальные эффекты
			setBackground();
			shakeAmount = rnd.Next(8, 12);
		}

		//Фон
		private void setBackground() {
			switch (health) {
				case 3:
					button1.BackgroundImage = Image.FromFile("../../..//break1.png");
					break;
				case 2:
					button1.BackgroundImage = Image.FromFile("../../..//break2.png");
					break;
				case 1:
					button1.BackgroundImage = Image.FromFile("../../..//break3.png");
					break;

			}
		}

		//Эффективность текущего инструмента
		private int get_efficiency() {
			if (!main.toolFunctional()) //Нет инструмента
				return Convert.ToInt32(cardType != "Ore");

			switch (main.getToolIndex()) {
				case 0: { //Топор
						if (cardType == "Wood") { //Дерево
							main.toolUsed();
							return 4;
						}
						if (cardType == "Ore") //Руда
							return 0;
						return 1;
					}
				case 1: { //Кирка
						if (cardType == "Stone") { //Камень
							main.toolUsed();
							return 3;
						}
						if (cardType == "Ore") { //Руда
							main.toolUsed();
							return 4;
						}
						return 1;
					}
				default: { //Другое
						if (cardType == "Ore") //Руда
							return 0;
						return 1;
					}
			}
		}
		//Почему бы и нет / ускоряет прогресс при нажатии на полосу прогресса
		private void progressBar1_Click(object sender, EventArgs e) {
			if (currentCardDelay > 3) {
				currentCardDelay -= 3;
			}
		}
		public override bool Equals(object? obj) {
			if (!(obj is String))
				return false;
			return (String)obj == cardType;
		}
		//Восстановление
		private void cooldownTimer_Tick(object sender, EventArgs e) {
			currentCardDelay--;
			if (currentCardDelay <= 0) {
				currentCardDelay = 0;
			}
		}


		//Текст для фона
		//Руда
		private String ore = "\r\n\r\n                                                        \r\n                                                        \r\n                       xx                               \r\n                     xx  $;                             \r\n                    xx    xx                            \r\n                   xx  Xx  x+                           \r\n                  xx   $;    ;+                         \r\n                 $X    &        ;+                      \r\n                &$     xx:         .;                   \r\n               $$    x      +;:       ;                 \r\n              XX   +x x         :;.    X                \r\n             xx   x   x              ; &&X              \r\n          xx $   $    x+                &  :;:          \r\n        $&X $&  X      x               x&       ;;;     \r\n    xx++x    $ &       ++              xx           ;   \r\n    $x       xxXx       ;             +x            xx  \r\n   x$                      ;          x              x  \r\n   X                xx;X+     :;;+   Xx              x  \r\n   x                  $&$          &&                xx \r\n   +                  $&$x:;;;;;;xx xX             ;+;  \r\n       ::   :;;;;;;;;;xX               +;;;;;;;;;;;     \r\n                                                        \r\n\r\n";
		//Камень
		private String rock = "\r\n\r\n                         --=-:                          \r\n                      --       :-                       \r\n                   :=-           --                     \r\n                  =+     . -       -=                   \r\n                ==     - + +=   :    --                 \r\n              -=+      +#* +     -.    ==               \r\n            :-     .: -= ++  -=          +-- :-         \r\n     ==         -:            +=-    .          ++      \r\n    + #       ==        -              .     -  *#+=    \r\n  == =+=-   ===   -    ==               ==--+-  :  ==   \r\n+##      - :    . :    =              :.             =  \r\n=+**=                  +  -=  =-  .      = ++ ++   -  -:\r\n   ++ : ++  +=  =      -==  ##  *  #+ += -+=++++=-=     \r\n      =+++==+: -==+++-     -++=====++++=                \r\n\r\n";
		//Дерево
		private String tree = "\r\n\r\n                ’’„)’ ìhƒìƒhó’                          \r\n             )2  ’                    ’„„ì)’„           \r\n            )„    ’„„))’’            ’’)      ))’       \r\n          ’)’     ’                     ’„ì„’    )ó     \r\n          „      ’  ’                       ì      ’’   \r\n       )’           ’„ ’„’       ’) )„             ’ )  \r\n      „)„’’’ ì’                          ’„’        )„  \r\n   ì)         ’                             ’ ’’     ’)’\r\n   ’Ö’’ì )’’’  ’           )„„’’’’                    ’’\r\n      ƒÖÖ¶ÖÖh)ì’„ ’                      ’’  ’  ’’ ’’)O \r\n                ’ƒ„  ) ’’ ’ ’ƒ      ’„      )„  )  ì    \r\n                    )’ ’ó’’   „„’„    ’ó’               \r\n                   ƒ„ƒ „   ))))    )                    \r\n                    óƒ ’)     „))’                      \r\n                   ƒO’   ’   ’ ƒ  ì                     \r\n                ’ ƒ          „ ì )                      \r\n               ì)     „„       ì„                       \r\n             )         )’       ’’  ’                   \r\n            ì ’                   „’ ’                  \r\n         )ƒ’ ’          ’’„  ’     ’„ ’„)ƒ„             \r\n    ’)ì) ’’                 ’)„’’)  ’’   ’’ƒ            \r\n                 ’’’’’’             ’’)) ’’             \r\n";

	}
}