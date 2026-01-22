namespace ClydeStewthEmailParser
{
    partial class ParseRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public ParseRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParseRibbon));
            this.Parse1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.parsefolder1 = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.configure1 = this.Factory.CreateRibbonButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Parse1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Parse1
            // 
            this.Parse1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Parse1.Groups.Add(this.group1);
            this.Parse1.Groups.Add(this.group2);
            this.Parse1.Label = "Parse";
            this.Parse1.Name = "Parse1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.parsefolder1);
            this.group1.Label = "Parse";
            this.group1.Name = "group1";
            // 
            // parsefolder1
            // 
            this.parsefolder1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.parsefolder1.Image = ((System.Drawing.Image)(resources.GetObject("parsefolder1.Image")));
            this.parsefolder1.Label = "Search Folder";
            this.parsefolder1.Name = "parsefolder1";
            this.parsefolder1.ShowImage = true;
            this.parsefolder1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.parse1_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.button1);
            this.group2.Items.Add(this.configure1);
            this.group2.Label = "Configuration";
            this.group2.Name = "group2";
            // 
            // button1
            // 
            this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Label = "Import";
            this.button1.Name = "button1";
            this.button1.ShowImage = true;
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // configure1
            // 
            this.configure1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.configure1.Image = ((System.Drawing.Image)(resources.GetObject("configure1.Image")));
            this.configure1.Label = "Export";
            this.configure1.Name = "configure1";
            this.configure1.ShowImage = true;
            this.configure1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.configure1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // ParseRibbon
            // 
            this.Name = "ParseRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.Parse1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.ParseRibbon_Load);
            this.Parse1.ResumeLayout(false);
            this.Parse1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Parse1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton parsefolder1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton configure1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
    }

    partial class ThisRibbonCollection
    {
        internal ParseRibbon ParseRibbon
        {
            get { return this.GetRibbon<ParseRibbon>(); }
        }
    }
}
