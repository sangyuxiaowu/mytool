using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 综合工具箱
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        #region 批量重命名

        private void btnSel_Click(object sender, EventArgs e)
        {
            if(renameDirSel.ShowDialog() == DialogResult.OK || renameDirSel.ShowDialog() == DialogResult.Yes)
            {
                txtDir.Text = renameDirSel.SelectedPath;
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (txtDir.Text == "") {
                MessageBox.Show("先选择文件夹！");
                return;
            }
            try
            {
                FileInfo[] file = new DirectoryInfo(txtDir.Text).GetFiles();
                if (file.Length != 0)                  
                {
                    int i = (int)numStart.Value;
                    foreach (FileInfo f in file) //显示当前目录所有文件   
                    {
                        if (seled.Contains(f.Extension.ToUpper()))
                        {
                            try
                            {
                                f.MoveTo(string.Format("{0}\\{1}{2}{3}", f.DirectoryName, txtQz.Text, i.ToString(), f.Extension.ToLower()));
                            }
                            catch { 
                            }
                            i++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private static readonly List<string> seled = new List<string> { };
        private void extList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (extList.CheckedItems.Count > 0) {
                seled.Clear();
                foreach (string item in extList.CheckedItems) {
                    seled.Add(item.ToUpper());
                }
            }
        }

        #endregion


        #region 图片base64 和 exif信息查看
        private void txtbox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void txtBase64_DragDrop(object sender, DragEventArgs e)
        {
            string file = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            
            if (File.Exists(file)){
                FileInfo finfo = new FileInfo(file);
                if (finfo.Length > 204800) {
                    toolStripStatusLabel.Text = "文件大于200k ，大小为 "+ finfo.Length.ToString();
                    return;
                }
                //2177747 2.07mb
                try
                {

                    FileStream filestream = new FileStream(file, FileMode.Open);
                    byte[] bt = new byte[filestream.Length];
                    //调用read读取方法  
                    filestream.Read(bt, 0, bt.Length);
                    txtBase64.Text = Convert.ToBase64String(bt);
                    filestream.Close();
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel.Text = ex.Message;
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtBase64_Click(object sender, EventArgs e)
        {
            txtBase64.SelectAll();
        }

        private void exifFileSel_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "图片|*.jpg;*.png;*.gif;*.jpeg;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                showFileExif(openFileDialog.FileName);
            }
        }

        private void txtExif_DragDrop(object sender, DragEventArgs e)
        {
            string[] allow = new string[]{ "jpg", "png", "gif", "peg", "bmp" };
            string file = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            string ext = file.ToLower().Substring(file.Length-3);
            if(allow.Contains(ext))showFileExif(file);
        }
        private void showFileExif(string file) {
            if (File.Exists(file))
            {
                Bitmap img = (Bitmap)Bitmap.FromFile(file);
                ExifManager exif = new ExifManager(img);
                txtExif.Text = exif.ToString().Replace("\n","\r\n");
                exif.Dispose();
                img.Dispose();
            }
        }

        #endregion

        #region 标记图片旋转
        private void btnXZSelDIr_Click(object sender, EventArgs e)
        {
            if (renameDirSel.ShowDialog() == DialogResult.OK || renameDirSel.ShowDialog() == DialogResult.Yes)
            {
                textXZImg.Text = renameDirSel.SelectedPath;
            }
        }

        private void btnXZSelJsonDIr_Click(object sender, EventArgs e)
        {
            if (renameDirSel.ShowDialog() == DialogResult.OK || renameDirSel.ShowDialog() == DialogResult.Yes)
            {
                textXZJson.Text = renameDirSel.SelectedPath;
            }
        }

        private void btnXZ_Click(object sender, EventArgs e)
        {
            string[] allow = new string[] { ".jpg", ".jpeg",".png",".gif",".bmp" };

            if (textXZImg.Text == "")
            {
                MessageBox.Show("先选择图片文件夹！");
                return;
            }
            if (checkXZJson.Checked && textXZJson.Text == "") {
                MessageBox.Show("先选择Json标记数据文件夹！");
                return;
            }

            FileInfo[] file = new DirectoryInfo(textXZImg.Text).GetFiles();
            if (file.Length != 0)
            {
                foreach (FileInfo f in file) //显示当前目录所有文件   
                {
                    if (allow.Contains(f.Extension.ToLower()))
                    {
                        string filename = f.FullName;
                        string tempfile = f.DirectoryName + "\\tmp";
                        Directory.CreateDirectory(tempfile);
                        tempfile +="\\" + f.Name;
                        Bitmap img = (Bitmap)Bitmap.FromFile(filename);
                        ExifManager exif = new ExifManager(img);
                        if (exif.Orientation == ExifManager.Orientations.RightTop) {
                            exif.SetPropertyInt16((int)ExifManager.TagNames.Orientation,(short)ExifManager.Orientations.LeftTop);
                            exif.Save(tempfile);

                            //旋转
                            /*
                            using (var limg = Image.FromFile(tempfile)) {
                                var newimg = RotateImg(limg, 90);
                                limg.Dispose();
                                newimg.Save(tempfile);
                            };
                            */
                            //
                        }
                        img.Dispose();
                        exif.Dispose();
                    }
                }
            }
        }

        /// <summary>
        /// 根据角度旋转图标
        /// </summary>
        /// <param name="img"></param>
        public Image RotateImg(Image img, float angle)
        {
            //通过Png图片设置图片透明，修改旋转图片变黑问题。
            int width = img.Width;
            int height = img.Height;
            //角度
            Matrix mtrx = new Matrix();
            mtrx.RotateAt(angle, new PointF((width / 2), (height / 2)), MatrixOrder.Append);
            //得到旋转后的矩形
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(new RectangleF(0f, 0f, width, height));
            RectangleF rct = path.GetBounds(mtrx);
            //生成目标位图
            Bitmap devImage = new Bitmap((int)(rct.Width), (int)(rct.Height));
            Graphics g = Graphics.FromImage(devImage);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Bilinear;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //计算偏移量
            Point Offset = new Point((int)(rct.Width - width) / 2, (int)(rct.Height - height) / 2);
            //构造图像显示区域：让图像的中心与窗口的中心点一致
            Rectangle rect = new Rectangle(Offset.X, Offset.Y, (int)width, (int)height);
            Point center = new Point((int)(rect.X + rect.Width / 2), (int)(rect.Y + rect.Height / 2));
            g.TranslateTransform(center.X, center.Y);
            g.RotateTransform(angle);
            //恢复图像在水平和垂直方向的平移
            g.TranslateTransform(-center.X, -center.Y);
            g.DrawImage(img, rect);
            //重至绘图的所有变换
            g.ResetTransform();
            g.Save();
            g.Dispose();
            path.Dispose();
            return devImage;
        }


        #endregion


    }
}
