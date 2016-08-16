﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChSettingEnabled As System.Windows.Forms.ColumnHeader
        Dim ChSettingCommented As System.Windows.Forms.ColumnHeader
        Dim ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Dim ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenADMXFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenADMXFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseADMXWorkspaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindByIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmptyCategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeduplicatePoliciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.ComboAppliesTo = New System.Windows.Forms.ComboBox()
        Me.CategoriesTree = New System.Windows.Forms.TreeView()
        Me.PolicyIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.PoliciesList = New System.Windows.Forms.ListView()
        Me.ChSettingName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SettingInfoPanel = New System.Windows.Forms.Panel()
        Me.PolicyInfoTable = New System.Windows.Forms.TableLayoutPanel()
        Me.PolicyTitleLabel = New System.Windows.Forms.Label()
        Me.PolicySupportedLabel = New System.Windows.Forms.Label()
        Me.PolicyDescLabel = New System.Windows.Forms.Label()
        Me.PolicyIsPrefLabel = New System.Windows.Forms.Label()
        Me.OpenPolicyResourcesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavePoliciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        ChSettingEnabled = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        ChSettingCommented = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MainMenu.SuspendLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.SettingInfoPanel.SuspendLayout()
        Me.PolicyInfoTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChSettingEnabled
        '
        ChSettingEnabled.Text = "State"
        ChSettingEnabled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        ChSettingEnabled.Width = 107
        '
        'ChSettingCommented
        '
        ChSettingCommented.Text = "Comment"
        ChSettingCommented.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        ChSettingCommented.Width = 68
        '
        'ToolStripSeparator1
        '
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(706, 24)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenADMXFolderToolStripMenuItem, Me.OpenADMXFileToolStripMenuItem, Me.CloseADMXWorkspaceToolStripMenuItem, ToolStripSeparator2, Me.OpenPolicyResourcesToolStripMenuItem, Me.SavePoliciesToolStripMenuItem, ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenADMXFolderToolStripMenuItem
        '
        Me.OpenADMXFolderToolStripMenuItem.Name = "OpenADMXFolderToolStripMenuItem"
        Me.OpenADMXFolderToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.OpenADMXFolderToolStripMenuItem.Text = "Open ADMX Folder"
        '
        'OpenADMXFileToolStripMenuItem
        '
        Me.OpenADMXFileToolStripMenuItem.Name = "OpenADMXFileToolStripMenuItem"
        Me.OpenADMXFileToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.OpenADMXFileToolStripMenuItem.Text = "Open ADMX File"
        '
        'CloseADMXWorkspaceToolStripMenuItem
        '
        Me.CloseADMXWorkspaceToolStripMenuItem.Name = "CloseADMXWorkspaceToolStripMenuItem"
        Me.CloseADMXWorkspaceToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CloseADMXWorkspaceToolStripMenuItem.Text = "Close ADMX Workspace"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindByIDToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'FindByIDToolStripMenuItem
        '
        Me.FindByIDToolStripMenuItem.Name = "FindByIDToolStripMenuItem"
        Me.FindByIDToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.FindByIDToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.FindByIDToolStripMenuItem.Text = "Find by ID"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmptyCategoriesToolStripMenuItem, ToolStripSeparator1, Me.DeduplicatePoliciesToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'EmptyCategoriesToolStripMenuItem
        '
        Me.EmptyCategoriesToolStripMenuItem.Name = "EmptyCategoriesToolStripMenuItem"
        Me.EmptyCategoriesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EmptyCategoriesToolStripMenuItem.Text = "Empty Categories"
        '
        'DeduplicatePoliciesToolStripMenuItem
        '
        Me.DeduplicatePoliciesToolStripMenuItem.Name = "DeduplicatePoliciesToolStripMenuItem"
        Me.DeduplicatePoliciesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeduplicatePoliciesToolStripMenuItem.Text = "Deduplicate Policies"
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.ComboAppliesTo)
        Me.SplitContainer.Panel1.Controls.Add(Me.CategoriesTree)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer.Panel2.Controls.Add(Me.PoliciesList)
        Me.SplitContainer.Panel2.Controls.Add(Me.SettingInfoPanel)
        Me.SplitContainer.Size = New System.Drawing.Size(706, 350)
        Me.SplitContainer.SplitterDistance = 190
        Me.SplitContainer.TabIndex = 1
        '
        'ComboAppliesTo
        '
        Me.ComboAppliesTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboAppliesTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboAppliesTo.Items.AddRange(New Object() {"User or Computer", "User", "Computer"})
        Me.ComboAppliesTo.Location = New System.Drawing.Point(0, 0)
        Me.ComboAppliesTo.Name = "ComboAppliesTo"
        Me.ComboAppliesTo.Size = New System.Drawing.Size(190, 21)
        Me.ComboAppliesTo.TabIndex = 1
        '
        'CategoriesTree
        '
        Me.CategoriesTree.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CategoriesTree.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CategoriesTree.HideSelection = False
        Me.CategoriesTree.ImageIndex = 0
        Me.CategoriesTree.ImageList = Me.PolicyIcons
        Me.CategoriesTree.Location = New System.Drawing.Point(0, 19)
        Me.CategoriesTree.Name = "CategoriesTree"
        Me.CategoriesTree.SelectedImageIndex = 0
        Me.CategoriesTree.Size = New System.Drawing.Size(190, 331)
        Me.CategoriesTree.TabIndex = 0
        '
        'PolicyIcons
        '
        Me.PolicyIcons.ImageStream = CType(resources.GetObject("PolicyIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.PolicyIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.PolicyIcons.Images.SetKeyName(0, "folder.png")
        Me.PolicyIcons.Images.SetKeyName(1, "folder_error.png")
        Me.PolicyIcons.Images.SetKeyName(2, "folder_delete.png")
        Me.PolicyIcons.Images.SetKeyName(3, "folder_go.png")
        Me.PolicyIcons.Images.SetKeyName(4, "page_white.png")
        Me.PolicyIcons.Images.SetKeyName(5, "page_white_gear.png")
        Me.PolicyIcons.Images.SetKeyName(6, "arrow_up.png")
        Me.PolicyIcons.Images.SetKeyName(7, "page_white_error.png")
        Me.PolicyIcons.Images.SetKeyName(8, "delete.png")
        Me.PolicyIcons.Images.SetKeyName(9, "arrow_right.png")
        '
        'PoliciesList
        '
        Me.PoliciesList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PoliciesList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PoliciesList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChSettingName, ChSettingEnabled, ChSettingCommented})
        Me.PoliciesList.FullRowSelect = True
        Me.PoliciesList.Location = New System.Drawing.Point(190, 0)
        Me.PoliciesList.MultiSelect = False
        Me.PoliciesList.Name = "PoliciesList"
        Me.PoliciesList.Size = New System.Drawing.Size(322, 350)
        Me.PoliciesList.SmallImageList = Me.PolicyIcons
        Me.PoliciesList.TabIndex = 1
        Me.PoliciesList.UseCompatibleStateImageBehavior = False
        Me.PoliciesList.View = System.Windows.Forms.View.Details
        '
        'ChSettingName
        '
        Me.ChSettingName.Text = "Name"
        Me.ChSettingName.Width = 116
        '
        'SettingInfoPanel
        '
        Me.SettingInfoPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SettingInfoPanel.AutoScroll = True
        Me.SettingInfoPanel.Controls.Add(Me.PolicyInfoTable)
        Me.SettingInfoPanel.Location = New System.Drawing.Point(0, 0)
        Me.SettingInfoPanel.Name = "SettingInfoPanel"
        Me.SettingInfoPanel.Size = New System.Drawing.Size(184, 350)
        Me.SettingInfoPanel.TabIndex = 0
        '
        'PolicyInfoTable
        '
        Me.PolicyInfoTable.AutoSize = True
        Me.PolicyInfoTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PolicyInfoTable.ColumnCount = 1
        Me.PolicyInfoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 706.0!))
        Me.PolicyInfoTable.Controls.Add(Me.PolicyTitleLabel, 0, 0)
        Me.PolicyInfoTable.Controls.Add(Me.PolicySupportedLabel, 0, 1)
        Me.PolicyInfoTable.Controls.Add(Me.PolicyDescLabel, 0, 3)
        Me.PolicyInfoTable.Controls.Add(Me.PolicyIsPrefLabel, 0, 2)
        Me.PolicyInfoTable.Location = New System.Drawing.Point(0, 0)
        Me.PolicyInfoTable.Name = "PolicyInfoTable"
        Me.PolicyInfoTable.RowCount = 4
        Me.PolicyInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PolicyInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PolicyInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PolicyInfoTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PolicyInfoTable.Size = New System.Drawing.Size(706, 124)
        Me.PolicyInfoTable.TabIndex = 0
        '
        'PolicyTitleLabel
        '
        Me.PolicyTitleLabel.AutoSize = True
        Me.PolicyTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PolicyTitleLabel.Location = New System.Drawing.Point(3, 0)
        Me.PolicyTitleLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 24)
        Me.PolicyTitleLabel.Name = "PolicyTitleLabel"
        Me.PolicyTitleLabel.Size = New System.Drawing.Size(66, 13)
        Me.PolicyTitleLabel.TabIndex = 0
        Me.PolicyTitleLabel.Text = "Policy title"
        '
        'PolicySupportedLabel
        '
        Me.PolicySupportedLabel.AutoSize = True
        Me.PolicySupportedLabel.Location = New System.Drawing.Point(3, 37)
        Me.PolicySupportedLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 24)
        Me.PolicySupportedLabel.Name = "PolicySupportedLabel"
        Me.PolicySupportedLabel.Size = New System.Drawing.Size(72, 13)
        Me.PolicySupportedLabel.TabIndex = 1
        Me.PolicySupportedLabel.Text = "Requirements"
        '
        'PolicyDescLabel
        '
        Me.PolicyDescLabel.AutoSize = True
        Me.PolicyDescLabel.Location = New System.Drawing.Point(3, 111)
        Me.PolicyDescLabel.Name = "PolicyDescLabel"
        Me.PolicyDescLabel.Size = New System.Drawing.Size(89, 13)
        Me.PolicyDescLabel.TabIndex = 2
        Me.PolicyDescLabel.Text = "Policy description"
        '
        'PolicyIsPrefLabel
        '
        Me.PolicyIsPrefLabel.AutoSize = True
        Me.PolicyIsPrefLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.PolicyIsPrefLabel.Location = New System.Drawing.Point(3, 74)
        Me.PolicyIsPrefLabel.Margin = New System.Windows.Forms.Padding(3, 0, 3, 24)
        Me.PolicyIsPrefLabel.Name = "PolicyIsPrefLabel"
        Me.PolicyIsPrefLabel.Size = New System.Drawing.Size(700, 13)
        Me.PolicyIsPrefLabel.TabIndex = 3
        Me.PolicyIsPrefLabel.Text = "Because it is not stored in a Policies section of the Registry, this policy is a " &
    "preference and will not be automatically undone if the setting is removed."
        '
        'ToolStripSeparator2
        '
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New System.Drawing.Size(198, 6)
        '
        'OpenPolicyResourcesToolStripMenuItem
        '
        Me.OpenPolicyResourcesToolStripMenuItem.Name = "OpenPolicyResourcesToolStripMenuItem"
        Me.OpenPolicyResourcesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.OpenPolicyResourcesToolStripMenuItem.Text = "Open Policy Resources"
        '
        'ToolStripSeparator3
        '
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New System.Drawing.Size(198, 6)
        '
        'SavePoliciesToolStripMenuItem
        '
        Me.SavePoliciesToolStripMenuItem.Name = "SavePoliciesToolStripMenuItem"
        Me.SavePoliciesToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SavePoliciesToolStripMenuItem.Text = "Save Policies"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 374)
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.MainMenu)
        Me.MainMenuStrip = Me.MainMenu
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.Text = "Policy Plus"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        Me.SettingInfoPanel.ResumeLayout(False)
        Me.SettingInfoPanel.PerformLayout()
        Me.PolicyInfoTable.ResumeLayout(False)
        Me.PolicyInfoTable.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenADMXFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenADMXFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseADMXWorkspaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer As SplitContainer
    Friend WithEvents CategoriesTree As TreeView
    Friend WithEvents PoliciesList As ListView
    Friend WithEvents SettingInfoPanel As Panel
    Friend WithEvents PolicyIcons As ImageList
    Friend WithEvents PolicyInfoTable As TableLayoutPanel
    Friend WithEvents PolicyTitleLabel As Label
    Friend WithEvents PolicySupportedLabel As Label
    Friend WithEvents PolicyDescLabel As Label
    Friend WithEvents ChSettingName As ColumnHeader
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmptyCategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboAppliesTo As ComboBox
    Friend WithEvents PolicyIsPrefLabel As Label
    Friend WithEvents DeduplicatePoliciesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindByIDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenPolicyResourcesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SavePoliciesToolStripMenuItem As ToolStripMenuItem
End Class
