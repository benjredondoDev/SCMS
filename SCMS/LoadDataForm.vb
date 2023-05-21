Imports System.IO
Imports System.Xml
Imports ExcelDataReader
Imports MySql.Data.MySqlClient

Public Class LoadDataForm

    Dim command As MySqlCommand
    Dim mycon As String = "server=localhost; user id= root; password= 48469894; database= schoolclub"
    Dim con As MySqlConnection

    Dim tables As DataTableCollection
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel Workbook|*xlsx|CSV Files (*.csv)|*.csv"}
            If ofd.ShowDialog() = DialogResult.OK Then
                txtFileName.Text = ofd.FileName
                Using Stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                    Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(Stream)
                        Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                 .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                 .UseHeaderRow = True}})
                        tables = result.Tables
                        cboSheet.Items.Clear()
                        For Each table As DataTable In tables
                            cboSheet.Items.Add(table.TableName)
                        Next
                    End Using
                End Using
            End If
        End Using
    End Sub

    Private Sub cboSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSheet.SelectedIndexChanged
        Dim dt As DataTable = tables(cboSheet.SelectedItem.ToString())
        DataGridView1.DataSource = dt

    End Sub
    Private Sub LoadDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv1()
    End Sub

    Private Sub LoadDataBtn_Click(sender As Object, e As EventArgs) Handles LoadDataBtn.Click
        Update()

    End Sub
    Private Sub dgv1()
        con = New MySqlConnection
        con.ConnectionString = mycon

        Dim sda As New MySqlDataAdapter
        Dim dbDataset As New DataTable
        Dim bsource As New BindingSource

        Try
            con.Open()
            Dim query1 As String = "Select * from students"
            command = New MySqlCommand(query1, con)
            sda.SelectCommand = command
            sda.Fill(dbDataset)
            bsource.DataSource = dbDataset
            DataGridView1.DataSource = bsource
            sda.Update(dbDataset)

            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub printdataBtn_Click(sender As Object, e As EventArgs) Handles printdataBtn.Click

    End Sub
End Class