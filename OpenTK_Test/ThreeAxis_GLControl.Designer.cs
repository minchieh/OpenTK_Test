namespace OpenTK_Test
{
    partial class ThreeAxis_GLControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_glControl = new OpenTK.GLControl();
            this.SuspendLayout();
            // 
            // Main_glControl
            // 
            this.Main_glControl.BackColor = System.Drawing.Color.Black;
            this.Main_glControl.Location = new System.Drawing.Point(3, 3);
            this.Main_glControl.Name = "Main_glControl";
            this.Main_glControl.Size = new System.Drawing.Size(524, 351);
            this.Main_glControl.TabIndex = 0;
            this.Main_glControl.VSync = false;
            this.Main_glControl.Load += new System.EventHandler(this.Main_glControl_Load);
            this.Main_glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_glControl_Paint);
            this.Main_glControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_glControl_MouseDown);
            this.Main_glControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_glControl_MouseMove);
            this.Main_glControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_glControl_MouseUp);
            // 
            // ThreeAxis_GLControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Main_glControl);
            this.Name = "ThreeAxis_GLControl";
            this.Size = new System.Drawing.Size(530, 357);
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl Main_glControl;
    }
}
