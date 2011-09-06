Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Type
Imports System.Text.RegularExpressions

Namespace Controls
    Public Class RichTextBoxEx
        Inherits System.Windows.Forms.RichTextBox
#Region "Interop-Defines"
        <StructLayout(LayoutKind.Sequential)> _
        Private Structure CHARFORMAT2_STRUCT
            Public cbSize As Integer
            Public dwMask As Integer
            Public dwEffects As Integer
            Public yHeight As Integer
            Public yOffset As Integer
            Public crTextColor As Integer
            Public bCharSet As Byte
            Public bPitchAndFamily As Byte
            <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> _
            Public szFaceName As Char()
            Public wWeight As Short
            Public sSpacing As Short
            Public crBackColor As Integer
            ' Color.ToArgb() -> int
            Public lcid As Integer
            Public dwReserved As Integer
            Public sStyle As Short
            Public wKerning As Short
            Public bUnderlineType As Byte
            Public bAnimation As Byte
            Public bRevAuthor As Byte
            Public bReserved1 As Byte
        End Structure

        <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
        Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
        End Function

        Private _protocols As List(Of String)
        Private updating As Integer
        Private oldEventMask As IntPtr
        Private Const WM_USER As Integer = &H400
        Private Const EM_GETCHARFORMAT As Integer = WM_USER + 58
        Private Const EM_SETCHARFORMAT As Integer = WM_USER + 68

        Private Const SCF_SELECTION As Integer = &H1
        Private Const SCF_WORD As Integer = &H2
        Private Const SCF_ALL As Integer = &H4

        Private Const WM_SETREDRAW As Integer = &HB
        Private Const EM_GETEVENTMASK As Integer = WM_USER + 59
        Private Const EM_SETEVENTMASK As Integer = WM_USER + 69

#Region "CHARFORMAT2 Flags"
        Private Const CFE_BOLD As Integer = &H1
        Private Const CFE_ITALIC As Integer = &H2
        Private Const CFE_UNDERLINE As Integer = &H4
        Private Const CFE_STRIKEOUT As Integer = &H8
        Private Const CFE_PROTECTED As Integer = &H10
        Private Const CFE_LINK As Integer = &H20
        Private Const CFE_AUTOCOLOR As Integer = &H40000000
        Private Const CFE_SUBSCRIPT As Integer = &H10000
        ' Superscript and subscript are 
        Private Const CFE_SUPERSCRIPT As Integer = &H20000
        '  mutually exclusive			 

        Private Const CFM_SMALLCAPS As Integer = &H40
        ' (*)	
        Private Const CFM_ALLCAPS As Integer = &H80
        ' Displayed by 3.0	
        Private Const CFM_HIDDEN As Integer = &H100
        ' Hidden by 3.0 
        Private Const CFM_OUTLINE As Integer = &H200
        ' (*)	
        Private Const CFM_SHADOW As Integer = &H400
        ' (*)	
        Private Const CFM_EMBOSS As Integer = &H800
        ' (*)	
        Private Const CFM_IMPRINT As Integer = &H1000
        ' (*)	
        Private Const CFM_DISABLED As Integer = &H2000
        Private Const CFM_REVISED As Integer = &H4000

        Private Const CFM_BACKCOLOR As Integer = &H4000000
        Private Const CFM_LCID As Integer = &H2000000
        Private Const CFM_UNDERLINETYPE As Integer = &H800000
        ' Many displayed by 3.0 
        Private Const CFM_WEIGHT As Integer = &H400000
        Private Const CFM_SPACING As Integer = &H200000
        ' Displayed by 3.0	
        Private Const CFM_KERNING As Integer = &H100000
        ' (*)	
        Private Const CFM_STYLE As Integer = &H80000
        ' (*)	
        Private Const CFM_ANIMATION As Integer = &H40000
        ' (*)	
        Private Const CFM_REVAUTHOR As Integer = &H8000


        Private Const CFM_BOLD As Integer = &H1
        Private Const CFM_ITALIC As Integer = &H2
        Private Const CFM_UNDERLINE As Integer = &H4
        Private Const CFM_STRIKEOUT As Integer = &H8
        Private Const CFM_PROTECTED As Integer = &H10
        Private Const CFM_LINK As Integer = &H20
        Private Const CFM_SIZE As Integer = &H80000000
        Private Const CFM_COLOR As Integer = &H40000000
        Private Const CFM_FACE As Integer = &H20000000
        Private Const CFM_OFFSET As Integer = &H10000000
        Private Const CFM_CHARSET As Integer = &H8000000
        Private Const CFM_SUBSCRIPT As Integer = CFE_SUBSCRIPT Or CFE_SUPERSCRIPT
        Private Const CFM_SUPERSCRIPT As Integer = CFM_SUBSCRIPT

        Private Const CFU_UNDERLINENONE As Byte = &H0
        Private Const CFU_UNDERLINE As Byte = &H1
        Private Const CFU_UNDERLINEWORD As Byte = &H2
        ' (*) displayed as ordinary underline	
        Private Const CFU_UNDERLINEDOUBLE As Byte = &H3
        ' (*) displayed as ordinary underline	
        Private Const CFU_UNDERLINEDOTTED As Byte = &H4
        Private Const CFU_UNDERLINEDASH As Byte = &H5
        Private Const CFU_UNDERLINEDASHDOT As Byte = &H6
        Private Const CFU_UNDERLINEDASHDOTDOT As Byte = &H7
        Private Const CFU_UNDERLINEWAVE As Byte = &H8
        Private Const CFU_UNDERLINETHICK As Byte = &H9
        Private Const CFU_UNDERLINEHAIRLINE As Byte = &HA
        ' (*) displayed as ordinary underline	


