Imports System.IO
Imports System.Text


Public Class FolderSetings
    Private _root As String
    Private _Directory As String
    Public Sub New()
        'init
    End Sub
    Public Sub New(root As String, Directory As String)
        _root = root
        _Directory = Directory
    End Sub
    Public Property Root As String
        Set(value As String)
            If value <> "" Then
                _root = value
            End If
        End Set
        Get
            Return _root
        End Get
    End Property

    Public Property Directory As String
        Set(value As String)
            If value <> "" Then
                _Directory = value
            End If
        End Set
        Get
            Return _Directory
        End Get
    End Property

    Function CreateFolders()

        If Not System.IO.Directory.Exists(_root) Then
            System.IO.Directory.CreateDirectory(_root)
        End If
        If Not System.IO.Directory.Exists(_root & "/" & _Directory) Then
            System.IO.Directory.CreateDirectory(_root & "/" & _Directory)
        End If

    End Function


End Class
