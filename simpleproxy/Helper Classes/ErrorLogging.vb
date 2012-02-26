Imports System.Runtime.InteropServices
Public Class ErrorLogging

    'Error Logging Class
    'Author: Tim Wilson
    'Created: Sept 10, 2011
    '
    'To Call Class 
    'Example of calling Custom Error Logging Code
    '    Try
    '        Throw New Exception("This is an example exception demonstrating the Error 
    'Logging Exception Routine") 'Don't require this... this is just manually throwing an error
    ' to demo the class, actual code you'd just have the try/catch
    '    Catch ex As Exception
    '        Dim logError As New ErrorLogging(ex, Me) 'Passes the new 
    'constructor in the Error Logging Class the exception and 'me' (the calling object)
    '    End Try
    '
    'To provide more details for individual object types create a new constructor by copying and pasting one below and then adjusting the argument.

    Public Sub New(ByRef Ex As System.Exception, ByRef ObjectThrowingError As System.Windows.Forms.Form)
        'Call Log Error
        LogError(Ex, ObjectThrowingError.Text)
    End Sub
    Public Sub New(ByRef Ex As System.Exception, ByRef ObjectThrowingError As Object)
        'Call Log Error
        LogError(Ex, ObjectThrowingError.ToString())
    End Sub
    Public Sub New(ByRef Ex As System.Exception, ByRef ObjectThrowingError As Object, ByRef ObJectCheck As Object)
        'Call Log Error
        LogError(Ex, ObjectThrowingError.ToString())
    End Sub

    Public Sub LogError(ByRef ex As System.Exception, ByRef ObjectThrowingError As Object)
        'CHANGE FILEPATH/STRUCTURE HERE TO CHANGE FILE NAME & SAVING LOCATION
        Dim strErrorFilePath As String
        strErrorFilePath = Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) & "\" & My.Application.Info.ProductName & "_Error_" & Date.Now().ToString("MM_dd_yyyy_H-mm-ss") & ".txt"
        Dim ioFile As System.IO.StreamWriter
        Try
            ioFile = New System.IO.StreamWriter(strErrorFilePath, False)

            '***********************************************************
            '* Error Log Formatting
            '***********************************************************
            ioFile.WriteLine("-------------------------------------------------------")
            ioFile.WriteLine("")
            ioFile.WriteLine(My.Application.Info.ProductName & " Error Report")
            ioFile.WriteLine("")
            ioFile.WriteLine("Date: " & Date.Now().ToString("d"))
            ioFile.WriteLine("")
            ioFile.WriteLine("System Details")
            ioFile.WriteLine("-------------------------------------------------------")
            ioFile.WriteLine("Windows Version: " & My.Computer.Info.OSFullName)
            ioFile.WriteLine("Version Number: " & My.Computer.Info.OSVersion)
            'Determine if 64-bit
            If OSBitness.Is64BitOperatingSystem() Then
                ' If Environment.Is64BitOperatingSystem = True Then
                ioFile.WriteLine("64-Bit")
            Else
                ioFile.WriteLine("32-Bit")
            End If
            ioFile.WriteLine("")
            ioFile.WriteLine("Program Location: " & My.Application.Info.DirectoryPath)

            ioFile.WriteLine("")
            ioFile.WriteLine("")
            ioFile.WriteLine("Error Details")
            ioFile.WriteLine("-------------------------------------------------------")
            ioFile.WriteLine("Error: " & ex.Message)
            ioFile.WriteLine("")
            ioFile.WriteLine("Source: " & ObjectThrowingError)
            ioFile.WriteLine("")
            ioFile.WriteLine("Stack Trace: " & My.Application.Info.StackTrace.ToString())
            ioFile.WriteLine("")
            ioFile.WriteLine("-------------------------------------------------------")


            '***********************************************************

            ioFile.Close()

        Catch exLog As Exception
            If Not IsNothing(ioFile) Then
                ioFile.Close()
            End If
        End Try
    End Sub

    Public Sub LogError(ByRef ex As System.Exception, ByRef ObjectThrowingError As Object, ByRef ObJectCheck As Object)
        'CHANGE FILEPATH/STRUCTURE HERE TO CHANGE FILE NAME & SAVING LOCATION
        Dim strErrorFilePath As String
        strErrorFilePath = Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) & "\" & My.Application.Info.ProductName & "_Error_" & Date.Now().ToString("MM_dd_yyyy_H-mm-ss") & ".txt"
        Dim ioFile As System.IO.StreamWriter
        Try
            ioFile = New System.IO.StreamWriter(strErrorFilePath, False)

            '***********************************************************
            '* Error Log Formatting
            '***********************************************************
            ioFile.WriteLine("-------------------------------------------------------")
            ioFile.WriteLine("")
            ioFile.WriteLine(My.Application.Info.ProductName & " Error Report")
            ioFile.WriteLine("")
            ioFile.WriteLine("Date: " & Date.Now().ToString("d"))
            ioFile.WriteLine("")
            ioFile.WriteLine("System Details")
            ioFile.WriteLine("-------------------------------------------------------")
            ioFile.WriteLine("Windows Version: " & My.Computer.Info.OSFullName)
            ioFile.WriteLine("Version Number: " & My.Computer.Info.OSVersion)
            'Determine if 64-bit
            If OSBitness.Is64BitOperatingSystem() Then
                ' If Environment.Is64BitOperatingSystem = True Then
                ioFile.WriteLine("64-Bit")
            Else
                ioFile.WriteLine("32-Bit")
            End If
            ioFile.WriteLine("")
            ioFile.WriteLine("Program Location: " & My.Application.Info.DirectoryPath)

            ioFile.WriteLine("")
            ioFile.WriteLine("")
            ioFile.WriteLine("Error Details")
            ioFile.WriteLine("-------------------------------------------------------")
            ioFile.WriteLine("Error: " & ex.Message)
            ioFile.WriteLine("")
            ioFile.WriteLine("Source: " & ObjectThrowingError)
            ioFile.WriteLine("")
            ioFile.WriteLine("Object Check: " & ObJectCheck)
            ioFile.WriteLine("")
            ioFile.WriteLine("Stack Trace: " & My.Application.Info.StackTrace.ToString())
            ioFile.WriteLine("")
            ioFile.WriteLine("-------------------------------------------------------")


            '***********************************************************

            ioFile.Close()

        Catch exLog As Exception
            If Not IsNothing(ioFile) Then
                ioFile.Close()
            End If
        End Try
    End Sub
