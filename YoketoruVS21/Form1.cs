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

        const int Player = 1;
        const int Enemy = 3;
        const int Item = 3;
        const int Max = Player + Enemy + Item;

        Label[] chrs = new Label[Max];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerIndex + Player;
        const int ItemIndex = EnemyIndex + Enemy;

        const string PlayerText = "('v')";
        const string EnemyText = "🦈";
        const string ItemText = "🍄";

        static Random rand = new Random();

        //ステート設定
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

        const int SpeedMax = 20;
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];

        [DllImport("user32.dll")]   
        public static extern short GetAsyncKeyState(int vKey);

        //フォーム
        public Form1()
        {
            InitializeComponent();

            for (int I = 0; I < Max; I++)
            {
                chrs[I] = new Label();
                chrs[I].AutoSize = true;

                if (I == PlayerIndex)
                    chrs[I].Text = PlayerText;
                else if (I < ItemIndex)
                    chrs[I].Text = EnemyText;
                else
                    chrs[I].Text = ItemText;
                chrs[I].Font = Temp.Font;
                Controls.Add(chrs[I]);
            }
        }

        //タイマー
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
                initProc();

            if (currentState == State.Game)
                UpdateGame();   
        }

        //ゲームが始まったら
        void UpdateGame()
        {
            Point mp = PointToClient(MousePosition);

            //mpがプレイヤーの中心になるように設定
            chrs[PlayerIndex].Left = mp.X - chrs[PlayerIndex].Width / 2;
            chrs[PlayerIndex].Left = mp.Y - chrs[PlayerIndex].Height / 2;

            for(int i=EnemyIndex;i<ChrMax;i++)
            {
                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];
                
                if(chrs[i].Left<0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (chrs[i].Right < ClientSize.Width)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Bottom < ClientSize.Height)
                {
                    vy[i] = Math.Abs(vy[i]);
                }

                //当たり判定
                if(    (mp.X>=chrs[i].Left)
                    && (mp.X<chrs[i].Right)
                    && (mp.Y>=chrs[i].Top)
                    && (mp.Y<chrs[i].Bottom)
                   )
                {
                    //MessageBox.Show("あたった！");
                    //敵か？
                    if(i<ItemIndex)
                    {
                        nextState = State.Gameover;
                    }
                    else
                    {
                        //アイテム
                        chrs[i].Visible = false;
                    }
                }
        }

        //ゲーム中
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

                    for (int i = EnemyIndex; i < ChrMax; i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                    }
                    
                    break;

                case State.Gameover:
                    Gameover.Visible = true;
                    Modoru.Visible = true;
                    break;

                case State.Clear:
                    Clear.Visible = true;
                    Modoru.Visible = true;
                    Hightscor.Visible = true;
                    break;
            }
        }

        //スタートボタン
        private void Start_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        //戻るボタン
        private void Modoru_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }


        
        private void Title_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
