Imports MySql.Data.MySqlClient
'Imports System.Data.SqlClient
Imports Mysqlx
Imports OfficeOpenXml
Imports System.IO

Public Class Form3

    'VARIABLES THAT ACCEPT THE VALUES OF THE USER FROM THE FORM1
    Public Username As String
    Public Lastname As String
    Public Age As Integer

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'maximized the window
        Me.WindowState = FormWindowState.Maximized

        'get the user name
        lblUsername.Text = Username

        'get the user last name
        lblLastname.Text = Lastname
        'get the user age
        lblAge.Text = Age.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn.Close()

        If (prodName.Text = "" And prodPrice.Text = "") And (prodDescription.Text = "") Then
            prodError.Visible = True

        Else
            DB_CONNECT()

            Dim SQLcommand As MySqlCommand

            Dim price As Integer

            If Integer.TryParse(prodPrice.Text, price) Then
                SQLcommand = New MySqlCommand("INSERT INTO product(prodName, prodPrice, prodDescription) values('" & prodName.Text & "', '" & price & "', '" & prodDescription.Text & "')", conn)
                SQLcommand.ExecuteNonQuery()


                prodError.Text = "Record added successfuly!"
                prodError.ForeColor = Color.Black
                prodError.BackColor = Color.Green
                prodError.Visible = True
            Else
                MessageBox.Show("Price need an integer amount", "Error!")
            End If
        End If


    End Sub

    'SHOW PRODUCT LISTS BOTTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        conn.Close()

        Cursor.Current = Cursors.WaitCursor
        System.Threading.Thread.Sleep(2000)

        Try
            Call DB_CONNECT()

            Dim dataTable As New DataTable()
            Using dataAdapter As New MySqlDataAdapter("SELECT * FROM product", conn)
                dataAdapter.Fill(dataTable)
            End Using
            dbData.DataSource = dataTable

            'Show the header name and enbale the error message
            prodError.Visible = False
            lblYourRecord.Text = "Product list"
            lblYourRecord.Visible = True

            'Reset the inout fields
            prodName.BackColor = Color.White
            prodPrice.BackColor = Color.White
            prodDescription.BackColor = Color.White
            lblFilePath.Text = ""

            'Reset the inputs in the input box
            prodDescription.Text = ""
            prodName.Text = ""
            prodPrice.Text = ""

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            MessageBox.Show("An error occured: " & ex.Message)
        End Try
        conn.Close()
    End Sub

    'SHOW USER LISTS BOTTON
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        conn.Close()

        Cursor.Current = Cursors.WaitCursor
        System.Threading.Thread.Sleep(2000)


        Try
            Call DB_CONNECT()

            Dim dataTable As New DataTable()
            Using dataAdapter As New MySqlDataAdapter("SELECT * FROM users", conn)
                dataAdapter.Fill(dataTable)
            End Using
            dbData.DataSource = dataTable

            'Show the header name and enbale the error message
            prodError.Visible = False
            lblYourRecord.Text = "User list"
            lblYourRecord.Visible = True

            'Reset the input fields
            prodName.BackColor = Color.White
            prodPrice.BackColor = Color.White
            prodDescription.BackColor = Color.White
            lblFilePath.Text = ""

            'Reset the inputs in the input box
            prodDescription.Text = ""
            prodName.Text = ""
            prodPrice.Text = ""

            Cursor.Current = Cursors.Default

        Catch ex As Exception
            MessageBox.Show("An error occured: " & ex.Message)
        End Try
        conn.Close()
    End Sub


    'BOTTON TO OPEN A FILE AND DISPLAY IT IN THE DataGridView
    Private dataTable As DataTable
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim openFileDialog1 As New OpenFileDialog()

        ' Set the filter for file extension and default file extension
        openFileDialog1.Filter = "CSV files (*.csv)|*.csv|Text files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.DefaultExt = "txt"

        ' Display the open file dialog
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Get the file name and file path
            Dim filePath As String = openFileDialog1.FileName

            ' Display the filepath and filename in the disabled input box
            lblFilePath.Text = filePath

            ' Read the contents of the file into a DataTable
            dataTable = New DataTable()
            Using parser As New FileIO.TextFieldParser(filePath)
                parser.TextFieldType = FileIO.FieldType.Delimited
                parser.SetDelimiters(",")
                If Not parser.EndOfData Then
                    ' Use the first row of the file as column names for the DataTable
                    Dim fields() As String = parser.ReadFields()
                    For Each field As String In fields
                        dataTable.Columns.Add(field)
                    Next
                End If
                While Not parser.EndOfData
                    ' Add a new row to the DataTable using the fields of the current row
                    Dim fields() As String = parser.ReadFields()
                    dataTable.Rows.Add(fields)
                End While
            End Using

            ' Bind the DataTable to the DataGridView
            dbData.DataSource = dataTable
        End If

        PrintBTN.Visible = True

    End Sub


    'BOTTON TO SAVE THE FILE AS A DATABASE BACKUP FILE
    Private Sub Backup_Click(sender As Object, e As EventArgs) Handles Backup.Click
        Dim saveFileDialog1 As New SaveFileDialog With {
        .Filter = "MySQL backup files (*.sql)|*.sql|All files (*.*)|*.*",
        .DefaultExt = "sql"
    }

        ' Display the save file dialog
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Get the file name and path for the backup file
            Dim backupFilePath As String = saveFileDialog1.FileName
            'Get the file name entered by the user
            Dim FileName As String = Path.GetFileNameWithoutExtension(backupFilePath)

            ' Create a new StreamWriter to write to the backup file
            Using writer As New StreamWriter(backupFilePath)

                writer.WriteLine(String.Format($"CREATE DATABASE IF NOT EXISTS {FileName};"))

                ' Write the SQL statements to create the table and insert the data
                writer.WriteLine(String.Format("CREATE TABLE IF NOT EXISTS {0} (", "my_table"))
                For Each column As DataGridViewColumn In dbData.Columns
                    writer.WriteLine(String.Format("`{0}` {1},", column.HeaderText, "VARCHAR(255)"))
                Next
                writer.WriteLine("PRIMARY KEY (`ID`));")
                For Each row As DataGridViewRow In dbData.Rows
                    writer.WriteLine(String.Format("INSERT INTO {0} VALUES ({1});", "my_table", String.Join(",", row.Cells.Cast(Of DataGridViewCell).Select(Function(cell) "'" & cell.Value.ToString().Replace("'", "''") & "'"))))
                Next

            End Using

            MessageBox.Show("Backup file created successfully.", "Successful!")
        End If
    End Sub

    Private Sub PrintBTN_Click(sender As Object, e As EventArgs) Handles PrintBTN.Click
        ' Set the path to the template file
        Dim templatePath As String = "template\template.xlsx"

        ' Load the template file using EPPlus
        Dim template As New ExcelPackage(New FileInfo(templatePath))

        ' Get the worksheet to copy data to
        Dim worksheet As ExcelWorksheet = template.Workbook.Worksheets("Sheet1")

        ' Set the starting row to 4
        Dim startRow As Integer = 4

        ' Copy the data from the DataGridView to the Excel worksheet
        For i As Integer = 0 To dataTable.Rows.Count - 1
            Dim row As DataRow = dataTable.Rows(i)
            For j As Integer = 0 To dataTable.Columns.Count - 1
                worksheet.Cells(startRow + i, j + 1).Value = row(j).ToString()
            Next
        Next

        ' Save the changes to the template file
        template.Save()

        ' Open the template file for printing
        Process.Start(templatePath)
    End Sub

End Class