#End Region

#End Region

        Public Sub New()
            MyBase.New()
            ' Otherwise, non-standard links get lost when user starts typing
            ' next to a non-standard link
            Me.DetectUrls = False
            Me._protocols = New List(Of String)
            Me._protocols.AddRange(New String() {"http://", "furc://", "file://", "mailto://", "ftp://", "https://", "gopher://", "nntp://", "prospero://", "telnet://", "news://", "wais://", "outlook://", "\\"})
        End Sub

        <Editor(("System.Windows.Forms.Design.StringCollectionEditor," _
           + "System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), _
           GetType(System.Drawing.Design.UITypeEditor))> _
        Public ReadOnly Property Protocols() As List(Of String)
            Get

                Return Me._protocols
            End Get
        End Property

        Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)

            For Each p As String In _protocols
                Dim matches As MatchCollection = Regex.Matches(Me.Text, p & "(.*?)\s", RegexOptions.IgnoreCase)
                For Each m As Match In matches
                    If m.Success Then
                        Me.Select(m.Index, m.Length - 1)
                        Me.SetSelectionStyle(CFM_LINK, CFE_LINK)
                    End If
                Next
            Next
        End Sub

        <DefaultValue(False)> _
        Public Shadows Property DetectUrls() As Boolean
            Get
                Return MyBase.DetectUrls
            End Get
            Set(ByVal value As Boolean)
                MyBase.DetectUrls = value
            End Set
        End Property

        ''' <summary>
        ''' Insert a given text as a link into the RichTextBox at the current insert position.
        ''' </summary>
        ''' <param name="text">Text to be inserted</param>
        Public Sub InsertLink(ByVal text As String)
            InsertLink(text, Me.SelectionStart)
        End Sub

        ''' <summary>
        ''' Insert a given text at a given position as a link. 
        ''' </summary>
        ''' <param name="text">Text to be inserted</param>
        ''' <param name="position">Insert position</param>
        Public Sub InsertLink(ByVal text As String, ByVal position As Integer)
            If position < 0 OrElse position > Me.Text.Length Then
                Throw New ArgumentOutOfRangeException("position")
            End If

            Me.SelectionStart = position
            Me.SelectedText = text
            Me.[Select](position, text.Length)
            Me.SetSelectionLink(True)
            Me.[Select](position + text.Length, 0)
        End Sub

        ''' <summary>
        ''' Insert a given text at at the current input position as a link.
        ''' The link text is followed by a hash (#) and the given hyperlink text, both of
        ''' them invisible.
        ''' When clicked on, the whole link text and hyperlink string are given in the
        ''' LinkClickedEventArgs.
        ''' </summary>
        ''' <param name="text">Text to be inserted</param>
        ''' <param name="hyperlink">Invisible hyperlink string to be inserted</param>
        Public Sub InsertLink(ByVal text As String, ByVal hyperlink As String)
            InsertLink(text, hyperlink, Me.SelectionStart)
        End Sub

        ''' <summary>
        ''' Insert a given text at a given position as a link. The link text is followed by
        ''' a hash (#) and the given hyperlink text, both of them invisible.
        ''' When clicked on, the whole link text and hyperlink string are given in the
        ''' LinkClickedEventArgs.
        ''' </summary>
        ''' <param name="text">Text to be inserted</param>
        ''' <param name="hyperlink">Invisible hyperlink string to be inserted</param>
        ''' <param name="position">Insert position</param>
        Public Sub InsertLink(ByVal text As String, ByVal hyperlink As String, ByVal position As Integer)
            If position < 0 OrElse position > Me.Text.Length Then
                Throw New ArgumentOutOfRangeException("position")
            End If

            Me.SelectionStart = position
            Me.SelectedRtf = "{\rtf1\ansi " & text & "\v #" & hyperlink & "\v0}"
            Me.[Select](position, text.Length + 1 + hyperlink.Length)
            Me.SetSelectionLink(True)
            Me.[Select](position + text.Length + 1 + hyperlink.Length, 0)
        End Sub

        ''' <summary>
        ''' Set the current selection's link style
        ''' </summary>
        ''' <param name="link">true: set link style, false: clear link style</param>
        Public Sub SetSelectionLink(ByVal link As Boolean)
            SetSelectionStyle(CFM_LINK, If(link, CFE_LINK, 0))
        End Sub
        ''' <summary>
        ''' Get the link style for the current selection
        ''' </summary>
        ''' <returns>0: link style not set, 1: link style set, -1: mixed</returns>
        Public Function GetSelectionLink() As Integer
            Return GetSelectionStyle(CFM_LINK, CFE_LINK)
        End Function

        Private Sub SetSelectionStyle(ByVal mask As Integer, ByVal effect As Integer)
            Dim cf As New CHARFORMAT2_STRUCT()
            cf.cbSize = CType(Marshal.SizeOf(cf), Integer)
            cf.dwMask = mask
            cf.dwEffects = effect

            Dim wpar As New IntPtr(SCF_SELECTION)
            Dim lpar As IntPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(cf))
            Marshal.StructureToPtr(cf, lpar, False)

            Dim res As IntPtr = SendMessage(Handle, EM_SETCHARFORMAT, wpar, lpar)

            Marshal.FreeCoTaskMem(lpar)
        End Sub

        Private Function GetSelectionStyle(ByVal mask As Integer, ByVal effect As Integer) As Integer
            Dim cf As New CHARFORMAT2_STRUCT()
            cf.cbSize = CType(Marshal.SizeOf(cf), Integer)
            cf.szFaceName = New Char(31) {}

            Dim wpar As New IntPtr(SCF_SELECTION)
            Dim lpar As IntPtr = Marshal.AllocCoTaskMem(Marshal.SizeOf(cf))
            Marshal.StructureToPtr(cf, lpar, False)

            Dim res As IntPtr = SendMessage(Handle, EM_GETCHARFORMAT, wpar, lpar)

            cf = CType(Marshal.PtrToStructure(lpar, GetType(CHARFORMAT2_STRUCT)), CHARFORMAT2_STRUCT)

            Dim state As Integer
            ' dwMask holds the information which properties are consistent throughout the selection:
            If (cf.dwMask And mask) = mask Then
                If (cf.dwEffects And effect) = effect Then
                    state = 1
                Else
                    state = 0
                End If
            Else
                state = -1
            End If

            Marshal.FreeCoTaskMem(lpar)
            Return state
        End Function

        Public Sub urlClicked(ByVal sender As Object, ByVal e As LinkClickedEventArgs) Handles Me.LinkClicked
            MessageBox.Show(e.LinkText)
        End Sub

        ''' <summary>
        ''' Maintains performance while updating.
        ''' </summary>
        ''' <remarks>
        ''' <para>
        ''' It is recommended to call this method before doing
        ''' any major updates that you do not wish the user to
        ''' see. Remember to call EndUpdate when you are finished
        ''' with the update. Nested calls are supported.
        ''' </para>
        ''' <para>
        ''' Calling this method will prevent redrawing. It will
        ''' also setup the event mask of the underlying richedit
        ''' control so that no events are sent.
        ''' </para>
        ''' </remarks>
        Public Sub BeginUpdate()
            ' Deal with nested calls.
            updating += 1

            If updating > 1 Then
                Return
            End If

            ' Prevent the control from raising any events.
            oldEventMask = SendMessage(New HandleRef(Me, Handle), EM_SETEVENTMASK, 0, 0)

            ' Prevent the control from redrawing itself.
            SendMessage(New HandleRef(Me, Handle), WM_SETREDRAW, 0, 0)
        End Sub

        ''' <summary>
        ''' Resumes drawing and event handling.
        ''' </summary>
        ''' <remarks>
        ''' This method should be called every time a call is made
        ''' made to BeginUpdate. It resets the event mask to it's
        ''' original value and enables redrawing of the control.
        ''' </remarks>
        Public Sub EndUpdate()
            ' Deal with nested calls.
            updating -= 1

            If updating > 0 Then
                Return
            End If

            ' Allow the control to redraw itself.
            SendMessage(New HandleRef(Me, Handle), WM_SETREDRAW, 1, 0)

            ' Allow the control to raise event messages.
            SendMessage(New HandleRef(Me, Handle), EM_SETEVENTMASK, 0, oldEventMask)
        End Sub

    End Class
End Namespace
