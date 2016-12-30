Public Class RpODC


    Private Sub XrLabel26_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel26.BeforePrint, Detail.BeforePrint
        XrLabel26.Text = Now.Date.ToLongDateString
        lblformadepago.text = "Forma de pago: " & Formadepago
         if Formadepago.Contains( "CONTRA ENTREGA" )Then
            horaentrega.Text = "HORA DE ENTREGA: A CONVENIR"
            Else
            horaentrega.Text = "HORARIO DE ENTREGA DE 9hs a 13hs y 14hs a 17hs"
        End If
        If Empresa = "MONTAGNE" Then
            XrPictureBox1.Visible = True
            XrLabel23.Visible = True
            FIRELANDBANNER.Visible = false
            XrLabel17.Visible = false
            RFTEXTUREBANNER.Visible = false
            
        Else
            XrPictureBox1.Visible = false

            XrLabel23.Visible = false
            XrLabel17.Visible = false
            FIRELANDBANNER.Visible = false
            RFTEXTUREBANNER.Visible = false

            If Empresa = "RANAWEL" Then
                XrPictureBox1.Visible = False
                XrLabel23.Visible = false
                XrLabel17.Visible = true
                FIRELANDBANNER.Visible = false
                RFTEXTUREBANNER.Visible = false
            Else
                XrPictureBox1.Visible = false
                XrLabel23.Visible = false
                XrLabel17.Visible = false
                FIRELANDBANNER.Visible = false
                RFTEXTUREBANNER.Visible = false

                If Empresa = "FIRELAND OUTDOORS" Then
                    XrPictureBox1.Visible = False
                    XrLabel23.Visible = false
                    XrLabel17.Visible = false
                    FIRELANDBANNER.Visible = true
                    RFTEXTUREBANNER.Visible = false
                Else
                    XrPictureBox1.Visible = false
                    XrLabel23.Visible = false
                    XrLabel17.Visible = false
                    FIRELANDBANNER.Visible = false
                    RFTEXTUREBANNER.Visible = false

                    If Empresa = "RF TEXTURE" Then
                        XrPictureBox1.Visible = False
                        XrLabel23.Visible = false
                        XrLabel17.Visible = false
                        FIRELANDBANNER.Visible = false
                        RFTEXTUREBANNER.Visible = true
                    Else
                        XrPictureBox1.Visible = false
                        XrLabel23.Visible = false
                        XrLabel17.Visible = false
                        FIRELANDBANNER.Visible = false
                        RFTEXTUREBANNER.Visible = false
                    End If
                End If
            End if
        End If
    End Sub


End Class