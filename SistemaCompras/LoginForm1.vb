Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports SistemaCompras.MontagneAdministracion.Sectores
Imports SistemaCompras.MontagneAdministracion
Public Class LoginForm1

    Public Session1 As Session = XpoHelper.GetNewSession()
    Dim loPSI As New ProcessStartInfo
    Dim loProceso As New Process
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        'If Environment.MachineName = "DESKTOP-TKS6FT6" Then
        '    Try

        '        Dim autoCreationOption As DB.AutoCreateOption
        '        Dim conn As String = MSSqlConnectionProvider.GetConnectionString("centralmontagne", "Gerencia", "interno.1660", "asd")
        '        XpoDefault.GetDataLayer(conn, autoCreationOption)
        '    Catch ex As Exception

        '    End Try
        'Else
        '    Try
        '        Dim autoCreationOption As DB.AutoCreateOption
        '        Dim conn As String = MSSqlConnectionProvider.GetConnectionString("centralmontagne", "Gerencia", "interno.1660", "dhg")
        '        XpoDefault.GetDataLayer(conn, autoCreationOption)
        '    Catch ex As Exception

        '    End Try
        'End If
        Dim querylinq As New XPQuery(Of Usuarios)(Session1)
        Dim querylinq1 As New XPQuery(Of Conectados)(Session1)
        Dim querylinq2 As New XPQuery(Of Pedidos)(Session1)
        Dim querylinq3 As New XPQuery(Of Sectores)(Session1)
        dim querylinq4 as new xpquery(of Equipos)(Session1)
        ' Dim actualizo As Integer
        Dim list = From o In querylinq Where o.UsuarioID = Username.Text And o.Contraseña = Password.Text Select o  ' Declara y asigna espacio de almacenamiento para una o varias variables.
        Dim count As Integer = list.count()
        Dim flag = 0
        If count > 0 Then                                                ' si count es mayor a 0 entonces 
            Usuario = Username.Text                                      ' toma el usuario del textbox usuario para validar, al igual que la contraseña
            Responsable = list.First.Nombres & " " & list.First.Apellidos   ' asigna a la variable responsable un string concatenado del nombre y apellido entre un espacio.
            Sectorid = CInt(list.First.Area)                                ' declara sectorid convirtiendolo a entero, el area del usuario (y contraseña)
            Dim list1 = From o In querylinq3 Where o.IdSector = Sectorid Select o.Sector    'asigna list1 desde querylinq3 donde idsector es Sectorid de la tabla sectores y selecciona el sector actual.
            Sector = list1.FirstOrDefault                                   ' toma el primer o default sectorid para asignarlo a Sector.
            Permiso = list.First.SeccionOficina                             ' a Permiso se le asigna el primero de la list(usuario y contraseña) de SeccionOficina
            Cotiza = list.First.Cotiza
            'habilitado = list.First.Habilitado
            Dim inhabilitado = Session1.ExecuteScalar("select Habilitado from Usuarios where UsuarioID = '" & Usuario & "'")
            If inhabilitado = 0 Then
                MsgBox("Temporalmente estas inhabilitado", vbinformation)
                Return
            Else
                Dim num = (From o In querylinq1 Where o.Login = Usuario And o.Equipo = Environment.MachineName Select o.Login).Count
                flag = num
                If flag = 0 Then
                    Dim conect = New Conectados(Session1)
                    conect.Login = Usuario
                    conect.Equipo = Environment.MachineName
                    conect.Ultimaconexion = Now
                    conect.save()
                Else
                    Dim res = Session1.ExecuteNonQuery("insert into Conectados (Equipo, UltimaConexion, Login) values ('" & Environment.MachineName & "', '" & Now & "', '" & Usuario & "')")
                End If

                Hide()                                                          ' procede a esconder el form login
                FrPrincipalCompras.show()
                If Sectorid = 14 Then
                    FrAprobarODC.show
                    FrPrincipalCompras.Hide
                End If
            End If
            'Reload(querylinq)
        Else                                                                ' si no se validan el usuario y contraseñas muestra el msgbox
            MsgBox("Usuario o Contraseña incorrectas")
            Password.SelectionStart = 0
            Password.SelectionLength = Password.text.length
            '  Return
        End If
        Dim exists As Boolean
        dim maquina as string = Environment.MachineName
        Dim actualizo = Session1.ExecuteScalar("select Actualizo from Equipos where NombreEquipo= '" & maquina & "'")
        Dim user As Integer = Session1.ExecuteScalar("select count(UsuarioID) from Usuarios where UsuarioID = '" & Usuario & "'")
       ' dim maquina1 as string = Session1.ExecuteNonQuery("select Maquina from Equipos where Maquina = '" & Environment.MachineName & "'")
             If user = 1 Then
            exists = System.IO.File.Exists("\\192.168.189.26\c$\update\setup.exe")
            If exists = True And actualizo = 0 Then
                If MsgBox("Existe una nueva version del sistema, deseas actualizar?", vbYesNo) = MsgBoxResult.Yes Then

                    Session1.ExecuteNonQuery("update Equipos set Actualizo = 1, Usuario = '" & Usuario & "' where NombreEquipo = '" & maquina & "'")
                    'Update [Usuarios] SET [Actualizo]='1' WHERE ([UsuarioID]='compras2')
                    loPSI.FileName = "\\192.168.189.26\c$\update\setup.exe"
                    Try
                        loProceso = Process.Start(loPSI)

                    Catch exp As Exception
                        MessageBox.Show(exp.Message, "Se produjo un error, consulte con soporte", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try

                    End
                End If
            End If
        End If

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        FrCambioContrasenia.ShowDialog()
        
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If Environment.MachineName = "DESKTOP-TKS6FT6" Then
        '    ComboBox1.Visible = True
        'Else
        '    ComboBox1.Visible = False
        'End If
        System.IO.Directory.CreateDirectory("c:\Reportes\Pedidos")
        System.IO.Directory.CreateDirectory("c:\Reportes\ODCs")

    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
