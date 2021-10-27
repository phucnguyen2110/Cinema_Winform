using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    class Ghe
    {
        int col;
        int row;
        bool isChoose = false; // ghế này đã được chọn chưa
        Button main = null;
        public Ghe(Button ghe, int col, int row)
        {
            main = ghe;
            this.col = col;
            this.row = row;
        }
        public int Col { get => col; set => col = value; }
        public int Row { get => row; set => row = value; }
        public Button Main { get => main; set => main = value; }
        public bool IsChoose { get => isChoose; set => isChoose = value; }
    }
}
