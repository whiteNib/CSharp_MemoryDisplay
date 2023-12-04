using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryDisplay
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            // Resize 이벤트 핸들러를 연결 
            this.Resize += Form1_Resize;

            // 초기 폼 크기를 설정 
            this.Size = new Size(350, 500);

            // 초기 너비를 기반으로 패널 가시성을 설정 
            UpdatePanelVisibility();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            // 폼 크기가 변경될 때마다 가시성을 업데이트 
            UpdatePanelVisibility();
        }

        private void UpdatePanelVisibility()
        {
            // 폼의 너비를 확인 
            if (this.Width > 600)
            {
                // 너비가 600보다 크면 splitContainer.Panel2를 보이게 설정하고
                // splitContainer.Panel2의 너비를 300으로 고정하며, splitContainer.Panel1의 크기를 동적으로 조절 
                splitContainer1.Panel2Collapsed = false;
                splitContainer1.SplitterDistance = this.Width - 300; // splitContainer.Panel1의 크기를 동적으로 조절
            }
            else
            {
                // 너비가 600 이하이면 splitContainer.Panel2를 감추게 설정하고
                // splitContainer.Panel1의 크기를 동적으로 조절 
                splitContainer1.Panel2Collapsed = true;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(350, 550);
        }
    }
}
