Imports CapaEntidad
Imports CapaNegocio

Public Class Form1
    Dim objNego As New Cls_Negocio

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarEmpleados()
    End Sub

    Sub listarEmpleados()
        Dim dt As DataTable = objNego.N_ListarEmpleados
        Dgv_Empleados.DataSource = dt

        If Dgv_Empleados.Rows.Count > 0 Then
            Dgv_Empleados.Rows(0).Selected = True
        End If

    End Sub

    Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        Dim frm2 As New Form2
        frm2.txtAccion.Text = "Nuevo"
        frm2.txtCodigo.Text = "0"
        frm2.ShowDialog()
        listarEmpleados()
    End Sub

    Private Sub Btn_Editar_Click(sender As Object, e As EventArgs) Handles Btn_Editar.Click
        Dim frm2 As New Form2
        Dim fila As Integer
        fila = Dgv_Empleados.CurrentCell.RowIndex
        frm2.txtAccion.Text = "Editar"
        frm2.txtCodigo.Text = Dgv_Empleados.CurrentRow.Cells(0).Value.ToString
        frm2.txtNombre.Text = Dgv_Empleados.CurrentRow.Cells(1).Value.ToString
        frm2.txtEdad.Text = Dgv_Empleados.CurrentRow.Cells(2).Value.ToString
        frm2.txtSexo.Text = Dgv_Empleados.CurrentRow.Cells(3).Value.ToString
        frm2.txtSueldo.Text = Dgv_Empleados.CurrentRow.Cells(4).Value.ToString


        ' frm2.txtCodigo.Text = Dgv_Empleados.SelectedCells[0].Value.ToString()

        'Dgv_Empleados.Rows[0].Cells[0].Value

        frm2.ShowDialog()
        listarEmpleados()
    End Sub

    Private Sub Dgv_Empleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Empleados.CellClick
        If e.RowIndex < 0 Then
            Exit Sub
        End If

        Dgv_Empleados.Rows(e.RowIndex).Selected = True
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim rpta As String
        rpta = MsgBox("¿Desea eliminar el registro seleccionado?", vbYesNo)
        If rpta = vbYes Then
            Dim objEnt = New Cls_Entidad
            Dim objNeg = New Cls_Negocio
            objEnt.codEmp = Dgv_Empleados.CurrentRow.Cells(0).Value.ToString

            objNeg.N_EliminarEmpleados(objEnt)
            MessageBox.Show("Dato Eliminado")
            listarEmpleados()
        End If
    End Sub
End Class
