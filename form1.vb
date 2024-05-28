Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private selectedItems As New List(Of String)

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim connectionString As String = "Data Source=PONCE\MSSQLSERVER1;Initial Catalog=carrosss;Integrated Security=True"

