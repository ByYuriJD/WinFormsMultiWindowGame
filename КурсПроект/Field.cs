using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КурсПроект {
    public partial class field : Form {
        //Переменные для переноса карты
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private Main main;
        public void setMain(Main main) {
            this.main = main;
        }

        //Код для переноса карты
        protected override void WndProc(ref Message m) {
            switch (m.Msg) {
                case WM_NCHITTEST:
                    base.WndProc(ref m);

                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    return;
            }

            base.WndProc(ref m);
        }

        public field() {
            InitializeComponent();
        }

        private void field_Load(object sender, EventArgs e) {

        }

        private void field_LocationChanged(object sender, EventArgs e) {
            main.fieldMoved();
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle;
                return myCp;
            }
        }
    }
}
