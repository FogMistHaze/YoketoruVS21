using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoketoruVS21
{
    public partial class Form1 : Form
    {
        enum State
        {
            None = -1,  //無効
            Title,      //タイトル
            Game,       //ゲーム
            Gameover,   //ゲームオーバー
            Clear,      //クリア
        }
        State currentState = State.None;
        State nextState = State.Title;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState!=State.None)
            {
                initProc();
            }

        }

        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch (currentState)
            {
                case State.Title:
                    Title.Visible = true;
                    Start.Visible = true;
                    Complete.Visible = true;
                    Hightscor.Visible = true;
                    Gameover.Visible = false;
                    Modoru.Visible = false;
                    Clear.Visible = false;
                    break;

                case State.Game:
                    Title.Visible = false;
                    Start.Visible = false;
                    Complete.Visible = false;
                    Hightscor.Visible = false;
                    break;

                case State.Gameover:
                    Gameover.Visible = true;
                    break;

                case State.Clear:
                    Clear.Visible = false;
                    break;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void Modoru_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
