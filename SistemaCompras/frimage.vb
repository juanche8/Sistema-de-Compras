Imports DevExpress.Xpo

Public Class frimage
  
    Public Session1 As Session = XpoHelper.GetNewSession()
    Private Sub frimage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        XpCollection1.Session = Session1
      If Google Isnot Nothing Then
             Dim a = "https://www.google.com.ar/search?q=" & Google & "&source=lnms&tbm=isch&sa=X&ved=0ahUKEwjkyOTtuJfSAhWMGZAKHUj1DQwQ_AUICCgB&biw=1169&bih=611"
        WebBrowser1.Navigate(new Uri(a))
        
      End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim img As String = TextEdit1.Text
        Dim a = "https://www.google.com.ar/search?q=" & img & "&source=lnms&tbm=isch&sa=X&ved=0ahUKEwjkyOTtuJfSAhWMGZAKHUj1DQwQ_AUICCgB&biw=1169&bih=611"
        WebBrowser1.Navigate(new Uri(a))
        
    End Sub

    Private Sub TextEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextEdit1.KeyDown
              If e.KeyData = Keys.Enter then
              Dim img As String = TextEdit1.text
        Dim a = "https://www.google.com.ar/search?q=" & img & "&source=lnms&tbm=isch&sa=X&ved=0ahUKEwjkyOTtuJfSAhWMGZAKHUj1DQwQ_AUICCgB&biw=1169&bih=611"
        WebBrowser1.Navigate(new Uri(a))
        End If
         
    End Sub
End Class