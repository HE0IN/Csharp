using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSingIn {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void SigninButton_Click(object sender, EventArgs e) {
            // 텍스트박스에 입력된 값을 가져오기
            string userId = id.Text;
            string userPw = password.Text;

            // hong/1234 이면 로그인 성공
            if (userId.Equals("hong") && userPw.Equals("1234")) {
                // 로그인 성공
                MessageBox.Show("로그인 성공함!!", "로그인");
            } else {
                // 로그인 실패
                MessageBox.Show("로그인 실패...", "로그인");
            }
            // 아니면 로그인 실패
        }
    }
}