#Region "MSPL Code"
    ' Source: http://1code.codeplex.com/SourceControl/changeset/view/39074#842775
    '**************************************************************************\
    '        * Portions of this source are subject to the Microsoft Public License.
    '        * See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
    '        * All other rights reserved.
    '        * 
    '        * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
    '        * EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
    '        * WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
    '        \**************************************************************************


    Public NotInheritable Class OSBitness
        Private Sub New()
        End Sub
#Region "Is64BitOperatingSystem (IsWow64Process)"

        ''' <summary>
        ''' The function determines whether the current operating system is a 
        ''' 64-bit operating system.
        ''' </summary>
        ''' <returns>
        ''' The function returns true if the operating system is 64-bit; 
        ''' otherwise, it returns false.
        ''' </returns>
        Public Shared Function Is64BitOperatingSystem() As Boolean
            If IntPtr.Size = 8 Then
                ' 64-bit programs run only on Win64
                Return True
            Else
                ' 32-bit programs run on both 32-bit and 64-bit Windows
                ' Detect whether the current process is a 32-bit process 
                ' running on a 64-bit system.
                Dim flag As Boolean
                Return ((DoesWin32MethodExist("kernel32.dll", "IsWow64Process") AndAlso IsWow64Process(GetCurrentProcess(), flag)) AndAlso flag)
            End If
        End Function

        ''' <summary>
        ''' The function determins whether a method exists in the export 
        ''' table of a certain module.
        ''' </summary>
        ''' <param name="moduleName">The name of the module</param>
        ''' <param name="methodName">The name of the method</param>
        ''' <returns>
        ''' The function returns true if the method specified by methodName 
        ''' exists in the export table of the module specified by moduleName.
        ''' </returns>
        Private Shared Function DoesWin32MethodExist(moduleName As String, methodName As String) As Boolean
            Dim moduleHandle As IntPtr = GetModuleHandle(moduleName)
            If moduleHandle = IntPtr.Zero Then
                Return False
            End If
            Return (GetProcAddress(moduleHandle, methodName) <> IntPtr.Zero)
        End Function

        <DllImport("kernel32.dll")> _
        Private Shared Function GetCurrentProcess() As IntPtr
        End Function

        <DllImport("kernel32.dll", CharSet:=CharSet.Auto)> _
        Private Shared Function GetModuleHandle(moduleName As String) As IntPtr
        End Function

        <DllImport("kernel32", CharSet:=CharSet.Auto, SetLastError:=True)> _
        Private Shared Function GetProcAddress(hModule As IntPtr, <MarshalAs(UnmanagedType.LPStr)> procName As String) As IntPtr
        End Function

        <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
        Private Shared Function IsWow64Process(hProcess As IntPtr, ByRef wow64Process As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
        End Function

#End Region
    End Class
#End Region


End Class
