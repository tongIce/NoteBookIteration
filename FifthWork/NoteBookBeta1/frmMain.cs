using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using BLL;
using System.Threading;

namespace NoteBookUI
{
    public partial class frmMain : BaseForm
    {
        DataTable tableX = new DataTable();
        int Noteid = 0;
        private string curTime;
        private SynchronizationContext m_SyncContext = null;
        private Thread timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public String UserEmail="";                                            //定义变量接受传参  用户名
        public String UserPassWord;                                         //定义变量接受传参  密码

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        /*
         * hWnd：指定产生动画的窗口的句柄。
         * dwTime：指明动画持续的时间（以微秒计），完成一个动画的标准时间为200微秒。
         * dwFags：指定动画类型。这个参数可以是一个或多个下列标志的组合。
         * 返回值：如果函数成功，返回值为非零；如果函数失败，返回值为零。
         */
        //标志描述：
        const int AW_SLIDE = 0x40000;//使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略。
        const int AW_ACTIVATE = 0x20000;//激活窗口。在使用了AW_HIDE标志后不要使用这个标志。
        const int AW_BLEND = 0x80000;//使用淡出效果。只有当hWnd为顶层窗口的时候才可以使用此标志。
        const int AW_HIDE = 0x10000;//隐藏窗口，缺省则显示窗口。(关闭窗口用)
        const int AW_CENTER = 0x0010;//若使用了AW_HIDE标志，则使窗口向内重叠；若未使用AW_HIDE标志，则使窗口向外扩展。
        const int AW_HOR_POSITIVE = 0x0001;//自左向右显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。
        const int AW_VER_POSITIVE = 0x0004;//自顶向下显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。
        const int AW_HOR_NEGATIVE = 0x0002;//自右向左显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。
        const int AW_VER_NEGATIVE = 0x0008;//自下向上显示窗口。该标志可以在滚动动画和滑动动画中使用。当使用AW_CENTER标志时，该标志将被忽略。

        string BookPicName = "";       //保存图片名字
        string picpath = "";           //保存图片路径

        //窗体移动的声明
        internal static int WM_NCHITTEST = 0x84;                            //移动鼠标，按住或释放鼠标时发生的系统消息
        internal static int WM_NCACTIVATE = 0x86;                           //窗体的激活状态发生改变的消息
        internal static IntPtr HTCLIENT = (IntPtr)0x1;                      //工作区
        internal static IntPtr HTSYSMENU = (IntPtr)3;                       //系统菜单
        internal static IntPtr HTCAPTION = (IntPtr)0x2;                     //标题栏
        internal static IntPtr HTLEFT = (IntPtr)10;                         //向左
        internal static IntPtr HTRIGHT = (IntPtr)11;                        //向右
        internal static IntPtr HTTOP = (IntPtr)12;                          //向上
        internal static IntPtr HTTOPLEFT = (IntPtr)13;                      //向左上
        internal static IntPtr HTTOPRIGHT = (IntPtr)14;                     //向右上
        internal static IntPtr HTBOTTOM = (IntPtr)15;                       //向下
        internal static IntPtr HTBOTTOMLEFT = (IntPtr)16;                   //向左下
        internal static IntPtr HTBOTTOMRIGHT = (IntPtr)17;                  //向右下
        private int m_BorderWidth = 4;

        
        frmUserModify formUserModify = new frmUserModify();               //声明修改账户信息窗口对象

        FontDialog fontDialog= new FontDialog();                            //Dialog变量
        ColorDialog colorDialog= new ColorDialog();
        SaveFileDialog saveFileDialog= new SaveFileDialog();
        OpenFileDialog openFileDialog = new OpenFileDialog();

        private NoteManage noteMod = new NoteManage();
        private NoteClassifyManage classifyManage = new NoteClassifyManage();
        private Dictionary<int, TreeNode> dic_node = new Dictionary<int, TreeNode>();

        //SQLHelperFile sqlHelperFile= new SQLHelperFile();                   //声明文件数据库操作类对象
        
