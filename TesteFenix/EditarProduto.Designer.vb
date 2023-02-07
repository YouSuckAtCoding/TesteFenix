<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarProduto
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
        Me.EditarProdutoBtn = New System.Windows.Forms.Button()
        Me.EscolherImagem = New System.Windows.Forms.Button()
        Me.ImagemLabel = New System.Windows.Forms.TextBox()
        Me.ImageBox = New System.Windows.Forms.PictureBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.PrecoTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.CategoriaTextBox = New System.Windows.Forms.TextBox()
        Me.CategoriaLabel = New System.Windows.Forms.TextBox()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.DescricaoLabel = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NomeLabel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EditarProdutoBtn
        '
        Me.EditarProdutoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditarProdutoBtn.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EditarProdutoBtn.ForeColor = System.Drawing.Color.White
        Me.EditarProdutoBtn.Location = New System.Drawing.Point(506, 386)
        Me.EditarProdutoBtn.Name = "EditarProdutoBtn"
        Me.EditarProdutoBtn.Size = New System.Drawing.Size(247, 68)
        Me.EditarProdutoBtn.TabIndex = 49
        Me.EditarProdutoBtn.Text = "Editar Produto"
        Me.EditarProdutoBtn.UseVisualStyleBackColor = True
        '
        'EscolherImagem
        '
        Me.EscolherImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EscolherImagem.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EscolherImagem.ForeColor = System.Drawing.Color.White
        Me.EscolherImagem.Location = New System.Drawing.Point(924, 321)
        Me.EscolherImagem.Name = "EscolherImagem"
        Me.EscolherImagem.Size = New System.Drawing.Size(183, 36)
        Me.EscolherImagem.TabIndex = 48
        Me.EscolherImagem.Text = "Escolher Imagem"
        Me.EscolherImagem.UseVisualStyleBackColor = True
        '
        'ImagemLabel
        '
        Me.ImagemLabel.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ImagemLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ImagemLabel.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ImagemLabel.ForeColor = System.Drawing.Color.White
        Me.ImagemLabel.Location = New System.Drawing.Point(941, 117)
        Me.ImagemLabel.Name = "ImagemLabel"
        Me.ImagemLabel.ReadOnly = True
        Me.ImagemLabel.Size = New System.Drawing.Size(125, 21)
        Me.ImagemLabel.TabIndex = 47
        Me.ImagemLabel.Text = "Imagem"
        Me.ImagemLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ImageBox
        '
        Me.ImageBox.Location = New System.Drawing.Point(822, 158)
        Me.ImageBox.Name = "ImageBox"
        Me.ImageBox.Size = New System.Drawing.Size(380, 152)
        Me.ImageBox.TabIndex = 46
        Me.ImageBox.TabStop = False
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.Location = New System.Drawing.Point(94, 353)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(266, 38)
        Me.MarcaTextBox.TabIndex = 45
        Me.MarcaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(85, 326)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(275, 21)
        Me.TextBox5.TabIndex = 44
        Me.TextBox5.Text = "Marca"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrecoTextBox
        '
        Me.PrecoTextBox.Location = New System.Drawing.Point(94, 278)
        Me.PrecoTextBox.Name = "PrecoTextBox"
        Me.PrecoTextBox.Size = New System.Drawing.Size(266, 38)
        Me.PrecoTextBox.TabIndex = 43
        Me.PrecoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(85, 251)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(275, 21)
        Me.TextBox3.TabIndex = 42
        Me.TextBox3.Text = "Preço"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CategoriaTextBox
        '
        Me.CategoriaTextBox.Location = New System.Drawing.Point(97, 198)
        Me.CategoriaTextBox.Name = "CategoriaTextBox"
        Me.CategoriaTextBox.Size = New System.Drawing.Size(263, 38)
        Me.CategoriaTextBox.TabIndex = 41
        Me.CategoriaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CategoriaLabel
        '
        Me.CategoriaLabel.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CategoriaLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CategoriaLabel.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CategoriaLabel.ForeColor = System.Drawing.Color.White
        Me.CategoriaLabel.Location = New System.Drawing.Point(85, 171)
        Me.CategoriaLabel.Name = "CategoriaLabel"
        Me.CategoriaLabel.ReadOnly = True
        Me.CategoriaLabel.Size = New System.Drawing.Size(275, 21)
        Me.CategoriaLabel.TabIndex = 40
        Me.CategoriaLabel.Text = "Categoria"
        Me.CategoriaLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.Location = New System.Drawing.Point(425, 169)
        Me.DescricaoTextBox.Multiline = True
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.Size = New System.Drawing.Size(348, 144)
        Me.DescricaoTextBox.TabIndex = 39
        '
        'DescricaoLabel
        '
        Me.DescricaoLabel.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DescricaoLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescricaoLabel.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DescricaoLabel.ForeColor = System.Drawing.Color.White
        Me.DescricaoLabel.Location = New System.Drawing.Point(506, 142)
        Me.DescricaoLabel.Name = "DescricaoLabel"
        Me.DescricaoLabel.ReadOnly = True
        Me.DescricaoLabel.Size = New System.Drawing.Size(155, 21)
        Me.DescricaoLabel.TabIndex = 38
        Me.DescricaoLabel.Text = "Descrição"
        Me.DescricaoLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(94, 126)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(263, 38)
        Me.NameTextBox.TabIndex = 37
        Me.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NomeLabel
        '
        Me.NomeLabel.BackColor = System.Drawing.Color.LightSkyBlue
        Me.NomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NomeLabel.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NomeLabel.ForeColor = System.Drawing.Color.White
        Me.NomeLabel.Location = New System.Drawing.Point(97, 99)
        Me.NomeLabel.Name = "NomeLabel"
        Me.NomeLabel.ReadOnly = True
        Me.NomeLabel.Size = New System.Drawing.Size(245, 21)
        Me.NomeLabel.TabIndex = 36
        Me.NomeLabel.Text = "Nome"
        Me.NomeLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(478, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 32)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Editar Produto"
        '
        'EditarProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1283, 546)
        Me.Controls.Add(Me.EditarProdutoBtn)
        Me.Controls.Add(Me.EscolherImagem)
        Me.Controls.Add(Me.ImagemLabel)
        Me.Controls.Add(Me.ImageBox)
        Me.Controls.Add(Me.MarcaTextBox)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.PrecoTextBox)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.CategoriaTextBox)
        Me.Controls.Add(Me.CategoriaLabel)
        Me.Controls.Add(Me.DescricaoTextBox)
        Me.Controls.Add(Me.DescricaoLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.NomeLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.MaximizeBox = False
        Me.Name = "EditarProduto"
        Me.Text = "Editar Produto"
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EditarProdutoBtn As Button
    Friend WithEvents EscolherImagem As Button
    Friend WithEvents ImagemLabel As TextBox
    Friend WithEvents ImageBox As PictureBox
    Friend WithEvents MarcaTextBox As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PrecoTextBox As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents CategoriaTextBox As TextBox
    Friend WithEvents CategoriaLabel As TextBox
    Friend WithEvents DescricaoTextBox As TextBox
    Friend WithEvents DescricaoLabel As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NomeLabel As TextBox
    Friend WithEvents Label1 As Label
End Class
