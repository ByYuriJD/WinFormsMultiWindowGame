using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace КурсПроект {
    public partial class Main : Form {
        Random rnd = new Random(); //Рандом

        //Хранит уровень прогресса пользователя (сколько зданий построено)
        private int progress = 0;

        private int progressTime = 0;
        private int extraProgressTime = 0;

        //Ресурсы
        public int woodCount = 0;
        public int stoneCount = 0;
        public int oreCount = 0;
        public int ironCount = 0;

        //Имена и цены проектов
        private String[] projectNames = ["Поле", "Кузница", "Топор?", "Кирка?", "Меч?", "Печь"];
        private int[,] projectPrices = { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 1 }, { 0, 0, 0, 1 }, { 0, 0, 0, 1 }, { 8, 8, 3, 0 } };

        //Размер окна в различные периоды игры
        private int[] mainWinWidth = { 155, 260, 370, 460, 580 };

        //Рес-карты в поле, кл-в
        private Form[] resources = new Form[12];
        private int resourceCount = 0;
        private int enemyCount = 0;

        //Инструменты
        private String[] toolNames = ["Топор", "Кирка", "Меч", "Щит"];
        public int[] toolDurability = [0, 0, 0, 0];
        public int[] itemAccessibility = [0, 3, 4, 5, 100];
        private int toolIndex = 0;

        //Поле куда добавляют карты
        private field field;
        private Forge forge;
        private Tools tools;

        //Остовшееся время до конца постройки
        public int ticsUntilBuilt = 0;


        //Сеттеры для рес
        public void setWoodCount(int value) {
            woodCount = value;
            woodStat.Text = value.ToString();
        }
        public void setStoneCount(int value) {
            stoneCount = value;
            stoneStat.Text = value.ToString();
        }
        public void setOreCount(int value) {
            oreCount = value;
            oreStat.Text = value.ToString();
        }
        public void setIronCount(int value) {
            ironCount = value;
            ironStat.Text = value.ToString();
        }
        public void setToolIndex(int value) {
            toolIndex = value;
        }

        //Инструменты
        public void toolBuilt(int toolId) {
            toolDurability[toolId] = 10;



            if (progress == 2)
                progressGame();
            else if (progress == 3 && toolId == 1) {
                progressGame();
            } else if (progress == 4 && toolId == 2) {
                progressGame();
            }
            tools.updateMenu();
        }
        public bool toolFunctional() {
            return toolDurability[toolIndex] != 0 && tools.toolCooldowns[toolIndex] <= 10;

        }
        public void toolUsed() {
            if (toolDurability[toolIndex] <= 0)
                return;
            toolDurability[toolIndex] -= 1;
            tools.useTool();
        }

        public void updateMenus() {
            if (progress < 2) { 
                return; 
            }else if (progress < 3) {
                forge.updateMenu();
                return;
            } else {
                forge.updateMenu();
                tools.updateMenu();
                return;
            }

        }

        //Различные геттеры
        public int getProgress() {
            return progress;
        }
        public String getToolName(int index) {
            return toolNames[index];
        }
        public int getToolIndex() {
            return toolIndex;
        }

        //Начало программы
        public Main() {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e) {

            //Обнулирование игры
            setWoodCount(0);
            setStoneCount(0);
            setOreCount(0);
            setIronCount(0);
            Width = mainWinWidth[0];

            //Первый проект
            projectName.Text = projectNames[progress];

            woodPrice.Text = projectPrices[progress, 0].ToString();
            stonePrice.Text = projectPrices[progress, 1].ToString();
            orePrice.Text = projectPrices[progress, 2].ToString();
            ironPrice.Text = projectPrices[progress, 3].ToString();

            //Делает все рес - null
            for (int i = 0; i < 12; i++) {
                resources[i] = null;
            }
        }

        //Добавления рес
        public void spawnResource(String chosenResource="") {
            if (resourceCount > 11) return; //Выходит если заполнено

            resourceCount++;

            ResourceCard newCard = new ResourceCard(); //Рес-карта
            newCard.setMain(this);

            field.AddOwnedForm(newCard);

            Point fieldPos = field.Location;


            if (chosenResource != "") {

                if (chosenResource == "Enemy") {
                    newCard.Close();
                    spawnEnemyInstead();
                    return;
                }

                newCard.setType(chosenResource);
                for (int j = 0; j < 12; j++) {
                    if (resources[j] == null) {
                        resources[j] = newCard;
                        if (j < 6) {
                            newCard.setOrigin(new Point(j * 200 + fieldPos.X + 30, fieldPos.Y + 20));
                        } else {
                            newCard.setOrigin(new Point((j - 6) * 200 + fieldPos.X + 30, fieldPos.Y + 300));
                        }
                        break;
                    }
                }

                newCard.Show();
                return;
            }

            //Выбирает тип рес, взависимости от прогресса
            if (progress < 2) { // Поле
                newCard.setType("Wood");
            } else if (progress<4) { //Кузница
                if (rnd.NextDouble() < (double)(stoneCount + 1) / (stoneCount + woodCount + 1)) {
                    newCard.setType("Wood");
                } else {
                    newCard.setType("Stone");
                }
            } else if (progress < 6) {
                if (rnd.NextDouble() < (double)(oreCount + 1) / (oreCount + stoneCount + woodCount + 1) / 6.0) {
                    newCard.setType("Ore");
                } else if (rnd.NextDouble() < (double)(stoneCount + 1) / (stoneCount + woodCount + 1)) {
                    newCard.setType("Wood");
                } else {
                    newCard.setType("Stone");
                }
            } else {
                if (rnd.NextDouble() < .2 && enemyCount == 0) {
                    newCard.Close();
                    spawnEnemyInstead();
                    return;
                }
                else if (rnd.NextDouble() < (double)(oreCount + 1) / (oreCount + stoneCount + woodCount + 1) / 6.0) {
                    newCard.setType("Ore");
                } else if (rnd.NextDouble() < (double)(stoneCount + 1) / (stoneCount + woodCount + 1)) {
                    newCard.setType("Wood");
                } else {
                    newCard.setType("Stone");
                }

            }

            //Меняет позицию карты
            for (int j = 0; j < 12; j++) {
                if (resources[j] == null) {
                    resources[j] = newCard;
                    if (j < 6) {
                        newCard.setOrigin(new Point(j * 200 + fieldPos.X + 30, fieldPos.Y + 20));
                    } else {
                        newCard.setOrigin(new Point((j - 6) * 200 + fieldPos.X + 30, fieldPos.Y + 300));
                    }
                    break;
                }
            }

            newCard.Show();

        }
        public void spawnEnemyInstead() {
            enemyCount++;
            EnemyCard newCard = new EnemyCard(); //Рес-карта
            newCard.setMain(this);

            field.AddOwnedForm(newCard);

            Point fieldPos = field.Location;

            //Меняет позицию карты
            for (int j = 0; j < 12; j++) {
                if (resources[j] == null) {
                    resources[j] = newCard;
                    if (j < 6) {
                        newCard.setOrigin(new Point(j * 200 + fieldPos.X + 30, fieldPos.Y + 20));
                    } else {
                        newCard.setOrigin(new Point((j - 6) * 200 + fieldPos.X + 30, fieldPos.Y + 300));
                    }
                    break;
                }
            }
            newCard.Show();
        }

        //Рес получен
        public void resourceMined(String type, Form card) {
            //Убирает рес и массива
            for (int i = 0; i < 12; i++) {
                if (resources[i] == card) {
                    resources[i] = null;
                }
            }

            resourceCount--;
            //добавляет рес к счёту
            switch (type) {
                case "Wood": {
                        setWoodCount(woodCount + 1);
                        break;
                    }
                case "Ore": {
                        setOreCount(oreCount + 1);
                        break;
                    }
                case "Stone": {
                        setStoneCount(stoneCount + 1);
                        break;
                    }
            }
        }
        
        public void enemyKilled(Form card) {
            //Убирает рес и массива
            for (int i = 0; i < 12; i++) {
                if (resources[i] == card) {
                    resources[i] = null;
                }
            }

            setWoodCount(woodCount + (int)rnd.NextInt64(0, 3));
            setStoneCount(stoneCount + (int)rnd.NextInt64(0, 3));

            resourceCount--;

        }

        //Проверка на имение рес
        public bool hasResource(int wood, int stone, int ore, int iron) {
            return woodCount >= wood && stoneCount >= stone && oreCount >= ore && ironCount >= iron;
        }

        //Таймер рес
        private void resourceSpawner_Tick(object sender, EventArgs e) {
            spawnResource();
        }

        //Нажатие на кнопку проектов
        private void projectButton_Click(object sender, EventArgs e) {
            if (projectNames.Length <= progress) //проекты кончились
                return;
            //Проверка на доступность
            if (ticsUntilBuilt == 0 && hasResource(projectPrices[progress, 0], projectPrices[progress, 1], projectPrices[progress, 2], projectPrices[progress, 3])) {
                buildTimer.Start();
                ticsUntilBuilt = progressTime + progress * extraProgressTime;

                //Покупка
                setWoodCount(woodCount - projectPrices[progress, 0]);
                setStoneCount(stoneCount - projectPrices[progress, 1]);
                setOreCount(oreCount - projectPrices[progress, 2]);
                setIronCount(ironCount - projectPrices[progress, 3]);
            }
        }

        //Таймер для стройки
        private void buildTimer_Tick(object sender, EventArgs e) {
            if (ticsUntilBuilt == 0) { //Конец стройки
                buildTimer.Stop();
                buildBar.Value = 0;
                ticsUntilBuilt = 0;

                progressGame();
                return;
            }
            //Прогрес
            buildBar.Value = Math.Min(100, (int)Single.Lerp(0, 100, (float)(Math.Pow(600 + 200 * progress, 1.5) - Math.Pow(ticsUntilBuilt, 1.5)) / (float)Math.Pow(600 + 200 * progress, 1.5)));
            buildBar.Value = Math.Max(0, buildBar.Value - 1);
            buildBar.Value = Math.Min(105, buildBar.Value + 1);

            ticsUntilBuilt--;
        }


        //Враг
        public void attacked() {
            if (toolIndex == 3 && toolFunctional()) {
                toolUsed();
                return;
            }
            for (int i = 0; i < resources.Count(); i++) {
                if (resources[i]!=null && !resources[i].Equals("Enemy")) {
                    ResourceCard res = (ResourceCard)resources[i];
                    res.cardDelayStart = res.time;
                }
            }
        }



        //Продолжение игры
        private void progressGame() {
            switch (progress) { //Выполняет действия взависимости от уровня

                case 0: //Поле
                    //Добавляет поле
                    field = new field();
                    field.setMain(this);

                    field.Show();
                    field.Location = new Point(600, 100);

                    //Начало Рес
                    resourceSpawner.Start();
                    resourceSpawner.Interval = 12000;
                    spawnResource();
                    
                    //Размер главы дерево
                    MaximumSize = new Size(mainWinWidth[1], Height);
                    Width = mainWinWidth[1];
                    MinimumSize = new Size(Width, Height);
                    break;
                case 1: //Кузница
                    //Добавляет кузнецу
                    forge = new Forge();
                    forge.setMain(this);

                    forge.Show();
                    forge.Location = new Point(270, 100);

                    //Уменьшает период
                    resourceSpawner.Interval = 10000;

                    //Размер главы камень
                    MaximumSize = new Size(mainWinWidth[2], Height);
                    Width = mainWinWidth[2];
                    MinimumSize = new Size(Width, Height);

                    spawnResource("Stone");

                    projectButton.Enabled = false;
                    break;
                case 2: 
                    tools = new Tools();
                    tools.setMain(this);
                    tools.Show();
                    tools.Location = new Point(270, 230);

                    break;
                case 3:

                    //Размер главы руда
                    MaximumSize = new Size(mainWinWidth[3], Height);
                    Width = mainWinWidth[3];
                    MinimumSize = new Size(Width, Height);

                    spawnResource("Ore");

                    //Уменьшает период
                    resourceSpawner.Interval = 5500;
                    break;
                case 4:
                    projectButton.Enabled = true;

                    spawnResource("Enemy");
                    //Уменьшает период
                    resourceSpawner.Interval = 5200;

                    break;


            }

            progress++;

            updateMenus();

            //Имя следующего проекта
            if (projectNames.Length > progress) {

                projectName.Text = projectNames[progress];

                woodPrice.Text = projectPrices[progress, 0].ToString();
                stonePrice.Text = projectPrices[progress, 1].ToString();
                orePrice.Text = projectPrices[progress, 2].ToString();
                ironPrice.Text = projectPrices[progress, 3].ToString();

            }

        }

        //Движение поля
        public void fieldMoved() {
            Point fieldPos = field.Location;

            for (int i = 0; i < resources.Length; i++) {
                if (resources[i] != null) {
                    if (resources[i] is ResourceCard) {
                        ResourceCard r = (ResourceCard)resources[i];
                        if (i < 6) {
                            r.setOrigin(new Point(i * 200 + fieldPos.X + 30, fieldPos.Y + 20));
                        } else {
                            r.setOrigin(new Point((i - 6) * 200 + fieldPos.X + 30, fieldPos.Y + 300));
                        }
                    } else if (resources[i] is EnemyCard) {
                        EnemyCard r = (EnemyCard)resources[i];
                        if (i < 6) {
                            r.setOrigin(new Point(i * 200 + fieldPos.X + 30, fieldPos.Y + 20));
                        } else {
                            r.setOrigin(new Point((i - 6) * 200 + fieldPos.X + 30, fieldPos.Y + 300));
                        }

                    }
                    //Дописать информацию про врагов, шахта, лес
                }
            }
        }
    }
}