        /// <summary>
        /// 构造函数
        /// </summary>
        public frmMain() {
            InitializeComponent();
            this.SetToolTip();
            m_SyncContext = SynchronizationContext.Current;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="nameToMain">登陆页面的传参</param>
        /// <param name="passwordToMain">登陆页面的传参</param>
        public frmMain(String nameToMain, string passwordToMain)
        {
            InitializeComponent();
            m_SyncContext = SynchronizationContext.Current;
            UserEmail = nameToMain;
            UserPassWord = passwordToMain;
            this.SetToolTip();
        }
        private void ThreadProSafePost() {
            while(true){
                m_SyncContext.Post(SetTextSafePost, "This text was set safely by SynchronizationContext-Post.");
                Thread.Sleep(10000);
            }
        }
        private void SetTextSafePost(object text)
        {
            DateTime date = DateTime.Now;
            string year = date.Year.ToString();
            string month = date.Month.ToString();
            string day = date.Day.ToString();
            string hour = date.Hour.ToString();
            string min = date.Minute.ToString();
            if (date.Minute < 10) {
                this.label_saveTime.Text =""+year+"年"+month+"月"+day+"日 "+ date.Hour.ToString() + ":" + "0"+date.Minute.ToString();
            }else
                this.label_saveTime.Text = "" + year + "年" + month + "月" + day + "日 " + date.Hour.ToString() + ":" + "" + date.Minute.ToString();

        }
        /// <summary>
        /// 程序初始加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cSharpDataSet.UserFileName”中。您可以根据需要移动或删除它。
            //this.userFileNameTableAdapter.Fill(this.cSharpDataSet.UserFileName);
            //sqlHelperFile.ReadFileToComboBox(LoginBean.UserName, cb_filesName);
            label_UserName.Text = UserEmail;
            CirclePaint(sender, e);
            this.timer = new Thread(new ThreadStart(this.ThreadProSafePost));
            this.timer.Start();
            SetToolTip();
            DataTable classData = classifyManage.SelectClass();
            dic_node.Clear();
            initClassfiy(1, classData, dic_node);
            initNotelist(0);
        }

        /// <summary>
        /// ToolTip设置
        /// </summary>
        private void SetToolTip()
        {
            toolTip1.SetToolTip(pb_clothesChange, "透明度");
            toolTip1.SetToolTip(pb_fontSize, "字体样式");
            toolTip1.SetToolTip(pb_fontColor, "字体颜色");
            toolTip1.SetToolTip(pb_openFile, "打开文档");
            toolTip1.SetToolTip(pb_saveAs, "另存为");
            toolTip1.SetToolTip(pb_save, "保存");
            toolTip1.SetToolTip(pb_back, "退出");
            toolTip1.SetToolTip(pb_small, "最小化");
            toolTip1.SetToolTip(pb_headPicture, "设置头像");
            toolTip1.SetToolTip(label_UserName, "设置账户信息");
            toolTip1.SetToolTip(cb_filesName, "选择文件夹");
            toolTip1.SetToolTip(pb_NewFileName, "新建文件夹");
        }

        /// <summary>
        /// 窗口最小化按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_small_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 关闭页面按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_back_Click(object sender, EventArgs e)
        {
            //this.Close();
            System.Environment.Exit(0);
        }

