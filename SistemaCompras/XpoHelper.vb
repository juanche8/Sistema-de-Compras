Imports System.Threading
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Public NotInheritable Class XpoHelper

    Private Shared fDataLayer As IDataLayer

    Private Shared lockObject As New Object()




    Public Shared Function GetNewSession() As Session
        Return New Session(DataLayer)
    End Function

    Public Shared Function GetNewUnitOfWork() As UnitOfWork
        Return New UnitOfWork(DataLayer)
    End Function
    Public Shared Function GetDataLayer(ByVal autoCreationOption As DB.AutoCreateOption) As IDataLayer

        Try
            If Environment.MachineName = "DESKTOP-TKS6FT6" or Environment.MachineName = "WK10SISTEMAS4" Then
                dim a = InputBox("", "Oficial o Test?", "Test",, 1)
                If a = "Test" then
                    MsgBox("Conectado a " & a)
                    Dim conn1 As String = MSSqlConnectionProvider.GetConnectionString("centralmontagne", "Gerencia", "interno.1660", "ComprasTest") 'montagneadministracion
                    Return XpoDefault.GetDataLayer(conn1, autoCreationOption)

                Else
                    MsgBox("Conectado al oficial")
                    Dim conn2 As String = MSSqlConnectionProvider.GetConnectionString("centralmontagne", "Gerencia", "interno.1660", "montagneadministracion") 'montagneadministracion
                    Return XpoDefault.GetDataLayer(conn2, autoCreationOption)
                end if
            Else
                Dim conn As String = MSSqlConnectionProvider.GetConnectionString("centralmontagne", "Gerencia", "interno.1660", "montagneadministracion") 'montagneadministracion
                Return XpoDefault.GetDataLayer(conn, autoCreationOption)
            End If


        Catch ex As Exception

        End Try
#Disable Warning BC42105
    End Function
#Enable Warning BC42105
    Private Shared ReadOnly Property DataLayer() As IDataLayer
        Get
            If fDataLayer Is Nothing Then
                SyncLock lockObject
                    If Thread.VolatileRead(fDataLayer) Is Nothing Then  ''' comment
                        ''' nmbr3
                        Thread.VolatileWrite(fDataLayer, GetDataLayer(Pedido))
                    End If
                End SyncLock
            End If
            Return fDataLayer
        End Get
    End Property




End Class





