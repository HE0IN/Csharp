using System;

using System.Windows.Forms;

namespace WinFormApp {
    // Form클래스 상속받아서 내 코드를 추가한다.
    public partial class Form1 : Form {
        // 생성자 함수
        public Form1() {

            //윈폼을 초기화한다.
            InitializeComponent();
        }
        // Load 이벤트 핸들러를 추가합니다.
        private void Form1_Load(object sender, EventArgs e) {
            // 폼이 로드될 때 수행할 작업을 여기에 작성합니다.
            Console.WriteLine("폼이 로드되었습니다.");
        }

        // 버튼 클릭 이벤트 - 콜백함수(대응함수)
        private void onClickButton(object sender, EventArgs e) {
            //Console.WriteLine("버튼 클릭됨");
            label1.Text = "버튼 클릭됨";
        }
    }
}