        /// <summary>
        /// 保存笔记按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_save_Click(object sender, EventArgs e)
        {
            //sqlHelperFile.SaveFile(LoginBean.UserName, cb_filesName.Text, tb_notebookName.Text, rtb_notebook.Text, DateTime.Now);
            
          
            string id = this.toolTip1.Tag.ToString();
            if (noteMod.saveNote(id, tb_notebookName.Text, rtb_notebook.Rtf))
            {
                DialogResult dr = MessageBox.Show("已成功保存到数据库！是否保存到本地？", "提示", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    noteMod.saveNote(this.rtb_notebook);
                tb_notebookName.Text = "";
                rtb_notebook.Rtf = "";
                tb_notebookName.ReadOnly = true;
                rtb_notebook.ReadOnly = true;
            }
            else {

                MessageBox.Show("保存失败！");
            }

            //MessageBox.Show("保存成功！");
        }

        /// <summary>
        /// 另存为按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_saveAs_Click(object sender, EventArgs e)
        {
            DialogUtil.FileSaveAs(saveFileDialog, rtb_notebook);
        }

        /// <summary>
        /// 打开文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_openFile_Click(object sender, EventArgs e)
        {
            //DialogUtil.OpenFile(openFileDialog, rtb_notebook);
            noteMod.openNote(this.rtb_notebook);
        }

        /// <summary>
        /// 改变字体颜色按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_fontColor_Click(object sender, EventArgs e)
        {
            noteMod.setFontColor(this.rtb_notebook);
        }

        /// <summary>
        /// 改变字体大小按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_fontSize_Click(object sender, EventArgs e)
        {
            noteMod.setFontSize(this.rtb_notebook);
        }

        /// <summary>
        /// 窗体移动
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if (DesignMode)
                {
                    return;
                }
                if (m.Result == HTCLIENT)
                {
                    m.HWnd = this.Handle;

                    System.Drawing.Rectangle rect = this.RectangleToScreen(this.ClientRectangle);
                    Point C_Pos = Cursor.Position;
                    if ((C_Pos.X <= rect.Left + m_BorderWidth) && (C_Pos.Y <= rect.Top + m_BorderWidth))
                        m.Result = HTTOPLEFT;//左上
                    else if ((C_Pos.X >= rect.Left + rect.Width - m_BorderWidth) && (C_Pos.Y <= rect.Top + m_BorderWidth))
                        m.Result = HTTOPRIGHT;//右上
                    else if ((C_Pos.X <= rect.Left + m_BorderWidth) && (C_Pos.Y >= rect.Top + rect.Height - m_BorderWidth))
                        m.Result = HTBOTTOMLEFT;//左下
                    else if ((C_Pos.X >= rect.Left + rect.Width - m_BorderWidth) && (C_Pos.Y >= rect.Top + rect.Height - m_BorderWidth))
                        m.Result = HTBOTTOMRIGHT;//右下
                    else if ((C_Pos.X <= rect.Left + m_BorderWidth - 1))
                        m.Result = HTLEFT;//左
                    else if ((C_Pos.X >= rect.Left + rect.Width - m_BorderWidth))
                        m.Result = HTRIGHT;//右
                    else if ((C_Pos.Y <= rect.Top + m_BorderWidth - 1))
                        m.Result = HTTOP;//上
                    else if ((C_Pos.Y >= rect.Top + rect.Height - m_BorderWidth))
                        m.Result = HTBOTTOM;//下
                    else
                    {
                        m.Result = HTCAPTION;//模拟标题栏,移动或双击可以最大或最小化窗体
                    }
                }
                return;
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// 点击头像旁边的用户名可以修改用户名和密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_UserName_Click(object sender, EventArgs e)
        {
            formUserModify.ShowDialog();
        }

        /// <summary>
        /// 将pictureBox画成圆形
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CirclePaint(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pb_headPicture.ClientRectangle);
            Region region = new Region(gp);
            pb_headPicture.Region = region;
            gp.Dispose();
            region.Dispose();
        }

        /// <summary>
        /// 点击头像修改头像
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_headPicture_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    picpath = openFileDialog1.FileName;
                    BookPicName = openFileDialog1.SafeFileName;

                    imageList1.Images.Clear();
                    imageList1.ImageSize = new Size(180, 149);
                    imageList1.Images.Add(Image.FromFile(picpath));


