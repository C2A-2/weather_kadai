using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_2
{
    public partial class Form1 : Form
    {
        float lat;
        float lon;
        String URL;

        public Form1()
        {
            InitializeComponent();
        }

        //実行ボタン押下
        private void startButton_Click(object sender, EventArgs e)
        {
            generation();
        }

        //URL生成
        public void generation()
        {
            
        }
    }
}
