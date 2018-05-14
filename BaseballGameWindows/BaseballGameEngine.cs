using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGameWindows
{
    class BaseballGameEngine
    {
        int[] quiz = new int[3];
        int strike = 0;
        int ball = 0;

        internal void Init()//quiz 내기
        {
            //1~9 중복없는 배열
            //랜덤하게 두자리 뽑고 교체
            //앞 3자리 quiz배열에 넣기, 중복없어야 하기때문에
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random rand = new Random();


            for (int n = 0; n < 100; n++)
            {
                int i = rand.Next(0, temp.Length);
                int j = rand.Next(0, temp.Length);

                int t = temp[i];
                temp[i] = temp[j];
                temp[j] = t;
            }

            for (int i = 0; i < quiz.Length; i++) // quiz의 길이 = 3
            {
                quiz[i] = temp[i];
            }

            return;
        }

        internal void Play(string input)
        {
            //quiz랑 input이랑 비교해서 strike, ball 판정
            //input을 int[]로 바꾸자
            //quiz를 for문으로 돌고
            //input을 for문으로 돌고
            //하나씩 꺼내어 숫자가 같으면
            //자릿수가 같으면 strike++
            //자릿수가 다르면 ball++

            strike = 0;
            ball = 0;

            int[] inputArray = new int[input.Length]; // input 문자열의 길이만큼 배열 선언. 숫자형태의 문자열 input을 숫자형으로 각 자리씩 비교하기 위함

            for (int i = 0; i < input.Length; i++)
            {
                inputArray[i] = input[i] - '0'; // input[0]이 '1'이라고 치면 아스키코드로는 49. '0'은 48이다. 49-48=1 or atoi() 사용, 문자를 숫자로 형변환
            }

            for (int i = 0; i < quiz.Length; i++) // quiz 배열은 int형 배열이다.
            {
                for (int j = 0; j < inputArray.Length; j++) // inputArray 배열 또한 int형 배열. , 각 자리 하나하나마다 비교하기 위해 이중 for문 사용
                {
                    if (quiz[i] == inputArray[j]) // 꺼낸 숫자가 같고
                    {
                        if (i == j) // 자릿수도 같으면
                        {
                            strike++;
                        }
                        else // 자릿수가 다르면
                        {
                            ball++;
                        }
                    }
                }
            }

            return;
        }

        internal int GetQuizLength()
        {
            return quiz.Length;
        }

        internal int GetStrike()
        {
            return strike;
        }

        internal int GetBall()
        {
            return ball;
        }

        internal string GetQuiz()
        {
            return String.Format("{0} {1} {2}", quiz[0], quiz[1], quiz[2]);
        }
    }
}
