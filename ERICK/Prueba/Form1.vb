Imports Infomatica.Restaurante.Model
Imports Infomatica.Restaurante.Controller
Imports System.Data.SqlClient

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If VG.Grupo.Count > 0 Then DataGridView1.DataSource = VG.Grupo
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim s As New SqlConnection
        Dim c As New GrupoController
        Dim d As New SubGrupoController
        s.ConnectionString = "Data Source=PC02\SQLEXPRESS;Initial Catalog=inforest;User ID = sa; Password = sistemas; "
        VG.CnRest = s
        c.GetGrupo()
        d.GetSubGrupo()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If VG.SubGrupo.Count > 0 Then
            For Each item As SubGrupoModel In VG.SubGrupo
                ListView1.Items.Add(item.Descripcion)
            Next
        End If
    End Sub
End Class
