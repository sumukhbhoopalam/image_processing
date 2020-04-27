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
        Me.Original = New System.Windows.Forms.PictureBox()
        Me.Result = New System.Windows.Forms.PictureBox()
        Me.btnopen = New System.Windows.Forms.Button()
        Me.btngray = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.Original, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Result, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Original
        '
        Me.Original.Location = New System.Drawing.Point(82, 43)
        Me.Original.Name = "Original"
        Me.Original.Size = New System.Drawing.Size(267, 241)
        Me.Original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Original.TabIndex = 0
        Me.Original.TabStop = False
        '
        'Result
        '
        Me.Result.Location = New System.Drawing.Point(438, 43)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(267, 241)
        Me.Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Result.TabIndex = 1
        Me.Result.TabStop = False
        '
        'btnopen
        '
        Me.btnopen.Location = New System.Drawing.Point(165, 345)
        Me.btnopen.Name = "btnopen"
        Me.btnopen.Size = New System.Drawing.Size(101, 42)
        Me.btnopen.TabIndex = 2
        Me.btnopen.Text = "open"
        Me.btnopen.UseVisualStyleBackColor = True
        '
        'btngray
        '
        Me.btngray.Location = New System.Drawing.Point(384, 340)
        Me.btngray.Name = "btngray"
        Me.btngray.Size = New System.Drawing.Size(101, 42)
        Me.btngray.TabIndex = 3
        Me.btngray.Text = "gray"
        Me.btngray.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(510, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 37)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Negative"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(639, 343)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 37)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Flip"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 10
        Me.TrackBar1.Location = New System.Drawing.Point(471, 406)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(190, 45)
        Me.TrackBar1.SmallChange = 5
        Me.TrackBar1.TabIndex = 6
        Me.TrackBar1.TickFrequency = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(512, 295)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 42)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Crop"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btngray)
        Me.Controls.Add(Me.btnopen)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Original)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Name = "Form1"
        Me.Text = "Image Processing"
        CType(Me.Original, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Result, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Original As PictureBox
    Friend WithEvents Result As PictureBox
    Friend WithEvents btnopen As Button
    Friend WithEvents btngray As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Button3 As Button
End Class
