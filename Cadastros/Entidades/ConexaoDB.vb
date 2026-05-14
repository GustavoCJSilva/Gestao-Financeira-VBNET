Imports System.Data.SqlClient

Public Class Conexão_DB
    Inherits Form
    Private myConn As SqlConnection
    Private myCmd As Object
    Private myReader As SqlDataReader
    Private results As String
    Private objBanco As Object
    Private dgvDados As Object
    Private Cmd As SqlCommand
    Private connectionString As String = "Data Source=localhost;Initial Catalog=Testes;User ID=sa;Password=1104;Integrated Security=False"

    Public Property MyConn1 As SqlConnection
        Get
            Return myConn
        End Get
        Set(value As SqlConnection)
            myConn = value
        End Set
    End Property

    Public Property MyCmd1 As Object
        Get
            Return myCmd
        End Get
        Set(value As Object)
            myCmd = value
        End Set
    End Property

    Public Property MyReader1 As SqlDataReader
        Get
            Return myReader
        End Get
        Set(value As SqlDataReader)
            myReader = value
        End Set
    End Property

    Public Property Results1 As String
        Get
            Return results
        End Get
        Set(value As String)
            results = value
        End Set
    End Property

    Public Property ObjBanco1 As Object
        Get
            Return objBanco
        End Get
        Set(value As Object)
            objBanco = value
        End Set
    End Property

    Public Property DgvDados1 As Object
        Get
            Return dgvDados
        End Get
        Set(value As Object)
            dgvDados = value
        End Set
    End Property

    Public Property Cmd1 As SqlCommand
        Get
            Return Cmd
        End Get
        Set(value As SqlCommand)
            Cmd = value
        End Set
    End Property

    Public Property ConnectionString1 As String
        Get
            Return connectionString
        End Get
        Set(value As String)
            connectionString = value
        End Set
    End Property
End Class
