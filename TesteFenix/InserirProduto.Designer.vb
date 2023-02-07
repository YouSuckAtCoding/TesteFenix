<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InserirProduto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImagemLabel = New System.Windows.Forms.TextBox()
        Me.ImageBox = New System.Windows.Forms.PictureBox()
        Me.MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.PrecoTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.CategoriaLabel = New System.Windows.Forms.TextBox()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.DescricaoLabel = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NomeLabel = New System.Windows.Forms.TextBox()
        Me.EscolherImagem = New System.Windows.Forms.Button()
        Me.CriarProdutoBtn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CategoriaCmb = New System.Windows.Forms.ComboBox()
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(397, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inserir Novo Produto"
        '
        'ImagemLabel
        '
        Me.ImagemLabel.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ImagemLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ImagemLabel.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ImagemLabel.ForeColor = System.Drawing.Color.White
        Me.ImagemLabel.Location = New System.Drawing.Point(895, 84)
        Me.ImagemLabel.Name = "ImagemLabel"
        Me.ImagemLabel.ReadOnly = True
        Me.ImagemLabel.Size = New System.Drawing.Size(125, 21)
        Me.ImagemLabel.TabIndex = 32
        Me.ImagemLabel.Text = "Imagem"
        Me.ImagemLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ImageBox
        '
        Me.ImageBox.Location = New System.Drawing.Point(776, 125)
        Me.ImageBox.Name = "ImageBox"
        Me.ImageBox.Size = New System.Drawing.Size(380, 152)
        Me.ImageBox.TabIndex = 31
        Me.ImageBox.TabStop = False
        '
        'MarcaTextBox
        '
        Me.MarcaTextBox.Location = New System.Drawing.Point(48, 320)
        Me.MarcaTextBox.Name = "MarcaTextBox"
        Me.MarcaTextBox.Size = New System.Drawing.Size(266, 27)
        Me.MarcaTextBox.TabIndex = 30
        Me.MarcaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(39, 293)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(275, 21)
        Me.TextBox5.TabIndex = 29
        Me.TextBox5.Text = "Marca"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PrecoTextBox
        '
        Me.PrecoTextBox.Location = New System.Drawing.Point(48, 245)
        Me.PrecoTextBox.Name = "PrecoTextBox"
        Me.PrecoTextBox.Size = New System.Drawing.Size(266, 27)
        Me.PrecoTextBox.TabIndex = 28
        Me.PrecoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(39, 218)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(275, 21)
        Me.TextBox3.TabIndex = 27
        Me.TextBox3.Text = "Preço"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CategoriaLabel
        '
        Me.CategoriaLabel.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CategoriaLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CategoriaLabel.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CategoriaLabel.ForeColor = System.Drawing.Color.White
        Me.CategoriaLabel.Location = New System.Drawing.Point(39, 138)
        Me.CategoriaLabel.Name = "CategoriaLabel"
        Me.CategoriaLabel.ReadOnly = True
        Me.CategoriaLabel.Size = New System.Drawing.Size(275, 21)
        Me.CategoriaLabel.TabIndex = 25
        Me.CategoriaLabel.Text = "Categoria"
        Me.CategoriaLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.Location = New System.Drawing.Point(379, 136)
        Me.DescricaoTextBox.Multiline = True
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.Size = New System.Drawing.Size(348, 144)
        Me.DescricaoTextBox.TabIndex = 24
        '
        'DescricaoLabel
        '
        Me.DescricaoLabel.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DescricaoLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescricaoLabel.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DescricaoLabel.ForeColor = System.Drawing.Color.White
        Me.DescricaoLabel.Location = New System.Drawing.Point(460, 109)
        Me.DescricaoLabel.Name = "DescricaoLabel"
        Me.DescricaoLabel.ReadOnly = True
        Me.DescricaoLabel.Size = New System.Drawing.Size(155, 21)
        Me.DescricaoLabel.TabIndex = 23
        Me.DescricaoLabel.Text = "Descrição"
        Me.DescricaoLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(48, 93)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(263, 27)
        Me.NameTextBox.TabIndex = 20
        Me.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NomeLabel
        '
        Me.NomeLabel.BackColor = System.Drawing.Color.LightSkyBlue
        Me.NomeLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NomeLabel.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NomeLabel.ForeColor = System.Drawing.Color.White
        Me.NomeLabel.Location = New System.Drawing.Point(51, 66)
        Me.NomeLabel.Name = "NomeLabel"
        Me.NomeLabel.ReadOnly = True
        Me.NomeLabel.Size = New System.Drawing.Size(245, 21)
        Me.NomeLabel.TabIndex = 19
        Me.NomeLabel.Text = "Nome"
        Me.NomeLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EscolherImagem
        '
        Me.EscolherImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EscolherImagem.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EscolherImagem.ForeColor = System.Drawing.Color.White
        Me.EscolherImagem.Location = New System.Drawing.Point(878, 288)
        Me.EscolherImagem.Name = "EscolherImagem"
        Me.EscolherImagem.Size = New System.Drawing.Size(183, 36)
        Me.EscolherImagem.TabIndex = 33
        Me.EscolherImagem.Text = "Escolher Imagem"
        Me.EscolherImagem.UseVisualStyleBackColor = True
        '
        'CriarProdutoBtn
        '
        Me.CriarProdutoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CriarProdutoBtn.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CriarProdutoBtn.ForeColor = System.Drawing.Color.White
        Me.CriarProdutoBtn.Location = New System.Drawing.Point(460, 353)
        Me.CriarProdutoBtn.Name = "CriarProdutoBtn"
        Me.CriarProdutoBtn.Size = New System.Drawing.Size(247, 68)
        Me.CriarProdutoBtn.TabIndex = 34
        Me.CriarProdutoBtn.Text = "Criar Produto"
        Me.CriarProdutoBtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CategoriaCmb
        '
        Me.CategoriaCmb.FormattingEnabled = True
        Me.CategoriaCmb.Location = New System.Drawing.Point(51, 165)
        Me.CategoriaCmb.Name = "CategoriaCmb"
        Me.CategoriaCmb.Size = New System.Drawing.Size(260, 28)
        Me.CategoriaCmb.TabIndex = 35
        '
        'InserirProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1200, 487)
        Me.Controls.Add(Me.CategoriaCmb)
        Me.Controls.Add(Me.CriarProdutoBtn)
        Me.Controls.Add(Me.EscolherImagem)
        Me.Controls.Add(Me.ImagemLabel)
        Me.Controls.Add(Me.ImageBox)
        Me.Controls.Add(Me.MarcaTextBox)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.PrecoTextBox)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.CategoriaLabel)
        Me.Controls.Add(Me.DescricaoTextBox)
        Me.Controls.Add(Me.DescricaoLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.NomeLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Georgia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "InserirProduto"
        Me.Text = "Inserir Produto"
        CType(Me.ImageBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ImagemLabel As TextBox
    Friend WithEvents ImageBox As PictureBox
    Friend WithEvents MarcaTextBox As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PrecoTextBox As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents CategoriaLabel As TextBox
    Friend WithEvents DescricaoTextBox As TextBox
    Friend WithEvents DescricaoLabel As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NomeLabel As TextBox
    Friend WithEvents EscolherImagem As Button
    Friend WithEvents CriarProdutoBtn As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CategoriaCmb As ComboBox
End Class
