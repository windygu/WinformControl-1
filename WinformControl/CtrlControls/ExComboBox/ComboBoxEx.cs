using CtrlControls.Enum;
using CtrlControls.ExListBox;
using CtrlControls.ExPopup;
using CtrlControls.ExTextBox;
using CtrlControls.Helper;
using CtrlResource;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CtrlControls.ExComboBox
{
    public class ComboBoxEx : UserControl
    {
        Image _arrowNormalImage = AssemblyHelper.GetImage("ComboBox.cmb_arrow_normal.png");
        Image _borderNormalImage = AssemblyHelper.GetImage("ComboBox.cmb_border_normal.png");
        Image _borderDownImage = AssemblyHelper.GetImage("ComboBox.cmb_border_down.png");
        EMouseState _mouseState = EMouseState.Normal;
        EMouseState _mouseAll = EMouseState.Normal;
        PopupEx _popupEx;
        private TextBoxEx BaseText;
        private ListBoxEx listBox;
        private ListBoxExCollection _items = null;

        //
        // 摘要:
        //     当 System.Windows.Forms.ListControl.SelectedValue 属性更改时发生。
        public event EventHandler SelectedValueChanged;
        [EditorBrowsable()]
        public new event EventHandler TextChanged;

        public ComboBoxEx()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.Opaque, false);
            base.UpdateStyles();
            this.BackColor = Color.Transparent;
            this.BaseText.Anchor = AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Top;
            this.BaseText.MouseMove += new MouseEventHandler(BaseText_MouseMove);
            this.BaseText.MouseLeave += new EventHandler(BaseText_MouseLeave);
            this.listBox.Visible = false;
            this.listBox.MaximumSize = new Size(this.Size.Width, this.listBox.ItemHeight * 5);
            this.listBox.SelectedValueChanged += new EventHandler(listBox_SelectedValueChanged);
            this.listBox.Click += new EventHandler(listBox_Click);
            this.BaseText.KeyPress += new KeyPressEventHandler(BaseText_KeyPress);
            this.BaseText.TextChanged += new EventHandler(BaseText_TextChanged);
        }

        void BaseText_TextChanged(object sender, EventArgs e)
        {
            if (this.TextChanged != null)
            {
                this.TextChanged(sender, e);
            }
        }

        void listBox_Click(object sender, EventArgs e)
        {
            if (this.listBox.SelectedItems.Count == 1)
            {
                this.BaseText.Text = (this.listBox.SelectedItem as ListBoxExItem).Text;
            }
            //this.listBox.Visible = false;
            this._popupEx.Close();
        }

        void listBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.SelectedValueChanged != null)
            {
                this.SelectedValueChanged(sender, e);
            }
        }

        internal Rectangle ImageRect
        {
            get { return new Rectangle(this.Width - 25, (this.Height - this._arrowNormalImage.Height) / 2, 23, 24); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]//这两个特性没有的话运行的时候就会删除Items的内容
        [EditorBrowsable(EditorBrowsableState.Always)]
        public ListBoxExCollection Items
        {
            get
            {
                if (this._items == null)
                    this._items = new ListBoxExCollection(this.listBox);
                return this._items;
            }
        }
        public int SelectedIndex
        {
            get { return this.listBox.SelectedIndex; }
            set { this.listBox.SelectedIndex = value; }
        }
        public object SelectedItem
        {
            get { return this.listBox.SelectedItem; }
            set { this.listBox.SelectedItem = value; }
        }
        public object SelectedValue
        {
            get { return this.listBox.SelectedValue; }
            set { this.listBox.SelectedValue = value; }
        }
        public bool ReadOnly
        {
            get { return this.BaseText.Enabled; }
            set { this.BaseText.Enabled = value; }
        }
        public new string Text
        {
            get { return this.BaseText.Text; }
            set { this.BaseText.Text = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            this.BaseText.Size = new Size(this.Width - 30, this.Height - 16);
            this.BaseText.Location = new Point(5, (this.Height - this.BaseText.Height) / 2);
            this.listBox.Height = 4 * 35;
            this.listBox.Font = base.Font;
            this.listBox.Width = this.Width;
            this.MinimumSize = new Size(60, 28);
            DrawHelper.DrawComboBoxArrowButtonBorderBackground(this.ClientRectangle, this._borderNormalImage, g);
            if (this._mouseAll == EMouseState.MouseMove
                || this._mouseAll == EMouseState.MouseDown
                || this._mouseAll == EMouseState.MouseUp)
            {
                DrawHelper.DrawComboBoxArrowButtonBorderBackground(this.ClientRectangle, this._borderDownImage, g);
            }
            switch (this._mouseState)
            {
                case EMouseState.MouseMove:
                case EMouseState.MouseUp:
                    this._arrowNormalImage = AssemblyHelper.GetImage("ComboBox.cmb_arrow_highlight.png");
                    break;
                case EMouseState.MouseDown:
                    this._arrowNormalImage = AssemblyHelper.GetImage("ComboBox.cmb_arrow_down.png");
                    break;
                case EMouseState.Normal:
                default:
                    this._arrowNormalImage = AssemblyHelper.GetImage("ComboBox.cmb_arrow_normal.png");
                    break;
            }
            g.DrawImage(this._arrowNormalImage, this.ImageRect);

            if (this.SelectedItem != null)
            {
                this.BaseText.Text = (this.SelectedItem as ListBoxExItem).Text;
            }
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComboBoxEx));
            this.listBox = new CtrlControls.ExListBox.ListBoxEx();
            this.BaseText = new CtrlControls.ExTextBox.TextBoxEx();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox.Font = new System.Drawing.Font("宋体", 11F);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 35;
            this.listBox.Location = new System.Drawing.Point(0, 20);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(200, 4);
            this.listBox.TabIndex = 3;
            // 
            // BaseText
            // 
            this.BaseText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseText.Border = false;
            this.BaseText.BorderNormalColor = System.Drawing.Color.RoyalBlue;
            this.BaseText.BorderNormalImage = ((System.Drawing.Image)(resources.GetObject("BaseText.BorderNormalImage")));
            this.BaseText.BorderOverColor = System.Drawing.Color.BlueViolet;
            this.BaseText.BorderOverImage = ((System.Drawing.Image)(resources.GetObject("BaseText.BorderOverImage")));
            this.BaseText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BaseText.BorderWeight = 1F;
            this.BaseText.Font = new System.Drawing.Font("宋体", 11F);
            this.BaseText.Location = new System.Drawing.Point(0, 1);
            this.BaseText.Name = "BaseText";
            this.BaseText.Size = new System.Drawing.Size(169, 17);
            this.BaseText.TabIndex = 2;
            this.BaseText.WaterColor = System.Drawing.Color.DarkGray;
            this.BaseText.WaterText = "";
            // 
            // ComboBoxEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.BaseText);
            this.Name = "ComboBoxEx";
            this.Size = new System.Drawing.Size(200, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (this.ImageRect.Contains(e.Location))
            {
                this._mouseState = EMouseState.MouseMove;
            }
            this._mouseAll = EMouseState.MouseMove;
            base.Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (this.ImageRect.Contains(e.Location))
            {
                this._mouseState = EMouseState.MouseDown;
                this.listBox.Visible = true;
                this._popupEx = new PopupEx(this.listBox);
                this._popupEx.Show(this);
            }
            this._mouseAll = EMouseState.MouseDown;
            base.Invalidate();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (this.ImageRect.Contains(e.Location))
            {
                this._mouseState = EMouseState.MouseUp;
            }
            this._mouseAll = EMouseState.MouseUp;
            base.Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this._mouseState = EMouseState.Normal;
            this._mouseAll = EMouseState.Normal;
            base.Invalidate();
        }

        void BaseText_MouseLeave(object sender, EventArgs e)
        {
            this._mouseAll = EMouseState.MouseLeave;
        }

        void BaseText_MouseMove(object sender, MouseEventArgs e)
        {
            this._mouseAll = EMouseState.MouseMove;
        }

        void BaseText_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
    }
}
