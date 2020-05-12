Imports CapaDatos
Imports CapaEntidad

Public Class Cls_Negocio
    Private objDatos As New Cls_Datos
    Public Function N_ListarEmpleados() As DataTable
        Return objDatos.D_ListarEmpleados
    End Function

    Public Sub N_InsertarEmpleados(enti As Cls_Entidad)
        objDatos.D_InsertarEmpleados(enti)
    End Sub
    Public Sub N_EditarEmpleados(enti As Cls_Entidad)
        objDatos.D_EditarEmpleados(enti)
    End Sub
    Public Sub N_EliminarEmpleados(enti As Cls_Entidad)
        objDatos.D_EliminarEmpleados(enti)
    End Sub
End Class
