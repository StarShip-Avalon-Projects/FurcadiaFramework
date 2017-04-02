Imports System.Windows.Forms
Imports System.Text
Imports System.Threading
Imports System.ComponentModel
Imports System.IO
Imports SimpleProxy2.ConfigStructs
Imports SimpleProxy2.Controls

Public Class TextBoxWriter
    Inherits System.IO.TextWriter

#Region "Private Fields"

    Private Builder As StringBuilder
    Private control As TextBoxBase

#End Region

#Region "Public Constructors"

    Public Sub New(ByVal control As TextBox)
        Me.control = control
        AddHandler control.HandleCreated,
           New EventHandler(AddressOf OnHandleCreated)
    End Sub

    Public Sub New(ByVal control As RichTextBoxEx)
        Me.control = control
        AddHandler control.HandleCreated,
           New EventHandler(AddressOf OnHandleCreated)
    End Sub

    Public Sub New(ByVal control As RichTextBox)
        Me.control = control
        AddHandler control.HandleCreated,
           New EventHandler(AddressOf OnHandleCreated)
    End Sub

#End Region

#Region "Public Delegates"

    Delegate Sub UpDateBtn_GoCallback(ByRef s As String)

#End Region

#Region "Public Properties"

    Public Overrides ReadOnly Property Encoding() As System.Text.Encoding
        Get
            Return Encoding.Default
        End Get
    End Property

#End Region

#Region "Public Methods"

    Public Overrides Sub Write(ByVal ch As Char)
        Write(ch.ToString())
    End Sub

    Public Overrides Sub Write(ByVal s As String)
        If (control.IsHandleCreated) Then
            AppendText(s)
        Else
            BufferText(s)
        End If
    End Sub

    Public Overrides Sub WriteLine(ByVal s As String)
        If Not IsNothing(cBot) Then
            If cBot.log And Not IsNothing(callbk.LogStream) Then
                callbk.LogStream.Writeline(s)
            End If
        End If
        Write(s + Environment.NewLine)
    End Sub

#End Region

#Region "Private Methods"

    Private Sub AppendText(ByRef s As String)
        If control.InvokeRequired Then
            control.Invoke(New UpDateBtn_GoCallback(AddressOf AppendText), s)
        Else
            If (Builder Is Nothing = False) Then
                control.AppendText(Builder.ToString())
                Builder = Nothing
            End If
            control.AppendText(s)
            ' (ByRef lb As Object, ByRef obj As Object, ByRef newColor As fColorEnum)
            'Main.AddDataToList(Main.log_, s, 0)
        End If
    End Sub

    Private Sub BufferText(ByRef s As String)

        If (Builder Is Nothing) Then
            Builder = New StringBuilder()
        End If
        Builder.Append(s)

    End Sub
    Private Sub OnHandleCreated(ByVal sender As Object,
       ByVal e As EventArgs)
        If (Builder Is Nothing = False) Then
            control.AppendText(Builder.ToString())
            Builder = Nothing
        End If
    End Sub

#End Region

End Class