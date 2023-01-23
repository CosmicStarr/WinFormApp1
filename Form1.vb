Public Class Form1
    Private Sub PhoneBookInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PhoneBookInfoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PhoneBookInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WinForm1DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WinForm1DataSet.PhoneBookInfo' table. You can move, or remove it, as needed.
        Try
            PhoneBookInfoTableAdapter.Fill_All(Me.WinForm1DataSet.PhoneBookInfo)
            Label1.Text = WinForm1DataSet.PhoneBookInfo.Rows.Count.ToString
            save_Button.Enabled = False
            cancel_Button.Enabled = False
            GroupBox1.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub CountryLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CountryTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PhoneTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PhoneLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ZipCodeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LastNameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub add_New_Button_Click(sender As Object, e As EventArgs) Handles add_New_Button.Click
        disableButtonsWhen()
        'Adding a new object to the Database'
        PhoneBookInfoBindingSource.AddNew()
    End Sub
    Sub editdisablebuttonWhen()
        Dim form1 As Form1 = Me
        '--------disabling first three buttons if save & cancel buttons not selected-------'
        form1.edit_Button.Enabled = False
        form1.add_New_Button.Enabled = False
        form1.delete_Button.Enabled = False
        '------Enabling them again------'
        GroupBox1.Enabled = True
        form1.save_Button.Enabled = True
        form1.cancel_Button.Enabled = True
        form1.PhoneBookInfoDataGridView.Enabled = False
    End Sub
    Sub disableButtonsWhen()
        Dim form1 As Form1 = Me
        '--------disabling first three buttons if save & cancel buttons not selected-------'
        form1.edit_Button.Enabled = False
        form1.add_New_Button.Enabled = False
        form1.delete_Button.Enabled = False
        '------Enabling them again------'
        form1.save_Button.Enabled = True
        form1.cancel_Button.Enabled = True
        form1.GroupBox1.Enabled = True
        form1.PhoneBookInfoDataGridView.Enabled = False
    End Sub

    Private Sub cancel_Button_Click(sender As Object, e As EventArgs) Handles cancel_Button.Click
        enableButtonsWhen()
        '------Rejecting Changes-----'
        WinForm1DataSet.PhoneBookInfo.RejectChanges()
        PhoneBookInfoBindingSource.CancelEdit()
    End Sub
    Sub enableButtonsWhen()
        save_Button.Enabled = False
        cancel_Button.Enabled = False
        GroupBox1.Enabled = False
        PhoneBookInfoDataGridView.Enabled = True
        edit_Button.Enabled = True
        add_New_Button.Enabled = True
        delete_Button.Enabled = True
    End Sub

    Private Sub edit_Button_Click(sender As Object, e As EventArgs) Handles edit_Button.Click
        editGuard(edit_Button)
    End Sub

    Sub editGuard(info As ToolStripButton)
        Dim record As Integer
        record = WinForm1DataSet.PhoneBookInfo.Rows.Count
        If record = 0 Then
            GroupBox1.Enabled = False
            save_Button.Enabled = False
            MessageBox.Show($"No record to {info}!")
            Exit Sub
        End If
        editdisablebuttonWhen()
    End Sub
    Sub deleteGuard(info As ToolStripButton)
        GroupBox1.Enabled = False
        Dim record As Integer
        record = WinForm1DataSet.PhoneBookInfo.Rows.Count
        If record = 0 Then
            MessageBox.Show($"No record to {info}!")
            Exit Sub
        End If
        disableButtonsWhen()
        PhoneBookInfoBindingSource.RemoveCurrent()
    End Sub
    Private Sub delete_Button_Click(sender As Object, e As EventArgs) Handles delete_Button.Click
        deleteGuard(delete_Button)
        'PhoneBookInfoBindingSource.EndEdit()
        'Dim saved As Integer
        'saved = Me.PhoneBookInfoTableAdapter.Update(Me.WinForm1DataSet.PhoneBookInfo)
        'If saved > 0 Then
        'MessageBox.Show("Delete!")
        'Else
        'MessageBox.Show("Unsuccessful!")
        'End If
    End Sub

    Private Sub save_Button_Click(sender As Object, e As EventArgs) Handles save_Button.Click
        'Saving Changes Made to the form!'
        PhoneBookInfoBindingSource.EndEdit()
        Dim saved As Integer
        saved = Me.PhoneBookInfoTableAdapter.Update(Me.WinForm1DataSet.PhoneBookInfo)
        If saved > 0 Then
            MessageBox.Show("Saved!")
        Else
            MessageBox.Show("Not Saved!")
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim record As Integer
        record = WinForm1DataSet.PhoneBookInfo.Rows.Count
        record = PhoneBookInfoTableAdapter.Fill_BY_Email(Me.WinForm1DataSet.PhoneBookInfo)
        If record = 0 Then
            MessageBox.Show("No records to show")
        End If
        MessageBox.Show($"You have {record} records!")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = WinForm1DataSet.PhoneBookInfo.Rows.Count.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'WinForm1DataSet.PhoneBookInfo.AcceptChanges()
        Label1.Text = WinForm1DataSet.PhoneBookInfo.Rows.Count.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        Dim fileName = OpenFileDialog1.FileName
        If fileName = "OpenFileDialog1" Then
            Exit Sub
        End If
        Image.FromFile(fileName)
        PictureBox1.Image = Image.FromFile(fileName)
    End Sub
End Class
