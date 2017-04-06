Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace FurEd
    NotInheritable Class Program

#Region "Private Constructors"

        Private Sub New()
        End Sub

#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _

#Region "Private Methods"

        Private Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New MainForm())
        End Sub

#End Region

    End Class
End Namespace