                    pb_headPicture.Image = imageList1.Images[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 最新文档label点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_lastNotebook_Click(object sender, EventArgs e)
        {
            //panel_deleteList.BackColor = Color.FromArgb(9, 143, 234);
            //panel_file.BackColor = Color.FromArgb(9, 143, 234);
            //panel_lastNotebook.BackColor = Color.FromArgb(91, 142, 146);


            ////设置停靠 
            //listView1.Dock = DockStyle.None;
            //panel_lastNotebook.Dock = DockStyle.Top;
            //panel_file.Dock = DockStyle.Bottom;
            //panel_deleteList.SendToBack();
            //panel_deleteList.Dock = DockStyle.Bottom;
            //listView1.BringToFront();
            //listView1.Dock = DockStyle.Top;
            ////添加项 
            //listView1.Clear();
            //sqlHelperFile.SearchAllNotebookTitleToListView(LoginBean.UserName, listView1);
        }

        /// <summary>
        /// 文件夹label点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_file_Click(object sender, EventArgs e)
        {
            //panel_deleteList.BackColor = Color.FromArgb(9, 143, 234);
            //panel_file.BackColor = Color.FromArgb(91, 142, 146);
            //panel_lastNotebook.BackColor = Color.FromArgb(9, 143, 234);


            ////设置停靠 
            //listView1.Dock = DockStyle.None;
            //panel_file.Dock = DockStyle.Top;
            //panel_lastNotebook.SendToBack();
            //panel_lastNotebook.Dock = DockStyle.Top;
            //panel_deleteList.Dock = DockStyle.Bottom;
            //listView1.Dock = DockStyle.Bottom;
            //listView1.BringToFront();
            ////添加项 
            //listView1.Clear();
            //sqlHelperFile.ReadFileToListView(LoginBean.UserName, listView1);
        }

        /// <summary>
        /// 删除列表label点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_deleteList_Click(object sender, EventArgs e)
        {
            //panel_deleteList.BackColor = Color.FromArgb(91, 142, 146);
            //panel_file.BackColor = Color.PowderBlue;
            //panel_lastNotebook.BackColor = Color.PowderBlue;

            ////设置停靠 
            //listView1.Dock = DockStyle.None;
            //panel_deleteList.SendToBack();
            //panel_deleteList.Dock = DockStyle.Top;
            //panel_file.SendToBack();
            //panel_file.Dock = DockStyle.Top;
            //panel_lastNotebook.SendToBack();
            //panel_lastNotebook.Dock = DockStyle.Top;
            //listView1.Dock = DockStyle.Top;
            //////添加项 
            //listView1.Clear();
            
            //sqlHelperFile.SearchAllDeleteNotebookTitleToListView(LoginBean.UserName, listView1);
        }

        /// <summary>
        /// 笔记搜索框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_searchNotebook_TextChanged(object sender, EventArgs e)
        {
            tb_searchNotebook.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb_searchNotebook.AutoCompleteMode = AutoCompleteMode.Suggest;
            //sqlHelperFile.SearchAllNotebookTitle(LoginBean.UserName, tb_searchNotebook);
        }

        /// <summary>
        /// 点击搜索按钮，将搜索内容打开到RichTextbook中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_searchNotebook_Click(object sender, EventArgs e)
        {
            //sqlHelperFile.SearchNotebookContent(LoginBean.UserName, tb_searchNotebook.Text.Trim(), rtb_notebook, label_saveTime, tb_notebookName);
        }

        /// <summary>
        /// 新建文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_NewFileName_Click(object sender, EventArgs e)
        {
            //frmNewFile formNewFile = new frmNewFile();                        //声明新建文件夹窗口对象
            //formNewFile.ShowDialog();
        }

        /// <summary>
        /// 删除笔记按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_deleteNotebook_Click(object sender, EventArgs e)
        {
            //sqlHelperFile.addDeleteNotebook(LoginBean.UserName, tb_notebookName.Text, rtb_notebook.Text, DateTime.Now);
            //sqlHelperFile.deleteNotebook(LoginBean.UserName, tb_notebookName.Text);
            MessageBox.Show("删除成功！");
            tb_notebookName.Text = "";
            rtb_notebook.Text = "";
            label_saveTime.Text = "";
        }

        /// <summary>
        /// 点击listview的item显示笔记内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sqlHelperFile.SearchNotebookContent(LoginBean.UserName, listView1.SelectedItems[0].SubItems[0].Text.Trim(), rtb_notebook, label_saveTime, tb_notebookName);
        }
        private void Add_BookInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnimateWindow(this.Handle, 700, AW_HIDE | AW_CENTER);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        /// <summary>
        /// 插入图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb_insertPicture_Click(object sender, EventArgs e)
        {
            noteMod.insertPicture(this.rtb_notebook);
        }
        /// <summary>
        /// 树状化分类
        /// </summary>
        /// <param name="no">初始值为：1</param>
        /// <param name="classdata">数据集</param>
        private void initClassfiy(int no, DataTable classdata, Dictionary<int, TreeNode> dic_node) 
        {
            //第一次递归：k=no=1;
            int k = no;
            //分类表
            classdata = classifyManage.SelectClass();
            //1.一级目录
            for(int i=0;i<classdata.Rows.Count;i++ ){
                string id = classdata.Rows[i][0].ToString();
                string name = classdata.Rows[i][1].ToString();
                string upid = classdata.Rows[i][2].ToString();
                if (no == 1 && upid.Equals(""))
                {
                    Dictionary<int, TreeNode> no_1 = new Dictionary<int, TreeNode>();
                    UiUtil.Output(this, "No1-->" + classdata.Rows[i][0] + "+" + classdata.Rows[i][1] + "+" + classdata.Rows[i][2]);
                    TreeNode node_1 = new TreeNode();
                    node_1.ContextMenuStrip = contextMenuStrip1 ;
                    node_1.ImageIndex = 1;
                    node_1.SelectedImageIndex = 1;
                    node_1.Text = name;
                    node_1.Name = id;
                    no_1.Add(int.Parse(id), node_1);
                    if (no == 1 && node_1 != null)
                    {
                        treeView1.Nodes.Add(node_1);
                    }
                    this.initClassfiy(k + 1, classdata, no_1);
                }
                else {
                    if (no!=1 && !upid.Equals(""))
                    {
                        if (dic_node.Count == 0)
                        {
                            return;
                        }
                        else {
                            Dictionary<int, TreeNode> no_1 = dic_node;
                            Dictionary<int, TreeNode> no_2 = new Dictionary<int, TreeNode>();
                            int iId = int.Parse(id);
                            int uid = int.Parse(upid);
                            try
                            {
                                UiUtil.Output(this, "No2-->" + classdata.Rows[i][0] + "+" + classdata.Rows[i][1] + "+" + classdata.Rows[i][2]);
                                TreeNode node_2 = new TreeNode();
                                node_2.Text = name;
                                node_2.ContextMenuStrip = contextMenuStrip1;
                                node_2.Name = id;
                                node_2.ImageIndex = 2;
                                node_2.SelectedImageIndex = 2;
                                no_1[uid].Nodes.Add(node_2);
                                no_2.Add(iId, node_2);
                                this.initClassfiy(k + 1, classdata, no_2);
                            }
                            catch (KeyNotFoundException e)
                            {
                                continue;
                            }
                        }
                    }
                }
            }
        }

