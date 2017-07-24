using System.Drawing;
using System.Windows.Forms;

namespace SmileBase
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool16 = new Infragistics.Win.UltraWinToolbars.ButtonTool("MainMenuExitButton");
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab1 = new Infragistics.Win.UltraWinToolbars.RibbonTab("StartRibbonTab");
            Infragistics.Win.UltraWinToolbars.RibbonGroup ribbonGroup1 = new Infragistics.Win.UltraWinToolbars.RibbonGroup("ClipBoardRibbonGroup");
            Infragistics.Win.UltraWinToolbars.RibbonGroup ribbonGroup2 = new Infragistics.Win.UltraWinToolbars.RibbonGroup("StudentsRibbonGroup");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool17 = new Infragistics.Win.UltraWinToolbars.ButtonTool("AddStudentButton");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool18 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Show Students");
            Infragistics.Win.UltraWinToolbars.RibbonGroup ribbonGroup3 = new Infragistics.Win.UltraWinToolbars.RibbonGroup("CustomersRibbonGroup");
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab2 = new Infragistics.Win.UltraWinToolbars.RibbonTab("InsertRibbonTab");
            Infragistics.Win.UltraWinToolbars.RibbonGroup ribbonGroup4 = new Infragistics.Win.UltraWinToolbars.RibbonGroup("TestRibbonGroup");
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab3 = new Infragistics.Win.UltraWinToolbars.RibbonTab("AccountingRibbonTab");
            Infragistics.Win.UltraWinToolbars.RibbonGroup ribbonGroup5 = new Infragistics.Win.UltraWinToolbars.RibbonGroup("PaymentsRibbonGroup");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool25 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Show George Account");
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.TextBoxTool textBoxTool6 = new Infragistics.Win.UltraWinToolbars.TextBoxTool("MainSearchTextBox");
            Infragistics.Win.UltraWinToolbars.TextBoxTool textBoxTool9 = new Infragistics.Win.UltraWinToolbars.TextBoxTool("MainSearchTextBox");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool26 = new Infragistics.Win.UltraWinToolbars.ButtonTool("MainMenuExitButton");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool27 = new Infragistics.Win.UltraWinToolbars.ButtonTool("AddStudentButton");
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool29 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Show Students");
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool43 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Show George Account");
            this.leftPanel = new System.Windows.Forms.ToolStripPanel();
            this._MainForm_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._MainForm_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._MainForm_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._MainForm_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainToolbarsManager = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainToolbarsManager)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            resources.ApplyResources(this.leftPanel, "leftPanel");
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.leftPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // _MainForm_Toolbars_Dock_Area_Left
            // 
            this._MainForm_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._MainForm_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._MainForm_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._MainForm_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._MainForm_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 4;
            resources.ApplyResources(this._MainForm_Toolbars_Dock_Area_Left, "_MainForm_Toolbars_Dock_Area_Left");
            this._MainForm_Toolbars_Dock_Area_Left.Name = "_MainForm_Toolbars_Dock_Area_Left";
            this._MainForm_Toolbars_Dock_Area_Left.ToolbarsManager = this.mainToolbarsManager;
            // 
            // _MainForm_Toolbars_Dock_Area_Right
            // 
            this._MainForm_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._MainForm_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._MainForm_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._MainForm_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._MainForm_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 4;
            resources.ApplyResources(this._MainForm_Toolbars_Dock_Area_Right, "_MainForm_Toolbars_Dock_Area_Right");
            this._MainForm_Toolbars_Dock_Area_Right.Name = "_MainForm_Toolbars_Dock_Area_Right";
            this._MainForm_Toolbars_Dock_Area_Right.ToolbarsManager = this.mainToolbarsManager;
            // 
            // _MainForm_Toolbars_Dock_Area_Top
            // 
            this._MainForm_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._MainForm_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._MainForm_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._MainForm_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this._MainForm_Toolbars_Dock_Area_Top, "_MainForm_Toolbars_Dock_Area_Top");
            this._MainForm_Toolbars_Dock_Area_Top.Name = "_MainForm_Toolbars_Dock_Area_Top";
            this._MainForm_Toolbars_Dock_Area_Top.ToolbarsManager = this.mainToolbarsManager;
            // 
            // _MainForm_Toolbars_Dock_Area_Bottom
            // 
            this._MainForm_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._MainForm_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._MainForm_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._MainForm_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._MainForm_Toolbars_Dock_Area_Bottom.InitialResizeAreaExtent = 4;
            resources.ApplyResources(this._MainForm_Toolbars_Dock_Area_Bottom, "_MainForm_Toolbars_Dock_Area_Bottom");
            this._MainForm_Toolbars_Dock_Area_Bottom.Name = "_MainForm_Toolbars_Dock_Area_Bottom";
            this._MainForm_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.mainToolbarsManager;
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.AllowNew = false;
            // 
            // mainToolbarsManager
            // 
            this.mainToolbarsManager.DesignerFlags = 1;
            this.mainToolbarsManager.DockWithinContainer = this;
            this.mainToolbarsManager.DockWithinContainerBaseType = typeof(System.Windows.Forms.Form);
            this.mainToolbarsManager.MiniToolbar.ToolRowCount = 1;
            buttonTool16.InstanceProps.IsFirstInGroup = true;
            this.mainToolbarsManager.Ribbon.ApplicationMenu.ToolAreaLeft.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool16});
            this.mainToolbarsManager.Ribbon.ApplicationMenuButtonImage = ((System.Drawing.Image)(resources.GetObject("resource.ApplicationMenuButtonImage")));
            this.mainToolbarsManager.Ribbon.Caption = "Smile Solution";
            resources.ApplyResources(ribbonTab1, "ribbonTab1");
            resources.ApplyResources(ribbonGroup1, "ribbonGroup1");
            resources.ApplyResources(ribbonGroup2, "ribbonGroup2");
            buttonTool17.InstanceProps.IsFirstInGroup = true;
            buttonTool17.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large;
            buttonTool18.InstanceProps.IsFirstInGroup = true;
            ribbonGroup2.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool17,
            buttonTool18});
            resources.ApplyResources(ribbonGroup3, "ribbonGroup3");
            ribbonTab1.Groups.AddRange(new Infragistics.Win.UltraWinToolbars.RibbonGroup[] {
            ribbonGroup1,
            ribbonGroup2,
            ribbonGroup3});
            resources.ApplyResources(ribbonTab2, "ribbonTab2");
            resources.ApplyResources(ribbonGroup4, "ribbonGroup4");
            ribbonTab2.Groups.AddRange(new Infragistics.Win.UltraWinToolbars.RibbonGroup[] {
            ribbonGroup4});
            resources.ApplyResources(ribbonTab3, "ribbonTab3");
            resources.ApplyResources(ribbonGroup5, "ribbonGroup5");
            appearance1.Image = ((object)(resources.GetObject("appearance1.Image")));
            buttonTool25.InstanceProps.AppearancesSmall.AppearanceOnRibbonGroup = appearance1;
            ribbonGroup5.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool25});
            ribbonTab3.Groups.AddRange(new Infragistics.Win.UltraWinToolbars.RibbonGroup[] {
            ribbonGroup5});
            this.mainToolbarsManager.Ribbon.NonInheritedRibbonTabs.AddRange(new Infragistics.Win.UltraWinToolbars.RibbonTab[] {
            ribbonTab1,
            ribbonTab2,
            ribbonTab3});
            this.mainToolbarsManager.Ribbon.QuickAccessToolbar.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            textBoxTool6});
            this.mainToolbarsManager.Ribbon.Visible = true;
            this.mainToolbarsManager.SaveSettings = true;
            this.mainToolbarsManager.SettingsKey = "MainForm.mainToolbarsManager";
            this.mainToolbarsManager.ShowFullMenusDelay = 500;
            this.mainToolbarsManager.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.WindowsVista;
            resources.ApplyResources(textBoxTool9.SharedPropsInternal, "textBoxTool9.SharedPropsInternal");
            textBoxTool9.ForceApplyResources = "SharedPropsInternal";
            appearance2.Image = ((object)(resources.GetObject("appearance2.Image")));
            buttonTool26.SharedPropsInternal.AppearancesLarge.Appearance = appearance2;
            appearance3.Image = ((object)(resources.GetObject("appearance3.Image")));
            buttonTool26.SharedPropsInternal.AppearancesSmall.Appearance = appearance3;
            resources.ApplyResources(buttonTool26.SharedPropsInternal, "buttonTool26.SharedPropsInternal");
            buttonTool26.SharedPropsInternal.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText;
            buttonTool26.ForceApplyResources = "SharedPropsInternal";
            appearance4.Image = ((object)(resources.GetObject("appearance4.Image")));
            buttonTool27.SharedPropsInternal.AppearancesLarge.Appearance = appearance4;
            appearance5.Image = ((object)(resources.GetObject("appearance5.Image")));
            buttonTool27.SharedPropsInternal.AppearancesSmall.Appearance = appearance5;
            resources.ApplyResources(buttonTool27.SharedPropsInternal, "buttonTool27.SharedPropsInternal");
            buttonTool27.ForceApplyResources = "SharedPropsInternal";
            appearance6.Image = ((object)(resources.GetObject("appearance6.Image")));
            buttonTool29.SharedPropsInternal.AppearancesLarge.Appearance = appearance6;
            appearance7.Image = ((object)(resources.GetObject("appearance7.Image")));
            buttonTool29.SharedPropsInternal.AppearancesSmall.Appearance = appearance7;
            resources.ApplyResources(buttonTool29.SharedPropsInternal, "buttonTool29.SharedPropsInternal");
            buttonTool29.ForceApplyResources = "SharedPropsInternal";
            resources.ApplyResources(buttonTool43.SharedPropsInternal, "buttonTool43.SharedPropsInternal");
            buttonTool43.ForceApplyResources = "SharedPropsInternal";
            this.mainToolbarsManager.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            textBoxTool9,
            buttonTool26,
            buttonTool27,
            buttonTool29,
            buttonTool43});
            this.mainToolbarsManager.UseLargeImagesOnMenu = true;
            this.mainToolbarsManager.UseLargeImagesOnToolbar = true;
            this.mainToolbarsManager.UseOsThemes = Infragistics.Win.DefaultableBoolean.True;
            this.mainToolbarsManager.ToolClick += new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(this.mainToolbarsManager_ToolClick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Left);
            this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Right);
            this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Top);
            this.Controls.Add(this._MainForm_Toolbars_Dock_Area_Bottom);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            ((System.Configuration.IPersistComponentSettings)(this.mainToolbarsManager)).LoadComponentSettings();
            ((System.ComponentModel.ISupportInitialize)(this.mainToolbarsManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource mainBindingSource;
        private ToolStripPanel leftPanel;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager mainToolbarsManager;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Left;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Right;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Top;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _MainForm_Toolbars_Dock_Area_Bottom;
    }
}