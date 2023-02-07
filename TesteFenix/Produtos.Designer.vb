<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produtos
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
        Me.CategoriaList = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CreateBtn = New System.Windows.Forms.Button()
        Me.RemoverBtn = New System.Windows.Forms.Button()
        Me.EditarBtn = New System.Windows.Forms.Button()
        Me.IdCategoriaLabel = New System.Windows.Forms.TextBox()
        Me.IdCategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.InserirCategoriaBtn = New System.Windows.Forms.Button()
        Me.NovaCategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.RemoverCategoriaBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoriaList
        '
        Me.CategoriaList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CategoriaList.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CategoriaList.FormattingEnabled = True
        Me.CategoriaList.ItemHeight = 21
        Me.CategoriaList.Location = New System.Drawing.Point(110, 84)
        Me.CategoriaList.Name = "CategoriaList"
        Me.CategoriaList.Size = New System.Drawing.Size(189, 273)
        Me.CategoriaList.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(371, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(390, 31)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Controle de Produtos"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CreateBtn
        '
        Me.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateBtn.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CreateBtn.ForeColor = System.Drawing.Color.White
        Me.CreateBtn.Location = New System.Drawing.Point(356, 309)
        Me.CreateBtn.Name = "CreateBtn"
        Me.CreateBtn.Size = New System.Drawing.Size(220, 48)
        Me.CreateBtn.TabIndex = 2
        Me.CreateBtn.Text = "Inserir Produto"
        Me.CreateBtn.UseVisualStyleBackColor = True
        '
        'RemoverBtn
        '
        Me.RemoverBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoverBtn.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RemoverBtn.ForeColor = System.Drawing.Color.White
        Me.RemoverBtn.Location = New System.Drawing.Point(604, 309)
        Me.RemoverBtn.Name = "RemoverBtn"
        Me.RemoverBtn.Size = New System.Drawing.Size(228, 48)
        Me.RemoverBtn.TabIndex = 3
        Me.RemoverBtn.Text = "Remover Produto"
        Me.RemoverBtn.UseVisualStyleBackColor = True
        '
        'EditarBtn
        '
        Me.EditarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditarBtn.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EditarBtn.ForeColor = System.Drawing.Color.White
        Me.EditarBtn.Location = New System.Drawing.Point(857, 309)
        Me.EditarBtn.Name = "EditarBtn"
        Me.EditarBtn.Size = New System.Drawing.Size(175, 48)
        Me.EditarBtn.TabIndex = 4
        Me.EditarBtn.Text = "Editar Produto"
        Me.EditarBtn.UseVisualStyleBackColor = True
        '
        'IdCategoriaLabel
        '
        Me.IdCategoriaLabel.BackColor = System.Drawing.Color.LightSkyBlue
        Me.IdCategoriaLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IdCategoriaLabel.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.IdCategoriaLabel.ForeColor = System.Drawing.Color.White
        Me.IdCategoriaLabel.Location = New System.Drawing.Point(371, 84)
        Me.IdCategoriaLabel.Name = "IdCategoriaLabel"
        Me.IdCategoriaLabel.ReadOnly = True
        Me.IdCategoriaLabel.Size = New System.Drawing.Size(194, 21)
        Me.IdCategoriaLabel.TabIndex = 5
        Me.IdCategoriaLabel.Text = "Id Categoria"
        Me.IdCategoriaLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IdCategoriaTextBox
        '
        Me.IdCategoriaTextBox.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IdCategoriaTextBox.Location = New System.Drawing.Point(364, 111)
        Me.IdCategoriaTextBox.Multiline = True
        Me.IdCategoriaTextBox.Name = "IdCategoriaTextBox"
        Me.IdCategoriaTextBox.Size = New System.Drawing.Size(211, 35)
        Me.IdCategoriaTextBox.TabIndex = 6
        Me.IdCategoriaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(55, 427)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1019, 205)
        Me.DataGridView1.TabIndex = 19
        '
        'InserirCategoriaBtn
        '
        Me.InserirCategoriaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InserirCategoriaBtn.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.InserirCategoriaBtn.ForeColor = System.Drawing.Color.White
        Me.InserirCategoriaBtn.Location = New System.Drawing.Point(811, 192)
        Me.InserirCategoriaBtn.Name = "InserirCategoriaBtn"
        Me.InserirCategoriaBtn.Size = New System.Drawing.Size(231, 48)
        Me.InserirCategoriaBtn.TabIndex = 20
        Me.InserirCategoriaBtn.Text = "Inserir Categoria"
        Me.InserirCategoriaBtn.UseVisualStyleBackColor = True
        '
        'NovaCategoriaTextBox
        '
        Me.NovaCategoriaTextBox.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NovaCategoriaTextBox.Location = New System.Drawing.Point(821, 111)
        Me.NovaCategoriaTextBox.Multiline = True
        Me.NovaCategoriaTextBox.Name = "NovaCategoriaTextBox"
        Me.NovaCategoriaTextBox.Size = New System.Drawing.Size(211, 35)
        Me.NovaCategoriaTextBox.TabIndex = 21
        Me.NovaCategoriaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(821, 84)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(211, 21)
        Me.TextBox3.TabIndex = 22
        Me.TextBox3.Text = "Nova Categoria"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RemoverCategoriaBtn
        '
        Me.RemoverCategoriaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoverCategoriaBtn.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RemoverCategoriaBtn.ForeColor = System.Drawing.Color.White
        Me.RemoverCategoriaBtn.Location = New System.Drawing.Point(356, 192)
        Me.RemoverCategoriaBtn.Name = "RemoverCategoriaBtn"
        Me.RemoverCategoriaBtn.Size = New System.Drawing.Size(228, 48)
        Me.RemoverCategoriaBtn.TabIndex = 23
        Me.RemoverCategoriaBtn.Text = "Remover Categoria"
        Me.RemoverCategoriaBtn.UseVisualStyleBackColor = True
        '
        'Produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1115, 868)
        Me.Controls.Add(Me.RemoverCategoriaBtn)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.NovaCategoriaTextBox)
        Me.Controls.Add(Me.InserirCategoriaBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.IdCategoriaTextBox)
        Me.Controls.Add(Me.IdCategoriaLabel)
        Me.Controls.Add(Me.EditarBtn)
        Me.Controls.Add(Me.RemoverBtn)
        Me.Controls.Add(Me.CreateBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CategoriaList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Produtos"
        Me.Text = "Produtos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CategoriaList As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CreateBtn As Button
    Friend WithEvents RemoverBtn As Button
    Friend WithEvents EditarBtn As Button
    Friend WithEvents IdCategoriaLabel As TextBox
    Friend WithEvents IdCategoriaTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents InserirCategoriaBtn As Button
    Friend WithEvents NovaCategoriaTextBox As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RemoverCategoriaBtn As Button
End Class
