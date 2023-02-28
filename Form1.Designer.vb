<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grpSelectType = New System.Windows.Forms.GroupBox()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.radAutographs = New System.Windows.Forms.RadioButton()
        Me.radSuperhero = New System.Windows.Forms.RadioButton()
        Me.picComic = New System.Windows.Forms.PictureBox()
        Me.lblTitleReg = New System.Windows.Forms.Label()
        Me.lblGrpSize = New System.Windows.Forms.Label()
        Me.txtGrpSize = New System.Windows.Forms.TextBox()
        Me.lblRegCost = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpSelectType.SuspendLayout()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSelectType
        '
        Me.grpSelectType.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.grpSelectType.Controls.Add(Me.radConvention)
        Me.grpSelectType.Controls.Add(Me.radAutographs)
        Me.grpSelectType.Controls.Add(Me.radSuperhero)
        Me.grpSelectType.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelectType.ForeColor = System.Drawing.Color.Chocolate
        Me.grpSelectType.Location = New System.Drawing.Point(96, 355)
        Me.grpSelectType.Name = "grpSelectType"
        Me.grpSelectType.Size = New System.Drawing.Size(493, 137)
        Me.grpSelectType.TabIndex = 0
        Me.grpSelectType.TabStop = False
        Me.grpSelectType.Text = "Select Badge Type:"
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConvention.Location = New System.Drawing.Point(26, 97)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(160, 28)
        Me.radConvention.TabIndex = 2
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'radAutographs
        '
        Me.radAutographs.AutoSize = True
        Me.radAutographs.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAutographs.Location = New System.Drawing.Point(26, 63)
        Me.radAutographs.Name = "radAutographs"
        Me.radAutographs.Size = New System.Drawing.Size(317, 28)
        Me.radAutographs.TabIndex = 1
        Me.radAutographs.TabStop = True
        Me.radAutographs.Text = "Convention + Autographs"
        Me.radAutographs.UseVisualStyleBackColor = True
        '
        'radSuperhero
        '
        Me.radSuperhero.AutoSize = True
        Me.radSuperhero.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSuperhero.Location = New System.Drawing.Point(26, 29)
        Me.radSuperhero.Name = "radSuperhero"
        Me.radSuperhero.Size = New System.Drawing.Size(440, 28)
        Me.radSuperhero.TabIndex = 0
        Me.radSuperhero.TabStop = True
        Me.radSuperhero.Text = "Convention + Superhero Experience"
        Me.radSuperhero.UseVisualStyleBackColor = True
        '
        'picComic
        '
        Me.picComic.Image = Global.ComicConvention.My.Resources.Resources.comic
        Me.picComic.Location = New System.Drawing.Point(-1, -2)
        Me.picComic.Name = "picComic"
        Me.picComic.Size = New System.Drawing.Size(686, 189)
        Me.picComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComic.TabIndex = 1
        Me.picComic.TabStop = False
        '
        'lblTitleReg
        '
        Me.lblTitleReg.AutoSize = True
        Me.lblTitleReg.Font = New System.Drawing.Font("Comic Sans MS", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleReg.ForeColor = System.Drawing.Color.Chocolate
        Me.lblTitleReg.Location = New System.Drawing.Point(43, 210)
        Me.lblTitleReg.Name = "lblTitleReg"
        Me.lblTitleReg.Size = New System.Drawing.Size(599, 55)
        Me.lblTitleReg.TabIndex = 2
        Me.lblTitleReg.Text = "Comic Convention Registration"
        '
        'lblGrpSize
        '
        Me.lblGrpSize.AutoSize = True
        Me.lblGrpSize.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrpSize.ForeColor = System.Drawing.Color.Chocolate
        Me.lblGrpSize.Location = New System.Drawing.Point(189, 295)
        Me.lblGrpSize.Name = "lblGrpSize"
        Me.lblGrpSize.Size = New System.Drawing.Size(152, 27)
        Me.lblGrpSize.TabIndex = 3
        Me.lblGrpSize.Text = "Group Size:"
        '
        'txtGrpSize
        '
        Me.txtGrpSize.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrpSize.ForeColor = System.Drawing.Color.Chocolate
        Me.txtGrpSize.Location = New System.Drawing.Point(396, 292)
        Me.txtGrpSize.MaxLength = 2
        Me.txtGrpSize.Name = "txtGrpSize"
        Me.txtGrpSize.Size = New System.Drawing.Size(71, 35)
        Me.txtGrpSize.TabIndex = 1
        Me.txtGrpSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRegCost
        '
        Me.lblRegCost.AutoSize = True
        Me.lblRegCost.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegCost.ForeColor = System.Drawing.Color.Chocolate
        Me.lblRegCost.Location = New System.Drawing.Point(117, 529)
        Me.lblRegCost.Name = "lblRegCost"
        Me.lblRegCost.Size = New System.Drawing.Size(232, 27)
        Me.lblRegCost.TabIndex = 5
        Me.lblRegCost.Text = "Registration Cost:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.ForeColor = System.Drawing.Color.Chocolate
        Me.lblTotalCost.Location = New System.Drawing.Point(408, 529)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(154, 27)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "$X,XXX.XX"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(82, 589)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(166, 40)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseCompatibleTextRendering = True
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(423, 589)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(166, 40)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblRegCost)
        Me.Controls.Add(Me.txtGrpSize)
        Me.Controls.Add(Me.lblGrpSize)
        Me.Controls.Add(Me.lblTitleReg)
        Me.Controls.Add(Me.picComic)
        Me.Controls.Add(Me.grpSelectType)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comic Convention Registration"
        Me.grpSelectType.ResumeLayout(False)
        Me.grpSelectType.PerformLayout()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSelectType As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutographs As RadioButton
    Friend WithEvents radSuperhero As RadioButton
    Friend WithEvents picComic As PictureBox
    Friend WithEvents lblTitleReg As Label
    Friend WithEvents lblGrpSize As Label
    Friend WithEvents txtGrpSize As TextBox
    Friend WithEvents lblRegCost As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
