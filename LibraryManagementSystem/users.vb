Public Class users
    Dim type As String = ""
    Dim comboVal() As String = {"librarian", "student", "faculty"}

    Public Sub New(ByRef userType As String)

        ' This call is required by the designer.
        InitializeComponent()
        type = userType

        For Each val As String In comboVal
            combousertype.Items.Add(val)
        Next
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDatagrid()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (Not checkIfEmpty()) Then
            If (Not checkpasswordMatch()) Then
            Else
                addUser()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (Not checkIfEmpty()) Then
            If (Not checkpasswordMatch()) Then
            Else
                updateUser()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        deleteUser()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim form As New main(Type)
        form.Show()
        Me.Close()
    End Sub

    Private Sub loadDatagrid()
        Dim userClass As New classUser
        DataGridView1.Refresh()
        DataGridView1.DataSource = userClass.populateData("SELECT * FROM tblUsers")
    End Sub

    Private Sub addUser()
        Dim data(2) As String
        data(0) = txtusername.Text.Trim
        data(1) = txtpassword.Text.Trim
        data(2) = combousertype.SelectedItem.ToString

        Dim userclass As New classUser
        userclass.Insert(data, "INSERT INTO tblUsers ([username], [password], [userType]) 
VALUES (@username, @password, @usertype)")
        loadDatagrid()
        emptyFields()
    End Sub

    Private Sub updateUser()
        Dim data(2) As String
        data(0) = txtusername.Text.Trim
        data(1) = txtpassword.Text.Trim
        data(2) = combousertype.SelectedItem.ToString

        Dim userclass As New classUser
        userclass.Update(data, Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value), "UPDATE tblUsers SET [username] = @username, [password] = @password, [userType] = @usertype WHERE ID = @id")
        loadDatagrid()
        emptyFields()
    End Sub

    Private Sub deleteUser()
        Dim userclass As New classUser
        Dim id As Integer
        id = Convert.ToInt32(DataGridView1.CurrentRow.Cells(0).Value)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "Warning", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            userclass.delete(id, "DELETE FROM tblUsers WHERE ID = @id")
            loadDatagrid()
        End If
    End Sub
    Private Sub emptyFields()
        txtusername.Text = ""
        txtpassword.Text = ""
        txtretry.Text = ""
        combousertype.SelectedIndex = -1
    End Sub

    Private Function checkIfEmpty() As Boolean
        If (txtusername.Text = "") Then
            MessageBox.Show("Please input username", "Alert", MessageBoxButtons.OK)
            Return True
        ElseIf (txtpassword.Text = "") Then
            MessageBox.Show("Please input password", "Alert", MessageBoxButtons.OK)
            Return True
        ElseIf (txtretry.Text = "") Then
            MessageBox.Show("Password mismatch", "Alert", MessageBoxButtons.OK)
            Return True
        ElseIf (combousertype.SelectedIndex = -1) Then
            MessageBox.Show("Please input specify the user type", "Alert", MessageBoxButtons.OK)
            Return True
        Else
            Return False
        End If
    End Function

    Private Function checkpasswordMatch() As Boolean
        If (txtpassword.Text = txtretry.Text) Then
            Return True
        Else
            MessageBox.Show("Password mismatch", "Alert", MessageBoxButtons.OK)
            Return False
        End If
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtusername.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        txtpassword.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        For i As Integer = 0 To 2
            If (comboVal(i) = DataGridView1.CurrentRow.Cells(3).Value.ToString) Then
                combousertype.SelectedIndex = combousertype.FindString(comboVal(i)).ToString
            End If
        Next
    End Sub

    Private Sub users_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form As New main(type)
        form.Show()
    End Sub
End Class