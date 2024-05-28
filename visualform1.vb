Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private selectedItems As New List(Of String)

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim connectionString As String = "Data Source=PONCE\MSSQLSERVER1;Initial Catalog=carrosss;Integrated Security=True"
        Dim query As String = "SELECT * FROM Modelo"
        Dim connection As New SqlConnection(connectionString)
        Dim command As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()

        Try
            connection.Open()
            adapter.Fill(table)
            DataGridView1.DataSource = table

            query = "SELECT * FROM Modelo"
            command = New SqlCommand(query, connection)
            adapter = New SqlDataAdapter(command)
            Dim table3 As New DataTable()
            adapter.Fill(table3)
            DataGridView3.DataSource = table3

            query = "SELECT * FROM Vendedor"
            command = New SqlCommand(query, connection)
            adapter = New SqlDataAdapter(command)
            Dim table4 As New DataTable()
            adapter.Fill(table4)
            DataGridView4.DataSource = table4

            query = "SELECT * FROM Factura"
            command = New SqlCommand(query, connection)
            adapter = New SqlDataAdapter(command)
            Dim table5 As New DataTable()
            adapter.Fill(table5)
            DataGridView5.DataSource = table5

            query = "SELECT * FROM Vehiculo"
            command = New SqlCommand(query, connection)
            adapter = New SqlDataAdapter(command)
            Dim table6 As New DataTable()
            adapter.Fill(table6)
            DataGridView6.DataSource = table6

        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Verificar si se hizo clic en una de las columnas deseadas
        Dim allowedColumns As New List(Of String) From {"cod_marca", "descripcion"}

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso allowedColumns.Contains(DataGridView1.Columns(e.ColumnIndex).Name) Then
            Dim selectedValue As String = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            selectedItems.Add(selectedValue)
            UpdateTextBox()
        End If
    End Sub




    Private Sub UpdateTextBox()
        ' Implementa la lógica para actualizar el cuadro de texto aquí
        ' Por ejemplo, si tienes un TextBox llamado TextBox1 puedes hacer algo como:
        TextBox1.Text = ""

        For Each item As String In selectedItems
            TextBox1.Text &= item & Environment.NewLine
        Next
    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        Dim allowedColumns As New List(Of String) From {"Nombre", "Direccion", "Telefono"}

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso allowedColumns.Contains(DataGridView3.Columns(e.ColumnIndex).Name) Then
            Dim selectedValue As String = DataGridView3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            selectedItems.Add(selectedValue)
            UpdateTextBox()
        End If
    End Sub

    Private Sub DataGridView5_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView5.CellClick
        Dim allowedColumns As New List(Of String) From {"nro_factura", "Nombre", "Fecha_venta", "Comision", "impt_total"}

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso allowedColumns.Contains(DataGridView5.Columns(e.ColumnIndex).Name) Then
            Dim selectedValue As String = DataGridView5.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            selectedItems.Add(selectedValue)
            UpdateTextBox()
        End If
    End Sub

    Private Sub DataGridView4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellClick
        Dim allowedColumns As New List(Of String) From {"idVendedor", "Nombre"}

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso allowedColumns.Contains(DataGridView4.Columns(e.ColumnIndex).Name) Then
            Dim selectedValue As String = DataGridView4.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            selectedItems.Add(selectedValue)
            UpdateTextBox()
        End If
    End Sub

    Private Sub DataGridView6_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView6.CellClick
        Dim allowedColumns As New List(Of String) From {"traccion", "modelo", "nro_puer", "color", "precio"}

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 AndAlso allowedColumns.Contains(DataGridView6.Columns(e.ColumnIndex).Name) Then
            Dim selectedValue As String = DataGridView6.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            selectedItems.Add(selectedValue)
            UpdateTextBox()
        End If
    End Sub

    Private Sub btnCerrarAplicacion_Click(sender As Object, e As EventArgs) Handles btnCerrarAplicacion.Click

        Application.Exit()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        TextBox1.Text = ""
    End Sub
End Class
