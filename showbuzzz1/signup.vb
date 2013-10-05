Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Imports WindowsApplication1.conndbglobal


Public Class form_signup


    Private Sub textbox_reg_no_GotFocus(sender As Object, e As EventArgs) Handles textbox_reg_no.GotFocus
        Label_error_reg_no.Text = ""
        Label_dob_validation.Text = ""
        textbox_first_name.Text = ""
        textbox_last_name.Text = ""
    End Sub

    Private Sub textbox_reg_no_Leave(sender As Object, e As EventArgs) Handles textbox_reg_no.Leave
        conn.ConnectionString = oradb
        conn.Open()
        Dim cmd As New OracleCommand("select * from employee where reg_no=:a ", conn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add(New OracleParameter(":a", (textbox_reg_no.Text)))
        Dim rd As OracleDataReader = cmd.ExecuteReader()
        If rd.HasRows Then
            rd.Read()
            textbox_first_name.Text = rd.Item("FIRST_NAME")
            textbox_last_name.Text = rd.Item("LAST_NAME")
            datetimepicker_dob.Enabled = True
            datetimepicker_dob.Focus()
        Else
            Label_error_reg_no.Text = "INVALID REGISTRATION NUMBER"
            textbox_first_name.Text = ""
            textbox_last_name.Text = ""
            Label_error_reg_no.Focus()
        End If
        rd.Close()
        cmd.Dispose()
        conn.Close()
    End Sub

    Private Sub datetimepicker_dob_GotFocus(sender As Object, e As EventArgs) Handles datetimepicker_dob.GotFocus
        Label_dob_validation.Text = ""
    End Sub

    Private Sub datetimepicker_dob_Leave(sender As Object, e As EventArgs) Handles datetimepicker_dob.Leave
        If textbox_reg_no.Text = "" Then
            label_reg_no_validation.Text = "ENTER REGISTRATION NO"
        Else
            conn.Open()
            Dim cmd As New OracleCommand("select to_char(dob,'dd-mm-yyyy') from employee where REG_NO = :a ", conn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add(New OracleParameter(":a", (textbox_reg_no.Text)))
            Dim rd As OracleDataReader = cmd.ExecuteReader()
            rd.Read()
            If datetimepicker_dob.Value.Date = rd.Item("to_char(dob,'dd-mm-yyyy')") Then
                Label_dob_validation.Text = "VALID  REGISTRATION NO."
                textbox_userid.ReadOnly = False
                textbox_password.ReadOnly = False
                textbox_confirm_password.ReadOnly = False
            Else
                Label_dob_validation.Text = "DATE OF BIRTH INVALID "
                datetimepicker_dob.Focus()
            End If
            conn.Close()
        End If
    End Sub



    Private Sub button_signup_Click(sender As Object, e As EventArgs) Handles button_signup.Click
        Dim sql As String
        If textbox_userid.Text = "" Then
            Label_userid_error.Text = "ENTER USER ID"
            textbox_userid.Focus()
        Else
            If textbox_password.Text = "" Or textbox_confirm_password.Text = "" Then
                Label_password_error.Text = "Enter password"
            Else
                If textbox_password.Text <> textbox_confirm_password.Text Then
                    Label_password_error.Text = "PASSWORD MISMATCH"
                Else
                    conn.ConnectionString = oradb
                    conn.Open()
                    sql = "insert into users values(:reg_no,:user_id,:password,'pos',1)"
                    Dim cmd As New OracleCommand(sql, conn)
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.Add(New OracleParameter(":reg_no", (textbox_reg_no.Text)))
                    cmd.Parameters.Add(New OracleParameter(":user_id", (textbox_userid.Text)))
                    cmd.Parameters.Add(New OracleParameter(":password", (textbox_password.Text)))
                    sql = "insert into users values(:reg_no,:user_id,:password,'pos',1)"
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    conn.Close()
                    MsgBox("USER CREATED")
                    reset_signpage()
                    form_login.Show()
                    Me.Hide()
                End If
            End If
        End If
    End Sub

    Private Sub textbox_userid_Leave(sender As Object, e As EventArgs) Handles textbox_userid.Leave

    End Sub


    Private Sub textbox_userid_TextChanged(sender As Object, e As EventArgs) Handles textbox_userid.TextChanged
        Label_userid_error.Text = ""
    End Sub

   

    Private Sub textbox_password_TextChanged(sender As Object, e As EventArgs) Handles textbox_password.TextChanged
        Label_password_error.Text = ""
    End Sub

    Public Function reset_signpage()
        textbox_password.Text = ""
        textbox_confirm_password.Text = ""
        textbox_userid.Text = ""
        textbox_password.ReadOnly = True
        textbox_userid.ReadOnly = True
        textbox_confirm_password.ReadOnly = True
        textbox_first_name.Text = ""
        textbox_last_name.Text = ""
        textbox_reg_no.Text = ""
        datetimepicker_dob.ResetText()

    End Function

    Private Sub button_reset_Click(sender As Object, e As EventArgs) Handles button_reset.Click
        reset_signpage()
    End Sub
End Class