        private void rtb_notebook_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }
        /// <summary>
        /// 新建文件夹事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新建文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode newNode = new TreeNode();
            TreeNode selectNode = treeView1.SelectedNode;
            frmNewFile formNewFile = new frmNewFile(selectNode);                        //声明新建文件夹窗口对象
            DialogResult result = formNewFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.updateTreeView();
            }

        }
        private void updateTreeView() {
            dic_node.Clear();
            this.treeView1.Nodes.Clear();
            this.initClassfiy(1, classifyManage.SelectClass(), dic_node);
            
        }
        /// <summary>
        /// 删除文件事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 重命名文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //笔记列表
        private void initNotelist(int classId) {

            dataGridView1.Enabled = true;
            //if (this.listView1.SelectedIndices != null && this.listView1.SelectedIndices.Count > 0)
            //{
            //    ListView.SelectedIndexCollection lv = this.listView1.SelectedIndices;
            //    Classid = (int)this.listView1.Items[lv[0]].Tag;
            //}
            //判断是否获取id
            if (classId == 0)
            {
                return;
            }
            else
            {
                try
                {
                     DataTable table = noteMod.SelectNote(classId);
                    if (table.Rows.Count == 0)
                    {
                        MessageBox.Show("没有笔记！", "！！", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        rtb_notebook.Clear();
                    }
                    LoadNote(classId);
                }
                catch
                {
                    return;
                }
            }
        }
        //重新加载笔记
        public void LoadNote(int classifyID)
        {
            try
            {
                dataGridView1.Rows.Clear();
                DataTable table = noteMod.SelectNote(classifyID);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    rtb_notebook.Rtf = table.Rows[i][1].ToString();
                    DateTime time = (DateTime)table.Rows[i][2];
                    if (rtb_notebook.Text.Length < 20)
                    {
                        dataGridView1.Rows.Add(rtb_notebook.Text, time.ToString("yyyy/MM/dd"), table.Rows[i][0]);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(rtb_notebook.Text.Replace("\n", "").Substring(0, 20), time.ToString("yyyy/MM/dd"), table.Rows[i][0]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //单击击打开笔记
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    Noteid = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim());
                }
                DataTable table = noteMod.OpenNote(Noteid);
                rtb_notebook.Rtf = table.Rows[0]["Notes"].ToString();
                tb_notebookName.Text = table.Rows[0][1].ToString();
                //tbNote.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.listView1.Groups.Clear();
            this.initNotelist( int.Parse( treeView1.SelectedNode.Name) );
        }

        private void 新建笔记ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //分类的ID
            int classId = int.Parse(treeView1.SelectedNode.Name);
            rtb_notebook.ReadOnly = false;
            tb_notebookName.ReadOnly = false;
            tb_notebookName.Text = "新增笔记";
            rtb_notebook.Rtf = "";
            this.toolTip1.Tag = classId;
            MessageBox.Show(classId+"");
            

            
        
        }

    }
}
