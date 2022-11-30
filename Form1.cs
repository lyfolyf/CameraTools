using CameraSDK;
using CameraSDK.Models;
using GL.Kit.Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CameraTools
{
    public partial class Form1 : Form
    {
        readonly IGLogger log;

        public Form1()
        {
            InitializeComponent();

            DisplayAdapter displayAdapter = new DisplayAdapter(200, LogFormat.General);
            displayAdapter.ClearCurrent += ClearLog;
            displayAdapter.NewLog += NewLog;

            log = GLogger.CreateLog("log1", LogLevel.All, displayAdapter);
        }

        CameraFactory cameraFactory;
        ICamera camera;
        bool changeCameraFlag = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            cameraFactory = new CameraFactory(log);
        }

        private void ckbHIK_GenTL_CheckedChanged(object sender, EventArgs e)
        {
            tbCtiPath.Enabled = ckbHIK_GenTL.Checked;
            btnSelectCti.Enabled = ckbHIK_GenTL.Checked;
        }

        OpenFileDialog openFile;

        private void btnSelectCti_Click(object sender, EventArgs e)
        {
            if (openFile == null)
            {
                openFile = new OpenFileDialog
                {
                    Filter = "DCF文件(*.cti)|*.cti"
                };
            }

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                tbCtiPath.Text = openFile.FileName;
                cameraFactory.SetCtiPath(tbCtiPath.Text);
            }
        }

        #region 初始化

        BindingList<ComCameraInfo> dataSource;

        // 查找
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<CameraBrand> cameraBrands = getSelectedCameraBrand();

            if (cameraBrands.Count == 0)
            {
                MessageBoxUtils.ShowWarn("请选择相机品牌");
                return;
            }

            cameraFactory.SetCameraBrands(cameraBrands);

            List<ComCameraInfo> cameraInfos = cameraFactory.SearchDevice();

            dataSource = new BindingList<ComCameraInfo>(cameraInfos);

            cbbDeviceList.DataSource = dataSource;
        }

        List<CameraBrand> getSelectedCameraBrand()
        {
            List<CameraBrand> cameraBrands = new List<CameraBrand>();

            if (ckbHIK_GigE.Checked)
                cameraBrands.Add(CameraBrand.HIK_Gige);
            if (ckbHIK_GenTL.Checked)
                cameraBrands.Add(CameraBrand.HIK_GenTL);
            if (ckbBasler.Checked)
                cameraBrands.Add(CameraBrand.Basler);
            if (ckbFLIR.Checked)
                cameraBrands.Add(CameraBrand.FLIR);
            if (ckbDH.Checked)
                cameraBrands.Add(CameraBrand.DaHua);
            return cameraBrands;
        }

        private void cbbDeviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!changeCameraFlag) return;

            if (camera != null)
            {
                camera.Close();
            }

            ComCameraInfo cameraInfo = cbbDeviceList.SelectedItem as ComCameraInfo;

            camera = cameraFactory.GetCamera(cameraInfo);
            camera.ImageReceived += (sender1, e1) =>
            {
                pictureBox1.AsyncAction((c) =>
                {
                    (c as PictureBox).Image = e1.CImage.Bitmap;
                });
            };
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (cbbDeviceList.SelectedIndex == -1)
            {
                MessageBoxUtils.ShowInfo("请选择相机");
                return;
            }

            FrmRename frm = new FrmRename();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (camera.Rename(frm.NewName))
                {
                    int index = cbbDeviceList.SelectedIndex;

                    ComCameraInfo cameraInfo = dataSource[index];

                    ComCameraInfo newCamera = cameraInfo.Clone();
                    newCamera.UserDefinedName = frm.NewName;

                    changeCameraFlag = false;

                    dataSource[index] = newCamera;

                    changeCameraFlag = true;
                }
            }
        }

        #endregion

        #region 打开/关闭

        // 打开
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cbbDeviceList.SelectedIndex == -1)
            {
                MessageBoxUtils.ShowInfo("请选择相机");
                return;
            }

            camera.Open();

            gbGrabbing.Enabled = true;
            rdoSoftTrigger.Enabled = true;
            rdoExternTrigger.Enabled = true;
            btnContinuous.Enabled = false;
            btnTriggerExec.Enabled = false;
            gbParams.Enabled = true;

            btnGetParams.PerformClick();
        }

        // 关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            camera.Close();

            rdoSoftTrigger.Checked = false;
            rdoExternTrigger.Checked = false;
            if (btnContinuous.Text == "停止实时")
                btnContinuous.Text = "实时";

            gbGrabbing.Enabled = false;
            gbParams.Enabled = false;
        }

        #endregion

        #region 采集图像

        // 软触发
        private void rdoSoftTrigger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSoftTrigger.Checked)
            {
                if (camera == null)
                {
                    MessageBoxUtils.ShowWarn("请选择相机");
                    return;
                }

                btnContinuous.Enabled = true;
                btnTriggerExec.Enabled = true;

                camera.Start(TriggerMode.Trigger, TriggerSource.Software);
            }
        }

        // 硬触发
        private void rdoExternTrigger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoExternTrigger.Checked)
            {
                if (camera == null)
                {
                    MessageBoxUtils.ShowWarn("请选择相机");
                    return;
                }

                btnContinuous.Enabled = false;
                btnTriggerExec.Enabled = false;

                if (btnContinuous.Text == "停止实时")
                    btnContinuous.Text = "实时";

                camera.Start(TriggerMode.Trigger, TriggerSource.Extern);
            }
        }

        // 实时
        private void btnStartGrab_Click(object sender, EventArgs e)
        {
            if (btnContinuous.Text == "实时")
            {
                btnContinuous.Text = "停止实时";
                btnTriggerExec.Enabled = false;

                camera.SetTriggerMode(TriggerMode.Continuous);
            }
            else
            {
                btnContinuous.Text = "实时";
                btnTriggerExec.Enabled = true;

                camera.SetTriggerMode(TriggerMode.Trigger);
            }
        }

        // 软触发一次
        private void btnTriggerExec_Click(object sender, EventArgs e)
        {
            camera.SoftTrigger();
        }

        #endregion

        #region 设置参数

        private void btnGetParams_Click(object sender, EventArgs e)
        {
            CameraParams param = camera.GetParams();

            tbExposure.Text = param.ExposureTime?.ToString();
            tbGain.Text = param.Gain?.ToString();

            tbImageWidth.Text = param.ImageWidth?.ToString();
            tbImageHeight.Text = param.ImageHeight?.ToString();

            tbDelay.Text = param.TriggerDelay?.ToString();
        }

        private void btnSetParams_Click(object sender, EventArgs e)
        {
            CameraParams @params = new CameraParams
            {
                ExposureTime = tbExposure.Text.Length > 0 ? float.Parse(tbExposure.Text) : (float?)null,
                Gain = tbGain.Text.Length > 0 ? float.Parse(tbGain.Text) : (float?)null,

                ImageWidth = tbImageWidth.Text.Length > 0 ? int.Parse(tbImageWidth.Text) : (int?)null,
                ImageHeight = tbImageHeight.Text.Length > 0 ? int.Parse(tbImageHeight.Text) : (int?)null,

                TriggerDelay = tbDelay.Text.Length > 0 ? float.Parse(tbDelay.Text) : (float?)null
            };

            camera.SetParams(@params);
        }

        #endregion

        #region 日志显示

        public void ClearLog()
        {
            rtbLog.AsyncAction((c) =>
            {
                (c as RichTextBox).Clear();
            });
        }

        public void NewLog(LogInfo log)
        {
            AppendLog(log, GetLogColor(log.Level));
        }

        readonly Color DebugColor = Color.FromArgb(192, 192, 192);
        readonly Color InfoColor = SystemColors.WindowText;
        readonly Color WarnColor = Color.FromArgb(192, 192, 0);
        readonly Color ErrorColor = Color.Red;

        private Color GetLogColor(LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Debug: return DebugColor;
                case LogLevel.Info: return InfoColor;
                case LogLevel.Warn: return WarnColor;
                case LogLevel.Error:
                case LogLevel.Fatal:
                    return ErrorColor;
                default: return InfoColor;
            }
        }

        private void AppendLog(LogInfo log, Color color)
        {
            rtbLog.AsyncAction((c) =>
            {
                RichTextBox rtb = c as RichTextBox;
                rtb.AppendLine(log.ToString(LogFormat.General), color);
                rtb.ScrollToCaret();
            });
        }

        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camera != null)
                camera.Close();
        }

        private void tsmiClearLog_Click(object sender, EventArgs e)
        {
            rtbLog.Clear();
        }

    }
}
