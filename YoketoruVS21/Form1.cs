using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace YoketoruVS21
{
    public partial class Form1 : Form
    {

        const bool isDebug = true;

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

        //Dll=ダイナミックリンクライブラリ
        //[]はC#のほーぶん
        [DllImport("user32.dll")]   
        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isDebug)
            {
                if(GetAsyncKeyState((int)Keys.O)<0)
                {
                    nextState = State.Gameover;
                }
                else if(GetAsyncKeyState((int)Keys.C)<0)
                {
                    nextState = State.Clear;
                }
            }

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
                    Hightscor.Visible = false;
                    break;

                case State.Gameover:
                    Gameover.Visible = true;
                    Modoru.Visible = true;
                    break;

                case State.Clear:
                    Clear.Visible = true;
                    Modoru.Visible = true;
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


        
        private void Title_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
