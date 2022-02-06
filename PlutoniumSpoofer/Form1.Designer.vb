Imports System.Threading

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListWriteBox = New MetroSet_UI.Controls.MetroSetListBox()
        Me.MetroSetComboBox1 = New MetroSet_UI.Controls.MetroSetComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(418, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.TabStop = False
        Me.Button1.Text = "Spoof"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(473, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.TabStop = False
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(484, 108)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LOADING"
        '
        'ListWriteBox
        '
        Me.ListWriteBox.AllowDrop = True
        Me.ListWriteBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListWriteBox.BorderColor = System.Drawing.Color.Transparent
        Me.ListWriteBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.ListWriteBox.DisabledBackColor = System.Drawing.Color.Transparent
        Me.ListWriteBox.DisabledForeColor = System.Drawing.Color.Transparent
        Me.ListWriteBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListWriteBox.HoveredItemBackColor = System.Drawing.Color.Transparent
        Me.ListWriteBox.HoveredItemColor = System.Drawing.Color.Transparent
        Me.ListWriteBox.IsDerivedStyle = False
        Me.ListWriteBox.ItemHeight = 30
        Me.ListWriteBox.Location = New System.Drawing.Point(0, 3)
        Me.ListWriteBox.MultiSelect = False
        Me.ListWriteBox.Name = "ListWriteBox"
        Me.ListWriteBox.SelectedIndex = -1
        Me.ListWriteBox.SelectedItem = Nothing
        Me.ListWriteBox.SelectedItemBackColor = System.Drawing.Color.Transparent
        Me.ListWriteBox.SelectedItemColor = System.Drawing.Color.Transparent
        Me.ListWriteBox.SelectedText = Nothing
        Me.ListWriteBox.SelectedValue = Nothing
        Me.ListWriteBox.ShowBorder = False
        Me.ListWriteBox.ShowScrollBar = True
        Me.ListWriteBox.Size = New System.Drawing.Size(446, 281)
        Me.ListWriteBox.Style = MetroSet_UI.Enums.Style.Custom
        Me.ListWriteBox.StyleManager = Nothing
        Me.ListWriteBox.TabIndex = 5
        Me.ListWriteBox.TabStop = False
        Me.ListWriteBox.ThemeAuthor = "Narwin"
        Me.ListWriteBox.ThemeName = "MetroDark"
        '
        'MetroSetComboBox1
        '
        Me.MetroSetComboBox1.AllowDrop = True
        Me.MetroSetComboBox1.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MetroSetComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.MetroSetComboBox1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.MetroSetComboBox1.BorderColor = System.Drawing.Color.Transparent
        Me.MetroSetComboBox1.CausesValidation = False
        Me.MetroSetComboBox1.DisabledBackColor = System.Drawing.Color.Transparent
        Me.MetroSetComboBox1.DisabledBorderColor = System.Drawing.Color.Transparent
        Me.MetroSetComboBox1.DisabledForeColor = System.Drawing.Color.Transparent
        Me.MetroSetComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.MetroSetComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MetroSetComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.MetroSetComboBox1.FormattingEnabled = True
        Me.MetroSetComboBox1.IsDerivedStyle = False
        Me.MetroSetComboBox1.ItemHeight = 20
        Me.MetroSetComboBox1.Location = New System.Drawing.Point(12, 304)
        Me.MetroSetComboBox1.Name = "MetroSetComboBox1"
        Me.MetroSetComboBox1.SelectedItemBackColor = System.Drawing.Color.Transparent
        Me.MetroSetComboBox1.SelectedItemForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.MetroSetComboBox1.Size = New System.Drawing.Size(400, 26)
        Me.MetroSetComboBox1.Style = MetroSet_UI.Enums.Style.Custom
        Me.MetroSetComboBox1.StyleManager = Nothing
        Me.MetroSetComboBox1.TabIndex = 6
        Me.MetroSetComboBox1.TabStop = False
        Me.MetroSetComboBox1.ThemeAuthor = "Narwin"
        Me.MetroSetComboBox1.ThemeName = "MetroDark"
        Me.MetroSetComboBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(516, 347)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroSetComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListWriteBox)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plutonium Spoofer"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListWriteBox As MetroSet_UI.Controls.MetroSetListBox
    Friend WithEvents MetroSetComboBox1 As MetroSet_UI.Controls.MetroSetComboBox
End Class
