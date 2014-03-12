Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace FurEd
	NotInheritable Class Program
		Private Sub New()
        End Sub


		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Private Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New MainForm())
		End Sub
	End Class
End Namespace
