Imports System
Imports DevExpress.Xpo
Namespace MontagneAdministracion

    Partial Public Class RecepcionProductos
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
    End Class

End Namespace
