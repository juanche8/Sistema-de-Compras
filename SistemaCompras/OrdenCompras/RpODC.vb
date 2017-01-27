Imports DevExpress.Snap.Core

Public Class RpODC

    Dim importe10 As Decimal
    Dim importe21 As Decimal
    Dim importe As Decimal
    Dim totalfinal As Decimal
    Dim subtotal2 As Decimal
    Private Sub XrLabel26_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel26.BeforePrint, Detail.BeforePrint

        XrLabel26.Text = Now.Date.ToLongDateString
        lblformadepago.Text = "CONDICION DE PAGO: " & Formadepago

        If Formadepago.Contains("CONTRA ENTREGA") Then
            horaentrega.Text = "HORA DE ENTREGA: A CONVENIR"
        Else
            horaentrega.Text = "HORARIO DE ENTREGA DE 9hs a 13hs y 14hs a 17hs"
        End If
        If Empresa = "MONTAGNE" Then
            XrPictureBox1.Visible = True
            XrLabel23.Visible = True
            FIRELANDBANNER.Visible = False
            XrLabel17.Visible = False
            RFTEXTUREBANNER.Visible = False

        Else
            XrPictureBox1.Visible = False

            XrLabel23.Visible = False
            XrLabel17.Visible = False
            FIRELANDBANNER.Visible = False
            RFTEXTUREBANNER.Visible = False

            If Empresa = "RANAWEL" Then
                XrPictureBox1.Visible = False
                XrLabel23.Visible = False
                XrLabel17.Visible = True
                FIRELANDBANNER.Visible = False
                RFTEXTUREBANNER.Visible = False
            Else
                XrPictureBox1.Visible = False
                XrLabel23.Visible = False
                XrLabel17.Visible = False
                FIRELANDBANNER.Visible = False
                RFTEXTUREBANNER.Visible = False

                If Empresa = "FIRELAND OUTDOORS" Then
                    XrPictureBox1.Visible = False
                    XrLabel23.Visible = False
                    XrLabel17.Visible = False
                    FIRELANDBANNER.Visible = True
                    RFTEXTUREBANNER.Visible = False
                Else
                    XrPictureBox1.Visible = False
                    XrLabel23.Visible = False
                    XrLabel17.Visible = False
                    FIRELANDBANNER.Visible = False
                    RFTEXTUREBANNER.Visible = False

                    If Empresa = "RF TEXTURE" Then
                        XrPictureBox1.Visible = False
                        XrLabel23.Visible = False
                        XrLabel17.Visible = False
                        FIRELANDBANNER.Visible = False
                        RFTEXTUREBANNER.Visible = True
                    Else
                        XrPictureBox1.Visible = False
                        XrLabel23.Visible = False
                        XrLabel17.Visible = False
                        FIRELANDBANNER.Visible = False
                        RFTEXTUREBANNER.Visible = False
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub XrLabel38_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel38.BeforePrint
        Dim subtotal As decimal
        Try
            Dim iva = XrLabel9.Text.TrimEnd("%")            'Le corta el "%"al label del porcentaje para que quede solo Numeros y poder hacer los calculos
            If iva = "" Then                                'Se calculan aca los items que no tengan iva marcado
                XrLabel38.Text = XrLabel19.text
                subtotal = XrLabel19.Text.TrimStart("$")    'Le corta el "%"al label del porcentaje para que quede solo Numeros y poder hacer los calculos
                subtotal2 = subtotal + subtotal2            'Sumatoria de los totales que no tengan impuestos
                Exit sub
            End If
            Dim flag = 0
            Dim num = XrLabel1.Text 
            IF Num = "COSTO DE ENVIO" Then
                flag = 1
            End If
            If flag = 1 Then

            End If
            subtotal = XrLabel19.Text.TrimStart("$")        'Le corta el "%"al label del porcentaje para que quede solo Numeros y poder hacer los calculos
            subtotal2 = subtotal + subtotal2                'Suma todos los datos que lleva la variable Subtotal con el anterior subtotal2
            importe = subtotal * iva / 100                  'Variable importe (excedente) es el subtotal por el impuesto entre 100
            If XrLabel9.Text.Contains("10,5") Then          'Pregunta si el iva es 10,5 para guardar en la variable importe10 el 10,5% con el ciclo for
                importe10 = importe + importe10
            Else
                importe21 = importe + importe21             'Si no, lo guarda en 21.
            End If
            Dim total = subtotal + importe                  'Total es la suma del subtotal mas importe
            XrLabel38.Text = "$" & total                    'Y se muestra en el label 38 todo el total.
        Catch ex As Exception
        End Try
    End Sub

    Private Sub XrLabel29_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel29.BeforePrint
        If XrLabel29.Text = "Proyecto:Stock" Then
            XrLabel29.Text = "Proyecto:Almacen" 'cambiar al nombre que compras quiere mostrar
        End If
    End Sub

    Private Sub XrLabel39_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel39.BeforePrint
        XrLabel39.Text = "IVA 10.5%   $" & importe10
    End Sub

    Private Sub XrLabel40_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel40.BeforePrint
        XrLabel40.Text = "IVA 21,00%   $" & importe21
    End Sub

    Private Sub XrLabel41_BeforePrint(sender As Object, e As Printing.PrintEventArgs)

    End Sub

    Private Sub XrLabel21_AfterPrint(sender As Object, e As EventArgs) Handles XrLabel21.AfterPrint
        '  dim subtotal2 = Val(XrLabel21.Text.TrimStart("Subtotal: $"))
        XrLabel20.Text = "TOTAL  $" & Math.Round(subtotal2 + importe10 + importe21, 2)  'Obliga a dos decimales el total general
    End Sub
End Class