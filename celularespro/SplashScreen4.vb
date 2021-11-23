Public NotInheritable Class SplashScreen4

    'TODO: Este formulario se puede establecer fácilmente como pantalla de presentación para la aplicación desde la pestaña "Aplicación"
    '  del Diseñador de proyectos ("Propiedades" bajo el menú "Proyecto").


    Private Sub SplashScreen4_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Timer1.Start()

    End Sub

    'Título de la aplicación
    If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Si falta el título de la aplicación, utilice el nombre de la aplicación sin la extensión
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

    'Título de la aplicación
    If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Si falta el título de la aplicación, utilice el nombre de la aplicación sin la extensión
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

    'Título de la aplicación
    If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Si falta el título de la aplicación, utilice el nombre de la aplicación sin la extensión
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

    'Título de la aplicación
    If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Si falta el título de la aplicación, utilice el nombre de la aplicación sin la extensión
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

    End Sub

    Private Sub MainLayoutPanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
