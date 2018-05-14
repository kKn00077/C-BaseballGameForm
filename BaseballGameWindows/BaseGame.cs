using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballGameWindows
{
    public partial class BaseGame : Form

    {

        private BaseballGameEngine bge;

        public BaseGame()//생성자
        {
            InitializeComponent(); // 컴포넌트가 나타나고 난 뒤
            //BaseballGameEngine을 생성하고, quiz 내기
            bge = new BaseballGameEngine();
            bge.Init();
            //MessageBox.Show(bge.GetQuiz());
        }

        private void bInput_Click(object sender, EventArgs e) // play 버튼을 클릭했을 때
        {

            int cnt = int.Parse(numberLimit.Text)-1; // 버튼을 누를 때 횟수제한에 있는 string을 불러와 형변환해 -1씩 카운트다운.
            numberLimit.Text = cnt + ""; // 카운트다운한 값을 다시 넣어줌

            //tNumber1, 2, 3에 있는 값을 가져와서
            //string으로 연결하고

            try
            {
                int a=int.Parse(tNumber1.Text); 
                // Parse 함수는 문자열을 숫자로 바꿔줌. 단 해당 문자열이 숫자 형식이어야함. 그외 문자열일 경우 알파벳 혹은 다른 문자일 가능성이 높으니 예외발생
            }
            catch
            {
                MessageBox.Show("첫번째 숫자 이상");
                tNumber1.Text = "";
                return;
            }

            try
            {
                int a = int.Parse(tNumber2.Text);
            }
            catch
            {
                MessageBox.Show("두번째 숫자 이상");
                tNumber2.Text = "";
                return;
            }

            try
            {
                int a = int.Parse(tNumber3.Text);
            }
            catch
            {
                MessageBox.Show("세번째 숫자 이상");
                tNumber3.Text = "";
                return;
            }

            if (cnt <= 0) //제한 횟수를 초과했을 때
            {
                MessageBox.Show("횟수 초과!");
                Clear(); // 정답 입력 텍스트 박스들과 라벨을 초기 상태로 되돌림
                numberList.Items.Clear(); // history가 적힌 리스트도 초기 상태로 되돌림
                bge.Init(); // 새 퀴즈 발생
                numberLimit.Text = "10";
                return;
            }

            string input = tNumber1.Text + tNumber2.Text + tNumber3.Text;// 정답칸들에 입력했던 정답들을 합쳐서 3자리의 숫자형태의 문자열로 만듬
            numberList.Items.Insert(0,input);//목록 0번째 인덱스에 삽입. 누적된다.

            //BaseballGameEngine에 준다
            //게임엔진이 strike, ball 판정한다.
            bge.Play(input);

            //statusLabel에 strike, ball 출력한다.
            statusLabel.Text = String.Format("Strike : {0}, Ball : {1}",bge.GetStrike(),bge.GetBall()); // Play 함수에서 ball, strike 여부를 판단한 ball, strike 변수의 getter 메서드를 이용해 값을 얻어옴

            //strike와 quiz길이가 같으면 축하 메시지 박스
            if (bge.GetStrike() == bge.GetQuizLength())
            {
                MessageBox.Show("축하드립니다. 정답입니다!");
                //Close();
                Clear();
                numberList.Items.Clear();
                bge.Init(); // 컴포넌트 모두 초기 상태로 되돌리고 새 퀴즈
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            tNumber1.Text = "";
            tNumber2.Text = "";
            tNumber3.Text = "";

            statusLabel.Text = "Play Ball!!";
        }
    }
}
